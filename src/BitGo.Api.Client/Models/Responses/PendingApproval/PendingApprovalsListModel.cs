namespace BitGo.Api.Client.Models.Responses.PendingApproval;

public class PendingApprovalsListModel : BaseResponseModel
{
	public IEnumerable<PendingApprovalModel>? PendingApprovals { get; set; }
}
