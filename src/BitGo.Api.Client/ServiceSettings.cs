using System.Text.Json;
using System.Text.Json.Serialization;
using Refit;

namespace BitGo.Api.Client;

public static class ServiceSettings
{
	public static RefitSettings GetRefitSettings() =>
		new()
		{
			ContentSerializer = new SystemTextJsonContentSerializer(
				new JsonSerializerOptions
				{
					Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase, allowIntegerValues: true) },
					PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
					DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
					ReferenceHandler = ReferenceHandler.IgnoreCycles,
					NumberHandling = JsonNumberHandling.AllowReadingFromString,
					PropertyNameCaseInsensitive = true,
				}
			),
		};
}
