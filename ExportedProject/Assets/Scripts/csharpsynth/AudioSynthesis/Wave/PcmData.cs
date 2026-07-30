namespace AudioSynthesis.Wave
{
	public abstract class PcmData
	{
		protected byte[] data;

		protected byte bytes;

		protected int length;

		public int Length => 0;

		public abstract float this[int index] { get; }

		protected PcmData(int bits, byte[] pcmData, bool isDataInLittleEndianFormat)
		{
		}

		public static PcmData Create(int bits, byte[] pcmData, bool isDataInLittleEndianFormat)
		{
			return null;
		}
	}
}
