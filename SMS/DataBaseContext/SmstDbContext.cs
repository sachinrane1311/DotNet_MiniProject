using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SMS.Models;


namespace SMS
{
    class SmsDbContext : DbContext
    {
        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SACHINRAN-VD\SQL2017; DataBase=SMS; User Id=sa; Password=cybage@123456;");
        }

        public virtual DbSet<Admin> Admins { get; set; }

        public virtual DbSet<Student> Students { get; set; }


    }
}
