using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppViews.AppModels;
using DAL.DbModel;

namespace DAL.Repository.BookName.Sql
{
    public class BookNameRepository : IBookNameRepository
    {
        readonly KonkorEntities2 _context;

        public BookNameRepository(KonkorEntities2 context)
        {
            _context = context;
        }

        public List<DbModel.BookName> GetAllActiveBookNames()
        {
            var ans = _context.BookNames.Where(x => x.IsActive).ToList();
            return ans;
        }

        public List<BookNameModel> GetAllActiveBookNamesByGradeId(long id)
        {
            var list = _context.BookNames.Where(x => x.IsActive && x.Grade_Id == id).ToList();
            var ans = new List<BookNameModel>();
            foreach (var temp in list)
            {
                var t = new BookNameModel();
                t.Id = temp.Id;
                t.IsActive = temp.IsActive;
                t.Description = temp.Description;
                t.GradeId = temp.Grade_Id;
                t.GradeName = temp.Grade.Name;
                t.Name = temp.Name;
                t.Price = temp.Price;
                t.QuestionPrice = temp.QuestionPrice;
                t.TextPrice = temp.TextPrice;
                ans.Add(t);
            }
            return ans;
        }

        public DbModel.BookName GetBookNameById(long id)
        {
            var ans = _context.BookNames.FirstOrDefault(x => x.Id == id);
            return ans;
        }
    }
}
