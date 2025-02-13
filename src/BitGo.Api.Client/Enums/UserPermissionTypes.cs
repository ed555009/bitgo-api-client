using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum UserPermissionTypes
{
	Admin,
	Spend,
	View,
	Freeze,
	Trade
}
