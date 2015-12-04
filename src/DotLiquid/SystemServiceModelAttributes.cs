using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#if DNXCORE50
namespace System.Collections.Generic
{
	public static class GenericExtensions
	{
		public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
		{
			foreach(var i in collection)
			{
				action(i);
			}
		}
	}
}

namespace System.ServiceModel
{
    internal class MessageHeaderAttribute : Attribute
    {
        public string Namespace { get; set; }
    }
}

namespace System.CodeDom.Compiler
{


    internal class GeneratedCodeAttribute : Attribute
    {
        public GeneratedCodeAttribute(string name, string version)
        {

        }
    }

}

namespace System
{
public delegate TOutput Converter<in TInput, out TOutput>(TInput input);
    internal class SerializableAttribute : Attribute
    {

    }

    internal class NonSerializedAttribute : Attribute
    {

    }
}

namespace System.Diagnostics
{
    internal class DebuggerStepThroughAttribute : Attribute
    {

    }
}
namespace System.Diagnostics.CodeAnalysis
{
    internal class SuppressMessageAttribute : Attribute
    {
        public SuppressMessageAttribute(string name, string version)
        {

        }
    }
}
namespace System.ComponentModel
{
    internal class DesignerCategoryAttribute : Attribute
    {
        public DesignerCategoryAttribute(string name)
        {

        }
    }

    internal class BrowsableAttribute : Attribute
    {
        public BrowsableAttribute(bool browsable)
        {

        }
    }
}

namespace System.Runtime.Serialization
{
    internal interface IExtensibleDataObject
    {

    }

    internal class ExtensionDataObject : IExtensibleDataObject
    {

    }

    internal class OptionalFieldAttribute : Attribute
    {

    }
}

#endif
