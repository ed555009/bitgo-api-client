using BitGo.Api.Client.Enums;

namespace BitGo.Api.Client.Models.Responses.Wallets;

public class RuleModel
{
	public string? Id { get; set; }
	public WalletRuleTypes? Type { get; set; }
	// public ActionModel? Action { get; set; }
	public bool? Latest { get; set; }
	public int? Version { get; set; }
	public DateTimeOffset? LockDate { get; set; }
	public string? MutabilityConstraint { get; set; }
	public string? Coin { get; set; }
	public ConditionModel? Condition { get; set; }
}
