using System.ComponentModel.DataAnnotations;
using BitGo.Api.Client.Interfaces;

namespace BitGo.Api.Client.Models.Requests.Transactions;

public class BuildTransactionModel : IBaseRequestModel
{
	[MaxLength(256)]
	public string? Comment { get; set; }

	[Required]
	public IEnumerable<TransactionRecipientModel>? Recipients { get; set; }
}
