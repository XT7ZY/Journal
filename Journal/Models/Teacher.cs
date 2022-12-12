namespace Journal.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SurName { get; set; }
        public string? FullName { get; set; }

        public ICollection<Object>? Objects { get; set; }


    }
}
