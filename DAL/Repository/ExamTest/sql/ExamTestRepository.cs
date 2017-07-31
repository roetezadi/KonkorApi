using DAL.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.ExamTest.sql
{
    public class ExamTestRepository:IExamTestRespository
    {
        readonly KonkorEntities2 _context;
        public ExamTestRepository(KonkorEntities2 context)
        {
            _context = context;
        }
        public DbModel.ExamTest GetExamTestById(long id)
        {
            var ans = _context.ExamTests.FirstOrDefault(x => x.Id == id);
            return ans;
        }

        public List<AppViews.AppModels.ExamTestModel> GetAllExamTest(long fieldId, long gradeId, long bookNameId, long lessonId, long topicId, int hardness)
        {
            var list = _context.ExamTests.Where(x => x.FieldId == fieldId && x.GradeId == gradeId && x.BookNameId == bookNameId && x.LessonId == lessonId && x.TopicId == topicId && x.Hardness == hardness).ToList();
            var ans = new List<AppViews.AppModels.ExamTestModel>();
            foreach (var temp in list)
            {
                var t = new AppViews.AppModels.ExamTestModel();
                t.BookNameId = temp.BookNameId;
                t.FieldId = temp.FieldId;
                t.GradeId = temp.GradeId;
                t.Hardness = temp.Hardness;
                t.Id = temp.Id;
                t.LessonId = temp.LessonId;
                t.Price = temp.Price;
                t.TopicId = temp.TopicId;
                ans.Add(t);
            }
            return ans;
        }

        public DbModel.ExamTest GetExamTestById()
        {
            throw new NotImplementedException();
        }
    }
}
