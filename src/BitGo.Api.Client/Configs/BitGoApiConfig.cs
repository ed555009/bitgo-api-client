namespace BitGo.Api.Client.Configs;

/// <summary>
/// Configuration settings for the BitGo API client.
/// </summary>
public class BitGoApiConfig
{
	/// <summary>
	/// Gets or sets the base URL for the BitGo API.
	/// </summary>
	public string BaseUrl { get; set; } = "https://app.bitgo-test.com/api/v2";

	/// <summary>
	/// Gets or sets the BitGo API token. (long-lived access token)
	/// </summary>
	public string? Token { get; set; }
}
