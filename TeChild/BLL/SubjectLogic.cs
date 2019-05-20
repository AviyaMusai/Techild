using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   
    public class SubjectLogic
    {
        public static DAL.TechildDBEntities db = new DAL.TechildDBEntities();
        public static List<SubjectDto> GetAllSubject()
        {
            List<SubjectDto> subjectsDto = new List<SubjectDto>();
            var subjects = db.Subjects.ToList();
            foreach (var item in subjects)
            {
                subjectsDto.Add(Dto.SubjectDto.ConvertDBToDto(item));
            }
            return subjectsDto;
        }
    }
}
