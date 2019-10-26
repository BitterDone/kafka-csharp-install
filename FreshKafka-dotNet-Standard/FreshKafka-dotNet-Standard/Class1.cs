using System;

namespace FreshKafka_dotNet_Standard
{
	public class Class1
	{
		public static void print(string message)
		{
			Console.WriteLine(message);
		}

		public static bool isValidString(string message)
		{
			return null != message && message.Length > -1;
		}
	}
}
