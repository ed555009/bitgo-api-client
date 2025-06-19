namespace BitGo.Api.Client.Models.Responses.Users;

public class UnlockDetailModel
{
	public DateTimeOffset? Time { get; set; }
	public DateTimeOffset? Expires { get; set; }
	public long? TxValueLimit { get; set; }
	public long? TxValue { get; set; }
	// public Dictionary<string, object>? SpendingLimits { get; set; }
	public int? TxCount { get; set; }
}
