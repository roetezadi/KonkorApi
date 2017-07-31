using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppViews.AppModels;
using DAL.DbModel;

namespace DAL.Repository.Lesson.Sql
{
    public class LessonRepository : ILessonRepository
    {
        readonly KonkorEntities2 _context;

        public LessonRepository(KonkorEntities2 context)
        {
            _context = context;
        }

        


        public List<DbModel.Lesson> GelAllActiveLessons()
        {
            var ans = _context.Lessons.Where(x => x.IsActive).ToList();
            return ans;
        }

        public List<LessonModel> GetAllActiveLessonsByBookNameId(long id)
        {
            var list = _context.Lessons.Where(x => x.IsActive && x.BookName_Id == id).ToList();
            var ans = new List<LessonModel>();
            foreach (var temp in list)
            {
                var t = new LessonModel();
                t.Id = temp.Id;
                t.IsActive = temp.IsActive;
                t.BookNameId = temp.BookName_Id;
                t.BookNameName = temp.BookName.Name;
                t.Description = temp.Description;
                t.Name = temp.Name;
                t.Price = temp.Price;
                t.QuestionPrice = temp.QuestionPrice;
                t.TextPrice = temp.TextPrice;
                ans.Add(t);
            }
            return ans;
        }

        public DbModel.Lesson GetLessonById(long id)
        {
            var ans = _context.Lessons.FirstOrDefault(x => x.Id == id);
            return ans;
        }
    }
}
