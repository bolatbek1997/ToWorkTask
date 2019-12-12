using System;
using System.ComponentModel.DataAnnotations;

namespace KendoUIApp2.Models
{
    public class Tasks
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; }
        public DateTime CreateDate { get; set; }
    }
}