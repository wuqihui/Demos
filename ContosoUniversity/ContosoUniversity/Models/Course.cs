using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
   /// <summary>
   /// 课程
   /// </summary>
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [MaxLength(50)]
        public string Title { get; set; }
        
        /// <summary>
        /// 学分
        /// </summary>
        [Required(ErrorMessage = "Number of credits is Required.")]
        [Range(0, 5, ErrorMessage = "Number of credits must be between 0 and 5.")]
        public int Credits { get; set; }

        [Display(Name = "Department")]
        public int DepartmentID { get; set; }

        /// <summary>
        /// 一个课程分配给了一个系，那么应该有一个Department和一个DepartmentId外键
        /// </summary>
        [Display(Name = "Department")]
        public virtual Department Department { get; set; }
        /// <summary>
        /// 一个课程可以有很多学生选，自然有Enrollments导航属性
        /// </summary>
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        /// <summary>
        /// 一个课程可以有多个教师任教，因此有一个Instructor导航属性
        /// </summary>
        public virtual ICollection<Instructor> Instructors { get; set; }


    }
}