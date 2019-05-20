using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class Class2
    {

        public int id { get; set; }
        public string name { get; set; }
        public static Class2 compareToTest(DAL.Subjects subjects)
        {
            return new Class2
            {
                id = subjects.id,
                name = subjects.name
            };

        }
        public static List<Class2> compareToTest2(List<DAL.Subjects> subjects)
        {
            List<Class2> list = new List<Class2>();
            foreach (DAL.Subjects item in subjects)
            {
                list.Add(compareToTest(item));
            }
            return list;
        }
    }
}
