using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoListProgramSP.Models
{
    public class ToDoList
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Enter Your Title")]
        [StringLength(4, ErrorMessage = "Title should be less than or equal to four characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Enter Total Time Spend")]
        public int TimeSpend { get; set; }
        public List<ToDoList> ShowallData { get; set; }
    }
}