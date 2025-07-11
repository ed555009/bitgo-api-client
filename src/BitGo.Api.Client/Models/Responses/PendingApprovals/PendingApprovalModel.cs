using BitGo.Api.Client.Enums;

namespace BitGo.Api.Client.Models.Responses.PendingApprovals;

public class PendingApprovalModel
{
	public string? Id { get; set; }
	public string? Coin { get; set; }
	public string? Wallet { get; set; }
	public string? WalletLabel { get; set; }
	public string? Creator { get; set; }
	public PendingStateType? State { get; set; }
	public int? ApprovalsRequired { get; set; }
	public string? TxRequestId { get; set; }
	public DateTimeOffset? CreateDate { get; set; }
	public DateTimeOffset? ApprovedDate { get; set; }
	public DateTimeOffset? LastUpdated { get; set; }
	public InfoModel? Info { get; set; }
	public IEnumerable<string>? Approvers { get; set; }
	public IEnumerable<Transfers.ResolverModel>? Resolvers { get; set; }
	public IEnumerable<Wallets.AddressLabelModel>? AddressLabels { get; set; }
}
