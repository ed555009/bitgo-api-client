using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TransferState
{
	Confirmed,
	Failed,
	Initialized,
	PendingApproval,
	Rejected,
	Removed,
	Replaced,
	Signed,
	Unconfirmed
}
