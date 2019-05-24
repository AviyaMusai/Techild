using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
  public  class ProgressDto
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int lessonAndSubjectId { get; set; }
        public int isPass { get; set; }
        public int mark { get; set; }

        //public virtual Lessons Lessons { get; set; }
        //public virtual Users Users { get; set; }
        public static ProgressDto ConvertDBToDto(Progress progress)
        {
            return new ProgressDto
            {
                id = progress.id,
                userId = progress.userId,
                lessonAndSubjectId = progress.lessonAndSubjectId,
                isPass = progress.isPass,
                mark = progress.mark
            };
        }
    }
}
