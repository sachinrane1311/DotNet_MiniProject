using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models
{
    public class Admin
    {
        [Key]
        public int userID { get; set; }

        [Column("Name")]
        [Required(ErrorMessage = "Please enter the Name")]
        [MaxLength(15)]
        public string name { get; set; }

        [Column("Email")]
        [Required(ErrorMessage = "Please enter the Email ID")]
        [MaxLength(20)]
        public string email { get; set; }

        [Column("Password")]
        [Required(ErrorMessage = "Please Enter the Password")]
        [MaxLength(12)]
        public string password { get; set; }

        [Column("Role")]
        [Required(ErrorMessage = "Please Enter your Role")]
        public string role { get; set; }

    }
    
}
