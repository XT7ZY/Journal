using Journal.Models;
using System.ComponentModel.DataAnnotations;

namespace Journal.ViewModels
{


    public class ClassIndexViewModel
    {
        public Class Class;
        public Teacher Teacher;
        public IEnumerable<Class> Classes;
        public IEnumerable<Teacher> Teachers;

    }
}
