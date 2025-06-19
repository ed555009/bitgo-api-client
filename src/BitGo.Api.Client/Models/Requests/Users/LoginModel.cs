using System.ComponentModel.DataAnnotations;
using BitGo.Api.Client.Interfaces;

namespace BitGo.Api.Client.Models.Requests.Users;

/// <summary>
/// Represents the model for user login request
/// </summary>
public class LoginModel : IBaseRequestModel
{
	/// <summary>
	/// The email address of the user
	/// </summary>
	[Required, EmailAddress]
	public string? Email { get; set; }

	/// <summary>
	/// "true" if the session is extensible beyond a one-hour duration
	/// </summary>
	public bool Extensible { get; set; } = false;

	/// <summary>
	/// Second factor authentication token
	/// </summary>
	[Required, RegularExpression(@"^\d{6}$")]
	public string? Otp { get; set; }

	/// <summary>
	/// The password of the user
	/// </summary>
	[Required]
	public string? Password { get; set; }
}
