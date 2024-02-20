using Intro.Entities;
using MyIntro.DataAccess.Abstracts;
using MyIntro.DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business
{
    public class CourseManager
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        //Course[] courses = new Course[] { };    

        //public CourseManager()
        //{
        //    Course course = new Course();
        //    course.Price = 0;
        //    course.Description = "Fiyatsız";
        //    course.Name = "Ürün"; 
        //    Course course2 = new Course();
        //    course2.Price = 1;
        //    course2.Name = "Ürün2";
        //    course2.Description = "Yeni";
        //    courses[0] = course;
        //    courses[1] = course2;
        //}
        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

    }

}
