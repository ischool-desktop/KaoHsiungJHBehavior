﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JHSchool.Evaluation.Calculation.GraduationConditions;
using JHSchool.Evaluation.Calculation;
using System.Xml;


namespace JHSchool.Evaluation.StudentExtendControls.Ribbon.GraduationPredictReportControls
{
    class ConditionalEvaluateFactory : IEvaluateFactory
    {
        private List<string> _conditions;

        public ConditionalEvaluateFactory(IEnumerable<string> conditions)
        {
            _conditions = new List<string>(conditions);
        }

        private bool IsValid(string condition)
        {
            if (_conditions.Contains(condition))
                return true;
            else
                return false;
        }

        #region IEvaluateFactory 成員

        public Dictionary<string, JHSchool.Evaluation.Calculation.IEvaluative> CreateEvaluativeEntities()
        {
            ScoreCalcRule.Instance.SyncAllBackground();

            Dictionary<string, IEvaluative> evals = new Dictionary<string, IEvaluative>();

            foreach (ScoreCalcRuleRecord record in ScoreCalcRule.Instance.Items)
            {
                if (record.Content == null) continue;

                AndEval allAndEval = new AndEval();

                XmlElement element;

                OrEval orScore = new OrEval();
                element = (XmlElement)record.Content.SelectSingleNode("畢業條件/學業成績畢業條件/條件[@Type='LearnDomainEach']");
                if (element != null && bool.Parse(element.GetAttribute("Checked")) && IsValid("LearnDomainEach")) orScore.Add(new LearnDomainEachEval(element));
                element = (XmlElement)record.Content.SelectSingleNode("畢業條件/學業成績畢業條件/條件[@Type='LearnDomainLast']");
                if (element != null && bool.Parse(element.GetAttribute("Checked")) && IsValid("LearnDomainLast")) orScore.Add(new LearnDomainLastEval(element));

                OrEval orDaily1 = new OrEval();
                element = (XmlElement)record.Content.SelectSingleNode("畢業條件/日常生活表現畢業條件/條件[@Type='AbsenceAmountEach']");
                if (element != null && bool.Parse(element.GetAttribute("Checked")) && IsValid("AbsenceAmountEach")) orDaily1.Add(new AbsenceAmountEachEval(element));
                element = (XmlElement)record.Content.SelectSingleNode("畢業條件/日常生活表現畢業條件/條件[@Type='AbsenceAmountLast']");
                if (element != null && bool.Parse(element.GetAttribute("Checked")) && IsValid("AbsenceAmountLast")) orDaily1.Add(new AbsenceAmountLastEval(element));

                OrEval orDaily2 = new OrEval();
                element = (XmlElement)record.Content.SelectSingleNode("畢業條件/日常生活表現畢業條件/條件[@Type='AbsenceAmountEachFraction']");
                if (element != null && bool.Parse(element.GetAttribute("Checked")) && IsValid("AbsenceAmountEachFraction")) orDaily2.Add(new AbsenceAmountEachFractionEval(element));
                element = (XmlElement)record.Content.SelectSingleNode("畢業條件/日常生活表現畢業條件/條件[@Type='AbsenceAmountLastFraction']");
                if (element != null && bool.Parse(element.GetAttribute("Checked")) && IsValid("AbsenceAmountLastFraction")) orDaily2.Add(new AbsenceAmountLastFractionEval(element));

                OrEval orDaily3 = new OrEval();
                element = (XmlElement)record.Content.SelectSingleNode("畢業條件/日常生活表現畢業條件/條件[@Type='DemeritAmountEach']");
                if (element != null && bool.Parse(element.GetAttribute("Checked")) && IsValid("DemeritAmountEach")) orDaily3.Add(new DemeritAmountEachEval(element));
                element = (XmlElement)record.Content.SelectSingleNode("畢業條件/日常生活表現畢業條件/條件[@Type='DemeritAmountLast']");
                if (element != null && bool.Parse(element.GetAttribute("Checked")) && IsValid("DemeritAmountLast")) orDaily3.Add(new DemeritAmountLastEval(element));

                OrEval orDaily4 = new OrEval();
                element = (XmlElement)record.Content.SelectSingleNode("畢業條件/日常生活表現畢業條件/條件[@Type='DailyBehavior']");
                if (element != null && bool.Parse(element.GetAttribute("Checked")) && IsValid("DailyBehavior")) orDaily4.Add(new DailyBehaviorEval(element));
                element = (XmlElement)record.Content.SelectSingleNode("畢業條件/日常生活表現畢業條件/條件[@Type='DailyBehaviorLast']");
                if (element != null && bool.Parse(element.GetAttribute("Checked")) && IsValid("DailyBehaviorLast")) orDaily4.Add(new DailyBehaviorLastEval(element));

                allAndEval.Add(orScore);
                allAndEval.Add(orDaily1);
                allAndEval.Add(orDaily2);
                allAndEval.Add(orDaily3);
                allAndEval.Add(orDaily4);

                evals.Add(record.ID, allAndEval);
            }

            return evals;
        }

        #endregion
    }
}
