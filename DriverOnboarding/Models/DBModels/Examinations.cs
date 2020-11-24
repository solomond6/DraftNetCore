using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class Examinations
    {
        public ulong Id { get; set; }
        public string Subject { get; set; }
        public string Batch { get; set; }
        public int Duration { get; set; }
        public sbyte ShowScoreWhenFinished { get; set; }
        public int NumberOfQuestions { get; set; }
        public string QuestionSelectionMode { get; set; }
        public int QuestionsPerCategory { get; set; }
        public string Instructions { get; set; }
        public sbyte RandomiseOptions { get; set; }
        public sbyte TimedQuestions { get; set; }
        public sbyte UseOnlyGraceLakeCbtbrowser { get; set; }
        public sbyte UseOnlyPremierCbtbrowser { get; set; }
        public sbyte PhysicalTest { get; set; }
        public sbyte PracticeExam { get; set; }
        public sbyte ExamPaused { get; set; }
        public string Branch { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string Company { get; set; }
        public long RecordVersion { get; set; }
        public long Deleted { get; set; }
    }
}
