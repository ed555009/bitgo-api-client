namespace BitGo.Api.Client.Models.Responses.Wallets;

public class TokenInfoModel
{
	public string? BalanceString { get; set; }
	public string? ConfirmedBalanceString { get; set; }
	public string? SpendableBalanceString { get; set; }
	public string? LockedBalanceString { get; set; }
	public int? TransferCount { get; set; }
	public DateTimeOffset? Updated { get; set; }
}
