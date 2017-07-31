using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.DbModel;
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
using Microsoft.Practices.Unity;
using Unity.WebApi;

namespace KonkorApi.Registration
{
    public class UnityConainerRegistration
    {
        public static IUnityContainer InotialiserContainer()
        {
            var container = new UnityContainer();


            container.RegisterType(typeof(IServiceRepository), typeof(ServiceRepository));
            container.RegisterType(typeof(IFieldRepository), typeof(FieldRepository));
            container.RegisterType(typeof(IGradeRepository), typeof(GradeRepository));
            container.RegisterType(typeof(IBookNameRepository), typeof(BookNameRepository));
            container.RegisterType(typeof(ILessonRepository), typeof(LessonRepository));
            container.RegisterType(typeof(ITopicRepository), typeof(TopicRepository));

            //container.RegisterType(typeof(QueueDAL.Models.Video.IVideoRepository), typeof(QueueDAL.Models.Video.Sql.VideoRepository));
            //container.RegisterType(typeof(QueueDAL.Models.Content.IContentRepository), typeof(QueueDAL.Models.Content.Sql.ContentRepository));
            //container.RegisterType(typeof(QueueDAL.Models.Home.IHomeRepository), typeof(QueueDAL.Models.Home.Sql.HomeRepository));
            //container.RegisterType(typeof(QueueDAL.Models.ServicePage.IServiceRepository), typeof(QueueDAL.Models.ServicePage.Sql.ServiceRepository));


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));


            return container;
        }
    }
}