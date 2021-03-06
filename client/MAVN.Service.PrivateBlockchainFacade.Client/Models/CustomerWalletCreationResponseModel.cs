using JetBrains.Annotations;

namespace MAVN.Service.PrivateBlockchainFacade.Client.Models
{
    /// <summary>
    /// Customer wallet creation response
    /// </summary>
    [PublicAPI]
    public class CustomerWalletCreationResponseModel
    {
        /// <summary>
        /// Customer wallet creation error
        /// </summary>
        public CustomerWalletCreationError Error { get; set; }
    }
}
