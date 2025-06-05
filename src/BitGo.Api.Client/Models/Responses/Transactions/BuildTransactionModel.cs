namespace BitGo.Api.Client.Models.Responses.Transactions;

public class BuildTransactionModel : BaseResponseModel
{
	public string? TxHex { get; set; }
	public AddressInfoModel? AddressInfo { get; set; }
	public TxInfoModel? TxInfo { get; set; }
	public FeeInfoModel? FeeInfo { get; set; }
	public NetFeeInfoModel? NetFeeInfo { get; set; }
	public string? Coin { get; set; }
}
