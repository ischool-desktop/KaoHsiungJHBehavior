using System;
using System.Collections.Generic;
using System.Xml;
using FISCA.Presentation;
using JHSchool.Data;
using SmartSchool.API.PlugIn;

namespace JHSchool.Behavior.ImportExport
{
    class ExportTextScore : SmartSchool.API.PlugIn.Export.Exporter
    {
        private List<string> DailyBehaviors = new List<string>() { "愛整潔", "有禮貌", "守秩序", "責任心", "公德心", "友愛關懷", "團隊合作" };
        private List<string> GroupActivities = new List<string>() { "學校活動", "自治活動", "班級活動" };
        private List<string> PublicActivities = new List<string>() { "校內服務", "社區服務" };
        private List<string> SchoolActivities = new List<string>() { "校外特殊表現", "校內特殊表現" };

        //建構子
        public ExportTextScore()
        {
            this.Image = null;
            this.Text = "匯出日常生活表現";
        }

        private bool IsElementExist(JHMoralScoreRecord record)
        {
            if (record.TextScore == null)
                return false;
            if (record.TextScore.SelectSingleNode("DailyLifeRecommend")==null)
                return false;
            if (record.TextScore.SelectSingleNode("DailyBehavior")==null)
                return false;
            if (record.TextScore.SelectSingleNode("GroupActivity") == null)
                return false;
            if (record.TextScore.SelectSingleNode("PublicService") == null)
                return false;
            if (record.TextScore.SelectSingleNode("SchoolSpecial") == null)
                return false;
            return true;
        }

        //覆寫
        public override void InitializeExport(SmartSchool.API.PlugIn.Export.ExportWizard wizard)
        {
            wizard.ExportableFields.AddRange("學年度", "學期", "具體建議");
            wizard.ExportableFields.AddRange(DailyBehaviors);

            foreach (string GroupActivity in GroupActivities)
            {
                wizard.ExportableFields.Add(GroupActivity + "：努力程度");
                wizard.ExportableFields.Add(GroupActivity + "：文字描述");
            }

            foreach (string PublicActivity in PublicActivities)
                wizard.ExportableFields.Add(PublicActivity + "：文字描述");

            foreach (string SchoolActivity in SchoolActivities)
                wizard.ExportableFields.Add(SchoolActivity + "：文字描述");

            wizard.ExportPackage += (sender,e)=>
            {
                //取得選取學生的缺曠記錄
                List<JHMoralScoreRecord> records = JHMoralScore.SelectByStudentIDs(e.List);

                try
                {

                    //尋訪每個缺曠記錄
                    foreach (JHMoralScoreRecord record in records)
                    {
                          if (record.TextScore!=null && !string.IsNullOrEmpty(record.TextScore.InnerXml))
                          {
                            //新增匯出列
                            RowData row = new RowData();

                            //指定匯出列的學生編號
                            row.ID = record.RefStudentID;

                            //判斷匯出欄位
                            foreach (string field in e.ExportFields)
                            {
                                if (wizard.ExportableFields.Contains(field))
                                {
                                    //匯出學年度及學期欄位
                                    switch (field)
                                    {
                                        case "學年度":
                                            row.Add(field, "" + record.SchoolYear);
                                            break;
                                        case "學期":
                                            row.Add(field, "" + record.Semester);
                                            break;
                                        case "具體建議":
                                            if (record.TextScore != null)
                                            {
                                                XmlElement Element = record.TextScore.SelectSingleNode("DailyLifeRecommend") as XmlElement;

                                                if (Element != null)
                                                    row.Add(field, "" + Element.GetAttribute("Description"));
                                            }
                                            break;
                                    }


                                    if (record.TextScore != null)
                                    {
                                        //匯出日常生活表現
                                        if (DailyBehaviors.Contains(field))
                                        {
                                            XmlElement Element = record.TextScore.SelectSingleNode("DailyBehavior/Item[@Name=\"" + field + "\"]") as XmlElement;

                                            if (Element != null)
                                                row.Add(field, "" + Element.GetAttribute("Degree"));
                                        }

                                        //匯出團體活動表現
                                        foreach (string GroupActivity in GroupActivities)
                                        {
                                            XmlElement Element = record.TextScore.SelectSingleNode("GroupActivity/Item[@Name=\"" + GroupActivity + "\"]") as XmlElement;

                                            if (Element != null)
                                            {
                                                if (field.Equals(GroupActivity + "：努力程度"))
                                                    row.Add(field, Element.GetAttribute("Degree"));
                                                if (field.Equals(GroupActivity + "：文字描述"))
                                                    row.Add(field, Element.GetAttribute("Description"));
                                            }
                                        }

                                        //匯出公共服務表現
                                        foreach (string PublicActivity in PublicActivities)
                                        {
                                            //XmlElement Element = record.TextScore.SelectSingleNode("PublicService/Item[@Name=\"" + PublicActivity + "\"]") as XmlElement;
                                            XmlElement Element = GetLast(record.TextScore, "PublicService/Item[@Name=\"" + PublicActivity + "\"]");

                                            if (Element != null)
                                            {
                                                if (field.Equals(PublicActivity + "：文字描述"))
                                                    row.Add(field, Element.GetAttribute("Description"));
                                            }
                                        }

                                        //匯出校內外特殊表現
                                        foreach (string SchoolActivity in SchoolActivities)
                                        {
                                            XmlElement Element = record.TextScore.SelectSingleNode("SchoolSpecial/Item[@Name=\"" + SchoolActivity + "\"]") as XmlElement;

                                            if (Element != null)
                                            {
                                                if (field.Equals(SchoolActivity + "：文字描述"))
                                                    row.Add(field, Element.GetAttribute("Description"));
                                            }
                                        }
                                    }
                                }
                            }
                            e.Items.Add(row);
                        }
                    }
                }
                catch (Exception ve)
                {
                    MotherForm.SetStatusBarMessage(ve.Message);
                }
            };
        }

        private XmlElement GetLast(XmlElement node, string xpath)
        {
            XmlNodeList nodes = node.SelectNodes(xpath);

            if (nodes.Count <= 0)
                return node.OwnerDocument.CreateElement("Item");

            return (nodes[nodes.Count - 1]).CloneNode(true) as XmlElement;
        }

        private int SortStudent(JHStudentRecord x, JHStudentRecord y)
        {

            string xx1 = x.Class != null ? x.Class.Name : "";
            string xx2 = x.SeatNo.HasValue ? x.SeatNo.Value.ToString().PadLeft(3, '0') : "000";
            string xx3 = xx1 + xx2;

            string yy1 = y.Class != null ? y.Class.Name : "";
            string yy2 = y.SeatNo.HasValue ? y.SeatNo.Value.ToString().PadLeft(3, '0') : "000";
            string yy3 = yy1 + yy2;

            return xx3.CompareTo(yy3);
        }

        private int SortDate(JHDisciplineRecord x, JHDisciplineRecord y)
        {
            return x.OccurDate.CompareTo(y.OccurDate);
        }
    }
}