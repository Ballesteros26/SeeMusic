using System;

namespace NatML
{
	public abstract class MLFeatureType
	{
		public readonly string name;

		public readonly Type dataType;

		protected MLFeatureType(string name, Type type)
		{
		}

		public static implicit operator bool(MLFeatureType type)
		{
			return false;
		}
	}
}
