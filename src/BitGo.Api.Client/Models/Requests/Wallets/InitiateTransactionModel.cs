using System.ComponentModel.DataAnnotations;
using BitGo.Api.Client.Interfaces;

namespace BitGo.Api.Client.Models.Requests.Wallets;

public class InitiateTransactionModel : IBaseRequestModel
{
	[MaxLength(256)]
	public string? Comment { get; set; }

	[Required]
	public IEnumerable<InitiateTransactionRecipientModel>? Recipients { get; set; }
}
