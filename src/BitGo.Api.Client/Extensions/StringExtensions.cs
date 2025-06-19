namespace BitGo.Api.Client.Extensions;

public static class StringExtensions
{
	public static decimal ToDecimal(this string str, int offset = 0) =>
		decimal.Parse(str ?? "0") / (decimal)Math.Pow(10, offset);
}
