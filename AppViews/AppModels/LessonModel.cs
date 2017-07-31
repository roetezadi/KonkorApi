using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppViews.AppModels
{
    public class LessonModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long BookNameId { get; set; }
        public string BookNameName { get; set; }
        public bool IsActive { get; set; }
        public int ? Price { get; set; }
        public int? QuestionPrice { get; set; }
        public int? TextPrice { get; set; }
    }
}
