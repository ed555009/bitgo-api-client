using System.ComponentModel.DataAnnotations;
using BitGo.Api.Client.Interfaces;

namespace BitGo.Api.Client.Models.Requests.Transactions;

public class SendHalfSignedTransactionModel : IBaseRequestModel
{
	[MaxLength(256)]
	public string? Comment { get; set; }

	[Required]
	public string? TxHex { get; set; }
}
