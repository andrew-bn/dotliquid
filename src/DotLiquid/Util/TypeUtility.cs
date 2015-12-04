using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace DotLiquid.Util
{
	internal static class TypeUtility
	{
		private const TypeAttributes AnonymousTypeAttributes = TypeAttributes.NotPublic;

		public static bool IsAnonymousType(Type t)
		{
			return (t.GetTypeInfo().GetCustomAttributes(typeof(CompilerGeneratedAttribute), false).FirstOrDefault() as CompilerGeneratedAttribute)!= null
				&& t.GetTypeInfo().IsGenericType
					&& (t.Name.Contains("AnonymousType") || t.Name.Contains("AnonType"))
						&& (t.Name.StartsWith("<>") || t.Name.StartsWith("VB$"))
							&& t.GetTypeInfo().IsNotPublic;
		}
	}
}