namespace BitGo.Api.Client.Models.Responses.Wallet;

public class ReceiveAddressModel
{
	public string? Id { get; set; }
	public string? Address { get; set; }
	public long? Chain { get; set; }
	public long? Index { get; set; }
	public string? Coin { get; set; }
	public string? Wallet { get; set; }
	public DateTimeOffset? LastConsolidatedTime { get; set; }
	public bool? NeedsConsolidation { get; set; }
	public CoinSpecificModel? coinSpecific { get; set; }
}
