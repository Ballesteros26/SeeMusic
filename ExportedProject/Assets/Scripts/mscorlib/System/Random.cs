namespace System
{
	/// <summary>Represents a pseudo-random number generator, a device that produces a sequence of numbers that meet certain statistical requirements for randomness.</summary>
	/// <filterpriority>1</filterpriority>
	public class Random
	{
		private int _inext;

		private int _inextp;

		private int[] _seedArray;

		[ThreadStatic]
		private static Random t_threadRandom;

		private static readonly Random s_globalRandom;

		/// <summary>Initializes a new instance of the <see cref="T:System.Random" /> class, using a time-dependent default seed value.</summary>
		public Random()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Random" /> class, using the specified seed value.</summary>
		/// <param name="Seed">A number used to calculate a starting value for the pseudo-random number sequence. If a negative number is specified, the absolute value of the number is used. </param>
		public Random(int Seed)
		{
		}

		/// <summary>Returns a random number between 0.0 and 1.0.</summary>
		/// <returns>A double-precision floating point number greater than or equal to 0.0, and less than 1.0.</returns>
		protected virtual double Sample()
		{
			return 0.0;
		}

		private int InternalSample()
		{
			return 0;
		}

		private static int GenerateSeed()
		{
			return 0;
		}

		private static int GenerateGlobalSeed()
		{
			return 0;
		}

		/// <summary>Returns a nonnegative random number.</summary>
		/// <returns>A 32-bit signed integer greater than or equal to zero and less than <see cref="F:System.Int32.MaxValue" />.</returns>
		/// <filterpriority>1</filterpriority>
		public virtual int Next()
		{
			return 0;
		}

		private double GetSampleForLargeRange()
		{
			return 0.0;
		}

		/// <summary>Returns a random number within a specified range.</summary>
		/// <returns>A 32-bit signed integer greater than or equal to <paramref name="minValue" /> and less than <paramref name="maxValue" />; that is, the range of return values includes <paramref name="minValue" /> but not <paramref name="maxValue" />. If <paramref name="minValue" /> equals <paramref name="maxValue" />, <paramref name="minValue" /> is returned.</returns>
		/// <param name="minValue">The inclusive lower bound of the random number returned. </param>
		/// <param name="maxValue">The exclusive upper bound of the random number returned. <paramref name="maxValue" /> must be greater than or equal to <paramref name="minValue" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="minValue" /> is greater than <paramref name="maxValue" />. </exception>
		/// <filterpriority>1</filterpriority>
		public virtual int Next(int minValue, int maxValue)
		{
			return 0;
		}

		/// <summary>Returns a nonnegative random number less than the specified maximum.</summary>
		/// <returns>A 32-bit signed integer greater than or equal to zero, and less than <paramref name="maxValue" />; that is, the range of return values ordinarily includes zero but not <paramref name="maxValue" />. However, if <paramref name="maxValue" /> equals zero, <paramref name="maxValue" /> is returned.</returns>
		/// <param name="maxValue">The exclusive upper bound of the random number to be generated. <paramref name="maxValue" /> must be greater than or equal to zero. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="maxValue" /> is less than zero. </exception>
		/// <filterpriority>1</filterpriority>
		public virtual int Next(int maxValue)
		{
			return 0;
		}

		/// <summary>Returns a random number between 0.0 and 1.0.</summary>
		/// <returns>A double-precision floating point number greater than or equal to 0.0, and less than 1.0.</returns>
		/// <filterpriority>1</filterpriority>
		public virtual double NextDouble()
		{
			return 0.0;
		}

		/// <summary>Fills the elements of a specified array of bytes with random numbers.</summary>
		/// <param name="buffer">An array of bytes to contain random numbers. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public virtual void NextBytes(byte[] buffer)
		{
		}
	}
}
