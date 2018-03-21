using System.Collections.Generic;
using System.Data.SqlClient;
using TinyCollege.Models;

namespace TinyCollege.Utilities
{
    public class DataPoster
    {
        private readonly string _connectionString;

        public DataPoster(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void CreateInstructors(List<Instructor> instructors1, List<Instructor> instructors2)
        {
            List<Instructor> newInstructors = GetNewInstructors(instructors1, instructors2);
            InsertInstructors(newInstructors);
        }

        private List<Instructor> GetNewInstructors(List<Instructor> instructors, List<Instructor> oldInstructors)
        {
            List<Instructor> newInstructors = new List<Instructor>();

            foreach (Instructor i in instructors)
            {
                bool found = false;
                foreach (Instructor i2 in oldInstructors)
                {
                    if (i.Id == i2.Id)
                        found = true;
                }
                if (!found)
                    newInstructors.Add(i);
            }
            return newInstructors;
        }

        private void InsertInstructors(List<Instructor> instructors)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                foreach (Instructor instructor in instructors)
                {
                    InsertInstructor(instructor, conn);
                }
                conn.Close();
            }

        }

        private void InsertInstructor(Instructor instructor, SqlConnection conn)
        {
            using (SqlCommand comd = new SqlCommand($"insert into Instructor (InstructorId, FirstName, LastName)" +
                    $" values (@{instructor.Id}, @{instructor.Id + "f"}, @{instructor.Id + "l"});", conn))
            {
                comd.Parameters.AddWithValue($"@{instructor.Id}", instructor.Id);
                comd.Parameters.AddWithValue($"@{instructor.Id + "f"}", instructor.FirstName);
                comd.Parameters.AddWithValue($"@{instructor.Id + "l"}", instructor.LastName);
                comd.ExecuteScalar();
            }
        }

        public void CreateStudents(List<Student> students, List<Student> oldStudents)
        {
            List<Student> newStudents = GetNewStudents(students, oldStudents);
            InsertStudents(newStudents);
        }

        private List<Student> GetNewStudents(List<Student> students, List<Student> oldStudents)
        {
            List<Student> newStudents = new List<Student>();

            foreach (Student s in students)
            {
                bool found = false;
                foreach (Student s2 in oldStudents)
                {
                    if (s.Id == s2.Id)
                        found = true;
                }
                if (!found)
                    newStudents.Add(s);
            }
            return newStudents;
        }

        private void InsertStudents(List<Student> students)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                foreach (Student student in students)
                {
                    InsertStudent(student, conn);
                }
                conn.Close();
            }
        }

        private void InsertStudent(Student student, SqlConnection conn)
        {
            using (SqlCommand comd = new SqlCommand
                ($"insert into Student (StudentId, FirstName, LastName)" +
                $" values (@{student.Id}, @{student.Id + "f"}, @{student.Id + "l"});", conn))
            {
                comd.Parameters.AddWithValue($"@{student.Id}", student.Id);
                comd.Parameters.AddWithValue($"@{student.Id + "f"}", student.FirstName);
                comd.Parameters.AddWithValue($"@{student.Id + "l"}", student.LastName);
                comd.ExecuteScalar();
            }
        }

        public void CreateCourses(List<Course> courses1, List<Course> courses2)
        {
            List<Course> newCourses = GetNewCourses(courses1, courses2);
            InsertCourses(newCourses);
        }

        private List<Course> GetNewCourses(List<Course> courses1, List<Course> courses2)
        {
            List<Course> newCourses = new List<Course>();

            foreach (Course c in courses1)
            {
                bool found = false;
                foreach (Course c2 in courses2)
                {
                    if (c.Id == c2.Id)
                        found = true;
                }
                if (!found)
                    newCourses.Add(c);
            }
            return newCourses;
        }

        private void InsertCourses(List<Course> courses)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                foreach (Course course in courses)
                {
                    InsertCourse(course, conn);
                }
                conn.Close();
            }

        }

        private void InsertCourse(Course course, SqlConnection conn)
        {
            using (SqlCommand comd = new SqlCommand
               ($"insert into Course (CourseId, CourseName, SeatAvailable, Active, InstructorId)" +
               $" values (@{course.Id}, @{course.Id + "n"}, @{course.Id + "s"}, @{course.Id + "a"}, @{course.Id + "i"});", conn))
            {
                comd.Parameters.AddWithValue($"@{course.Id}", course.Id);
                comd.Parameters.AddWithValue($"@{course.Id + "n"}", course.Name);
                comd.Parameters.AddWithValue($"@{course.Id + "s"}", course.SeatsAvailable);
                comd.Parameters.AddWithValue($"@{course.Id + "a"}", course.IsActive ? 1 : 0);
                comd.Parameters.AddWithValue($"@{course.Id + "i"}", course.Instructor.Id);
                comd.ExecuteScalar();
            }

        }

        public void CreateEnrollments(List<Enrollment> enrollments1, List<Enrollment> enrollments2)
        {
            List<Enrollment> newEnrollments = GetNewEnrollments(enrollments1, enrollments2);
            InsertEnrollments(newEnrollments);
        }

        private List<Enrollment> GetNewEnrollments(List<Enrollment> enrollments1, List<Enrollment> enrollments2)
        {
            List<Enrollment> newEnrollments = new List<Enrollment>();

            foreach (Enrollment e in enrollments1)
            {
                bool found = false;
                foreach (Enrollment e2 in enrollments2)
                {
                    if (e.Course.Id == e2.Course.Id && e.Student.Id == e2.Student.Id)
                        found = true;
                }
                if (!found)
                    newEnrollments.Add(e);
            }
            return newEnrollments;
        }

        private void InsertEnrollments(List<Enrollment> newEnrollments)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                foreach (Enrollment enrollment in newEnrollments)
                {
                    InsertEnrollment(enrollment, conn);
                }
                conn.Close();
            }

        }

        private void InsertEnrollment(Enrollment enrollment, SqlConnection conn)
        {
            using (SqlCommand comd = new SqlCommand
                ($"insert into Enrollment (CourseId, StudentId) " +
                $" values (@{enrollment.Course.Id + enrollment.Student.Id + "c"}, @{enrollment.Student.Id + enrollment.Course.Id + "s"});", conn))
            {
                comd.Parameters.AddWithValue($"@{enrollment.Course.Id + enrollment.Student.Id + "c"}", enrollment.Course.Id);
                comd.Parameters.AddWithValue($"@{enrollment.Student.Id + enrollment.Course.Id + "s"}", enrollment.Student.Id);
                comd.ExecuteScalar();
            }
        }

        public void UpdateRepository(ModelRepository repo)
        {
            UpdateCourses(repo.Courses);
            UpdateEnrollments(repo.Enrollments);
        }

        private void UpdateCourses(List<Course> courses)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                foreach (Course course in courses)
                {
                    UpdateCourse(course, conn);
                }
                conn.Close();
            }

        }

        private void UpdateCourse(Course course, SqlConnection conn)
        {
            using (SqlCommand comd = new SqlCommand
                ($"update Course set SeatAvailable = @{course.Id + "us"} " +
                $"where CourseId = @{course.Id + "u"};", conn))
            {
                comd.Parameters.AddWithValue($"@{course.Id + "u"}", course.Id);
                comd.Parameters.AddWithValue($"@{course.Id + "us"}", course.SeatsAvailable);
                comd.ExecuteScalar();
            }
        }

        private void UpdateEnrollments(List<Enrollment> enrollments)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                foreach (Enrollment enrollment in enrollments)
                {
                    UpdateEnrollment(enrollment, conn);
                }
                conn.Close();
            }
            
        }

        private void UpdateEnrollment(Enrollment enrollment, SqlConnection conn)
        {
            using (SqlCommand comd = new SqlCommand
                ($"update Enrollment set Grade = @{enrollment.Course.Id + enrollment.Student.Id + "ug" }" 
                + $" where CourseId = @{enrollment.Course.Id + "ec"} and StudentId = @{enrollment.Student.Id + "es"}", conn))
            {
                comd.Parameters.AddWithValue($"@{enrollment.Course.Id + "ec"}", enrollment.Course.Id);
                comd.Parameters.AddWithValue($"@{enrollment.Student.Id + "es"}", enrollment.Student.Id);
                comd.Parameters.AddWithValue($"@{enrollment.Course.Id + enrollment.Student.Id + "ug" }", enrollment.Grade);
                comd.ExecuteScalar();
            }
            
        }
    }
}