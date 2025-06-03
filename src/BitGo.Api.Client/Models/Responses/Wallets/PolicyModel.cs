namespace BitGo.Api.Client.Models.Responses.Wallets;

public class PolicyModel
{
	public DateTimeOffset? Date { get; set; }
	public string? Id { get; set; }
	public bool? Latest { get; set; }
	public int? Version { get; set; }
	public string? EnterpriseId { get; set; }
	public string? Label { get; set; }
	public IEnumerable<RuleModel>? Rules { get; set; }
	public string? WalletId { get; set; }
}
