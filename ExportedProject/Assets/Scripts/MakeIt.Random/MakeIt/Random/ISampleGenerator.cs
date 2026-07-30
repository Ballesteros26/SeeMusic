namespace MakeIt.Random
{
	public interface ISampleGenerator<TNumber>
	{
		TNumber Next();
	}
}
