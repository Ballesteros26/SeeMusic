using System;

namespace Microsoft.CSharp.RuntimeBinder
{
	internal readonly struct ArgumentObject
	{
		internal readonly object Value;

		internal readonly CSharpArgumentInfo Info;

		internal readonly Type Type;

		public ArgumentObject(object value, CSharpArgumentInfo info, Type type)
		{
			Value = null;
			Info = null;
			Type = null;
		}
	}
}
