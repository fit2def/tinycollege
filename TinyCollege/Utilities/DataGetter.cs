using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TinyCollege.Models;

namespace TinyCollege.Utilities
{
    public class DataGetter
    {
        private readonly string _connectionString;

        public DataGetter(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Instructor> Instructors()
        {
            DataTable table = GetDataTable("Instructor");
            return CompileInstructors(table);
        }

        private List<Instructor> CompileInstructors(DataTable table)
        {
            List<Instructor> instructors = new List<Instructor>();

            foreach (DataRow r in table.Rows)
            {
                instructors.Add(CompileInstructor(r));
            }

            return instructors;
        }

        private Instructor CompileInstructor(DataRow r)
        {
            Instructor instructor = new Instructor();
            instructor.Id = r["InstructorId"].ToString();
            instructor.FirstName = r["FirstName"].ToString();
            instructor.LastName = r["LastName"].ToString();
            return instructor;
        }

        public List<CourseFromDB> Courses()
        {
            DataTable table = GetDataTable("Course");
            return CompileCourses(table);
        }

        private List<CourseFromDB> CompileCourses(DataTable table)
        {
            List<CourseFromDB> courses = new List<CourseFromDB>();

            foreach (DataRow r in table.Rows)
            {
                courses.Add(CompileCourse(r));
            }

            return courses;
        }

        private CourseFromDB CompileCourse(DataRow r)
        {
            CourseFromDB course = new CourseFromDB();
            course.Id = r["CourseId"].ToString();
            course.Name = r["CourseName"].ToString();
            course.SeatsAvailable = int.Parse(r["SeatAvailable"].ToString());
            course.InstructorId = r["InstructorId"].ToString();
            string bit = r["Active"].ToString();
            course.IsActive = bit == "True" ? true : false;
            return course;
        }

        public List<Student> Students()
        {
            DataTable table = GetDataTable("Student");
            return CompileStudents(table);
        }

        private List<Student> CompileStudents(DataTable table)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow r in table.Rows)
            {
                students.Add(CompileStudent(r));
            }

            return students;
        }

        private Student CompileStudent(DataRow r)
        {
            Student student = new Student();
            student.Id = r["StudentId"].ToString();
            student.FirstName = r["FirstName"].ToString();
            student.LastName = r["LastName"].ToString();
            return student;
        }

        public List<EnrollmentFromDB> Enrollments()
        {
            DataTable table = GetDataTable("Enrollment");
            return CompileEnrollments(table);
        }

        private List<EnrollmentFromDB> CompileEnrollments(DataTable table)
        {
            List<EnrollmentFromDB> enrollments = new List<EnrollmentFromDB>();

            foreach (DataRow r in table.Rows)
            {
                enrollments.Add(CompileEnrollment(r));
            }

            return enrollments;
        }

        private EnrollmentFromDB CompileEnrollment(DataRow r)
        {
            EnrollmentFromDB enrollment = new EnrollmentFromDB();
            enrollment.StudentId = r["StudentId"].ToString();
            enrollment.CourseId = r["CourseId"].ToString();
            double grade;
            bool gradeEntered = double.TryParse(r["Grade"].ToString(), out grade);
            if (gradeEntered)
                enrollment.Grade = grade;
            return enrollment;
        }

        private DataTable GetDataTable(string target)
        {
            using (var conn = new SqlConnection(_connectionString))
            using (SqlCommand comd = new SqlCommand
                ($"Select * from {target}", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}