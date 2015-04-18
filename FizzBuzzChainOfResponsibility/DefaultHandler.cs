using System;

namespace FizzBuzzChainOfResponsibility
{
	/// <summary>
	/// Description of DefaultHandler.
	/// </summary>
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
