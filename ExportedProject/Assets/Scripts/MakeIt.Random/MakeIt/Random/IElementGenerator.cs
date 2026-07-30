namespace MakeIt.Random
{
	public interface IElementGenerator<TElement>
	{
		TElement Next();

		int NextIndex();

		TElement Next(out int index);
	}
}
