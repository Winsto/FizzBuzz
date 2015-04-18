using System;
using System.Collections.Generic;
using FizzBuzzTDDOne;
using NUnit.Framework;

namespace FizzBuzzTDDOneUnitTests
{
	[TestFixture]
	public class FizzBuzzTDDOneUnitTests
	{
		
		[Test]
		public void ReturnsTheTestCaseAsStringForAnyNumberNotAMultipleOfThreeOrFiveBetweenOneAndOneHundred()
		{
			foreach(int testCase in AllOtherNumbersBetweenOneAndOneHundred())
				if(! FizzBuzzTDDOne.FizzBuzzTDDOne.FizzBuzzOrNumber(testCase).Equals(testCase.ToString(), StringComparison.Ordinal))
					Assert.Fail();
					
		}
		
		[Test]
		public void ReturnsFizzForAllMultiplesOfThreeButNotFiveBetweenOneAndOneHundred()
		{
			foreach(int testCase in MultiplesOfThreeButNotFiveBetweenOneAndOneHundred())
			{
				
				if(! FizzBuzzTDDOne.FizzBuzzTDDOne.FizzBuzzOrNumber(testCase).Equals("Fizz", StringComparison.Ordinal))
					Assert.Fail();
			}
		}
			
		[Test]
		public void ReturnsBuzzForAllMulitplesOfFiveButNotThreeBetweenOneAndOneHundred()
		{
			foreach(int testCase in MultiplesOfFiveButNotThreeBetweenOneAndOneHundred())
			{
				if(! FizzBuzzTDDOne.FizzBuzzTDDOne.FizzBuzzOrNumber(testCase).Equals("Buzz", StringComparison.Ordinal))
					Assert.Fail();
			}
		}
		
		[Test]
		public void ReturnsFizzBuzzForAllMultiplesOfThreeAndFiveBetweenOneAndOneHundred()
		{
			foreach(int testCase in MultiplesOfFiveAndThreeBetweenOneAndOneHundred())
			{
				if(! FizzBuzzTDDOne.FizzBuzzTDDOne.FizzBuzzOrNumber(testCase).Equals("FizzBuzz", StringComparison.Ordinal))
					Assert.Fail();
			}
		}
		
		#region Utility methods
		
		IEnumerable<int> MultiplesOfThreeButNotFiveBetweenOneAndOneHundred()
		{
			int multipleOfThree;
			
			for(int factor = 1; factor < 34; factor++)
			{
				multipleOfThree = factor * 3;
				
				if(multipleOfThree % 5 == 0)
					continue;
				else
					yield return multipleOfThree;
			}
		}
		
		IEnumerable<int> MultiplesOfFiveButNotThreeBetweenOneAndOneHundred()
		{
			int multipleOfFive;
			
			for(int factor = 1; factor < 21; factor++)
			{
				multipleOfFive = factor * 5;
				
				if(multipleOfFive % 3 == 0)
					continue;
				else
					yield return multipleOfFive;
			}
		}
		
		IEnumerable<int> MultiplesOfFiveAndThreeBetweenOneAndOneHundred()
		{
			int multiple;
			
			for(int factor = 1; factor < 7; factor++)
			{
				multiple = factor * 15;
				
				if(multiple % 15 == 0)
					yield return multiple;
				else
					continue;
			}
		}
		
		IEnumerable<int> AllOtherNumbersBetweenOneAndOneHundred()
		{
			for(int candidateReturn = 1; candidateReturn < 101; candidateReturn++)
			{
				if(candidateReturn % 3 == 0) continue;
				if(candidateReturn % 5 == 0) continue;
				
				yield return candidateReturn;
			}

		}
		
		#endregion
	}
}
