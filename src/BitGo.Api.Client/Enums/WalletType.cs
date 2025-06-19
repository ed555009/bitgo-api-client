using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum WalletType
{
	Backing,
	Cold,
	Custodial,
	CustodialPaired,
	Hot,
	Trading
}
