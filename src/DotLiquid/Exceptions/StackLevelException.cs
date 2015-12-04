using System;

namespace DotLiquid.Exceptions
{
#if !DNXCORE50
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