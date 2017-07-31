using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppViews.AppModels;
using DAL.DbModel;

namespace DAL.Repository.Topic.Sql
{
    public class TopicRepository : ITopicRepository
    {
        readonly KonkorEntities2 _context;

        public TopicRepository(KonkorEntities2 context)
        {
            _context = context;
        }

       

        public List<DbModel.Topic> GetAllActiveTopics()
        {
            var ans = _context.Topics.Where(x => x.IsActive).ToList();
            return ans;
        }

        public List<TopicModel> GetAllActiveTopicsByLessonId(long id)
        {
            var list = _context.Topics.Where(x => x.IsActive && x.Lesson_Id == id).ToList();
            var ans = new List<TopicModel>();
            foreach (var temp in list)
            {
                var t = new TopicModel();
                t.IsActive = temp.IsActive;
                t.Description = temp.Description;
                t.Id = temp.Id;
                t.LessonId = temp.Lesson_Id;
                t.LesoonName = temp.Lesson.Name;
                t.Name = temp.Name;
                t.Price = temp.Price;
                t.QuestionPrice = temp.QuestionPrice;
                t.TextPrice = temp.TextPrice;
                ans.Add(t);
            }
            return ans;
        }

        public DbModel.Topic GetTopicById(long id)
        {
            var ans = _context.Topics.FirstOrDefault(x => x.Id == id);
            return ans;
        }
    }
}
