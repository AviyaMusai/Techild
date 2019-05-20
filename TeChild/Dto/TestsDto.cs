using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace Dto
{
  public  class TestsDto
    {
        public int id { get; set; }
        public int lessonAndSubjectId { get; set; }
        public string testFile { get; set; }

     //   public virtual Lessons Lessons { get; set; }
     public static TestsDto ConvertDBToDto(Tests tests)
        {
            return new TestsDto()
            {
                id = tests.id,
                lessonAndSubjectId = tests.lessonAndSubjectId,
                testFile = tests.testFile
            };
        }
    }
}
