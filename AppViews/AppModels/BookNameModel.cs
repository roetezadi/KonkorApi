using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppViews.AppModels
{
    public class BookNameModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long GradeId { get; set; }
        public string GradeName { get; set; }
        public bool IsActive { get; set; }
        public int ? Price { get; set; }
        public int? QuestionPrice { get; set; }
        public int? TextPrice { get; set; }
    }
}
