using System;

namespace FizzBuzzChainOfResponsibility
{
	public class FizzBuzzHandler : PredicateAndStringHandler
	{
		public FizzBuzzHandler(NumberHandler succesor):base(succesor)
		{
			canWeHandleInputNumber = new Predicate<int>( candidateNumber => candidateNumber % 15 == 0);
			
			whatToReturnIfWeCanHandleInputNumber = "FizzBuzz";
		}
			
	}
}
