using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class CourseRepository : GenericRepositrory<Course>
    {
        public CourseRepository(SchoolContext context) : base(context)
        {
        }

        public int UpdateCourseCredits(int multiplier)
        {
            return context.Database.ExecuteSqlCommand("update course set credits = Credits * {0}", multiplier);
        }
    }
}