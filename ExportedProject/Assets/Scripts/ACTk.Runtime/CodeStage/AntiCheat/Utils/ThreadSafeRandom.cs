using System;

namespace CodeStage.AntiCheat.Utils
{
	internal class ThreadSafeRandom
	{
		private static readonly Random Global;

		[ThreadStatic]
		private static Random local;

		public static int Next(int minInclusive, int maxExclusive)
		{
			return 0;
		}

		public static long NextLong(long minInclusive, long maxExclusive)
		{
			return 0L;
		}

		public static void NextBytes(byte[] buffer)
		{
		}

		public static void NextChars(char[] buffer)
		{
		}

		public static int Next()
		{
			return 0;
		}

		public static int Next(int maxExclusive)
		{
			return 0;
		}

		private static long NextLong(Random random, long minInclusive, long maxExclusive)
		{
			return 0L;
		}

		private static void NextChars(Random random, char[] buffer)
		{
		}
	}
}
