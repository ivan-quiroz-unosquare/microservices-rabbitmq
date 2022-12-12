using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Banking.Domain.Repositories;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _dbContext;

        public AccountRepository(BankingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _dbContext.Accounts;
        }
    }
}
