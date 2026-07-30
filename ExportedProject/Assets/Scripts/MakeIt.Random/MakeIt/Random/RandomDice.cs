using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MakeIt.Random
{
	public static class RandomDice
	{
		private class DiceGeneratorBase
		{
			protected readonly IRangeGenerator<int> _dieGenerator;

			protected readonly int[] _dice;

			protected readonly int[] _discardedDice;

			public int[] dice => null;

			public int[] discardedDice => null;

			public DiceGeneratorBase(IRandom random, int sides, int keepQuantity, int dropQuantity)
			{
			}
		}

		private class SimpleDiceGenerator : DiceGeneratorBase, IDiceGenerator
		{
			public SimpleDiceGenerator(IRandom random, int quantity, int sides)
			{
			}

			public int Roll()
			{
				return 0;
			}
		}

		private class KeepHighestDiceGenerator : DiceGeneratorBase, IDiceGenerator
		{
			public KeepHighestDiceGenerator(IRandom random, int quantity, int sides, int keepQuantity)
			{
			}

			public int Roll()
			{
				return 0;
			}
		}

		private class KeepLowestDiceGenerator : DiceGeneratorBase, IDiceGenerator
		{
			public KeepLowestDiceGenerator(IRandom random, int quantity, int sides, int keepQuantity)
			{
			}

			public int Roll()
			{
				return 0;
			}
		}

		private static Regex _diceNotationRegex;

		public static int RollDie(this IRandom random, int sides)
		{
			return 0;
		}

		public static int RollDie(this IRangeGenerator<int> dieGenerator)
		{
			return 0;
		}

		public static int[] RollDice(this IRandom random, int quantity, int sides)
		{
			return null;
		}

		public static int[] RollDice(this IRangeGenerator<int> dieGenerator, int quantity)
		{
			return null;
		}

		public static void RollDice(this IRandom random, int quantity, int sides, int[] dice)
		{
		}

		public static void RollDice(this IRangeGenerator<int> dieGenerator, int quantity, int[] dice)
		{
		}

		public static void RollDice(this IRandom random, int quantity, int sides, List<int> dice)
		{
		}

		public static void RollDice(this IRangeGenerator<int> dieGenerator, int quantity, List<int> dice)
		{
		}

		public static int SumRollDice(this IRandom random, int quantity, int sides)
		{
			return 0;
		}

		public static int SumRollDice(this IRangeGenerator<int> dieGenerator, int quantity)
		{
			return 0;
		}

		public static int SumRollDice(this IRandom random, int quantity, int sides, out int[] dice)
		{
			dice = null;
			return 0;
		}

		public static int SumRollDice(this IRangeGenerator<int> dieGenerator, int quantity, out int[] dice)
		{
			dice = null;
			return 0;
		}

		public static int SumRollDice(this IRandom random, int quantity, int sides, int[] dice)
		{
			return 0;
		}

		public static int SumRollDice(this IRangeGenerator<int> dieGenerator, int quantity, int[] dice)
		{
			return 0;
		}

		public static int SumRollDice(this IRandom random, int quantity, int sides, List<int> dice)
		{
			return 0;
		}

		public static int SumRollDice(this IRangeGenerator<int> dieGenerator, int quantity, List<int> dice)
		{
			return 0;
		}

		private static int Sum(int[] dice)
		{
			return 0;
		}

		private static int Sum(List<int> dice)
		{
			return 0;
		}

		private static int FindMinIndex(IList<int> dice)
		{
			return 0;
		}

		private static int FindMaxIndex(IList<int> dice)
		{
			return 0;
		}

		private static void RollAdditionalKeepHighest(this IRandom random, int additionalQuantity, int sides, IList<int> dice)
		{
		}

		private static void RollAdditionalKeepHighest(this IRangeGenerator<int> dieGenerator, int additionalQuantity, IList<int> dice)
		{
		}

		private static void RollAdditionalKeepHighest(this IRandom random, int additionalQuantity, int sides, IList<int> dice, int[] discardedDice)
		{
		}

		private static void RollAdditionalKeepHighest(this IRangeGenerator<int> dieGenerator, int additionalQuantity, IList<int> dice, int[] discardedDice)
		{
		}

		private static void RollAdditionalKeepHighest(this IRandom random, int additionalQuantity, int sides, IList<int> dice, List<int> discardedDice)
		{
		}

		private static void RollAdditionalKeepHighest(this IRangeGenerator<int> dieGenerator, int additionalQuantity, IList<int> dice, List<int> discardedDice)
		{
		}

		private static void RollAdditionalKeepLowest(this IRandom random, int additionalQuantity, int sides, IList<int> dice)
		{
		}

		private static void RollAdditionalKeepLowest(this IRangeGenerator<int> dieGenerator, int additionalQuantity, IList<int> dice)
		{
		}

		private static void RollAdditionalKeepLowest(this IRandom random, int additionalQuantity, int sides, IList<int> dice, int[] discardedDice)
		{
		}

		private static void RollAdditionalKeepLowest(this IRangeGenerator<int> dieGenerator, int additionalQuantity, IList<int> dice, int[] discardedDice)
		{
		}

		private static void RollAdditionalKeepLowest(this IRandom random, int additionalQuantity, int sides, IList<int> dice, List<int> discardedDice)
		{
		}

		private static void RollAdditionalKeepLowest(this IRangeGenerator<int> dieGenerator, int additionalQuantity, IList<int> dice, List<int> discardedDice)
		{
		}

		public static int[] RollDiceKeepHighest(this IRandom random, int quantity, int sides, int keepQuantity)
		{
			return null;
		}

		public static int[] RollDiceKeepHighest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity)
		{
			return null;
		}

		public static void RollDiceKeepHighest(this IRandom random, int quantity, int sides, int keepQuantity, int[] dice)
		{
		}

		public static void RollDiceKeepHighest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, int[] dice)
		{
		}

		public static void RollDiceKeepHighest(this IRandom random, int quantity, int sides, int keepQuantity, int[] dice, int[] discardedDice)
		{
		}

		public static void RollDiceKeepHighest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, int[] dice, int[] discardedDice)
		{
		}

		public static void RollDiceKeepHighest(this IRandom random, int quantity, int sides, int keepQuantity, List<int> dice)
		{
		}

		public static void RollDiceKeepHighest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, List<int> dice)
		{
		}

		public static void RollDiceKeepHighest(this IRandom random, int quantity, int sides, int keepQuantity, List<int> dice, List<int> discardedDice)
		{
		}

		public static void RollDiceKeepHighest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, List<int> dice, List<int> discardedDice)
		{
		}

		public static int[] RollDiceKeepLowest(this IRandom random, int quantity, int sides, int keepQuantity)
		{
			return null;
		}

		public static int[] RollDiceKeepLowest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity)
		{
			return null;
		}

		public static void RollDiceKeepLowest(this IRandom random, int quantity, int sides, int keepQuantity, int[] dice)
		{
		}

		public static void RollDiceKeepLowest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, int[] dice)
		{
		}

		public static void RollDiceKeepLowest(this IRandom random, int quantity, int sides, int keepQuantity, int[] dice, int[] discardedDice)
		{
		}

		public static void RollDiceKeepLowest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, int[] dice, int[] discardedDice)
		{
		}

		public static void RollDiceKeepLowest(this IRandom random, int quantity, int sides, int keepQuantity, List<int> dice)
		{
		}

		public static void RollDiceKeepLowest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, List<int> dice)
		{
		}

		public static void RollDiceKeepLowest(this IRandom random, int quantity, int sides, int keepQuantity, List<int> dice, List<int> discardedDice)
		{
		}

		public static void RollDiceKeepLowest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, List<int> dice, List<int> discardedDice)
		{
		}

		public static int[] RollDiceDropHighest(this IRandom random, int quantity, int sides, int dropQuantity)
		{
			return null;
		}

		public static int[] RollDiceDropHighest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity)
		{
			return null;
		}

		public static void RollDiceDropHighest(this IRandom random, int quantity, int sides, int dropQuantity, int[] dice)
		{
		}

		public static void RollDiceDropHighest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, int[] dice)
		{
		}

		public static void RollDiceDropHighest(this IRandom random, int quantity, int sides, int dropQuantity, int[] dice, int[] discardedDice)
		{
		}

		public static void RollDiceDropHighest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, int[] dice, int[] discardedDice)
		{
		}

		public static void RollDiceDropHighest(this IRandom random, int quantity, int sides, int dropQuantity, List<int> dice)
		{
		}

		public static void RollDiceDropHighest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, List<int> dice)
		{
		}

		public static void RollDiceDropHighest(this IRandom random, int quantity, int sides, int dropQuantity, List<int> dice, List<int> discardedDice)
		{
		}

		public static void RollDiceDropHighest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, List<int> dice, List<int> discardedDice)
		{
		}

		public static int[] RollDiceDropLowest(this IRandom random, int quantity, int sides, int dropQuantity)
		{
			return null;
		}

		public static int[] RollDiceDropLowest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity)
		{
			return null;
		}

		public static void RollDiceDropLowest(this IRandom random, int quantity, int sides, int dropQuantity, int[] dice)
		{
		}

		public static void RollDiceDropLowest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, int[] dice)
		{
		}

		public static void RollDiceDropLowest(this IRandom random, int quantity, int sides, int dropQuantity, int[] dice, int[] discardedDice)
		{
		}

		public static void RollDiceDropLowest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, int[] dice, int[] discardedDice)
		{
		}

		public static void RollDiceDropLowest(this IRandom random, int quantity, int sides, int dropQuantity, List<int> dice)
		{
		}

		public static void RollDiceDropLowest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, List<int> dice)
		{
		}

		public static void RollDiceDropLowest(this IRandom random, int quantity, int sides, int dropQuantity, List<int> dice, List<int> discardedDice)
		{
		}

		public static void RollDiceDropLowest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, List<int> dice, List<int> discardedDice)
		{
		}

		public static int SumRollDiceKeepHighest(this IRandom random, int quantity, int sides, int keepQuantity)
		{
			return 0;
		}

		public static int SumRollDiceKeepHighest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity)
		{
			return 0;
		}

		public static int SumRollDiceKeepHighest(this IRandom random, int quantity, int sides, int keepQuantity, out int[] dice)
		{
			dice = null;
			return 0;
		}

		public static int SumRollDiceKeepHighest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, out int[] dice)
		{
			dice = null;
			return 0;
		}

		public static int SumRollDiceKeepHighest(this IRandom random, int quantity, int sides, int keepQuantity, out int[] dice, out int[] discardedDice)
		{
			dice = null;
			discardedDice = null;
			return 0;
		}

		public static int SumRollDiceKeepHighest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, out int[] dice, out int[] discardedDice)
		{
			dice = null;
			discardedDice = null;
			return 0;
		}

		public static int SumRollDiceKeepHighest(this IRandom random, int quantity, int sides, int keepQuantity, int[] dice)
		{
			return 0;
		}

		public static int SumRollDiceKeepHighest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, int[] dice)
		{
			return 0;
		}

		public static int SumRollDiceKeepHighest(this IRandom random, int quantity, int sides, int keepQuantity, int[] dice, int[] discardedDice)
		{
			return 0;
		}

		public static int SumRollDiceKeepHighest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, int[] dice, int[] discardedDice)
		{
			return 0;
		}

		public static int SumRollDiceKeepHighest(this IRandom random, int quantity, int sides, int keepQuantity, List<int> dice)
		{
			return 0;
		}

		public static int SumRollDiceKeepHighest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, List<int> dice)
		{
			return 0;
		}

		public static int SumRollDiceKeepHighest(this IRandom random, int quantity, int sides, int keepQuantity, List<int> dice, List<int> discardedDice)
		{
			return 0;
		}

		public static int SumRollDiceKeepHighest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, List<int> dice, List<int> discardedDice)
		{
			return 0;
		}

		public static int SumRollDiceKeepLowest(this IRandom random, int quantity, int sides, int keepQuantity)
		{
			return 0;
		}

		public static int SumRollDiceKeepLowest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity)
		{
			return 0;
		}

		public static int SumRollDiceKeepLowest(this IRandom random, int quantity, int sides, int keepQuantity, out int[] dice)
		{
			dice = null;
			return 0;
		}

		public static int SumRollDiceKeepLowest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, out int[] dice)
		{
			dice = null;
			return 0;
		}

		public static int SumRollDiceKeepLowest(this IRandom random, int quantity, int sides, int keepQuantity, out int[] dice, out int[] discardedDice)
		{
			dice = null;
			discardedDice = null;
			return 0;
		}

		public static int SumRollDiceKeepLowest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, out int[] dice, out int[] discardedDice)
		{
			dice = null;
			discardedDice = null;
			return 0;
		}

		public static int SumRollDiceKeepLowest(this IRandom random, int quantity, int sides, int keepQuantity, int[] dice)
		{
			return 0;
		}

		public static int SumRollDiceKeepLowest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, int[] dice)
		{
			return 0;
		}

		public static int SumRollDiceKeepLowest(this IRandom random, int quantity, int sides, int keepQuantity, int[] dice, int[] discardedDice)
		{
			return 0;
		}

		public static int SumRollDiceKeepLowest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, int[] dice, int[] discardedDice)
		{
			return 0;
		}

		public static int SumRollDiceKeepLowest(this IRandom random, int quantity, int sides, int keepQuantity, List<int> dice)
		{
			return 0;
		}

		public static int SumRollDiceKeepLowest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, List<int> dice)
		{
			return 0;
		}

		public static int SumRollDiceKeepLowest(this IRandom random, int quantity, int sides, int keepQuantity, List<int> dice, List<int> discardedDice)
		{
			return 0;
		}

		public static int SumRollDiceKeepLowest(this IRangeGenerator<int> dieGenerator, int quantity, int keepQuantity, List<int> dice, List<int> discardedDice)
		{
			return 0;
		}

		public static int SumRollDiceDropHighest(this IRandom random, int quantity, int sides, int dropQuantity)
		{
			return 0;
		}

		public static int SumRollDiceDropHighest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity)
		{
			return 0;
		}

		public static int SumRollDiceDropHighest(this IRandom random, int quantity, int sides, int dropQuantity, out int[] dice)
		{
			dice = null;
			return 0;
		}

		public static int SumRollDiceDropHighest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, out int[] dice)
		{
			dice = null;
			return 0;
		}

		public static int SumRollDiceDropHighest(this IRandom random, int quantity, int sides, int dropQuantity, out int[] dice, out int[] discardedDice)
		{
			dice = null;
			discardedDice = null;
			return 0;
		}

		public static int SumRollDiceDropHighest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, out int[] dice, out int[] discardedDice)
		{
			dice = null;
			discardedDice = null;
			return 0;
		}

		public static int SumRollDiceDropHighest(this IRandom random, int quantity, int sides, int dropQuantity, int[] dice)
		{
			return 0;
		}

		public static int SumRollDiceDropHighest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, int[] dice)
		{
			return 0;
		}

		public static int SumRollDiceDropHighest(this IRandom random, int quantity, int sides, int dropQuantity, int[] dice, int[] discardedDice)
		{
			return 0;
		}

		public static int SumRollDiceDropHighest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, int[] dice, int[] discardedDice)
		{
			return 0;
		}

		public static int SumRollDiceDropHighest(this IRandom random, int quantity, int sides, int dropQuantity, List<int> dice)
		{
			return 0;
		}

		public static int SumRollDiceDropHighest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, List<int> dice)
		{
			return 0;
		}

		public static int SumRollDiceDropHighest(this IRandom random, int quantity, int sides, int dropQuantity, List<int> dice, List<int> discardedDice)
		{
			return 0;
		}

		public static int SumRollDiceDropHighest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, List<int> dice, List<int> discardedDice)
		{
			return 0;
		}

		public static int SumRollDiceDropLowest(this IRandom random, int quantity, int sides, int dropQuantity)
		{
			return 0;
		}

		public static int SumRollDiceDropLowest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity)
		{
			return 0;
		}

		public static int SumRollDiceDropLowest(this IRandom random, int quantity, int sides, int dropQuantity, out int[] dice)
		{
			dice = null;
			return 0;
		}

		public static int SumRollDiceDropLowest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, out int[] dice)
		{
			dice = null;
			return 0;
		}

		public static int SumRollDiceDropLowest(this IRandom random, int quantity, int sides, int dropQuantity, out int[] dice, out int[] discardedDice)
		{
			dice = null;
			discardedDice = null;
			return 0;
		}

		public static int SumRollDiceDropLowest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, out int[] dice, out int[] discardedDice)
		{
			dice = null;
			discardedDice = null;
			return 0;
		}

		public static int SumRollDiceDropLowest(this IRandom random, int quantity, int sides, int dropQuantity, int[] dice)
		{
			return 0;
		}

		public static int SumRollDiceDropLowest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, int[] dice)
		{
			return 0;
		}

		public static int SumRollDiceDropLowest(this IRandom random, int quantity, int sides, int dropQuantity, int[] dice, int[] discardedDice)
		{
			return 0;
		}

		public static int SumRollDiceDropLowest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, int[] dice, int[] discardedDice)
		{
			return 0;
		}

		public static int SumRollDiceDropLowest(this IRandom random, int quantity, int sides, int dropQuantity, List<int> dice)
		{
			return 0;
		}

		public static int SumRollDiceDropLowest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, List<int> dice)
		{
			return 0;
		}

		public static int SumRollDiceDropLowest(this IRandom random, int quantity, int sides, int dropQuantity, List<int> dice, List<int> discardedDice)
		{
			return 0;
		}

		public static int SumRollDiceDropLowest(this IRangeGenerator<int> dieGenerator, int quantity, int dropQuantity, List<int> dice, List<int> discardedDice)
		{
			return 0;
		}

		public static int RollD4(this IRandom random)
		{
			return 0;
		}

		public static int RollD6(this IRandom random)
		{
			return 0;
		}

		public static int RollD8(this IRandom random)
		{
			return 0;
		}

		public static int RollD10(this IRandom random)
		{
			return 0;
		}

		public static int RollD12(this IRandom random)
		{
			return 0;
		}

		public static int RollD20(this IRandom random)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeDieGenerator(this IRandom random, int sides)
		{
			return null;
		}

		public static IDiceGenerator MakeDiceGenerator(this IRandom random, int quantity, int sides)
		{
			return null;
		}

		public static IDiceGenerator MakeDiceGeneratorKeepHighest(this IRandom random, int quantity, int sides, int keepQuantity)
		{
			return null;
		}

		public static IDiceGenerator MakeDiceGeneratorKeepLowest(this IRandom random, int quantity, int sides, int keepQuantity)
		{
			return null;
		}

		public static IDiceGenerator MakeDiceGeneratorDropHighest(this IRandom random, int quantity, int sides, int dropQuantity)
		{
			return null;
		}

		public static IDiceGenerator MakeDiceGeneratorDropLowest(this IRandom random, int quantity, int sides, int dropQuantity)
		{
			return null;
		}

		public static IDiceGenerator MakeDiceGenerator(this IRandom random, string notation)
		{
			return null;
		}
	}
}
