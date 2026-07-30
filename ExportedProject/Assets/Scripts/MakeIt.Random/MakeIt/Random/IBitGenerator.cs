namespace MakeIt.Random
{
	public interface IBitGenerator
	{
		uint Next32();

		ulong Next64();

		void Next64(out uint lower, out uint upper);
	}
}
