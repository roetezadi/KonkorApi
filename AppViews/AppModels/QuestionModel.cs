using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppViews.AppModels
{
    public class QuestionModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PathKey{ get; set; }
        public bool IsActive { get; set; }
        public long Day { get; set; }
        public int InsertData { get; set; }
        public long InsertUserId { get; set; }
        public long AnswerId { get; set; }
        public long TopicId { get; set; }
        public long SubscribeAcc { get; set; }
        public long SubscribeCount { get; set; }
        public long SubscribeWrong { get; set; }
        public float FuzzyValue { get; set; }
        public int EstimateTime { get; set; }
        public int Price { get; set; }

    }
}
