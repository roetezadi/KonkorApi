using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Field
{
    public interface IFieldRepository
    {
        DbModel.Field GetFieldById(long id);
        List<AppViews.AppModels.FieldModel> GetAllActiveFields();
    }
}
