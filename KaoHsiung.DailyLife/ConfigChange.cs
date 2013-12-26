using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FISCA.Presentation.Controls;
using FISCA.DSAUtil;
using System.Xml;
using K12.Data;

namespace KaoHsiung.DailyLife
{
    public partial class ConfigChange : BaseForm
    {
        //努力程度設定
        XmlElement mapping;

        //設定檔
        K12.Data.Configuration.ConfigData cd;

        public ConfigChange()
        {
            InitializeComponent();
        }

        private void ConfigChange_Load(object sender, EventArgs e)
        {
            cd = K12.Data.School.Configuration["DLBehaviorConfig"];

            if (!string.IsNullOrEmpty(cd["DailyBehavior"]))
            {
                if (cd.Contains("DailyBehavior"))
                {
                    XmlElement dailyBehavior = XmlHelper.LoadXml(cd["DailyBehavior"]);
                    int count = 1;
                    foreach (XmlElement item in dailyBehavior.SelectNodes("Item"))
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridViewX1);
                        row.Cells[0].Value = count.ToString();
                        row.Cells[1].Value = item.GetAttribute("Name");
                        row.Cells[2].Value = item.GetAttribute("Index");
                        dataGridViewX1.Rows.Add(row);
                        count++;
                    }

                    mapping = dailyBehavior.SelectSingleNode("PerformanceDegree") as XmlElement;
                }
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewX1.Rows)
            {
                row.Cells[0].Value = ChangeIndex("" + row.Cells[1].Value);
            }
        }

        private string ChangeIndex(string name)
        {
            if (name == "愛整潔")
            {
                return "1";
            }
            else if (name == "有禮貌")
            {
                return "2";
            }
            else if (name == "守秩序")
            {
                return "3";
            }
            else if (name == "責任心")
            {
                return "4";
            }
            else if (name == "公德心")
            {
                return "5";
            }
            else if (name == "友愛關懷")
            {
                return "6";
            }
            else if (name == "團隊合作")
            {
                return "7";
            }
            else
            {
                return "";
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            //不可為文字或符號
            if (CheckIndex())
            {
                MsgBox.Show("資料不正確!!");
                return;
            }
            //不可重覆

            //努力程度資料不可掉...

            //內部更新昨天的相關修正
        }

        private bool CheckIndex()
        {
            bool check = false;
            foreach (DataGridViewRow row in dataGridViewX1.Rows)
            {
                string index = "" + row.Cells[0].Value;
                int x;
                if (!int.TryParse(index, out x))
                {
                    check = true;
                    row.Cells[0].ErrorText = "不是數字";
                }
                else
                {
                    row.Cells[0].ErrorText = "";
                }
            }
            return check;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
