using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace BLL
{
    public class UserLogic
    {
        public static DAL.TechildDBEntities1 db = new DAL.TechildDBEntities1();
        
        //החזרת רשימת כל המשתמשים
        public static List<UsersDto> GetAllUsers()
        {
            List<UsersDto> u = new List<UsersDto>();
            var users = db.Users.ToList();
            foreach (var item in users)
            {
                u.Add(Dto.UsersDto.ConvertDBToDto(item));
            }
            return u;
        }
        //החזרת משתמש בודד לפי סיסמה ושם משתמש
        public static UsersDto GetUserByPasAndName(string name, string password)
        {
            var q = from user in db.Users
                    where user.password == password &&
                    user.name == name
                    select user;
            return (Dto.UsersDto.ConvertDBToDto(q.FirstOrDefault()));
        }
        //בדיקה תקינות
        // בעת רישום בדיקה האם משתמש קיים במערכת
        public static bool IsExistSignup(string mail)
        {
            var q = db.Users.Where(u => u.mail == mail).Select(i => i.mail).FirstOrDefault();
            if (q != null)
                return true;
            return false;
        }
        //!בעת כניסה בדיקה האם משתמש קיים במערכת
        public static bool IsExistSignin(string pass)
        {
            var q = db.Users.Where(u => u.password == pass).Select(i => i.password).FirstOrDefault();
            if (q != null)
                return true;
            return false;
        }
        //בעת רישום בדיקה האם השדות ריקים
        public static bool IsEmptyInSignUp(string mail, string name)
        {
            if (mail != null && name != null)
                return true;
            return false;
        }
        //שליחת סיסמה למשתמש חדש 
        public static void sendMailToNewUser(string m)
        {
            mail x = new BLL.mail();
            x.sendmail(m);
        }
        //בעת כניסה בדיקה האם האם השדות ריקים
        public static bool IsEmptyInSignIn(string password, string name)
        {
            if (password != null && name != null)
                return true;
            return false;
        }
        //בעת רישום הוספת המשתמש לטבלה
        public static void AddNewUser(DAL.Users user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
        // בעת כניסה עדכון שיוך לקבוצה בטבלת המשתמשים
        public static void UpDateStatus(string password, int IsConnect)
        {
            var q = db.Users.Where(u => u.password == password).FirstOrDefault();
            q.IsConnect = IsConnect;
            db.SaveChanges();           
        }
    }
}
