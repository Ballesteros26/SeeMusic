namespace MakeIt.Random.Detail
{
	public class BufferedBitGenerator
	{
		private IRandom _random;

		private ulong _bits;

		public BufferedBitGenerator(IRandom random)
		{
		}

		protected ulong Next32()
		{
			return 0uL;
		}

		protected ulong Next64()
		{
			return 0uL;
		}
	}
}
