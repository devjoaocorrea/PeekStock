namespace ConsoleApp1;

public static class StringExtensions
{
	public static Guid ToGuid(this string text)
	{
		Guid.TryParse(text, out var result);
		return result;
	}
}
