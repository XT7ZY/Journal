using System.ComponentModel.DataAnnotations;

namespace Journal.Models
{
    public class Parent
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SurName { get; set; }


    }
}
