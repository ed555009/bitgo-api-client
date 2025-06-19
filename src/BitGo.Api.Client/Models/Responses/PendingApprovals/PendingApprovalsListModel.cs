namespace BitGo.Api.Client.Models.Responses.PendingApprovals;

public class PendingApprovalsListModel : BaseResponseModel
{
	public IEnumerable<PendingApprovalModel>? PendingApprovals { get; set; }
}
