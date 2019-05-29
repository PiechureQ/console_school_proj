using System;

namespace console
{
	public class MainClass
	{
		private static void Main(string[] args)
		{
			Program program = new Program();
			Console.WriteLine("-> Change string ");

			bool calculatorOn = true;
			while (calculatorOn)
			{
				calculatorOn = program.loop ();
			}

			program.ExitAndThankYouMessage();
		}
	}
}

