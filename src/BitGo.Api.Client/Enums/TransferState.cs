using System.ComponentModel;
using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TransferState
{
	[Description("已確認")]
	Confirmed,

	[Description("失敗")]
	Failed,

	[Description("初始化")]
	Initialized,

	[Description("待核准")]
	PendingApproval,

	[Description("已拒絕")]
	Rejected,

	[Description("已刪除")]
	Removed,

	[Description("已替換")]
	Replaced,

	[Description("已簽署")]
	Signed,

	[Description("未確認")]
	Unconfirmed
}
