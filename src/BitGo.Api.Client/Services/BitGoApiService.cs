using BitGo.Api.Client.Interfaces;
using BitGo.Api.Client.Options;
using RequestUser = BitGo.Api.Client.Models.Requests.User;
using ResponseUser = BitGo.Api.Client.Models.Responses.User;
using Refit;
using Microsoft.Extensions.Options;

namespace BitGo.Api.Client.Services;

public class BitGoApiService(IBitGoApi bitGoApi, IOptionsMonitor<BitGoApiOptions> bitGoApiOptions) : IBitGoApiService
{
	private readonly IBitGoApi _bitGoApi = bitGoApi;
	private readonly BitGoApiOptions _bitGoApiOptions = bitGoApiOptions.CurrentValue;

	public async Task<ApiResponse<ResponseUser.LoginModel>> LoginAsync(
		RequestUser.LoginModel data,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.LoginAsync(data, cancellationToken);
}
