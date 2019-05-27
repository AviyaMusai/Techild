using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class TestsLogic
    {
        public static DAL.TechildDBEntities db = new DAL.TechildDBEntities();
        public static List<TestsDto> GetAllTest()
        {
            List<TestsDto> t = new List<TestsDto>();
            var tests = db.Tests.ToList();
            foreach (var item in tests)
            {
                t.Add(Dto.TestsDto.ConvertDBToDto(item));
            }
            return t;
        }
        //קבלת כל המבחנים של נושא מסוים לפי קוד נושא
        public static List<TestsDto>GetTestsBySubId(int subId)
        {
            List<TestsDto> t = new List<TestsDto>();
            var q = from l in db.Lessons
                    join ts in db.Tests
                    on l.id equals (ts.lessonAndSubjectId)
                    where l.subjectId == subId
                    select ts;
            foreach (var item in q)
            {
                t.Add(Dto.TestsDto.ConvertDBToDto(item));
            }
            return t;    
        }       
    }
}
