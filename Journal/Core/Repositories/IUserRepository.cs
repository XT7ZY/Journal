using Journal.Areas.Identity.Data;

namespace Journal.Core.Repositories
{
    public interface IUserRepository
    {
        ICollection<ApplicationUser> GetUsers();
        ApplicationUser GetUser(string id);
        ApplicationUser UpdateUser(ApplicationUser user);

    }
}
