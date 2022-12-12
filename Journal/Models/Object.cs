using System.ComponentModel.DataAnnotations;

namespace Journal.Models
{
    public class Object
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Class> Class { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Lesson> Lessons { get; set; }

    }
}
