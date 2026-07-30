using System;

namespace Parse.Common.Internal
{
	[AttributeUsage(AttributeTargets.Assembly)]
	public class ParseModuleAttribute : Attribute
	{
		public Type ModuleType { get; private set; }

		public ParseModuleAttribute(Type ModuleType)
		{
		}
	}
}
