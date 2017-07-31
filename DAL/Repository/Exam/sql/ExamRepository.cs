using DAL.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Exam.sql
{
    public class ExamRepository
    {
        readonly KonkorEntities2 _context;

        public ExamRepository(KonkorEntities2 context)
        {
            _context = context;
        }

        DbModel.Exam GetExamById(long id)
        {
            var ans = _context.Exams.FirstOrDefault(x => x.Id == id);
            return ans;
        }

        List<AppViews.AppModels.ExamModel> GetAllExamsByBookLessonTopic(long bookid, long lessonid, long topicid)
        {
            var list = from Exam in _context.Exams
                       join ExamDetail in _context.ExamDetails on Exam.Id equals ExamDetail.Exam_Id
                       select Exam;
            var ans = new List<AppViews.AppModels.ExamModel>();
            foreach (var temp in list)
            {
                var e = new AppViews.AppModels.ExamModel();
                e.CreateTime = temp.CreateTime;

                ans.Add(e);
            }
            return ans;
        }

    }
}
