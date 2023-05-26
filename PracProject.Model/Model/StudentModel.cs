using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracProject.Model.Model
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FName { get; set; }
        [Required]
        public string LName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public int Country { get; set; }

        [Required]
        public int State { get; set; }

      
    }
}
