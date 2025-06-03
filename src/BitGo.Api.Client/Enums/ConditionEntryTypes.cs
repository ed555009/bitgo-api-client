using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ConditionEntryTypes
{
	Address,
	EnterpriseId,
	WalletId,
	OrganizationId
}
