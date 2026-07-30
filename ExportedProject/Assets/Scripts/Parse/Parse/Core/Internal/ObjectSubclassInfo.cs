using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Parse.Core.Internal
{
	internal class ObjectSubclassInfo
	{
		[CompilerGenerated]
		private string _003CClassName_003Ek__BackingField;

		public TypeInfo TypeInfo { get; private set; }

		private string ClassName
		{
			[CompilerGenerated]
			set
			{
				_003CClassName_003Ek__BackingField = value;
			}
		}

		public IDictionary<string, string> PropertyMappings { get; private set; }

		private ConstructorInfo Constructor { get; set; }

		public ObjectSubclassInfo(Type type, ConstructorInfo constructor)
		{
		}

		public ParseObject Instantiate()
		{
			return null;
		}

		internal static string GetClassName(TypeInfo type)
		{
			return null;
		}
	}
}
