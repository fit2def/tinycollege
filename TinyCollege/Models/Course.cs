namespace TinyCollege.Models
{
    public class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int SeatsAvailable { get; set; }
        public Instructor Instructor { get; set; }
        public bool IsActive { get; set; }
    }
}
