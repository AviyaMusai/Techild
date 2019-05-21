using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
  public  class LessonDto
    {
        public int subjectId { get; set; }
        public int lessonId { get; set; }
        public string lessonName { get; set; }
        public string lessonFile { get; set; }
        public int id { get; set; }

        //public virtual Subjects Subjects { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Progress> Progress { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Tests> Tests { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Users> Users { get; set; }
        public static LessonDto ConvertDBToDto(Lessons lesson)
        {
            return new LessonDto
            {
                id = lesson.id,
                subjectId = lesson.subjectId,
                lessonId = lesson.lessonId,
                lessonName = lesson.lessonName,
                lessonFile = lesson.lessonFile
            };
        }
    }
}
