﻿using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using JHSchool.Data;
using SmartSchool.API.PlugIn;

namespace JHSchool.Behavior.ImportExport
{
    class ImportTextScore : SmartSchool.API.PlugIn.Import.Importer
    {
        private List<string> DailyBehaviors = new List<string>() { "愛整潔", "有禮貌", "守秩序", "責任心", "公德心", "友愛關懷", "團隊合作" };
        private List<string> GroupActivities = new List<string>() { "學校活動", "自治活動", "班級活動" };
        private List<string> PublicActivities = new List<string>() { "校內服務", "社區服務" };
        private List<string> SchoolActivities = new List<string>() { "校外特殊表現", "校內特殊表現" };
        private List<string> Keys = new List<string>();
        private Dictionary<string, string> Indexes = new Dictionary<string, string>();

        public ImportTextScore()
        {
            this.Image = null;
            this.Text = "匯入日常生活表現";
        }

        public override void InitializeImport(SmartSchool.API.PlugIn.Import.ImportWizard wizard)
        {
            K12.Data.Configuration.ConfigData cd = K12.Data.School.Configuration["DLBehaviorConfig"];

            XmlDocument xmldoc = new XmlDocument();

            xmldoc.LoadXml(cd["DailyBehavior"]);

            foreach (XmlNode Node in xmldoc.DocumentElement.SelectNodes("Item"))
            {
                XmlElement Element = Node as XmlElement;

                if (Element != null)
                    Indexes.Add(Element.GetAttribute("Name"), Element.GetAttribute("Index"));
            }

            Dictionary<string, JHMoralScoreRecord> CacheMoralScore = new Dictionary<string, JHMoralScoreRecord>();

            wizard.RequiredFields.AddRange("學年度", "學期");
            wizard.ImportableFields.AddRange("學年度", "學期", "具體建議");

            wizard.RequiredFields.AddRange(DailyBehaviors);
            wizard.ImportableFields.AddRange(DailyBehaviors);

            foreach (string GroupActivity in GroupActivities)
            {
                wizard.ImportableFields.Add(GroupActivity + "：努力程度");
                wizard.ImportableFields.Add(GroupActivity + "：文字描述");
            }

            foreach (string PublicActivity in PublicActivities)
                wizard.ImportableFields.Add(PublicActivity + "：文字描述");

            foreach (string SchoolActivity in SchoolActivities)
                wizard.ImportableFields.Add(SchoolActivity + "：文字描述");



            wizard.PackageLimit = 250;
            wizard.ValidateRow += (sender, e) =>
            {
                int schoolYear, semester;
                #region 驗共同必填欄位
                if (!int.TryParse(e.Data["學年度"], out schoolYear))
                {
                    e.ErrorFields.Add("學年度", "必需輸入數字");
                }
                if (!int.TryParse(e.Data["學期"], out semester))
                {
                    e.ErrorFields.Add("學期", "必需輸入數字");
                }
                else if (semester != 1 && semester != 2)
                {
                    e.ErrorFields.Add("學期", "必須填入1或2");
                }
                #endregion
                #region 驗證主鍵
                string Key = e.Data.ID + "-" + e.Data["學年度"] + "-" + e.Data["學期"];
                string errorMessage = string.Empty;

                if (Keys.Contains(Key))
                    errorMessage = "學生編號、學年及學期的組合不能重覆!";
                else
                    Keys.Add(Key);

                e.ErrorMessage = errorMessage;
                #endregion
            };
            wizard.ImportComplete += (sender, e) => MessageBox.Show("匯入完成");
            wizard.ImportPackage += (sender, e) =>
            {
                foreach (JHMoralScoreRecord record in JHMoralScore.SelectByStudentIDs(e.Items.Select(x => x.ID)))
                    if (!CacheMoralScore.ContainsKey(record.ID))
                        CacheMoralScore.Add(record.ID, record);

                //要更新的德行成績列表
                List<JHMoralScoreRecord> updateMoralScores = new List<JHMoralScoreRecord>();

                //要新增的德行成績列表
                List<JHMoralScoreRecord> insertMoralScores = new List<JHMoralScoreRecord>();

                //巡訪匯入資料
                foreach (RowData row in e.Items)
                {
                    int schoolYear = int.Parse(row["學年度"]);
                    int semester = int.Parse(row["學期"]);

                    //根據學生編號、學年度及學期尋找是否有對應的德行成績
                    List<JHMoralScoreRecord> records = CacheMoralScore.Values.Where(x => x.RefStudentID.Equals(row.ID) && (x.SchoolYear == schoolYear) && x.Semester == semester).ToList();

                    //該學生的學年度及學期德行成績已存在
                    if (records.Count > 0)
                    {
                        //根據學生編號、學年度、學期及日期取得的缺曠記錄應該只有一筆
                        JHMoralScoreRecord record = records[0];

                        MakeSureElement(record);

                        if (record.TextScore != null)
                        {
                            //處理日常行為表現
                            foreach (string DailyBehavior in DailyBehaviors)
                            {
                                if (row.ContainsKey(DailyBehavior))
                                {
                                    XmlElement Element = record.TextScore.SelectSingleNode("DailyBehavior/Item[@Name='" + DailyBehavior + "']") as XmlElement;

                                    if (Element != null)
                                        Element.SetAttribute("Degree", row[DailyBehavior]);
                                    else
                                    {
                                        XmlElement NewElement = record.TextScore.OwnerDocument.CreateElement("Item");
                                        NewElement.SetAttribute("Name", DailyBehavior);
                                        NewElement.SetAttribute("Index", Indexes[DailyBehavior]);

                                        if (!string.IsNullOrEmpty(row[DailyBehavior]))
                                            NewElement.SetAttribute("Degree", row[DailyBehavior]);
                                        record.TextScore.SelectSingleNode("DailyBehavior").AppendChild(NewElement);
                                    }
                                }
                            }

                            //處理團體活動表現

                            foreach (string GroupActivity in GroupActivities)
                            {
                                if (row.ContainsKey(GroupActivity + "：努力程度") || row.ContainsKey(GroupActivity + "：文字描述"))
                                {
                                    XmlElement Element = record.TextScore.SelectSingleNode("GroupActivity/Item[@Name='" + GroupActivity + "']") as XmlElement;

                                    if (Element != null)
                                    {
                                        if (row.ContainsKey(GroupActivity + "：努力程度"))
                                            Element.SetAttribute("Degree", row[GroupActivity + "：努力程度"]);

                                        if (row.ContainsKey(GroupActivity + "：文字描述"))
                                            Element.SetAttribute("Description", row[GroupActivity + "：文字描述"]);
                                    }
                                    else
                                    {
                                        XmlElement NewElement = record.TextScore.OwnerDocument.CreateElement("Item");

                                        NewElement.SetAttribute("Name", GroupActivity);

                                        if (row.ContainsKey(GroupActivity + "：努力程度"))
                                            NewElement.SetAttribute("Degree", row[GroupActivity + "：努力程度"]);

                                        if (row.ContainsKey(GroupActivity + "：文字描述"))
                                            NewElement.SetAttribute("Description", row[GroupActivity + "：文字描述"]);

                                        record.TextScore.SelectSingleNode("GroupActivity").AppendChild(NewElement);
                                    }
                                }
                            }

                            //處理公共服務表現

                            List<XmlElement> items = new List<XmlElement>();
                            foreach (string PublicActivity in PublicActivities)
                            {
                                if (row.ContainsKey(PublicActivity + "：文字描述"))
                                {
                                    //XmlElement Element = record.TextScore.SelectSingleNode("PublicService/Item[@Name='" + PublicActivity + "']") as XmlElement;
                                    XmlElement Element = GetLast(record.TextScore, "PublicService/Item[@Name='" + PublicActivity + "']");

                                    Element.SetAttribute("Name", PublicActivity);
                                    Element.SetAttribute("Description", row[PublicActivity + "：文字描述"]);

                                    items.Add(Element);

                                    //if (Element != null)
                                    //    Element.SetAttribute("Description", row[PublicActivity + "：文字描述"]);
                                    //else
                                    //{
                                    //    XmlElement NewElement = record.TextScore.OwnerDocument.CreateElement("Item");

                                    //    NewElement.SetAttribute("Name", PublicActivity);
                                    //    NewElement.SetAttribute("Description", row[PublicActivity + "：文字描述"]);

                                    //    record.TextScore.SelectSingleNode("PublicService").AppendChild(NewElement);
                                    //}
                                }
                            }
                            XmlElement xml5 = (XmlElement)record.TextScore.SelectSingleNode("PublicService");
                            string PublicServiceName = xml5.GetAttribute("Name");

                            xml5.RemoveAll();
                            xml5.SetAttribute("Name", PublicServiceName);
                            foreach (XmlElement item in items)
                                xml5.AppendChild(item);

                            //校內外特殊表現

                            foreach (string SchoolActivity in SchoolActivities)
                            {
                                if (row.ContainsKey(SchoolActivity + "：文字描述"))
                                {
                                    XmlElement Element = record.TextScore.SelectSingleNode("SchoolSpecial/Item[@Name='" + SchoolActivity + "']") as XmlElement;

                                    if (Element != null)
                                        Element.SetAttribute("Description", row[SchoolActivity + "：文字描述"]);
                                    else
                                    {
                                        XmlElement NewElement = record.TextScore.OwnerDocument.CreateElement("Item");

                                        NewElement.SetAttribute("Name", SchoolActivity);
                                        NewElement.SetAttribute("Description", row[SchoolActivity + "：文字描述"]);

                                        record.TextScore.SelectSingleNode("SchoolSpecial").AppendChild(NewElement);
                                    }
                                }
                            }

                            if (row.ContainsKey("具體建議"))
                            {
                                XmlElement DailyLifeRecommentElement = record.TextScore.SelectSingleNode("DailyLifeRecommend") as XmlElement;

                                if (DailyLifeRecommentElement != null)
                                    DailyLifeRecommentElement.SetAttribute("Description", row["具體建議"]);
                                else
                                {
                                    XmlElement Element = record.TextScore.OwnerDocument.CreateElement("DailyLifeRecommend");
                                    Element.SetAttribute("Description", row["具體建議"]);
                                    record.TextScore.AppendChild(Element);
                                }
                            }
                            updateMoralScores.Add(record);
                        }
                    }
                    else
                    {
                        JHMoralScoreRecord record = new JHMoralScoreRecord();

                        record.SchoolYear = schoolYear;
                        record.Semester = semester;
                        record.RefStudentID = row.ID;

                        MakeSureElement(record);

                        //日常生活表現
                        foreach (string DailyBehavior in DailyBehaviors)
                        {
                            XmlElement NewElement = record.TextScore.OwnerDocument.CreateElement("Item");

                            NewElement.SetAttribute("Name", DailyBehavior);
                            NewElement.SetAttribute("Index", Indexes[DailyBehavior]);
                            NewElement.SetAttribute("Degree", "");

                            if (row.ContainsKey(DailyBehavior))
                                NewElement.SetAttribute("Degree", "" + row[DailyBehavior]);

                            record.TextScore.SelectSingleNode("DailyBehavior").AppendChild(NewElement);
                        }

                        //處理團體活動表現

                        foreach (string GroupActivity in GroupActivities)
                        {
                            XmlElement NewElement = record.TextScore.OwnerDocument.CreateElement("Item");

                            NewElement.SetAttribute("Name", GroupActivity);
                            NewElement.SetAttribute("Degree", "");
                            NewElement.SetAttribute("Description", "");

                            if (row.ContainsKey(GroupActivity + "：努力程度"))
                                NewElement.SetAttribute("Degree", row[GroupActivity + "：努力程度"]);

                            if (row.ContainsKey(GroupActivity + "：文字描述"))
                                NewElement.SetAttribute("Description", row[GroupActivity + "：文字描述"]);

                            record.TextScore.SelectSingleNode("GroupActivity").AppendChild(NewElement);
                        }

                        //處理公共服務表現

                        foreach (string PublicActivity in PublicActivities)
                        {
                            XmlElement NewElement = record.TextScore.OwnerDocument.CreateElement("Item");

                            NewElement.SetAttribute("Name", PublicActivity);
                            NewElement.SetAttribute("Description", "");

                            if (row.ContainsKey(PublicActivity + "：文字描述"))
                                NewElement.SetAttribute("Description", row[PublicActivity + "：文字描述"]);

                            record.TextScore.SelectSingleNode("PublicService").AppendChild(NewElement);
                        }

                        //校內外特殊表現

                        foreach (string SchoolActivity in SchoolActivities)
                        {
                            XmlElement NewElement = record.TextScore.OwnerDocument.CreateElement("Item");

                            NewElement.SetAttribute("Name", SchoolActivity);
                            NewElement.SetAttribute("Description", "");

                            if (row.ContainsKey(SchoolActivity + "：文字描述"))
                                NewElement.SetAttribute("Description", row[SchoolActivity + "：文字描述"]);

                            record.TextScore.SelectSingleNode("SchoolSpecial").AppendChild(NewElement);
                        }

                        if (row.ContainsKey("具體建議"))
                        {
                            XmlElement Element = record.TextScore.SelectSingleNode("DailyLifeRecommend") as XmlElement;

                            if (Element != null)
                                Element.SetAttribute("Description", row["具體建議"]);
                        }

                        insertMoralScores.Add(record);
                    }
                }

                if (updateMoralScores.Count > 0)
                    JHMoralScore.Update(updateMoralScores);
                if (insertMoralScores.Count > 0)
                    JHMoralScore.Insert(insertMoralScores);
            };
        }

        public void MakeSureElement(JHMoralScoreRecord record)
        {
            //<TextScore><DailyBehavior Name="日常行為表現"/><GroupActivity Name="團體活動表現"/><PublicService Name="公共服務表現"/><SchoolSpecial Name="校內外特殊表現"/><DailyLifeRecommend Description="" Name="日常生活表現具體建議"/></TextScore>

            if (record.TextScore == null)
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml("<TextScore/>");
                record.TextScore = xmldoc.DocumentElement;
            }

            //<DailyBehavior Name=\"日常行為表現\"/>
            if (record.TextScore.SelectSingleNode("DailyBehavior") == null)
            {
                XmlDocumentFragment Fragment = record.TextScore.OwnerDocument.CreateDocumentFragment();
                Fragment.InnerXml = "<DailyBehavior Name=\"日常行為表現\"/>";
                record.TextScore.AppendChild(Fragment);
            }

            //<GroupActivity Name=\"團體活動表現\"/>
            if (record.TextScore.SelectSingleNode("GroupActivity") == null)
            {
                XmlDocumentFragment Fragment = record.TextScore.OwnerDocument.CreateDocumentFragment();
                Fragment.InnerXml = "<GroupActivity Name=\"團體活動表現\"/>";
                record.TextScore.AppendChild(Fragment);
            }

            //<PublicService Name=\"公共服務表現\"/>
            if (record.TextScore.SelectSingleNode("PublicService") == null)
            {
                XmlDocumentFragment Fragment = record.TextScore.OwnerDocument.CreateDocumentFragment();
                Fragment.InnerXml = "<PublicService Name=\"公共服務表現\"/>";
                record.TextScore.AppendChild(Fragment);
            }

            //<SchoolSpecial Name=\"校內外特殊表現\"/>
            if (record.TextScore.SelectSingleNode("SchoolSpecial") == null)
            {
                XmlDocumentFragment Fragment = record.TextScore.OwnerDocument.CreateDocumentFragment();
                Fragment.InnerXml = "<SchoolSpecial Name=\"校內外特殊表現\"/>";
                record.TextScore.AppendChild(Fragment);
            }

            //<DailyLifeRecommend Description=\"\" Name=\"具體建議\"/>
            if (record.TextScore.SelectSingleNode("DailyLifeRecommend") == null)
            {
                XmlDocumentFragment Fragment = record.TextScore.OwnerDocument.CreateDocumentFragment();
                Fragment.InnerXml = "<DailyLifeRecommend Description=\"\" Name=\"具體建議\"/>";
                record.TextScore.AppendChild(Fragment);
            }
        }

        private XmlElement GetLast(XmlElement node, string xpath)
        {
            XmlNodeList nodes = node.SelectNodes(xpath);

            if (nodes.Count <= 0)
                return node.OwnerDocument.CreateElement("Item");

            return (nodes[nodes.Count - 1]).CloneNode(true) as XmlElement;
        }
    }
}