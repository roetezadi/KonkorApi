using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppViews.AppModels;

namespace DAL.Repository.BookName
{
    public interface IBookNameRepository
    {
        List<DbModel.BookName> GetAllActiveBookNames();
        List<BookNameModel> GetAllActiveBookNamesByGradeId(long id);
        DbModel.BookName GetBookNameById(long id);
    }
}
