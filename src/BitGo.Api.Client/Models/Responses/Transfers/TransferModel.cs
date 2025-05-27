using System.Text.Json.Serialization;
using BitGo.Api.Client.Enums;
using BitGo.Api.Client.Models.Responses.Wallets;

namespace BitGo.Api.Client.Models.Responses.Transfers;

public class TransferModel : BaseResponseModel
{
	public string? Coin { get; set; }
	public string? Id { get; set; }

	[JsonPropertyName("wallet")]
	public string? WalletId { get; set; }
	public string? Txid { get; set; }
	public long Height { get; set; }
	public DateTimeOffset? Date { get; set; }
	public long Confirmations { get; set; }
	public TransferType? Type { get; set; }
	public string? ValueString { get; set; }
	public string? FeeString { get; set; }
	public decimal? Usd { get; set; }
	public decimal? UsdRate { get; set; }
	public TransferState? State { get; set; }
	public string? Comment { get; set; }
	public CoinSpecificModel? CoinSpecific { get; set; }
	public string? Label { get; set; }
	public IEnumerable<EntryModel>? Entries { get; set; }

	[JsonIgnore]
	public string? FeeCoin => Coin?.Split(':')[0];
}
