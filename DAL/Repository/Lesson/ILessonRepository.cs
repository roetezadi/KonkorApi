using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppViews.AppModels;

namespace DAL.Repository.Lesson
{
    public interface ILessonRepository
    {
        List<DbModel.Lesson> GelAllActiveLessons();
        List<LessonModel> GetAllActiveLessonsByBookNameId(long id);
        DbModel.Lesson GetLessonById(long id);

    }
}
