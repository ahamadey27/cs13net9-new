using System.Globalization; 

partial class Program
{
	private static void ConfigureConsole(
		string culture = "en-us",
		bool userComputerCulture = false,
		bool showCulture = true)
	{
		OutputEncoding = System.Text.Encoding.UTF8;

		if (!userComputerCulture )
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
		}
		if (showCulture)
		{
			WriteLine($"Current Culture:{CultureInfo.CurrentCulture.DisplayName}.");
		}
	}
}
