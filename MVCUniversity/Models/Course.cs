using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVCUniversity.Models
{
    public class Course
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Subject Matter")]
        public string SubjectMatter { get; set; }

        [Required]
        public string Description { get; set; }

        [Display(Name = "Start")]
        [DataType(DataType.Date)]
        public DateTime StartingDate { get; set; }
    }
}

