namespace BitGo.Api.Client.Models.Responses.Wallet;

public class UserModel
{
	public string? User { get; set; }
	public IEnumerable<string>? Permissions { get; set; }
}
