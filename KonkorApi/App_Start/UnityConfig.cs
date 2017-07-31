using Microsoft.Practices.Unity;
using System.Web.Http;
using DAL.Repository.BookName;
using DAL.Repository.BookName.Sql;
using DAL.Repository.Field;
using DAL.Repository.Field.Sql;
using DAL.Repository.Grade;
using DAL.Repository.Grade.Sql;
using DAL.Repository.Lesson;
using DAL.Repository.Lesson.Sql;
using DAL.Repository.Service;
using DAL.Repository.Service.Sql;
using DAL.Repository.Topic;
using DAL.Repository.Topic.Sql;
using Unity.WebApi;

namespace KonkorApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IServiceRepository, ServiceRepository>(); 
            container.RegisterType<IFieldRepository, FieldRepository>();
            container.RegisterType<IGradeRepository, GradeRepository>();
            container.RegisterType<IBookNameRepository, BookNameRepository>();
            container.RegisterType<ILessonRepository, LessonRepository>();
            container.RegisterType<ITopicRepository, TopicRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}