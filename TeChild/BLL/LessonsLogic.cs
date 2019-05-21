using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
namespace BLL
{
   public class LessonsLogic
    {
        public static DAL.TechildDBEntities db = new DAL.TechildDBEntities();
        //מחזיר רשימה של שיעורים מסוג DTO
        public static List<LessonDto> GetAllLessons()
        {
            List<LessonDto> l = new List<LessonDto>();
            var lessons = db.Lessons.ToList();
            foreach (var item in lessons)
            {
               l.Add( Dto.LessonDto.ConvertDBToDto(item));
            }
            return l;
        }
        //החזרת רשימת השיעורים לפי קוד נושא
        public static List<LessonDto>GetAllLessonsBySubId(int subId)
        {
            List<LessonDto> les = new List<LessonDto>();
            var q = from l in db.Lessons
                    where l.subjectId == subId
                    select l;
            foreach (var item in q.ToList())
            {
                les.Add(Dto.LessonDto.ConvertDBToDto(item));
            }
            return les;
        }
      
    }
}
