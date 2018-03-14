namespace TinyCollege.Models
{
    public class Enrollment
    {
        public Student Student { get; set; }
        public CourseFromDb Course { get; set; }
        public double Grade { get; set; }
    }
}
