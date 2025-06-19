namespace BitGo.Api.Client.Models.Responses.Wallets;

public class WalletListModel : BaseResponseModel
{
	public IEnumerable<WalletModel>? Wallets { get; set; }
}
