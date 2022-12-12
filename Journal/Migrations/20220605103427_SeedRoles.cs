using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Journal.Migrations
{
    public partial class SeedRoles : Migration
    {
        private string UserRoleId = Guid.NewGuid().ToString();
        private string StudentRoleId = Guid.NewGuid().ToString();
        private string TeacherRoleId = Guid.NewGuid().ToString();
        private string AdminRoleId = Guid.NewGuid().ToString();



        protected override void Up(MigrationBuilder migrationBuilder)
        {
            SeedRolesSQL(migrationBuilder);
        }

        private void SeedRolesSQL(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp])
                VALUES('{UserRoleId}', 'User', 'USER', null);");
            migrationBuilder.Sql($@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp])
                VALUES('{StudentRoleId}', 'Student', 'STUDENT', null);");
            migrationBuilder.Sql($@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp])
                VALUES('{TeacherRoleId}', 'Teacher', 'TEACHER', null);");
            migrationBuilder.Sql($@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp])
                VALUES('{AdminRoleId}', 'Administrator', 'ADMINISTRATOR', null);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
