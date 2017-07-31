using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppViews.AppModels
{
    public class TopicModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long LessonId { get; set; }
        public string LesoonName { get; set; }
        public bool IsActive { get; set; }
        public int ? Price { get; set; }
        public int? QuestionPrice { get; set; }
        public int? TextPrice { get; set; }
    }
}
