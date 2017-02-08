using System;

namespace FizzBuzzChainOfResponsibility
{
	public class FizzHandler : PredicateAndStringHandler
	{
		public FizzHandler(NumberHandler succesor):base(succesor)
		{
			canWeHandleInputNumber = new Predicate<int>(candidateNumber => candidateNumber % 3 == 0);
			
			whatToReturnIfWeCanHandleInputNumber = "Fizz";
		}
	}
}
