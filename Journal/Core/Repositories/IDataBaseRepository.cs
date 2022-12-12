using Journal.Areas.Identity.Data;

namespace Journal.Core.Repositories
{
    public interface IDataBaseRepository
    {
        ApplicationDbContext TakeDB(ApplicationDbContext context);
    }
}
