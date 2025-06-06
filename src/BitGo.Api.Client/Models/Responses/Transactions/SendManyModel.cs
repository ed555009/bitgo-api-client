using BitGo.Api.Client.Models.Responses.PendingApprovals;

namespace BitGo.Api.Client.Models.Responses.Transactions;

public class SendManyModel : BaseResponseModel
{
	public PendingApprovalModel? PendingApproval { get; set; }
}
