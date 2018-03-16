using System.Collections.Generic;
using TinyCollege.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System;

namespace TinyCollege.Utilities
{

    public static class Data
    {

        static string connectionString = ConfigurationManager
        .ConnectionStrings["TinyCollege.Properties.Settings.TinyCollegeDBConnectionString"]
        .ConnectionString;


        public static List<Instructor> GetInstructors()
        {
            DataTable table = GetDataTable("Instructors");
            return CompileInstructors(table);
        }

        private static List<Instructor> CompileInstructors(DataTable table)
        {
            throw new NotImplementedException();
        }

        public static List<CourseFromDB> GetCourses()
        {
            DataTable table = GetDataTable("Courses");
            return CompileCourses(table);
        }

        private static List<CourseFromDB> CompileCourses(DataTable table)
        {
            throw new NotImplementedException();
        }

        public static List<Student> GetStudents()
        {
            DataTable table = GetDataTable("Students");
            return CompileStudents(table);
        }

        private static List<Student> CompileStudents(DataTable table)
        {
            throw new NotImplementedException();
        }

        public static List<EnrollmentFromDB> GetEnrollments()
        {
            DataTable table = GetDataTable("Enrollments");
            return CompileEnrollments(table);
        }

        private static List<EnrollmentFromDB> CompileEnrollments(DataTable table)
        {
            throw new NotImplementedException();
        }

        private static DataTable GetDataTable(string target)
        {
            using (var conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand
                ($"Select * from {target}", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
 
        public static void SaveRepository(ModelRepository repo)
        {
            SaveInstructors(repo.Instructors);
            SaveCourses(repo.Courses);
            SaveStudents(repo.Students);
            SaveEnrollments(repo.Enrollments);
        }

        private static void SaveInstructors(List<Instructor> instructors)
        {
            throw new NotImplementedException();
        }

        private static void SaveCourses(List<Course> courses)
        {
            throw new NotImplementedException();
        }

        private static void SaveStudents(List<Student> students)
        {
            throw new NotImplementedException();
        }

        private static void SaveEnrollments(List<Enrollment> enrollments)
        {
            throw new NotImplementedException();
        }

    }
}
