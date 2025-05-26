namespace BitGo.Api.Client.Models.Responses.Wallets;

public class InitiateTransactionModel : BaseResponseModel
{
	public string? Id { get; set; }
	public string? Coin { get; set; }
	public string? Wallet { get; set; }
	public string? Enterprise { get; set; }
	public string? Organization { get; set; }
	public string? Creator { get; set; }
	public DateTimeOffset? CreateDate { get; set; }
	public InitiateTransactionInfoModel? Info { get; set; }
	public string? State { get; set; }
	public string? Scope { get; set; }
	public IEnumerable<string>? UserIds { get; set; }
	public int? ApprovalsRequired { get; set; }
	public string? WalletLabel { get; set; }
	public IEnumerable<ResolverModel>? Resolvers { get; set; }
	public IEnumerable<AddressLabelModel>? AddressLabels { get; set; }
}
