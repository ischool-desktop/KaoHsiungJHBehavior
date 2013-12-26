using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JHSchool.Data;
using JHSchool;
using FISCA.UDT;
using JHSchool.Behavior.BusinessLogic;

namespace KaoHsiung.DailyLife.日常生活表現總表
{
    class GetMSRlist
    {
        private string SchoolYear;
        private string Semester;
        private List<JHClassRecord> ClassList = new List<JHClassRecord>();

        private AccessHelper _accessHelper = new AccessHelper();

        /// <summary>
        /// Key是JHMoralScoreRecord的ID
        /// </summary>
        public Dictionary<string, AutoSummaryRecord> AutoSummaryDic = new Dictionary<string, AutoSummaryRecord>();
        public Dictionary<string, Dictionary<string, JHMoralScoreRecord>> SuperList = new Dictionary<string, Dictionary<string, JHMoralScoreRecord>>();

        public Dictionary<string, AssnCode> AssnList;

        public string GetMSRList(string schoolYear, string semester)
        {
            string ErrorMessage = "";

            SchoolYear = schoolYear;
            Semester = semester;

            //班級Key<學生Record,JHMoral>
            SuperList.Clear();
            AutoSummaryDic.Clear();

            //學生ID,AssnCode
            AssnList = new Dictionary<string, AssnCode>();

            ClassList.Clear();
            ClassList = JHClass.SelectByIDs(Class.Instance.SelectedKeys); //班級清單

            ClassList.Sort(new Comparison<JHClassRecord>(ClassComparer));

            List<string> StudentList = new List<string>();

            List<JHStudentRecord> Test = JHStudent.SelectAll(); //Catch

            foreach (JHClassRecord each in ClassList)
            {
                if (!SuperList.ContainsKey(each.ID))
                {
                    SuperList.Add(each.ID, new Dictionary<string, JHMoralScoreRecord>()); //建立班級盒子
                }

                List<JHStudentRecord> ClassStudentList = each.Students;
                foreach (JHStudentRecord stud in ClassStudentList)
                {
                    if (stud.Status == K12.Data.StudentRecord.StudentStatus.一般)
                    {
                        //建立取得資料的學生ID-key
                        StudentList.Add(stud.ID);
                        if (!SuperList[each.ID].ContainsKey(stud.ID))
                        {
                            SuperList[each.ID].Add(stud.ID, null);
                        }
                    }
                }
            }

            //取得社團資料
            List<AssnCode> UDTAssnList = _accessHelper.Select<AssnCode>(string.Format("SchoolYear='{0}' and Semester='{1}'", SchoolYear, Semester));
            int Assnx = 0;
            foreach (AssnCode each in UDTAssnList)
            {
                if (!AssnList.ContainsKey(each.StudentID))
                {
                    AssnList.Add(each.StudentID, each);
                }
                else
                {
                    Assnx++;
                }
            }
            if (Assnx != 0)
            {
                ErrorMessage += string.Format("{0}學年度 第{1}學期 社團成績重覆「{2}」筆!!\n\n請使用資料合理性檢查「社團成績重覆檢查」\n處理重覆之成績!", SchoolYear, Semester, Assnx);
            }

            //取得utoSummary
            SchoolYearSemester SchoolSYS = new SchoolYearSemester(int.Parse(SchoolYear), int.Parse(Semester));
            List<AutoSummaryRecord> AutoSummaryList = AutoSummary.Select(StudentList, new SchoolYearSemester[] { SchoolSYS });//取得學生AutoSummary

            List<JHMoralScoreRecord> MoralList = JHMoralScore.SelectByStudentIDs(StudentList); //取得所有日常生活表現

            //把資料依 班級Key<學生Record,JHMoral> 進行資料收集
            foreach (JHMoralScoreRecord each in MoralList)
            {
                if (each.SchoolYear.ToString() == SchoolYear && each.Semester.ToString() == Semester) //如果為本學期之資料
                {
                    JHStudentRecord sr = each.Student;
                    SuperList[sr.Class.ID][sr.ID] = each;
                }
            }

            //處理AutoSummary
            foreach (AutoSummaryRecord auto in AutoSummaryList)
            {
                if (!AutoSummaryDic.ContainsKey(auto.RefStudentID))
                {
                    AutoSummaryDic.Add(auto.RefStudentID, auto);
                }
            }

            return ErrorMessage;
        }

        /// <summary>
        /// 建構子
        /// </summary>
        public GetMSRlist()
        {

        }


        private int ClassComparer(JHClassRecord x, JHClassRecord y)
        {
            string xx = x.Name;
            string yy = y.Name;
            return xx.CompareTo(yy);
        }
    }
}
