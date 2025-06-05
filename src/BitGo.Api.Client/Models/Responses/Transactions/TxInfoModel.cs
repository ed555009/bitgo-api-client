using BitGo.Api.Client.Models.Requests.Transactions;

namespace BitGo.Api.Client.Models.Responses.Transactions;

public class TxInfoModel
{
	public IEnumerable<TransactionRecipientModel>? Recipients { get; set; }
	public string? From { get; set; }
	public string? Txid { get; set; }
}
