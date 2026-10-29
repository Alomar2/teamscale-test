namespace TeamscaleTest;

internal static class Program
{
	static void Main()
	{
		bool condition = true;

		if (condition == true)
			Console.WriteLine("Teamscale test");
	}

	private static void UnusedHelper()
	{
		Console.WriteLine("Never called");
	}
}
