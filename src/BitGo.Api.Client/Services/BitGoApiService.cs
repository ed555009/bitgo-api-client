using BitGo.Api.Client.Interfaces;
using BitGo.Api.Client.Options;
using RequestUser = BitGo.Api.Client.Models.Requests.User;
using ResponseUser = BitGo.Api.Client.Models.Responses.User;
using ResponseWallet = BitGo.Api.Client.Models.Responses.Wallet;
using Refit;
using Microsoft.Extensions.Options;

namespace BitGo.Api.Client.Services;

public class BitGoApiService(IBitGoApi bitGoApi, IOptionsMonitor<BitGoApiOptions> bitGoApiOptions) : IBitGoApiService
{
	private readonly IBitGoApi _bitGoApi = bitGoApi;
	private readonly BitGoApiOptions _bitGoApiOptions = bitGoApiOptions.CurrentValue;

	public async Task<ApiResponse<IEnumerable<ResponseWallet.WalletModel>>> ListWalletsAsync(
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.ListWalletsAsync(cancellationToken);

	public async Task<ApiResponse<IEnumerable<ResponseWallet.WalletModel>>> ListWalletsAsync(
		string coin,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.ListWalletsAsync(coin, cancellationToken);

	public async Task<ApiResponse<ResponseUser.LoginModel>> LoginAsync(
		RequestUser.LoginModel data,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.LoginAsync(data, cancellationToken);
}
