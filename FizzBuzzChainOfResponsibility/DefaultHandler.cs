using System;

namespace FizzBuzzChainOfResponsibility
{
	public class DefaultHandler : NumberHandler
	{
#region NumberHandler implementation

public string HandleNumber(int numbertoHandle)
{
	return numbertoHandle.ToString();
}

	#endregion
	}
}
