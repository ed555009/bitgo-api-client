using System.ComponentModel.DataAnnotations;

namespace BitGo.Api.Client.Models.Requests.Wallets;

public class InitiateTransactionRecipientModel
{
	[Required, RegularExpression(@"^(-?\d+|max)$")]
	public string? Amount { get; set; }

	[Required, MaxLength(250)]
	public string? Address { get; set; }

	[MaxLength(100)]
	public string? Memo { get; set; }
}
