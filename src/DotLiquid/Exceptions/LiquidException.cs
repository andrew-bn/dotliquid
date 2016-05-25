using System;

namespace DotLiquid.Exceptions
{
#if !NETCORE
	[Serializable]
#endif
	public abstract class LiquidException : Exception
	{
		protected LiquidException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		protected LiquidException(string message)
			: base(message)
		{
		}

		protected LiquidException()
		{
		}
	}
}