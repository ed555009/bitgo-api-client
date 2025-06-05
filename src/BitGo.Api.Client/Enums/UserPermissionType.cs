using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum UserPermissionType
{
	Admin,
	Spend,
	View,
	Freeze,
	Trade
}
