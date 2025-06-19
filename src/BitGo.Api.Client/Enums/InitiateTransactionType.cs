using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum InitiateTransactionType
{
	Acceleration,
	AccountSet,
	EnableToken,
	StakingLock,
	StakingUnlock,
	Transfer,
	TransferToken,
	Trustline
}
