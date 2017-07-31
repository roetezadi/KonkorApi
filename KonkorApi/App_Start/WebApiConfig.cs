using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using KonkorApi.Resolver;
using Microsoft.Owin.Security.OAuth;
using Microsoft.Practices.Unity;
using Newtonsoft.Json.Serialization;

namespace KonkorApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            var container = new UnityContainer();

            container.RegisterType<IServiceRepository, ServiceRepository>
                (new HierarchicalLifetimeManager());
            container.RegisterType<IFieldRepository, FieldRepository>
                (new HierarchicalLifetimeManager());
            container.RegisterType<IGradeRepository, GradeRepository>
               (new HierarchicalLifetimeManager());
            container.RegisterType<IBookNameRepository, BookNameRepository>
               (new HierarchicalLifetimeManager());
            container.RegisterType<ILessonRepository, LessonRepository>
              (new HierarchicalLifetimeManager());
            container.RegisterType<ITopicRepository, TopicRepository>
              (new HierarchicalLifetimeManager());
            //container.RegisterType<IVideoRepository, VideoRepository>(new HierarchicalLifetimeManager());
            //container.RegisterType<IErrorLogRepository, ErrorLogRepository>(new HierarchicalLifetimeManager());
            //container.RegisterType<IContentRepository, ContentRepository>(new HierarchicalLifetimeManager());

            config.DependencyResolver = new UnityResolver(container);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
