using Info.Entities;
using Intro.DataAccess.Abstracts;

namespace Intro.DataAccess.Concretes
{
    public class EfCourseDal : ICourseDal
    {
        List<Course> courses;
        public EfCourseDal()
        {

            //Constructor
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "JavaScript";
            course1.Description = ".NET8";
            course1.Price = 0;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Java";
            course2.Description = "JAVA";
            course2.Price = 10;

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "Python";
            course3.Description = "PYTHON 3.12";
            course3.Price = 100;
            Console.WriteLine("başladı...");


            courses = new List<Course> { course1, course2, course3 };

        }

        public void Add(Course course)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            return courses;
        }
    }
}
