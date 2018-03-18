using System.Collections.Generic;
using TinyCollege.Models;
using System.Configuration;

namespace TinyCollege.Utilities
{

    public class Data
    {
        private readonly string connectionString;
        private readonly DataGetter _get;
        private readonly DataPoster _post;

        public Data()
        {
            string _connectionString = BuildConnectionString();
            _get = new DataGetter(_connectionString);
            _post = new DataPoster(_connectionString);
        }

        private string BuildConnectionString() =>
            ConfigurationManager
            .ConnectionStrings["TinyCollege.Properties.Settings.TinyCollegeDBConnectionString"]
            .ConnectionString;

        public List<Instructor> GetInstructors() => _get.Instructors();
        public List<Student> GetStudents() => _get.Students();
        public List<CourseFromDB> GetCourses() => _get.Courses();
        public List<EnrollmentFromDB> GetEnrollments() => _get.Enrollments();


        public void Create(ModelRepository repo, ModelRepository oldState)
        {
            _post.CreateInstructors(repo.Instructors, oldState.Instructors);
            _post.CreateStudents(repo.Students, oldState.Students);
            _post.CreateCourses(repo.Courses, oldState.Courses);
            _post.CreateEnrollments(repo.Enrollments, oldState.Enrollments);
        }

        public void Update(ModelRepository repo) => _post.UpdateRepository(repo);
        

        

        

        

        
    }
}
