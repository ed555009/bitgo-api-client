namespace BitGo.Api.Client.Models.Responses.User;

public class UserModel
{
	public string? Id { get; set; }
	public bool IsActive { get; set; }
	public bool IsFrozen { get; set; }
	public string? Username { get; set; }
	public UsernameModel? Name { get; set; }
	public UserEmailModel? Email { get; set; }
	public DateTimeOffset? LastLogin { get; set; }
}
