using BitGo.Api.Client.Models.Responses.Transfers;

namespace BitGo.Api.Client.Models.Responses.Wallets;

public class InitiateTransactionInfoModel
{
	public TransactionRequestModel? TransactionRequest { get; set; }
	public string? Type { get; set; }
}
