using System;

namespace FizzBuzzChainOfResponsibility
{
	public interface NumberHandler
	{
		string HandleNumber(int numbertoHandle);
	}
}
