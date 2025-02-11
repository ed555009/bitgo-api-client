using BitGo.Api.Client.Models.Requests.User;
using Refit;

namespace BitGo.Api.Client.Interfaces;

public interface IBitGoApi
{
	[Get("/user/login")]
	Task<ApiResponse<string>> LoginAsync([Body] LoginModel data, CancellationToken cancellationToken = default);
}
