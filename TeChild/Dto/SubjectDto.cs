using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class SubjectDto
    {
        public int id { get; set; }
        public string name { get; set; }

        //  public  List<Lessons> Lessons { get; set; }

        public static SubjectDto ConvertDBToDto(Subjects subjects )
        {
            return new SubjectDto()
            {
                id = subjects.id,
                name = subjects.name
            };
        }

    }
}
