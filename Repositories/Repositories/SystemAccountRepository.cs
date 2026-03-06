using Repositories.Models;

namespace Repositories.Repositories
{
    public class SystemAccountRepository : GenericRepository<SystemAccount>, ISystemAccountRepository
    {
        private readonly FUNewsManagementContext _context;

        public SystemAccountRepository(FUNewsManagementContext context) : base(context)
        {
            _context = context;
        }

        public SystemAccount? GetByEmailAndPassword(string email, string password)
        {
            return _context.SystemAccounts.FirstOrDefault(a => a.AccountEmail == email && a.AccountPassword == password);
        }
    }
}
