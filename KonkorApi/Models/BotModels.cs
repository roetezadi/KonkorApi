using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KonkorApi.Models
{
    public class SubscriberModel
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string PhoneNumber { get; set; }
        public string Sex { get; set; }
        public string TelegramId { get; set; }
        public string IsMarriedP { get; set; }
        public string BithDay { get; set; }
    }

    public class SubscriberInfoModel
    {
        public string GradeId { get; set; }
        public string FieldId { get; set; }
    }


    public class FieldModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string QuestionPrice { get; set; }
    }

    public class GradeModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string QuestionPrice { get; set; }
    }

    public class BookNameModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string QuestionPrice { get; set; }
        
    }
    public class LessonModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string QuestionPrice { get; set; }
        
    }
    public class TopicModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string QuestionPrice { get; set; }

    }

    public class KeyAndValueEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
    }
}