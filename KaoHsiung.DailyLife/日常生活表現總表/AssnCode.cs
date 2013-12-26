using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FISCA.UDT;
using System.Xml;

namespace KaoHsiung.DailyLife
{
    [TableName("JHSchool.Association.UDT")]
    class AssnCode : ActiveRecord
    {

        //因為有使用社團模組,所以需要此Record

        //Key ID
        /// <summary>
        /// ID
        /// </summary>
        [Field(Field = "StudentID", Indexed = true)]
        public string StudentID { get; set; }

        /// <summary>
        /// Key 學年度
        /// </summary>
        [Field(Field = "SchoolYear", Indexed = false)]
        public string SchoolYear { get; set; }

        /// <summary>
        /// Key 學期
        /// </summary>
        [Field(Field = "Semester", Indexed = false)]
        public string Semester { get; set; }

        /// <summary>
        /// 課程成績相關資訊(Xml結構)
        /// </summary>
        [Field(Field = "Scores", Indexed = false)]
        public string Scores { get; set; }
    }
}
