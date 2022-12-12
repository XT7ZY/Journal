using System.ComponentModel.DataAnnotations;

namespace Journal.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SurName { get; set; }
        public int ParentId { get; set; }
        public Parent Parent { get; set; }
        public Class Class { get; set; }



    }
}
