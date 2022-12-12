using System.ComponentModel.DataAnnotations;

namespace Journal.Models
{
    public class Lesson
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public Object Object { get; set; }

    }
}
