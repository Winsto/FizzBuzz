using System;

namespace FizzBuzzChainOfResponsibility
{
	/// <summary>
	/// Description of NumberHandler.
	/// </summary>
	public interface NumberHandler
	{
		string HandleNumber(int numbertoHandle);
	}
}
