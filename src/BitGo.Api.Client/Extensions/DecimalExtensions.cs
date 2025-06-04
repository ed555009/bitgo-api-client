namespace BitGo.Api.Client.Extensions;

public static class DecimalExtensions
{
	public static string ToBalanceString(this decimal value) => value.ToString("#,0.##################");
}
