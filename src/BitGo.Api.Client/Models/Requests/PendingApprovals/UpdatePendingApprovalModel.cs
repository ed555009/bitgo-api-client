using System.ComponentModel.DataAnnotations;
using BitGo.Api.Client.Enums;
using BitGo.Api.Client.Interfaces;

namespace BitGo.Api.Client.Models.Requests.PendingApprovals;

public class UpdatePendingApprovalModel : IBaseRequestModel
{
	/// <summary>
	/// Second factor authentication token
	/// </summary>
	[Required, RegularExpression(@"^\d{6}$")]
	public string? Otp { get; set; }

	/// <summary>
	/// The state of the approval
	/// </summary>
	[Required, EnumDataType(typeof(ApprovalStateType))]
	public ApprovalStateType? State { get; set; }
}
