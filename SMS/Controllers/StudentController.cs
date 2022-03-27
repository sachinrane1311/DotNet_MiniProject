using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SMS.Controllers
{
    public class StudentController
    {
        public void StudentRole()
        {
            Console.WriteLine("1-showDetails\n2-updateDetails\n3-Logout");

            int option = Convert.ToInt32(Console.ReadLine());

            StudentController sc = new StudentController();

            switch (option)
            {
                case 1:
                    Console.WriteLine("Show Details");
                    sc.showDetails();
                    break;

                case 2:
                    Console.WriteLine("Update Details");
                    sc.updateDetails();
                    break;

                case 3:
                    Console.WriteLine("Logout !!!");
                    break;

            }

        }

        private void updateDetails()
        {

            throw new NotImplementedException();
        }

        private void showDetails()
        {
            throw new NotImplementedException();
        }

        internal void updateStudent()
        {
            throw new NotImplementedException();
        }

        internal void deleteStudent()
        {
            throw new NotImplementedException();
        }

        internal void showAll()
        {
            throw new NotImplementedException();
        }

        internal void addStudent()
        {
        }
    }

}
