using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ConditionEntryType
{
	Address,
	EnterpriseId,
	WalletId,
	OrganizationId
}
