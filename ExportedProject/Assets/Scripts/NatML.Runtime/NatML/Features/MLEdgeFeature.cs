using System;
using NatML.API.Types;

namespace NatML.Features
{
	public readonly struct MLEdgeFeature : IDisposable
	{
		private readonly IntPtr feature;

		public unsafe void* data => null;

		public int[] shape => null;

		public Dtype dataType => default(Dtype);

		public void Dispose()
		{
		}

		public MLEdgeFeature(IntPtr feature)
		{
			this.feature = (IntPtr)0;
		}

		public static implicit operator IntPtr(MLEdgeFeature feature)
		{
			return (IntPtr)0;
		}
	}
}
