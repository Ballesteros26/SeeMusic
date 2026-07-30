namespace MakeIt.Random
{
	public interface IDiceGenerator
	{
		int[] dice { get; }

		int[] discardedDice { get; }

		int Roll();
	}
}
