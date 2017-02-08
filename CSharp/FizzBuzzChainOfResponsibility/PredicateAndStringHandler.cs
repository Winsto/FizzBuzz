using System;

namespace FizzBuzzChainOfResponsibility
{
	public abstract class PredicateAndStringHandler:NumberHandler
	{
		private readonly NumberHandler succesor;
		
		protected Predicate<int> canWeHandleInputNumber;
		protected string whatToReturnIfWeCanHandleInputNumber;
		
		public PredicateAndStringHandler(NumberHandler succesor)
		{
			this.succesor = succesor;
		}

#region NumberHandler implementation

public string HandleNumber(int numbertoHandle)
{
	if(canWeHandleInputNumber(numbertoHandle))
		return whatToReturnIfWeCanHandleInputNumber;
	else
	{
		if(succesor == null)
			throw new InvalidOperationException("No succesor to call.");
		else
			return succesor.HandleNumber(numbertoHandle);
	}
}

	#endregion
	}
}
