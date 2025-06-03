using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum MutabilityConstraintTypes
{
	Unlocked,
	Permanent,
	Sticky,
	Managed
}
