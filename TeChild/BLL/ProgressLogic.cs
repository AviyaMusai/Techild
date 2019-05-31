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
        public static DAL.TechildDBEntities1 db = new DAL.TechildDBEntities1();
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
			List<ProgressDto> pp = new List<ProgressDto>();
            foreach (var item in db.Progress.Where(p => p.userId == userId && p.Lessons.subjectId == subId).ToList())
            {
                pp.Add(Dto.ProgressDto.ConvertDBToDto(item));
            }
            return pp;
        }
    }
}
