using System.ComponentModel.DataAnnotations;
using BitGo.Api.Client.Interfaces;

namespace BitGo.Api.Client.Options;

/// <summary>
/// Represents the configuration options for the BitGo API client.
/// </summary>
public class BitGoApiOptions : IBitGoOptions
{
	/// <summary>
	/// Gets or sets the base URL for the BitGo API.
	/// Default value is "https://app.bitgo-test.com/api/v2".
	/// </summary>
	[Required, Url]
	public string BaseUrl { get; set; } = "https://app.bitgo-test.com/api/v2";

	/// <summary>
	/// Gets or sets the access token used for authenticating API requests. (long-lived access token)
	/// </summary>
	public string? AccessToken { get; set; }
}
