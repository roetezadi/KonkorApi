using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppViews.AppModels;

namespace DAL.Repository.Grade
{
    public interface IGradeRepository
    {
        List<DbModel.Grade> GetAllActiveGrades();
        List<GradeModel> GetAllActiveGradesByFieldId(long id);
        DbModel.Grade GetGradeById(long id);
    }
}
