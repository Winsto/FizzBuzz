using System;

namespace FizzBuzzChainOfResponsibility
{
	/// <summary>
	/// Description of BuzzHandler.
	/// </summary>
	public class BuzzHandler : PredicateAndStringHandler
	{
		public BuzzHandler(NumberHandler succesor):base(succesor)
		{
			canWeHandleInputNumber = new Predicate<int>(candidateNumber => candidateNumber % 5 == 0);
			
			whatToReturnIfWeCanHandleInputNumber = "Buzz";
		}
	}
}
