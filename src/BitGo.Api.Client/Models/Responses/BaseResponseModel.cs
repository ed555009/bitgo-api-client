using BitGo.Api.Client.Interfaces;

namespace BitGo.Api.Client.Models.Responses;

/// <summary>
/// Represents the base response model for API responses.
/// </summary>
public abstract class BaseResponseModel : IBaseResponseModel
{
	/// <summary>
	/// Gets or sets the error message, if any, associated with the response.
	/// </summary>
	public string? Error { get; set; }

	/// <summary>
	/// Gets or sets the name associated with the response.
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// Gets or sets the unique identifier for the request.
	/// </summary>
	public string? RequestId { get; set; }
}
