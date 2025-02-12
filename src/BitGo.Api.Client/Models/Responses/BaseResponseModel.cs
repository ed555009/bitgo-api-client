using BitGo.Api.Client.Interfaces;

namespace BitGo.Api.Client.Models.Responses;

public abstract class BaseResponseModel : IBaseResponseModel
{
	public string? Error { get; set; }
	public string? Name { get; set; }
	public string? RequestId { get; set; }
}
