namespace BitGo.Api.Client.Models.Responses.Transfer;

public class EntryModel
{
	public string? Address { get; set; }
	public string? Wallet { get; set; }
	public decimal? Value { get; set; }
	public string? ValueString { get; set; }
	public bool? IsChange { get; set; }
	public bool? IsPayGo { get; set; }
	public string? Token { get; set; }
	public string? Label { get; set; }
	public bool? Failed { get; set; }
	public string? AssociatedNativeCoinAddress { get; set; }
}
