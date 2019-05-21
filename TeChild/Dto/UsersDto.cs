using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace Dto
{
  public  class UsersDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public int IsConnect { get; set; }
        public int lessonAndSubjectId { get; set; }

        //public virtual Lessons Lessons { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Progress> Progress { get; set; }
        public static UsersDto ConvertDBToDto(Users user)
        {
            return new UsersDto
            {
                id = user.id,
                name = user.name,
                mail = user.mail,
                password = user.password,
                IsConnect = user.IsConnect,
                lessonAndSubjectId = user.lessonAndSubjectId
            };
        }
    }
}
