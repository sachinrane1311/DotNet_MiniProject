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
    class AdminController
    {
        public static void AdminRole()
        {

            Console.WriteLine("1-Add_Student\n2-Delete_Student\n3-Update_Student\n4-Show_All_Students\n5-Logout");

            int option = Convert.ToInt32(Console.ReadLine());

            StudentController sc = new StudentController();

            switch (option)
            {
                case 1:
                    Console.WriteLine("Add Student");
                    sc.addStudent();
                    break;

                case 2:
                    Console.WriteLine("Delete Student");
                    sc.deleteStudent();
                    break;

                case 3:
                    Console.WriteLine("Update Student");
                    sc.updateStudent();
                    break;

                case 4:
                    Console.WriteLine("Show All Students");
                    sc.showAll();
                    break;

                case 5:
                    Console.WriteLine("Logout !!!");
                    break;

            }

        }

        public void AddAdmin()
        {
            SmsDbContext ctx = new SmsDbContext();
            Admin admn = new Admin();
            admn.name = "admin";
            admn.email = "admin@gmail.com";
            admn.password = "12345";
            admn.role = "Admin";

            ctx.Admins.Add(admn);
            ctx.SaveChanges();
        }
    }
}
