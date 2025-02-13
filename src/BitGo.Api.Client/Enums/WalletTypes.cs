using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum WalletTypes
{
	Backing,
	Cold,
	Custodial,
	CustodialPaired,
	Hot,
	Trading
}
