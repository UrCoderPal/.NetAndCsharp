using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FMW_LectureCode.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Photo { get; set; }
        public decimal? Height { get; set; }
        public float? Weight { get; set; }

        [ForeignKey ("Grade")]
        public int? GradeId { get;set; }
        public Grade? Grade { get;set; }
    }
}
