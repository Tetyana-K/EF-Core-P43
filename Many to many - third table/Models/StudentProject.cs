namespace Many_to_many___third_table.Models
{
    public class StudentProject
    {
        public int StudentId { get; set; } // зовнішній ключ до таблиці Student
        public Student Student { get; set; } = null!; // навігаційна властивість до студента

        public int ProjectId { get; set; } // зовнішній ключ до таблиці Project
        public Project Project { get; set; } = null!; // навігаційна властивість до проекту

        public double Grade { get; set; }  //оцінка студента за проект
    }
}