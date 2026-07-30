using System;
using System.IO;
using NatML.API.Types;

namespace NatML.Features
{
	public readonly struct MLCloudFeature : IDisposable
	{
		public readonly MemoryStream data;

		public readonly Dtype type;

		public readonly int[]? shape;

		public void Dispose()
		{
		}

		public MLCloudFeature(MemoryStream data, Dtype type, int[]? shape = null)
		{
			this.data = null;
			this.type = default(Dtype);
			this.shape = null;
		}
	}
}
