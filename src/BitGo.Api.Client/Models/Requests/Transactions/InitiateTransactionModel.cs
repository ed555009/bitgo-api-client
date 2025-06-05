using System.ComponentModel.DataAnnotations;
using BitGo.Api.Client.Enums;

namespace BitGo.Api.Client.Models.Requests.Transactions;

public class InitiateTransactionModel : BuildTransactionModel
{
	[Required, EnumDataType(typeof(InitiateTransactionType))]
	public InitiateTransactionType? Type { get; set; }
}
