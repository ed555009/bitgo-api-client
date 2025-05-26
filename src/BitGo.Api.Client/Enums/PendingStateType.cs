using System.ComponentModel;

namespace BitGo.Api.Client.Enums;

public enum PendingStateType
{
	[Description("待處理")]
	Pending,

	[Description("待簽名")]
	AwaitingSignature,

	[Description("待最終批准")]
	PendingFinalApproval,

	[Description("待保管人批准")]
	PendingCustodianApproval,

	[Description("待視頻批准")]
	PendingVideoApproval,

	[Description("待身份驗證")]
	PendingIdVerification
}
