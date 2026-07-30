using System;

namespace MakeIt.Random
{
	public interface IRandom : IBitGenerator
	{
		int stepBitCount { get; }

		int skipAheadMagnitude { get; }

		int skipBackMagnitude { get; }

		byte[] SaveState();

		void RestoreState(byte[] stateArray);

		void Seed();

		void Seed(int seed);

		void Seed(params int[] seed);

		void Seed(string seed);

		void Seed(IBitGenerator bitGenerator);

		void MergeSeed();

		void MergeSeed(int seed);

		void MergeSeed(params int[] seed);

		void MergeSeed(string seed);

		void MergeSeed(IBitGenerator bitGenerator);

		void Step();

		void SkipAhead();

		void SkipBack();

		System.Random AsSystemRandom();
	}
}
