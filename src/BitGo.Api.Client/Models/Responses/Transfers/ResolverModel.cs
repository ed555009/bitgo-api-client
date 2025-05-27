namespace BitGo.Api.Client.Models.Responses.Transfers;

public class ResolverModel
{
	public string? User { get; set; }
	public string? Date { get; set; }
	public string? ResolutionType { get; set; }
	public IEnumerable<string>? Signatures { get; set; }
	public string? VideoApprover { get; set; }
	public string? VideoLink { get; set; }
	public string? VideoException { get; set; }
}
