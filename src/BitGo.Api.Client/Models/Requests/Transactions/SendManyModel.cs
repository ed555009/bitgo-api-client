using System.ComponentModel.DataAnnotations;

namespace BitGo.Api.Client.Models.Requests.Transactions;

public class SendManyModel : BuildTransactionModel
{
	[Required, RegularExpression(@"^\d{6}$")]
	public string? Otp { get; set; }

	[Required]
	public string? WalletPassphrase { get; set; }
}
