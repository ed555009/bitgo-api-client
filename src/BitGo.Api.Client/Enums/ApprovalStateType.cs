using System.ComponentModel;
using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ApprovalStateType
{
	[Description("核准")]
	Approved,

	[Description("拒絕")]
	Rejected
}
