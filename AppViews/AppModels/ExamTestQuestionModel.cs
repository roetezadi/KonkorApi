using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppViews.AppModels
{
    public class ExamTestQuestionModel
    {
        public long Id { get; set; }
        public long? ExamTestId { get; set; }
        public long? QuestionId { get; set; }

    }
}
