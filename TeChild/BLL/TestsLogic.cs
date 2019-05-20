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
       
    }
}
