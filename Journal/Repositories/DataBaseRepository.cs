using Journal.Areas.Identity.Data;
using Journal.Core.Repositories;

namespace Journal.Repositories
{
    public class DataBaseRepository : IDataBaseRepository
    {
        private readonly ApplicationDbContext _context;

        public DataBaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationDbContext TakeDB(ApplicationDbContext context)
        {
            return _context;
        }

    }
}
