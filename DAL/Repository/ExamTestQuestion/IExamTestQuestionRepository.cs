using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.ExamTestQuestion
{
    public interface IExamTestQuestionRepository
    {
        DbModel.ExamTestQuestion GetExamTestQuestionById(long id);
        List<AppViews.AppModels.ExamTestQuestionModel> GetExamTestQuestion(long ExamTestid);
    }
}
