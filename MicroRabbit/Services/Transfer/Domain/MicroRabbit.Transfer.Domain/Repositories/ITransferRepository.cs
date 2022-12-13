using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Domain.Repositories
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
        void Add(TransferLog transferLog);
    }
}
