using System;

namespace console
{
	public class BaseProgram
	{
		public BaseProgram ()
		{
			
		}
		public void doOperation(String input){
			var op = input [0];
			var str = input.Substring (2);

			Console.Write("choosen operation");
			Console.Write(op);
			Console.Write("\n");

			Console.Write("string");
			Console.Write(str);
			Console.Write("\n");
		
		}
	}
}

