namespace TinyCollege.Models
{
    public class CourseFromDB
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int SeatsAvailable { get; set; }
        public int InstructorId { get; set; }
    }
}
