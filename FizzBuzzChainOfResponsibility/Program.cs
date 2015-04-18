using System;
using System.ComponentModel;

namespace FizzBuzzChainOfResponsibility
{
	class Program
	{
		public static void Main(string[] args)
		{
			NumberHandler handlesNumbers = new FizzBuzzHandler(
				new FizzHandler(
					new BuzzHandler(
						new DefaultHandler())));
			
			for(int candidateNumber = 1; candidateNumber < 101; candidateNumber++)
				Console.WriteLine("{0} -> {1}", candidateNumber, handlesNumbers.HandleNumber(candidateNumber));
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
