namespace BitGo.Api.Client.Extensions;

public static class EnumExtensions
{
	public static string GetDescription(this Enum value)
	{
		var fieldInfo = value.GetType().GetField(value.ToString());

		if (fieldInfo == null)
		{
			return value.ToString();
		}

		var attributes = fieldInfo.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);

		return attributes.Length > 0
			? ((System.ComponentModel.DescriptionAttribute)attributes[0]).Description
			: value.ToString();
	}
}
