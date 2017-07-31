using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppViews.AppModels
{
    public class ExamModel
    {
        public long Id { get; set; }
        public System.DateTime CreateTime { get; set; }
        public float ExamLevel { get; set; }
        public int Price { get; set; }
        public int QuestionCount { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime ExpireTime { get; set; }
    }
}
