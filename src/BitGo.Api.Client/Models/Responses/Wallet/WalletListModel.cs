namespace BitGo.Api.Client.Models.Responses.Wallet;

public class WalletListModel : BaseResponseModel
{
	public IEnumerable<WalletModel>? Wallets { get; set; }
}
