using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Models.Responses.Users;

public class LoginModel : BaseResponseModel
{
	[JsonPropertyName("access_token")]
	public string? AccessToken { get; set; }

	[JsonPropertyName("expires_at")]
	public long? ExpiresAtTimestamp { get; set; }

	public DateTimeOffset? ExpiresAt =>
		ExpiresAtTimestamp.HasValue
			? DateTimeOffset.FromUnixTimeSeconds(ExpiresAtTimestamp.Value)
			: null;

	[JsonPropertyName("expires_in")]
	public long? ExpiresIn { get; set; }

	public UserModel? User { get; set; }
}
