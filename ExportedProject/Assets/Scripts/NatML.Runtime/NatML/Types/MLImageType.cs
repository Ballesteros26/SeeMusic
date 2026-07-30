using System;

namespace NatML.Types
{
	public class MLImageType : MLArrayType
	{
		public virtual int width => 0;

		public virtual int height => 0;

		public virtual int channels => 0;

		public virtual bool interleaved { get; protected set; }

		public MLImageType(int width, int height, int channels)
			: base(null, null)
		{
		}

		public MLImageType(int width, int height, int channels, Type type)
			: base(null, null)
		{
		}

		public MLImageType(int[] shape, Type type, string name = null)
			: base(null, null)
		{
		}

		public static MLImageType FromType(MLFeatureType type)
		{
			return null;
		}
	}
}
