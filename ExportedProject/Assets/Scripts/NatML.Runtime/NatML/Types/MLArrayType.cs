using System;

namespace NatML.Types
{
	public class MLArrayType : MLFeatureType
	{
		public readonly int[] shape;

		public int dims => 0;

		public int elementCount => 0;

		public MLArrayType(int[] shape, Type type, string name = null)
			: base(null, null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
