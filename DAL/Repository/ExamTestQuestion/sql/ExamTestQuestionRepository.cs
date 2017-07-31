using DAL.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.ExamTestQuestion.sql
{
    public class ExamTestQuestionRepository:IExamTestQuestionRepository
    {
        readonly KonkorEntities2 _context;
        public ExamTestQuestionRepository(KonkorEntities2 context)
        {
            _context = context;
        }

        public DbModel.ExamTestQuestion GetExamTestQuestionById(long id)
        {
            var ans = _context.ExamTestQuestions.FirstOrDefault(x => x.Id == id);
            return ans;
        }

        public List<AppViews.AppModels.ExamTestQuestionModel> GetExamTestQuestion(long ExamTestid)
        {
            var list = _context.ExamTestQuestions.Where(x => x.ExamTestId == ExamTestid).ToList();
            var ans = new List<AppViews.AppModels.ExamTestQuestionModel>();
            foreach (var temp in list)
            {
                var t = new AppViews.AppModels.ExamTestQuestionModel();
                t.ExamTestId = temp.ExamTestId;
                t.Id = temp.Id;
                t.QuestionId = temp.QuestionId;
                ans.Add(t);
            }
            return ans;
        }

        DbModel.ExamTestQuestion IExamTestQuestionRepository.GetExamTestQuestionById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
