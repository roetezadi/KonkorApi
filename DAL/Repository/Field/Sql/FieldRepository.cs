using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DbModel;

namespace DAL.Repository.Field.Sql
{
    public class FieldRepository : IFieldRepository
    {
        readonly KonkorEntities2 _context;

        public FieldRepository(KonkorEntities2 context)
        {
            _context = context;
        }





        public DbModel.Field GetFieldById(long id)
        {
            var ans = _context.Fields.FirstOrDefault(x => x.Id == id);
            return ans;
        }

        public List<AppViews.AppModels.FieldModel> GetAllActiveFields()
        {
            var list = _context.Fields.Where(x => x.IsActive).ToList();
            var ans = new List<AppViews.AppModels.FieldModel>();
            foreach (var temp in list)
            {
                var t = new AppViews.AppModels.FieldModel();
                t.Description = temp.Description;
                t.Id = temp.Id;
                t.IsActive = temp.IsActive;
                t.Name = temp.Name;
                t.Price = temp.Price;
                t.QuestionPrice = temp.QuestionPrice;
                t.TextPrice = temp.TextPrice;
                ans.Add(t);
            }
            return ans;
        }

        
    }
}
