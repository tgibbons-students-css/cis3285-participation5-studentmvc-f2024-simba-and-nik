namespace CIS3285_Unit4_StudentMVC_2024.Models
{
    public class NullStudent : IStudentInterface
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }

        public NullStudent(int id, string name, int credits)
        {
            Id = id;
            Name = name;
            Credits = credits;
        }

        public NullStudent()
        {
            Id = -1;
            Name = "Null Student";
            Credits = -999;

        }

    }

    
}
