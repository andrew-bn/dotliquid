using System;

namespace DotLiquid.Exceptions
{
#if !NETCORE
	[Serializable]
#endif
	public class ArgumentException : LiquidException
	{
		public ArgumentException(string message, params string[] args)
			: base(string.Format(message, args))
		{
		}

		public ArgumentException()
		{
		}
	}
}