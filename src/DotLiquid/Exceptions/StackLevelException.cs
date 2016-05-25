using System;

namespace DotLiquid.Exceptions
{
#if !NETCORE
	[Serializable]
#endif
	public class StackLevelException : LiquidException
	{
		public StackLevelException(string message)
			: base(string.Format(message))
		{
		}
	}
}