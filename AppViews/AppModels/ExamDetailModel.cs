using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppViews.AppModels
{
    public class ExamDetailModel
    {
        public long Id { get; set; }
        public long ExamId { get; set; }
        public long BookNameId { get; set; }
        public long LessonId { get; set; }
        public long TopicId { get; set; }
        public int Accept { get; set; }
        public int Wrong { get; set; }

    }
}
