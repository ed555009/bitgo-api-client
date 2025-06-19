using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum WalletSubType
{
	DistributedCustody,
	PairedCustodial,
	CustodialHot,
	CustodialCold
}
