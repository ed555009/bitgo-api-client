using BitGo.Api.Client.Enums;

namespace BitGo.Api.Client.Models.Responses.Wallets;

public class ConditionEntryModel
{
	public string? Item { get; set; }
	public ConditionEntryType? Type { get; set; }
	public MetaDataModel? MetaData { get; set; }
}
