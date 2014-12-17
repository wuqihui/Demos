using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    /// <summary>
    /// 注册
    /// </summary>
    public class Enrollment
    {public int EnrollmentID { get; set; }
        
        public int CourseID { get; set; }
         public int StudentID { get; set; }
        /// <summary>
        /// 等级，年级
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:#.#}",ApplyFormatInEditMode = true,NullDisplayText = "No grade")]
        public decimal ? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
       

    }
}