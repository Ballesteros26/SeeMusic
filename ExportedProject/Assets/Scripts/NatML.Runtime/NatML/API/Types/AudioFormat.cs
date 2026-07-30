using System;
using NatML.API.Graph;

namespace NatML.API.Types
{
	[Serializable]
	[Preserve]
	public sealed class AudioFormat
	{
		public int sampleRate;

		public int channelCount;
	}
}
