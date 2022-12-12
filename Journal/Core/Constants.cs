namespace Journal.Core
{
    public class Constants
    {
        public static class Roles
        {
            public const string Administrator = "Administrator";
            public const string User = "User";
            public const string Student = "Student";
            public const string Teacher = "Teacher";
        }

        public static class Policies
        {
            public const string RequireAdmin = "RequireAdmin";
            public const string RequireStudent = "RequireStudent";
            public const string RequireTeacher = "RequireTeacher";
        }







    }
}
