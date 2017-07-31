using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppViews.AppModels;

namespace DAL.Repository.Topic
{
    public interface ITopicRepository
    {
        DbModel.Topic GetTopicById(long id);
        List<TopicModel> GetAllActiveTopicsByLessonId(long id);
        List<DbModel.Topic> GetAllActiveTopics();

    }
}
