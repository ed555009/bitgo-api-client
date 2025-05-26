namespace BitGo.Api.Client.Models.Responses.Transfers;

public class TransferListModel : BaseResponseModel
{
	public IEnumerable<TransferModel>? Transfers { get; set; }
	public string? Coin { get; set; }
	public string? NextBatchPrevId { get; set; }
}
