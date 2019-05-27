using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
namespace BLL
{
  public class ProgressLogic
    {
        public static DAL.TechildDBEntities db = new DAL.TechildDBEntities();
        //החזרת כל ההתקדמויות של משתמש לפי קוד משתמש
        public static List<ProgressDto> GetProgressByUserId(int userId)
        {
            List<ProgressDto> p = new List<ProgressDto>();
            var progress = from pro in db.Progress
                           where pro.userId == userId
                           select pro;
            foreach (var item in progress)
            {
                p.Add(Dto.ProgressDto.ConvertDBToDto(item));
            }
            return p;
        }
        //החזרת ההתקדמויות של נושא מסוים למשתמש מסוים לפי קוד נושא וקוד משתמש
        public static List<ProgressDto> GetProgressByUserIdAndSubjectid(int userId,int subId)
        {
            List<ProgressDto> p = new List<ProgressDto>();
            var progress = from pro in db.Progress join m in db.Lessons
                           on pro.lessonAndSubjectId equals m.id                   
                           where pro.userId == userId &&
                           m.subjectId==subId
                           select pro;
            foreach (var item in progress)
            {
                p.Add(Dto.ProgressDto.ConvertDBToDto(item));
            }
            return p;
        }
    }
}
