using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAppHD.Models
{
    public class ToDo
    {
        
        [Key]
        public int ID { get; set; }
        [Required]
        //[Display(Name = "titulo")]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Priority { get; set; }
        [Required]
        public Boolean Status { get; set; }
    }
}
