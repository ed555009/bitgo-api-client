using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum WalletRuleTypes
{
	AdvancedWhitelist,
	AllTx,
	CoinAddressWhitelist,
	CoinAddressBlacklist,
	TrustUsdVelocityLimit,
	TxUsdThreshold,
	UsdVelocityLimit,
	VelocityLimit,
	Webhook
}
