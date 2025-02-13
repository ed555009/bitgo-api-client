using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum WalletSubTypes
{
	DistributedCustody,
	PairedCustodial,
	CustodialHot,
	CustodialCold
}
