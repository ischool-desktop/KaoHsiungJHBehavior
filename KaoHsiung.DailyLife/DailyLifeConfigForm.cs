﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework;
using System.Xml;
using JHSchool;
using JHSchool.Data;
using FISCA.Presentation.Controls;
using FISCA.DSAUtil;
using FISCA.LogAgent;

namespace KaoHsiung.DailyLife
{
    public partial class DailyLifeConfigForm : BaseForm
    {
        //<DailyBehavior Name="日常行為表現">
        //    <Item Name="愛整潔" Index="....."/>
        //    <PerformanceDegree>
        //        <Mapping Degree="4" Desc="完全符合"/>
        //        <Mapping Degree="3" Desc="大部份符合"/>
        //        <Mapping Degree="2" Desc="部份符合"/>
        //    </PerformanceDegree>
        //</DailyBehavior>

        //<GroupActivity Name="團體活動表現">
        //    <Item Name="社團活動" SortOrder="1"/> For 高雄市
        //</GroupActivity>

        //<PublicService Name="公共服務表現">
        //    <Item Name="校內服務" SortOrder="1"/> For 高雄市
        //</PublicService>

        //<SchoolSpecial Name="校內外時特殊表現">
        //    <Item Name="校外特殊表現" SortOrder="1"/> For 高雄市
        //</SchoolSpecial>

        //<DailyLifeRecommend Name="日常生活表現具體建議"/> For 高雄市&新竹市

        //<OtherRecommend Name="其他表現建議"/>     For 新竹市

        XmlElement mapping;

        public DailyLifeConfigForm()
        {
            InitializeComponent();

            #region 建構子
            K12.Data.Configuration.ConfigData cd = K12.Data.School.Configuration["DLBehaviorConfig"];

            #region 日常行為表現
            if (!string.IsNullOrEmpty(cd["DailyBehavior"]))
            {
                if (cd.Contains("DailyBehavior"))
                {
                    XmlElement dailyBehavior = XmlHelper.LoadXml(cd["DailyBehavior"]);

                    gpDailyBehavior.Text = dailyBehavior.GetAttribute("Name");

                    txtDailyBehavior.Text = gpDailyBehavior.Text;

                    foreach (XmlElement item in dailyBehavior.SelectNodes("Item"))
                        dgvDailyBehavior.Rows.Add(item.GetAttribute("Name"), item.GetAttribute("Index"));

                    mapping = dailyBehavior.SelectSingleNode("PerformanceDegree") as XmlElement;
                }
            }
            #endregion

            #region 團體活動表現
            if (!string.IsNullOrEmpty(cd["GroupActivity"]))
            {
                if (cd.Contains("GroupActivity"))
                {
                    XmlElement groupActivity = XmlHelper.LoadXml(cd["GroupActivity"]);

                    gpGroupActivity.Text = groupActivity.GetAttribute("Name");

                    txtGroupActivity.Text = gpGroupActivity.Text;

                    foreach (XmlElement item in groupActivity.SelectNodes("Item"))
                        dgvGroupActivity.Rows.Add(item.GetAttribute("Name"));
                }
            }
            #endregion

            #region 公共服務表現
            if (!string.IsNullOrEmpty(cd["PublicService"]))
            {
                if (cd.Contains("PublicService"))
                {
                    XmlElement publicService = XmlHelper.LoadXml(cd["PublicService"]);

                    gpPublicService.Text = publicService.GetAttribute("Name");

                    txtPublicService.Text = gpPublicService.Text;

                    foreach (XmlElement item in publicService.SelectNodes("Item"))
                        dgvPublicService.Rows.Add(item.GetAttribute("Name"));
                }
            }
            #endregion

            #region 校內外時特殊表現
            if (!string.IsNullOrEmpty(cd["SchoolSpecial"]))
            {
                if (cd.Contains("SchoolSpecial"))
                {
                    XmlElement schoolSpecial = XmlHelper.LoadXml(cd["SchoolSpecial"]);

                    gpSchoolSpecial.Text = schoolSpecial.GetAttribute("Name");

                    txtSchoolSpecial.Text = gpSchoolSpecial.Text;

                    foreach (XmlElement item in schoolSpecial.SelectNodes("Item"))
                        dgvSchoolSpecial.Rows.Add(item.GetAttribute("Name"));
                }
            }
            #endregion

            #region 日常生活表現具體建議
            if (!string.IsNullOrEmpty(cd["DailyLifeRecommend"]))
            {
                if (cd.Contains("DailyLifeRecommend"))
                {
                    XmlElement dailyLifeRecommend = XmlHelper.LoadXml(cd["DailyLifeRecommend"]);

                    gpDailyLifeRecommend.Text = dailyLifeRecommend.GetAttribute("Name");

                    txtDailyLifeRecommend.Text = gpDailyLifeRecommend.Text;
                }
            }
            #endregion
            #endregion
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            K12.Data.Configuration.ConfigData cd = K12.Data.School.Configuration["DLBehaviorConfig"];


            #region 日常行為表現
            //<DailyBehavior Name=\"日常行為表現\">
            //    <Item Name=\"愛整潔\" Index=\"抽屜乾淨\"></Item>
            //    <Item Name=\"有禮貌\" Index=\"懂得向老師,學長敬禮\"></Item>
            //    <Item Name=\"守秩序\" Index=\"自習時間能夠安靜自習\"></Item>
            //    <Item Name=\"責任心\" Index=\"打掃時間,徹底整理自己打掃範圍\"></Item>
            //    <Item Name=\"公德心\" Index=\"不亂丟垃圾\"></Item>
            //    <Item Name=\"友愛關懷\" Index=\"懂得關心同學朋友\"></Item>
            //    <Item Name=\"團隊合作\" Index=\"團體活動能夠遵守相關規定\"></Item>
            //    <PerformanceDegree>
            //        <Mapping Degree=\"8\" Desc=\"完全符合\"></Mapping>
            //        <Mapping Degree=\"7\" Desc=\"大部份符合\"></Mapping>
            //        <Mapping Degree=\"6\" Desc=\"部份符合\"></Mapping>
            //        <Mapping Degree=\"5\" Desc=\"尚再努力\"></Mapping>
            //        <Mapping Degree=\"4\" Desc=\"努力又努力\"></Mapping>
            //        <Mapping Degree=\"3\" Desc=\"不努力也不努力\"></Mapping>
            //        <Mapping Degree=\"2\" Desc=\"有點努力\"></Mapping>
            //        <Mapping Degree=\"1\" Desc=\"很不努力\"></Mapping>
            //    </PerformanceDegree>
            //</DailyBehavior>
            DSXmlHelper dailyBehavior = new DSXmlHelper("DailyBehavior");
            //dailyBehavior.SetAttribute(".", "Name", gpDailyBehavior.Text);
            dailyBehavior.SetAttribute(".", "Name", txtDailyBehavior.Text);

            foreach (DataGridViewRow row in dgvDailyBehavior.Rows)
            {
                if (row.IsNewRow) continue;

                string rowValue = "" + row.Cells[0].Value + row.Cells[1].Value;
                if (string.IsNullOrEmpty(rowValue.Trim()))
                    continue;

                XmlElement node = dailyBehavior.AddElement("Item");
                node.SetAttribute("Name", "" + row.Cells[0].Value);
                node.SetAttribute("Index", "" + row.Cells[1].Value);
            }

            dailyBehavior.AddElement("PerformanceDegree");

            if (mapping != null)
            {
                foreach (XmlElement each in mapping.SelectNodes("Mapping"))
                {
                    XmlElement node = dailyBehavior.AddElement("PerformanceDegree", "Mapping");
                    node.SetAttribute("Degree", "" + each.Attributes[0].Value);
                    node.SetAttribute("Desc", "" + each.Attributes[1].Value);
                }
            }
            cd["DailyBehavior"] = dailyBehavior.ToString(); 
            #endregion

            #region 團體活動表現
            //<GroupActivity Name=\"團體活動表現\">
            //    <Item Name=\"社團活動\"></Item>
            //    <Item Name=\"學校活動\"></Item>
            //    <Item Name=\"自治活動\"></Item>
            //    <Item Name=\"班級活動\"></Item>
            //</GroupActivity>
            DSXmlHelper groupActivity = new DSXmlHelper("GroupActivity");
            groupActivity.SetAttribute(".", "Name", txtGroupActivity.Text);
            foreach (DataGridViewRow row in dgvGroupActivity.Rows)
            {
                if (row.IsNewRow) continue;

                string rowValue = "" + row.Cells[0].Value;
                if (string.IsNullOrEmpty(rowValue.Trim()))
                    continue;

                XmlElement node = groupActivity.AddElement("Item");
                node.SetAttribute("Name", "" + row.Cells[0].Value);
            }
            cd["GroupActivity"] = groupActivity.ToString(); 
            #endregion

            #region 公共服務表現
            // <PublicService Name=\"公共服務表現\">
            //    <Item Name=\"校內服務\"></Item>
            //    <Item Name=\"社區服務\"></Item>
            //</PublicService>
            DSXmlHelper publicService = new DSXmlHelper("PublicService");
            publicService.SetAttribute(".", "Name", txtPublicService.Text);
            foreach (DataGridViewRow row in dgvPublicService.Rows)
            {
                if (row.IsNewRow) continue;

                string rowValue = "" + row.Cells[0].Value;
                if (string.IsNullOrEmpty(rowValue.Trim()))
                    continue;

                XmlElement node = publicService.AddElement("Item");
                node.SetAttribute("Name", "" + row.Cells[0].Value);
            }
            cd["PublicService"] = publicService.ToString(); 
            #endregion

            #region 校內外時特殊表現
            //<SchoolSpecial Name=\"校內外特殊表現\">
            //    <Item Name=\"校外特殊表現\"></Item>
            //    <Item Name=\"校內特殊表現\"></Item>
            //</SchoolSpecial>
            DSXmlHelper schoolSpecial = new DSXmlHelper("SchoolSpecial");
            schoolSpecial.SetAttribute(".", "Name", txtSchoolSpecial.Text);
            foreach (DataGridViewRow row in dgvSchoolSpecial.Rows)
            {
                if (row.IsNewRow) continue;

                string rowValue = "" + row.Cells[0].Value;
                if (string.IsNullOrEmpty(rowValue.Trim()))
                    continue;

                XmlElement node = schoolSpecial.AddElement("Item");
                node.SetAttribute("Name", "" + row.Cells[0].Value);
            }
            cd["SchoolSpecial"] = schoolSpecial.ToString(); 
            #endregion

            #region 日常生活表現具體建議
            //<DailyLifeRecommend Name=\"日常生活表現具體建議\"/>
            DSXmlHelper dailyLifeRecommend = new DSXmlHelper("DailyLifeRecommend");
            dailyLifeRecommend.SetAttribute(".", "Name", txtDailyLifeRecommend.Text);
            cd["DailyLifeRecommend"] = dailyLifeRecommend.ToString(); 
            #endregion

            try
            {
                cd.Save();
                K12.Data.School.Configuration.Sync("DLBehaviorConfig");
            }
            catch
            {
                FISCA.Presentation.Controls.MsgBox.Show("儲存失敗");
            }

            ApplicationLog.Log("日常生活表現模組.日常生活表現評量設定", "修改日常生活表現評量設定值", "「日常生活表現評量設定值」已被修改。");
            FISCA.Presentation.Controls.MsgBox.Show("設定檔儲存成功");

            this.Close(); 
        }

        #region TextBox相關事件
        private void txtDailyBehavior_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode & Keys.Escape) == Keys.Escape)
            {
                gpDailyBehavior.Text = txtDailyBehavior.Text;
                txtDailyBehavior.SendToBack();
                return;
            }

            if ((e.KeyCode & Keys.Enter) == Keys.Enter)
            {
                gpDailyBehavior.Text = txtDailyBehavior.Text;
                txtDailyBehavior.SendToBack();
            }
        }

        private void txtPublicService_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode & Keys.Escape) == Keys.Escape)
            {
                gpPublicService.Text = txtPublicService.Text;
                txtPublicService.SendToBack();
                return;
            }

            if ((e.KeyCode & Keys.Enter) == Keys.Enter)
            {
                gpPublicService.Text = txtPublicService.Text;
                txtPublicService.SendToBack();
            }
        }

        private void txtGroupActivity_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode & Keys.Escape) == Keys.Escape)
            {
                gpGroupActivity.Text = txtGroupActivity.Text;
                txtGroupActivity.SendToBack();
                return;
            }

            if ((e.KeyCode & Keys.Enter) == Keys.Enter)
            {
                gpGroupActivity.Text = txtGroupActivity.Text;
                txtGroupActivity.SendToBack();
            }
        }

        private void txtSchoolSpecial_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode & Keys.Escape) == Keys.Escape)
            {
                gpSchoolSpecial.Text = txtSchoolSpecial.Text;
                txtSchoolSpecial.SendToBack();
                return;
            }

            if ((e.KeyCode & Keys.Enter) == Keys.Enter)
            {
                gpSchoolSpecial.Text = txtSchoolSpecial.Text;
                txtSchoolSpecial.SendToBack();
            }
        }

        private void txtDailyLifeRecommend_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode & Keys.Escape) == Keys.Escape)
            {
                gpDailyLifeRecommend.Text = txtDailyLifeRecommend.Text;
                txtDailyLifeRecommend.SendToBack();
                return;
            }

            if ((e.KeyCode & Keys.Enter) == Keys.Enter)
            {
                gpDailyLifeRecommend.Text = txtDailyLifeRecommend.Text;
                txtDailyLifeRecommend.SendToBack();
            }
        } 
        #endregion

        #region 修改名稱
        private void lnkDailyBehavior_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtDailyBehavior.BringToFront();
            txtDailyBehavior.Focus();
        }

        private void lnkPublicService_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPublicService.BringToFront();
            txtPublicService.Focus();
        }

        private void lnkGroupActivity_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtGroupActivity.BringToFront();
            txtGroupActivity.Focus();
        }

        private void lnkSchoolSpecial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtSchoolSpecial.BringToFront();
            txtSchoolSpecial.Focus();
        } 

        private void lnkDailyLifeRecommend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtDailyLifeRecommend.BringToFront();
            txtDailyLifeRecommend.Focus();
        }

        #endregion
    }
}
