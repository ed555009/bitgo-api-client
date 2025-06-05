using BitGo.Api.Client.Models.Responses.Transfers;

namespace BitGo.Api.Client.Models.Responses.Transactions;

public class TransactionInfoModel
{
	public TransactionRequestModel? TransactionRequest { get; set; }
	public string? Type { get; set; }
}
