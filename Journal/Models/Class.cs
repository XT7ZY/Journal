using System.ComponentModel.DataAnnotations;

namespace Journal.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public string Letter { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<Object> Objects { get; set; }



    }
}
