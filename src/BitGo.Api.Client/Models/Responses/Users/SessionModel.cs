namespace BitGo.Api.Client.Models.Responses.Users;

public class SessionModel
{
	public string? Id { get; set; }
	public string? Client { get; set; }
	public string? User { get; set; }
	public IEnumerable<string>? Scope { get; set; }
	public DateTimeOffset? Created { get; set; }
	public DateTimeOffset? Expires { get; set; }
	public string? Ip { get; set; }
	// public List<object>? IpRestrict { get; set; }
	public string? Origin { get; set; }
	public bool? IsExtensible { get; set; }
	// public IEnumerable<object>? Organizations { get; set; }
	public UnlockDetailModel? Unlock { get; set; }
	public OAuthModel? Oauth { get; set; }
}
