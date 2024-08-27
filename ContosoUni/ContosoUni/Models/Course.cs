namespace ContosoUni.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Tittle { get; set; }
        public int Credits { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}