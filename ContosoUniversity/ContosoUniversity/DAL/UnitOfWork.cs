using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class UnitOfWork : IDisposable
    {
        private SchoolContext context = new SchoolContext();
        private GenericRepositrory<Department> departmentRepositrory;
        private CourseRepository courseRepositrory;


        public GenericRepositrory<Department> DepartmentRepositrory
        {
            get
            {
                if (this.departmentRepositrory == null)
                {
                    this.departmentRepositrory = new GenericRepositrory<Department>(context);
                }
                return departmentRepositrory;
            }
        }

        public CourseRepository CourseRepositrory
        {
            get
            {
                if (this.courseRepositrory == null)
                {
                    this.courseRepositrory=new CourseRepository(context);
                    //this.courseRepositrory = new GenericRepositrory<Course>(context);
                }
                return courseRepositrory;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}