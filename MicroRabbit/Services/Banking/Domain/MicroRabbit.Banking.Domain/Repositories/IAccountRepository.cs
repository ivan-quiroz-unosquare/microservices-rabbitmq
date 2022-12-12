using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Domain.Repositories
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
