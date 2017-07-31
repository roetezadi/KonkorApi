using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Exam
{
    public interface IExamRepository
    {
        DbModel.Exam GetExamById(long id);
        List<AppViews.AppModels.ExamModel> GetAllExamsByBookLessonTopic(long bookid, long lessonid, long topicid);
    }
}
