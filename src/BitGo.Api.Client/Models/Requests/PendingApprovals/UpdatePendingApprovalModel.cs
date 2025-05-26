using System.ComponentModel.DataAnnotations;
using BitGo.Api.Client.Enums;

namespace BitGo.Api.Client.Models.Requests.PendingApprovals;

public class UpdatePendingApprovalModel
{
	/// <summary>
	/// Second factor authentication token
	/// </summary>
	[Required, RegularExpression(@"^\d{6}$")]
	public string? Otp { get; set; }

	/// <summary>
	/// The state of the approval
	/// </summary>
	public ApprovalStateType? State { get; set; }
}
