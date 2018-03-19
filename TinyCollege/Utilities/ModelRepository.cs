using System.Collections.Generic;
using System.Linq;
using TinyCollege.Models;

namespace TinyCollege.Utilities
{
    public class ModelRepository
    {
        public List<Instructor> Instructors { get; set; }
        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }
        public List<Enrollment> Enrollments { get; set; }
        private ModelRepository OldState { get; set; }

        private static readonly Data _data = new Data();

        public static ModelRepository Build()
        {
            List<Instructor> instructors =
                _data.GetInstructors(); 
            List<Course> courses = 
                BuildCourses(instructors);
            List<Student> students =
                _data.GetStudents();
            List<Enrollment> enrollments =
                BuildEnrollments(courses, students);


            return new ModelRepository
            {
                Instructors = instructors,
                Courses = courses,
                Students = students,
                Enrollments = enrollments,
                OldState = new ModelRepository
                {
                    Instructors = new List<Instructor>(instructors),
                    Courses = new List<Course>(courses),
                    Students = new List<Student>(students),
                    Enrollments = new List<Enrollment>(enrollments)
                }
            };
        }


        private static List<Course> BuildCourses(List<Instructor> instructors)
        {
            List<CourseFromDB> coursesFromDB = _data.GetCourses();
            return coursesFromDB.
                Select(c => new Course {
                    Id = c.Id,
                    Instructor = instructors.FirstOrDefault(i => i.Id == c.InstructorId),
                    Name = c.Name,
                    SeatsAvailable = c.SeatsAvailable
                })
                .ToList();
        }


        private static List<Enrollment> BuildEnrollments(List<Course> courses, List<Student> students)
        {
            List<EnrollmentFromDB> enrollmentFromDB = _data.GetEnrollments();
            return enrollmentFromDB.
                Select(e => new Enrollment
                {
                    Course = courses.FirstOrDefault(c => c.Id == e.CourseId),
                    Student = students.FirstOrDefault(s => e.StudentId == s.Id),
                    Grade = e.Grade
                })
                .ToList();
        }

        public void Save()
        {
            _data.Create(this, OldState);
            _data.Update(this);
        }
    }
}
