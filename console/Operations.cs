using System;
using System.Collections.Generic;

namespace console
{
	public class Operations
	{
		private List<String> history = new List<String>();

		private void historyAdd(String str){
			this.history.Add (str);
		}

		public String reverse(String input){
			String output = input;

			char[] charArray = output.ToCharArray();
			Array.Reverse( charArray );
			output = new string( charArray );

			this.historyAdd (output);
			return output;
		}

		public String contains(String input, String arg){
			String output = input;

			if (output.Contains(arg))
				output = "Char is in String";
			else
				output = "Char not in String";

			this.historyAdd (output);
			return output;
		}

		public String length(String input){
			String output = input;

			output = output.Length.ToString();

			this.historyAdd (output);
			return output;
		} 

		public String encrypt(String input){
			String output = input;

			//todo

			this.historyAdd (output);
			return output;
		} 

		public String shift(String input, int n){
			String output = input;

			output = output.Substring(n, output.Length - n) + output.Substring(0, n); 

			this.historyAdd (output);
			return output;
		} 

		public String shift(String input, int n, bool reverse){
			String output = input;

			if (reverse)
				output = output.Substring(0, n) + output.Substring(n, output.Length - n) + output.Substring(0, n); 
			else
				output = output.Substring(n, output.Length - n) + output.Substring(0, n); 

			this.historyAdd (output);
			return output;
		}

		public String showHistory(){
			String outp = "";

			foreach (String s in this.history.ToArray()) {
				outp += s;
				outp += "/n";
			}
			return outp;
		} 
	}
}

