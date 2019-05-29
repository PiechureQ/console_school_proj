using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
namespace console
{
	class Program : BaseProgram
	{
		public Program(){

		}

		//Method invoked as long as the user is running the calculator
		public bool loop()
		{
			var userInput = Console.ReadLine();

			if (String.IsNullOrEmpty(userInput))
			{
				const string message = "Type something! :)";
				Console.WriteLine(message);
				return true;
			}

			if (userInput.ToLower() == "exit")
				return false;

			doOperation(userInput);
			return true;
		}

		new public void doOperation(String input)
		{
			string[] ssize = input.Split();
			var op = ssize [0];
			var str = ssize [1];
			var arg = ssize [2];

			Operations operation = new Operations();

			//Checking if math operators are equal or more than the numbers to be calculated
			if (input[1].Equals(" "))
			{
				Console.WriteLine("Wrong entry. Try again using one or more operations");
				doOperation(Console.ReadLine());
			}

			String result = "";
			switch (op)
			{
				case "r": //reverse
				{
					result = operation.reverse (str);
					break;
				}
				case "c": //constains
				{
					result = operation.contains (str, arg);
					break;
				}
				case "l": //length
				{
					result = operation.length(str);
					break;
				}
				case "e": //encrypt
				{
					result = operation.encrypt(str);
					break;
				}
				case "s": //shift
				{
					result = operation.shift (str, 2);
					break;
				}
				case "sr": //shift
				{
					if (arg.Equals("1")){
						result = operation.shift (str, 2, true);
					} else {
						result = operation.shift (str, 2, false);
					}
					break;
				}
				case "h": //show history
				{
					result = operation.showHistory();
					break;
				}
				default:
					break;
			}

			Console.WriteLine("Result: {0}", result);
			Console.WriteLine("\nType 'Exit' to leave\n");
		}

		public void ExitAndThankYouMessage()
		{
			Console.Clear();
			Console.WriteLine("\n");
			Console.WriteLine ("thank you");
		}

	}
}