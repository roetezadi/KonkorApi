using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppViews.AppModels
{
    public class ExamTestModel
    {
        public long Id { get; set; }
        public int? Price { get; set; }
        public long? FieldId { get; set; }
        public long? GradeId { get; set; }
        public long? BookNameId { get; set; }
        public long? LessonId { get; set; }
        public long? TopicId { get; set; }
        public int? Hardness { get; set; }

    }
}
