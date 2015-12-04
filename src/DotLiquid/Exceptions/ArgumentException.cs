using System;

namespace DotLiquid.Exceptions
{
#if !DNXCORE50
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