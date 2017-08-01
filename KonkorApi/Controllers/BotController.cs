using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using AppViews.ApiResultData;
using DAL.DbModel;
using DAL.Repository.BookName;
using DAL.Repository.Field;
using DAL.Repository.Grade;
using DAL.Repository.Lesson;
using DAL.Repository.Service;
using DAL.Repository.Topic;
using KonkorApi.Models;
using Newtonsoft.Json;
using DAL.Repository.ExamTest;

namespace KonkorApi.Controllers
{   
    //[Authorize]
    [RoutePrefix("api/Bot")]
    public class BotController : ApiController
    { 
        private readonly IServiceRepository _serviceRepository;
        private readonly IFieldRepository _fieldRepository;
        private readonly IGradeRepository _gradeRepository;
        private readonly IBookNameRepository _bookNameRepository;
        private readonly ILessonRepository _lessonRepository;
        private readonly ITopicRepository _topicRepository;
        private readonly IExamTestRespository _examTestRepository;
        private readonly DAL.Repository.ExamTestQuestion.IExamTestQuestionRepository _examTestQuestionRepository;

        public BotController(IServiceRepository serviceRepository
            , IFieldRepository fieldRepository, IGradeRepository gradeRepository
            , IBookNameRepository bookNameRepository, ILessonRepository lessonRepository
            , ITopicRepository topicRepository , IExamTestRespository examTestRepository
            , DAL.Repository.ExamTestQuestion.IExamTestQuestionRepository examTestQuestionRepository)
        {
            _serviceRepository = serviceRepository;
            _fieldRepository = fieldRepository;
            _gradeRepository = gradeRepository;
            _bookNameRepository = bookNameRepository;
            _lessonRepository = lessonRepository;
            _topicRepository = topicRepository;
            _examTestRepository = examTestRepository;
            _examTestQuestionRepository = examTestQuestionRepository;
        }


        public static Dictionary<string, string> JsonDataParser(string str)
        {
            var dictionary = 
                JsonConvert.DeserializeObject<Dictionary<string, string>>(str);
            return dictionary;
        }

        public static string JsonSerializer(Dictionary<string, string> inputDic)
        {  
            return JsonConvert.SerializeObject(inputDic);
        }



        ///<summary>
        ///vorodi : fieldid , gradeid , BooknameId , LessonId , TopicId , Hardness
        ///khoroji : list of questions with their property
        /// </summary>
        [AcceptVerbs("GET")]
        [Route("GetExamTest")]
        public JsonResult<ResultUi> GetExamTest(long fieldid, long gradeid, long booknameid, long lessonid, long topicid, int hardness)
        {
            ResultUi resultUi;
            try
            {
                var ans = new DataPackUi();
                var exams = _examTestRepository.GetAllExamTest(fieldid, gradeid, booknameid, lessonid, topicid, hardness);

                //generating long random()
                long LongRandom(long min, long max, Random rand)
                {
                    long result = rand.Next((Int32)(min >> 32), (Int32)(max >> 32));
                    result = (result << 32);
                    result = result | (long)rand.Next((Int32)min, (Int32)max);
                    return result;
                }
                long maxi = -1;
                foreach (var e in exams)
                {
                    if (e.Id > maxi)
                    {
                        maxi = e.Id;
                    }
                }
                long id = LongRandom(0, maxi, new Random());
                
                var questions = _examTestQuestionRepository.GetExamTestQuestion(id);
                ans.MyData = questions;
                resultUi = new ResultUi { Value = ans, Msg = "Success" };
                return Json(resultUi);
            }
            catch (Exception ex)
            {
                resultUi = new ResultUi { Value = "", Msg = "Fail", Exception = ex.Message };
                return Json(resultUi);
            }
        }





        ///// <summary>
        ///// vorodi : name family phoneNumber sex telegramId Ismarried BithDay
        ///// khoroji : Guid 
        ///// </summary>
        ///// <param name="myData"></param>
        ///// <returns></returns>
        //[AcceptVerbs("POST")]
        //[Route("SetSubscriber")]
        //public DataPackUi SetSubscriber (SubscriberModel myData) 
        //{
        //    var ans = new DataPackUi();
        //    return ans;
        //}

        ///// <summary>
        ///// Vorodi : GradeId , FieldId
        ///// </summary>
        ///// <param name="myData"></param>
        ///// <returns></returns>
        //[AcceptVerbs("POST")]
        //[Route("SetSubscriberInfo")]
        //public DataPackUi SetSubscriberInfo(SubscriberInfoModel myData)
        //{
        //    var ans = new DataPackUi();
        //    return ans;
        //}

        /// <summary>
        /// vorodi : null
        /// khoroji : List<Field/>
        /// Field
        /// {
        ///     Id , Name , Description , TotalPrice , QuestionPrice , TextPrice
        /// } 
        /// </summary>
        /// <returns></returns>
        [AcceptVerbs("GET")]
        [Route("GetAllActiveFields")]
        public JsonResult<ResultUi> GetAllActiveFields() // OK
        {
            ResultUi resultUi;
            try
            {
                var ans = new DataPackUi();
                var fields = _fieldRepository.GetAllActiveFields();
                ans.MyData = fields;
                resultUi = new ResultUi {Value = ans , Msg = "Success" };
                return Json(resultUi);
            }
            catch (Exception ex)
            {
                resultUi = new ResultUi {Value = "" , Msg = "Fail", Exception = ex.Message};
                return Json(resultUi);
            }
            
        }

        /// <summary>
        /// vorodi : FieldId
        /// khoroji : List<Grade/>
        /// Grade 
        /// {
        ///     Id , Name , Description , TotalPrice , QuestionPrice , TextPrice
        /// }
        /// </summary>
        /// <param name="fieldId"></param>
        /// <returns></returns>
        [AcceptVerbs("GET")]
        [Route("GetAllActiveGradesByFieldId")]
        public JsonResult<ResultUi> GetAllActiveGradesByFieldId(long fieldId) //OK
        {
            ResultUi resultUi;
            try
            {
                var ans = new DataPackUi();
                var grades = _gradeRepository.GetAllActiveGradesByFieldId(fieldId);
                ans.MyData = grades;
                resultUi = new ResultUi { Value = ans, Msg = "Success" };
                return Json(resultUi);
            }
            catch (Exception ex)
            {
                resultUi = new ResultUi { Value = "", Msg = "Fail", Exception = ex.Message };
                return Json(resultUi);
            }
        }

        /// <summary>
        /// Vorodi : GradeId
        /// khoroji : List<BookName/>
        /// bookName 
        /// {
        ///     Id , Name , Description , TotalPrice , QuestionPrice , TextPrice
        /// }
        /// </summary>
        /// <param name="gradeId"></param>
        /// <returns></returns>
        [AcceptVerbs("GET")]
        [Route("GetAllActiveBookNamesByGradeId")]
        public JsonResult<ResultUi> GetAllActiveBookNamesByGradeId(long gradeId) //OK
        {
            ResultUi resultUi;
            try
            {
                var ans = new DataPackUi();
                var bookNames = _bookNameRepository.GetAllActiveBookNamesByGradeId(gradeId);
                ans.MyData = bookNames;
                resultUi = new ResultUi { Value = ans, Msg = "Success" };
                return Json(resultUi);
            }
            catch (Exception ex)
            {
                resultUi = new ResultUi { Value = "", Msg = "Fail", Exception = ex.Message };
                return Json(resultUi);
            }
        }

        /// <summary>
        /// Vorodi : BookNameId     
        /// khoroji : List<Lesson/>
        /// Lesson 
        /// {
        ///     Id , Name , Description , TotalPrice , QuestionPrice , TextPrice
        /// }
        /// </summary>
        /// <param name="lessonId"></param>
        /// <returns></returns>
        [AcceptVerbs("GET")]
        [Route("GetAllActiveLessonsByBookNameId")]
        public JsonResult<ResultUi> GetAllActiveLessonsByBookNameId(long lessonId)
        {
            ResultUi resultUi;
            try
            {
                var ans = new DataPackUi();
                var lessons = _lessonRepository.GetAllActiveLessonsByBookNameId(lessonId);
                ans.MyData = lessons;
                resultUi = new ResultUi { Value = ans, Msg = "Success" };
                return Json(resultUi);
            }
            catch (Exception ex)
            {
                resultUi = new ResultUi { Value = "", Msg = "Fail", Exception = ex.Message };
                return Json(resultUi);
            }
        }

        /// <summary>
        /// Vorodi : LessonId     
        /// khoroji : List<Topic/>
        /// Topic 
        /// {
        ///     Id , Name , Description , TotalPrice , QuestionPrice , TextPrice
        /// }
        /// </summary>
        /// <param name="lessonId"></param>
        /// <returns></returns>
        [AcceptVerbs("GET")]
        [Route("GetAllActiveTopicsByLessonId")]
        public JsonResult<ResultUi> GetAllActiveTopicsByLessonId(long lessonId)
        {
            ResultUi resultUi;
            try
            {
                var ans = new DataPackUi();
                var topics = _topicRepository.GetAllActiveTopicsByLessonId(lessonId);
                ans.MyData = topics;
                resultUi = new ResultUi { Value = ans, Msg = "Success" };
                return Json(resultUi);
            }
            catch (Exception ex)
            {
                resultUi = new ResultUi { Value = "", Msg = "Fail", Exception = ex.Message };
                return Json(resultUi);
            }
        }


        ///// <summary>
        ///// vorodi : null
        ///// khoroji : List<package/>
        ///// package 
        ///// {
        /////     Id , Name , Description , DurationDay , ChargeDurationDay 
        ///// }
        ///// </summary>
        ///// <param name="myData"></param>
        ///// <returns></returns>
        //[AcceptVerbs("POST")]
        //[Route("GetActivePackages")]
        //public DataPackUi GetActivePackages(string myData)
        //{
        //    var ans = new DataPackUi();
        //    return ans;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="myData"></param>
        ///// <returns></returns>
        //[AcceptVerbs("GET", "POST")]
        //[Route("GetExamWithTopicId")]
        //public DataPackUi GetExamWithTopicId(KeyAndValueEntity myData)
        //{
        //    var ans = new DataPackUi();
        //    return ans;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="myData"></param>
        ///// <returns></returns>
        //[AcceptVerbs("GET", "POST")]
        //[Route("GetExamWithLessonId")]
        //public DataPackUi GetExamWithLessonId(KeyAndValueEntity myData)
        //{
        //    var ans = new DataPackUi();
        //    return ans;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="myData"></param>
        ///// <returns></returns>
        //[AcceptVerbs("GET", "POST")]
        //[Route("GetExamWithBookNameId")]
        //public DataPackUi GetExamWithBookNameId(KeyAndValueEntity myData)
        //{
        //    var ans = new DataPackUi();
        //    return ans;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="myData"></param>
        ///// <returns></returns>
        //[AcceptVerbs("GET", "POST")]
        //[Route("GetExamWithGradeId")]
        //private DataPackUi GetExamWithGradeId(KeyAndValueEntity myData)
        //{
        //    var ans = new DataPackUi();
        //    return ans;
        //}

    }
}
