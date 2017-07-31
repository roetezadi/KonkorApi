using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppViews.AppModels;
using DAL.DbModel;

namespace DAL.Repository.Grade.Sql
{
    public class GradeRepository : IGradeRepository
    {
        readonly KonkorEntities2 _context;

        public GradeRepository(KonkorEntities2 context)
        {
            _context = context;
        }

        public List<DbModel.Grade> GetAllActiveGrades()
        {
            var ans = _context.Grades.Where(x => x.IsActive).ToList();
            return ans;
        }
        public List<GradeModel> GetAllActiveGradesByFieldId(long id)
        {
            var list = _context.Grades.Where(x => x.Field_Id == id && x.IsActive).ToList();
            var ans = new List<GradeModel>();
            foreach (var temp in list)
            {
                var t = new GradeModel();
                t.Id = temp.Id;
                t.Description = temp.Description;
                t.FieldId = temp.Field_Id;
                t.FieldName = temp.Field.Name;
                t.Name = temp.Name;
                t.IsActive = temp.IsActive;
                t.Price = temp.Price;
                t.QuestionPrice = temp.QuestionPrice;
                t.TextPrice = temp.TextPrice;
                ans.Add(t);
            }
            return ans;
        }

        public DbModel.Grade GetGradeById(long id)
        {
            var ans = _context.Grades.FirstOrDefault(x => x.Id == id);
            return ans;
        }

    }
}
