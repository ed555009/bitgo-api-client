namespace BitGo.Api.Client.Models.Responses.Transactions;

public class NetFeeInfoModel
{
	public long? Size { get; set; }
	public long? FeeRate { get; set; }
	public long? Fee { get; set; }
	public string? FeeString { get; set; }
}
