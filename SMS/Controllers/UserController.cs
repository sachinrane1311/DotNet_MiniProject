using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SMS.Models;
using SMS.Controllers;
using System.Data.SqlClient;

namespace SMS.Controllers
{
    class UserController
    {

        internal void login(string email, string password)
        {
            SmsDbContext studentDb = new SmsDbContext();

            SqlParameter p1 = new SqlParameter();
            SqlParameter p2 = new SqlParameter();

            p1.ParameterName = "@Email";
            p1.Value = email;
            p1.SqlDbType = System.Data.SqlDbType.VarChar;
            p2.ParameterName = "@Password";
            p2.Value = password;
            p2.SqlDbType = System.Data.SqlDbType.VarChar;

            var students = studentDb.Students.ToList();
            Student stud = new Student();
            foreach (Student s in students)
            {
                if (s.email == email && s.password == password) stud = s;

            }


            if (stud != null)
            {
                if (stud.role == "Student")
                {
                    Console.WriteLine("Student Role");
                    StudentController sc = new StudentController();
                    sc.StudentRole();
                }
                else
                {
                    Console.WriteLine("Admin Role");
                    AdminController.AdminRole();
                }
            }
            else Console.WriteLine("User Not Found !!!");

        }

        internal void register(string studentName, string studentEmail, string studentPassword, string course)
        {

            SmsDbContext ctx = new SmsDbContext();
            Student stud = new Student();
            stud.name = studentName;
            stud.email = studentEmail;
            stud.password = studentPassword;
            stud.role = "Student";
            stud.course = course;

            ctx.Students.Add(stud);
            ctx.SaveChanges();

        }
    
    }
}
