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
            using (SqlCommand comd = new SqlCommand
                ($"insert into Instructor (InstructorId, FirstName, LastName)" +
                $" values (@Id, @FirstName, @LastName);", conn))
            {
                conn.Open();
                foreach (Instructor instructor in instructors)
                {
                    InsertInstructor(comd, instructor);
                }
                conn.Close();
            }
        }

        private void InsertInstructor(SqlCommand comd, Instructor instructor)
        {
            comd.Parameters.AddWithValue("@Id", instructor.Id);
            comd.Parameters.AddWithValue("@FirstName", instructor.FirstName);
            comd.Parameters.AddWithValue("@LastName", instructor.LastName);
            comd.ExecuteScalar();
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
            using (SqlCommand comd = new SqlCommand
                ($"insert into Student (StudentId, FirstName, LastName)" +
                $" values (@Id, @FirstName, @LastName);", conn))
            {
                conn.Open();
                foreach (Student student in students)
                {
                    InsertStudent(comd, student);
                }
                conn.Close();
            }
        }

        private void InsertStudent(SqlCommand comd, Student student)
        {
            comd.Parameters.AddWithValue("@Id", student.Id);
            comd.Parameters.AddWithValue("@FirstName", student.FirstName);
            comd.Parameters.AddWithValue("@LastName", student.LastName);
            comd.ExecuteScalar();
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
            using (SqlCommand comd = new SqlCommand
                ($"insert into Course (CourseId, CourseName, SeatsAvailable, InstructorId)" +
                $" values (@id, @name, @seats, @instructorId);", conn))
            {
                conn.Open();
                foreach (Course course in courses)
                {
                    InsertCourse(comd, course);
                }
                conn.Close();
            }
        }

        private void InsertCourse(SqlCommand comd, Course course)
        {
            comd.Parameters.AddWithValue("@id", course.Id);
            comd.Parameters.AddWithValue("@name", course.Name);
            comd.Parameters.AddWithValue("@seats", course.SeatsAvailable);
            comd.Parameters.AddWithValue("@instructorId", course.Instructor.Id);
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
            using (SqlCommand comd = new SqlCommand
                ($"insert into Enrollment (CourseId, StudentId) " +
                $" values (@courseId, @studentId);", conn))
            {
                conn.Open();
                foreach (Enrollment enrollment in newEnrollments)
                {
                    InsertEnrollment(comd, enrollment);
                }
                conn.Close();
            }
        }

        private void InsertEnrollment(SqlCommand comd, Enrollment enrollment)
        {
            comd.Parameters.AddWithValue("@courseId", enrollment.Course.Id);
            comd.Parameters.AddWithValue("@studentId", enrollment.Student.Id);
            comd.ExecuteScalar();
        }

        public void UpdateRepository(ModelRepository repo)
        {
                UpdateCourses(repo.Courses);
                UpdateEnrollments(repo.Enrollments); 
        }

        private void UpdateCourses(List<Course> courses)
        {
            using (var conn = new SqlConnection(_connectionString))
            using (SqlCommand comd = new SqlCommand
                ($"update Course set SeatsAvailable = @SeatsAvailable  " +
                $"where CourseId = @CourseId;", conn))
            {
                conn.Open();
                foreach (Course course in courses)
                {
                    UpdateCourse(comd, course);
                }
                conn.Close();
            }
        }

        private void UpdateCourse(SqlCommand comd, Course course)
        {
            comd.Parameters.AddWithValue("@id", course.Id);
            comd.Parameters.AddWithValue("@SeatsAvailable", course.SeatsAvailable);
            comd.ExecuteScalar();
        }

        private void UpdateEnrollments(List<Enrollment> enrollments)
        {
            using (var conn = new SqlConnection(_connectionString))
            using (SqlCommand comd = new SqlCommand
                ($"update Enrollment set Grade = @grade where CourseId = @courseId and StudentId = @student", conn))
            {
                conn.Open();
                foreach (Enrollment enrollment in enrollments)
                {
                    UpdateEnrollment(comd, enrollment);
                }
                conn.Close();
            }
        }

        private void UpdateEnrollment(SqlCommand comd, Enrollment enrollment)
        {
            comd.Parameters.AddWithValue("@courseId", enrollment.Course.Id);
            comd.Parameters.AddWithValue("@studentId", enrollment.Student.Id);
            comd.Parameters.AddWithValue("@grade", enrollment.Grade);
            comd.ExecuteScalar();
        }
    }
}