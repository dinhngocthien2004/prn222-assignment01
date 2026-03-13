using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public interface ISystemAccountService
    {
        List<SystemAccount> GetAllAccounts();
        SystemAccount? GetAccountById(short id);
        SystemAccount? Login(string email, string password);
        void AddAccount(SystemAccount account);
        void UpdateAccount(SystemAccount account);
        void DeleteAccount(short id);
    }
}
