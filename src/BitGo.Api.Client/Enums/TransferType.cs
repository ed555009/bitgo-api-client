using System.ComponentModel;
using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TransferType
{
	[Description("轉出")]
	Send,

	[Description("轉入")]
	Receive
}
