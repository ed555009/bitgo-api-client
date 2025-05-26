namespace BitGo.Api.Client.Models.Responses.Wallets;

public class TransactionRequestModel
{
	public CoinSpecificModel? CoinSpecific { get; set; }
	public string? Comment { get; set; }
	public string? Fee { get; set; }
	public bool? IsUnsigned { get; set; }
	public IEnumerable<RecipientModel>? Recipients { get; set; }
	public string? RequestedAmount { get; set; }
	public string? SourceWallet { get; set; }
	public string? TriggeredPolicy { get; set; }
	public string? ValidTransaction { get; set; }
	public string? ValidTransactionHash { get; set; }
}
