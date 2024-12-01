namespace PeekStock.API.Utils;

public static class StringUtils
{
	public static Guid ToGuid(this string input)
	{
		_ = Guid.TryParse(input, out Guid result);
		return result;
	}
}
