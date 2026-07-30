namespace AudioSynthesis.Wave
{
	public class PcmData32Bit : PcmData
	{
		public override float this[int index] => 0f;

		public PcmData32Bit(int bits, byte[] pcmData, bool isDataInLittleEndianFormat)
			: base(0, null, isDataInLittleEndianFormat: false)
		{
		}
	}
}
