using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.ExamTest
{
    public interface IExamTestRespository
    {
        DbModel.ExamTest GetExamTestById();
        List<AppViews.AppModels.ExamTestModel> GetAllExamTest(long FieldId, long GradeId, long BookNameId, long LessonId, long TopicId, int Hardness);
    }
}
