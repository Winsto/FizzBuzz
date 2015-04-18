using System;

namespace FizzBuzzTDDOne
{
	/// <summary>
	/// Description of FizzBuzzTDDOne.
	/// </summary>
	public static class FizzBuzzTDDOne
	{
		public static string FizzBuzzOrNumber(int numberToMap)
		{
			if(numberToMap % 15 == 0) return "FizzBuzz";
			if(numberToMap % 3 == 0) return "Fizz";
			if(numberToMap % 5 == 0) return "Buzz";
			
			return numberToMap.ToString();
		}
	}
}
