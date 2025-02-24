using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ApprovalStateType
{
	[EnumMember(Value = "approved")]
	Approved,

	[EnumMember(Value = "pending")]
	Pending,

	[EnumMember(Value = "rejected")]
	Rejected
}
