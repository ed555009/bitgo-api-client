using System.ComponentModel.DataAnnotations;
using BitGo.Api.Client.Interfaces;

namespace BitGo.Api.Client.Models.Requests.Users;

public class UnlockModel : IBaseRequestModel
{
	[Required, Range(1, 3600)]
	public int? Duration { get; set; }

	[Required, RegularExpression(@"^\d{6}$")]
	public string? Otp { get; set; }
}
