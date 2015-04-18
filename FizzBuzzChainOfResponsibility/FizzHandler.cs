using System;

namespace FizzBuzzChainOfResponsibility
{
	/// <summary>
	/// Description of FizzHandler.
	/// </summary>
	public class FizzHandler : PredicateAndStringHandler
	{
		public FizzHandler(NumberHandler succesor):base(succesor)
		{
			canWeHandleInputNumber = new Predicate<int>(candidateNumber => candidateNumber % 3 == 0);
			
			whatToReturnIfWeCanHandleInputNumber = "Fizz";
		}
	}
}
