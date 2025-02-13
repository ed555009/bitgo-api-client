using RequestUser = BitGo.Api.Client.Models.Requests.User;
using ResponseUser = BitGo.Api.Client.Models.Responses.User;
using ResponseWallet = BitGo.Api.Client.Models.Responses.Wallet;
using Refit;

namespace BitGo.Api.Client.Interfaces;

public interface IBitGoApiService
{
	Task<ApiResponse<IEnumerable<ResponseWallet.WalletModel>>> ListWalletsAsync(
		CancellationToken cancellationToken = default);

	Task<ApiResponse<IEnumerable<ResponseWallet.WalletModel>>> ListWalletsAsync(
		string coin, CancellationToken cancellationToken = default);

	Task<ApiResponse<ResponseUser.LoginModel>> LoginAsync(
		RequestUser.LoginModel data,
		CancellationToken cancellationToken = default);
}
