using RequestUser = BitGo.Api.Client.Models.Requests.User;
using ResponseUser = BitGo.Api.Client.Models.Responses.User;
using ResponseWallet = BitGo.Api.Client.Models.Responses.Wallet;
using Refit;

namespace BitGo.Api.Client.Interfaces;

public interface IBitGoApi
{
	/// <summary>
	/// https://developers.bitgo.com/api/v2.wallet.list
	/// </summary>
	[Get("/wallets")]
	Task<ApiResponse<IEnumerable<ResponseWallet.WalletModel>>> ListWalletsAsync(
		CancellationToken cancellationToken = default);

	/// <summary>
	/// https://developers.bitgo.com/api/v2.wallet.listbycoin
	/// </summary>
	[Get("/{coin}/wallet")]
	Task<ApiResponse<IEnumerable<ResponseWallet.WalletModel>>> ListWalletsAsync(
		string coin, CancellationToken cancellationToken = default);

	/// <summary>
	/// https://developers.bitgo.com/api/v2.user.login
	/// </summary>
	[Get("/user/login")]
	Task<ApiResponse<ResponseUser.LoginModel>> LoginAsync(
		[Body] RequestUser.LoginModel data,
		CancellationToken cancellationToken = default);
}
