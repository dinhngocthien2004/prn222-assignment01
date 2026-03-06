using Repositories.Models;

namespace Repositories.Repositories
{
    public interface ISystemAccountRepository : IGenericRepository<SystemAccount>
    {
        SystemAccount? GetByEmailAndPassword(string email, string password);
    }
}
