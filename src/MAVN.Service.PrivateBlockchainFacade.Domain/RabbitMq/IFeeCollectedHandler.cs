using System.Threading.Tasks;
using MAVN.Numerics;

namespace MAVN.Service.PrivateBlockchainFacade.Domain.RabbitMq
{
    public interface IFeeCollectedHandler
    {
        Task HandleAsync(string eventId, string walletAddress, string reason, Money18 amount, string transactionHash);
    }
}
