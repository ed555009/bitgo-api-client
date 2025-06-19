using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum MutabilityConstraintType
{
	Unlocked,
	Permanent,
	Sticky,
	Managed
}
