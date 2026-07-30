using System.IO;
using AudioSynthesis.Bank.Components;

namespace AudioSynthesis.Bank.Descriptors
{
	public class FilterDescriptor
	{
		public FilterTypeEnum FilterMethod;

		public float CutOff;

		public float Resonance;

		public short RootKey;

		public short KeyTrack;

		public short VelTrack;

		public int Read(BinaryReader reader)
		{
			return 0;
		}

		private void ApplyDefault()
		{
		}

		private void CheckValidParameters()
		{
		}
	}
}
