using Journal.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace Journal.Core.Repositories
{
    public interface IRoleRepository
    {
        ICollection<IdentityRole> GetRoles();
    }
}
