using System.Collections.Generic;
using TinyCollege.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace TinyCollege.Utilities
{

    public static class Data
    {

        static string connectionString = ConfigurationManager
        .ConnectionStrings["TinyCollege.Properties.Settings.TinyCollegeDBConnectionString"]
        .ConnectionString;



        public static List<Instructor> GetInstructors()
        {
            using (var conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand
                ("Select * from Instructor", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                DataTable instructorTable = new DataTable();
                adapter.Fill(instructorTable);
            }


            return null;
        }

        public static List<CourseFromDB> GetCourses()
        {
            return null;
        }

        public static List<Student> GetStudents()
        {
            return null;
        }

        public static List<EnrollmentFromDB> GetEnrollments()
        {
            return null;
        }

    }
}
