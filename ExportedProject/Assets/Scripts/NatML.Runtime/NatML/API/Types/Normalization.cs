using System;
using NatML.API.Graph;

namespace NatML.API.Types
{
	[Serializable]
	[Preserve]
	public sealed class Normalization
	{
		public float[] mean;

		public float[] std;
	}
}
