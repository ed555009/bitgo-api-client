namespace BitGo.Api.Client.Models.Responses.Wallets;

public class CoinSpecificModel
{
	public string? RootAddress { get; set; }
	public string? RootPub { get; set; }
	public bool? PendingChainInitialization { get; set; }
}
