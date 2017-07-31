using System.Collections.Generic;
using System.Linq;
using DAL.DbModel;


namespace DAL.Repository.Service.Sql
{
    public class ServiceRepository : IServiceRepository
    {
        readonly KonkorEntities2 _context;

        public ServiceRepository (KonkorEntities2 context)
        {
            _context = context;
        }


        

        

       

        

        public List<DbModel.Topic> GetAllTopics()
        {
            var ans = _context.Topics.ToList();
            return ans;
        }

        public List<DbModel.Topic> GetAllActiveTopics()
        {
            var ans = _context.Topics.Where(x => x.IsActive).ToList();
            return ans;
        }

        public List<DbModel.Topic> GetAllActiveTopicsByLessonId(long id)
        {
            var ans = _context.Topics.Where(x => x.IsActive && x.Lesson_Id == id).ToList();
            return ans;
        }

        public DbModel.Topic GetTopicById(long id)
        {
            var ans = _context.Topics.FirstOrDefault(x => x.Id == id);
            return ans;
        }


    }
}
