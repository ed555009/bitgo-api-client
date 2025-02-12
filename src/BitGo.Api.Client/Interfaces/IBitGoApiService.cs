using RequestUser = BitGo.Api.Client.Models.Requests.User;
using ResponseUser = BitGo.Api.Client.Models.Responses.User;
using Refit;

namespace BitGo.Api.Client.Interfaces;

public interface IBitGoApiService
{
	Task<ApiResponse<ResponseUser.LoginModel>> LoginAsync(
		RequestUser.LoginModel data,
		CancellationToken cancellationToken = default);
}
