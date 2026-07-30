using System;

namespace MakeIt.Random
{
	public interface IWeightedElementGenerator<TElement, TWeight, TWeightSum> : IElementGenerator<TElement>
	{
		TWeightSum weightSum { get; }

		TElement Next(out TWeight weight);

		int NextIndex(out TWeight weight);

		TElement Next(out int index, out TWeight weight);

		void UpdateWeights();

		void UpdateWeights(TWeight[] weights);

		void UpdateWeights(int elementCount, Func<int, TWeight> weightsAccessor);
	}
}
