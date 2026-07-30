using System;

namespace MakeIt.Random
{
	public interface IWeightedIndexGenerator<TWeight, TWeightSum>
	{
		TWeightSum weightSum { get; }

		int Next();

		int Next(out TWeight weight);

		void UpdateWeights();

		void UpdateWeights(TWeight[] weights);

		void UpdateWeights(int elementCount, Func<int, TWeight> weightsAccessor);
	}
}
