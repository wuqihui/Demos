using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student:Person
    {    

        /// <summary>
        /// 入学时间
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:d}",ApplyFormatInEditMode = true)]
        [Display(Name = "EnrollmentDate")]
        [Required(ErrorMessage = "Enrollment date is required.")]
        public DateTime ?EnrollmentDate { get; set; }
          
        public virtual ICollection<Enrollment> Enrollments { get; set; } 
    }
}