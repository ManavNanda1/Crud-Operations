using PracProject.Model.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracProject.Model.Model
{
    public class QuizModel
    {
        [Key]
        public int QuizId { get; set; }

        [Required]
        public string QuestionName { get; set; }
        [Required]
        public string Option1 { get; set; }
        [Required]
        public string Option2 { get; set; }
        [Required]
        public string Option3 { get; set; }
        [Required]
        public string Option4 { get; set; }
        [Required]
        public string Answer { get; set; }

    }
}
