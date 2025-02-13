namespace BitGo.Api.Client.Models.Responses.Wallet;

public class WalletModel
{
	public string? Id { get; set; }
	public IEnumerable<UserModel>? Users { get; set; }
	public string? Coin { get; set; }
	public string? Label { get; set; }
	public bool? Deleted { get; set; }
	public bool IsCold { get; set; }
	public int? ApprovalsRequired { get; set; }
	public CoinSpecificModel? CoinSpecific { get; set; }
	public string? BalanceString { get; set; }
	public string? ConfirmedBalanceString { get; set; }
	public string? SpendableBalanceString { get; set; }
	public string? StakingBalanceString { get; set; }
	public string? RewardBalanceString { get; set; }
}
