using System.Text.Json.Serialization;

namespace BitGo.Api.Client.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum WalletRuleType
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
