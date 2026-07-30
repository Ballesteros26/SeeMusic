using System;
using System.Collections.Generic;

namespace MakeIt.Random
{
	public static class RandomListAccess
	{
		private class VariableLengthArrayIndexGenerator<TElement> : IRangeGenerator<int>
		{
			private IRandom _random;

			private TElement[] _array;

			public VariableLengthArrayIndexGenerator(IRandom random, TElement[] array)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class VariableLengthListIndexGenerator<TElement> : IRangeGenerator<int>
		{
			private IRandom _random;

			private IList<TElement> _list;

			public VariableLengthListIndexGenerator(IRandom random, IList<TElement> list)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class FixedLengthArrayElementGenerator<TElement> : IElementGenerator<TElement>
		{
			private IRangeGenerator<int> _indexGenerator;

			private TElement[] _array;

			public FixedLengthArrayElementGenerator(IRandom random, TElement[] array)
			{
			}

			public TElement Next()
			{
				return default(TElement);
			}

			public int NextIndex()
			{
				return 0;
			}

			public TElement Next(out int index)
			{
				index = default(int);
				return default(TElement);
			}
		}

		private class FixedLengthListElementGenerator<TElement> : IElementGenerator<TElement>
		{
			private IRangeGenerator<int> _indexGenerator;

			private IList<TElement> _list;

			public FixedLengthListElementGenerator(IRandom random, IList<TElement> list)
			{
			}

			public TElement Next()
			{
				return default(TElement);
			}

			public int NextIndex()
			{
				return 0;
			}

			public TElement Next(out int index)
			{
				index = default(int);
				return default(TElement);
			}
		}

		private class VariableLengthArrayElementGenerator<TElement> : IElementGenerator<TElement>
		{
			private IRandom _random;

			private TElement[] _array;

			public VariableLengthArrayElementGenerator(IRandom random, TElement[] array)
			{
			}

			public TElement Next()
			{
				return default(TElement);
			}

			public int NextIndex()
			{
				return 0;
			}

			public TElement Next(out int index)
			{
				index = default(int);
				return default(TElement);
			}
		}

		private class VariableLengthListElementGenerator<TElement> : IElementGenerator<TElement>
		{
			private IRandom _random;

			private IList<TElement> _list;

			public VariableLengthListElementGenerator(IRandom random, IList<TElement> list)
			{
			}

			public TElement Next()
			{
				return default(TElement);
			}

			public int NextIndex()
			{
				return 0;
			}

			public TElement Next(out int index)
			{
				index = default(int);
				return default(TElement);
			}
		}

		private abstract class WeightedIndexGeneratorBase<TWeight, TWeightSum, TCumulativeWeightSum>
		{
			protected IRandom _random;

			protected TWeightSum _weightSum;

			protected int _elementCount;

			protected TWeight[] _weights;

			protected TCumulativeWeightSum[] _cumulativeWeightSums;

			protected Func<int, TWeight> _weightsAccessor;

			public TWeightSum weightSum => default(TWeightSum);

			protected WeightedIndexGeneratorBase(IRandom random, int elementCount, TWeight[] weights)
			{
			}

			public WeightedIndexGeneratorBase(IRandom random, int elementCount, Func<int, TWeight> weightsAccessor)
			{
			}

			protected abstract void SumWeights();

			public abstract int NextIndex();

			public virtual void UpdateWeights(TWeight[] weights)
			{
			}

			public virtual void UpdateWeights(int elementCount, Func<int, TWeight> weightsAccessor)
			{
			}
		}

		private abstract class WeightedIndexGenerator<TWeight, TWeightSum, TCumulativeWeightSum> : WeightedIndexGeneratorBase<TWeight, TWeightSum, TCumulativeWeightSum>, IWeightedIndexGenerator<TWeight, TWeightSum>
		{
			public WeightedIndexGenerator(IRandom random, int elementCount, TWeight[] weights)
			{
			}

			public WeightedIndexGenerator(IRandom random, int elementCount, Func<int, TWeight> weightsAccessor)
			{
			}

			public int Next()
			{
				return 0;
			}

			public int Next(out TWeight weight)
			{
				weight = default(TWeight);
				return 0;
			}

			public void UpdateWeights()
			{
			}
		}

		private abstract class WeightedElementGenerator<TElement, TWeight, TWeightSum, TCumulativeWeightSum> : WeightedIndexGeneratorBase<TWeight, TWeightSum, TCumulativeWeightSum>, IWeightedElementGenerator<TElement, TWeight, TWeightSum>, IElementGenerator<TElement>
		{
			private IList<TElement> _list;

			public WeightedElementGenerator(IRandom random, IList<TElement> list, TWeight[] weights)
			{
			}

			public WeightedElementGenerator(IRandom random, IList<TElement> list, int elementCount, TWeight[] weights)
			{
			}

			public WeightedElementGenerator(IRandom random, IList<TElement> list, Func<int, TWeight> weightsAccessor)
			{
			}

			public TElement Next()
			{
				return default(TElement);
			}

			public TElement Next(out TWeight weight)
			{
				weight = default(TWeight);
				return default(TElement);
			}

			TElement IElementGenerator<TElement>.Next(out int index)
			{
				index = default(int);
				return default(TElement);
			}

			public int NextIndex(out TWeight weight)
			{
				weight = default(TWeight);
				return 0;
			}

			public TElement Next(out int index, out TWeight weight)
			{
				index = default(int);
				weight = default(TWeight);
				return default(TElement);
			}

			public void UpdateWeights()
			{
			}

			public override void UpdateWeights(TWeight[] weights)
			{
			}

			public void UpdateWeights(Func<int, TWeight> weightsAccessor)
			{
			}
		}

		private class SByteWeightedIndexGenerator : WeightedIndexGenerator<sbyte, int, int>
		{
			public SByteWeightedIndexGenerator(IRandom random, int elementCount, sbyte[] weights)
			{
			}

			public SByteWeightedIndexGenerator(IRandom random, int elementCount, Func<int, sbyte> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class SByteWeightedElementGenerator<TElement> : WeightedElementGenerator<TElement, sbyte, int, int>
		{
			public SByteWeightedElementGenerator(IRandom random, IList<TElement> list, sbyte[] weights)
			{
			}

			public SByteWeightedElementGenerator(IRandom random, IList<TElement> list, int elementCount, sbyte[] weights)
			{
			}

			public SByteWeightedElementGenerator(IRandom random, IList<TElement> list, Func<int, sbyte> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class ByteWeightedIndexGenerator : WeightedIndexGenerator<byte, uint, uint>
		{
			public ByteWeightedIndexGenerator(IRandom random, int elementCount, byte[] weights)
			{
			}

			public ByteWeightedIndexGenerator(IRandom random, int elementCount, Func<int, byte> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class ByteWeightedElementGenerator<TElement> : WeightedElementGenerator<TElement, byte, uint, uint>
		{
			public ByteWeightedElementGenerator(IRandom random, IList<TElement> list, byte[] weights)
			{
			}

			public ByteWeightedElementGenerator(IRandom random, IList<TElement> list, int elementCount, byte[] weights)
			{
			}

			public ByteWeightedElementGenerator(IRandom random, IList<TElement> list, Func<int, byte> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class ShortWeightedIndexGenerator : WeightedIndexGenerator<short, int, int>
		{
			public ShortWeightedIndexGenerator(IRandom random, int elementCount, short[] weights)
			{
			}

			public ShortWeightedIndexGenerator(IRandom random, int elementCount, Func<int, short> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class ShortWeightedElementGenerator<TElement> : WeightedElementGenerator<TElement, short, int, int>
		{
			public ShortWeightedElementGenerator(IRandom random, IList<TElement> list, short[] weights)
			{
			}

			public ShortWeightedElementGenerator(IRandom random, IList<TElement> list, int elementCount, short[] weights)
			{
			}

			public ShortWeightedElementGenerator(IRandom random, IList<TElement> list, Func<int, short> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class UShortWeightedIndexGenerator : WeightedIndexGenerator<ushort, uint, uint>
		{
			public UShortWeightedIndexGenerator(IRandom random, int elementCount, ushort[] weights)
			{
			}

			public UShortWeightedIndexGenerator(IRandom random, int elementCount, Func<int, ushort> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class UShortWeightedElementGenerator<TElement> : WeightedElementGenerator<TElement, ushort, uint, uint>
		{
			public UShortWeightedElementGenerator(IRandom random, IList<TElement> list, ushort[] weights)
			{
			}

			public UShortWeightedElementGenerator(IRandom random, IList<TElement> list, int elementCount, ushort[] weights)
			{
			}

			public UShortWeightedElementGenerator(IRandom random, IList<TElement> list, Func<int, ushort> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class IntWeightedIndexGenerator : WeightedIndexGenerator<int, int, int>
		{
			public IntWeightedIndexGenerator(IRandom random, int elementCount, int[] weights)
			{
			}

			public IntWeightedIndexGenerator(IRandom random, int elementCount, Func<int, int> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class IntWeightedElementGenerator<TElement> : WeightedElementGenerator<TElement, int, int, int>
		{
			public IntWeightedElementGenerator(IRandom random, IList<TElement> list, int[] weights)
			{
			}

			public IntWeightedElementGenerator(IRandom random, IList<TElement> list, int elementCount, int[] weights)
			{
			}

			public IntWeightedElementGenerator(IRandom random, IList<TElement> list, Func<int, int> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class UIntWeightedIndexGenerator : WeightedIndexGenerator<uint, uint, uint>
		{
			public UIntWeightedIndexGenerator(IRandom random, int elementCount, uint[] weights)
			{
			}

			public UIntWeightedIndexGenerator(IRandom random, int elementCount, Func<int, uint> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class UIntWeightedElementGenerator<TElement> : WeightedElementGenerator<TElement, uint, uint, uint>
		{
			public UIntWeightedElementGenerator(IRandom random, IList<TElement> list, uint[] weights)
			{
			}

			public UIntWeightedElementGenerator(IRandom random, IList<TElement> list, int elementCount, uint[] weights)
			{
			}

			public UIntWeightedElementGenerator(IRandom random, IList<TElement> list, Func<int, uint> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class LongWeightedIndexGenerator : WeightedIndexGenerator<long, long, long>
		{
			public LongWeightedIndexGenerator(IRandom random, int elementCount, long[] weights)
			{
			}

			public LongWeightedIndexGenerator(IRandom random, int elementCount, Func<int, long> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class LongWeightedElementGenerator<TElement> : WeightedElementGenerator<TElement, long, long, long>
		{
			public LongWeightedElementGenerator(IRandom random, IList<TElement> list, long[] weights)
			{
			}

			public LongWeightedElementGenerator(IRandom random, IList<TElement> list, int elementCount, long[] weights)
			{
			}

			public LongWeightedElementGenerator(IRandom random, IList<TElement> list, Func<int, long> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class ULongWeightedIndexGenerator : WeightedIndexGenerator<ulong, ulong, ulong>
		{
			public ULongWeightedIndexGenerator(IRandom random, int elementCount, ulong[] weights)
			{
			}

			public ULongWeightedIndexGenerator(IRandom random, int elementCount, Func<int, ulong> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class ULongWeightedElementGenerator<TElement> : WeightedElementGenerator<TElement, ulong, ulong, ulong>
		{
			public ULongWeightedElementGenerator(IRandom random, IList<TElement> list, ulong[] weights)
			{
			}

			public ULongWeightedElementGenerator(IRandom random, IList<TElement> list, int elementCount, ulong[] weights)
			{
			}

			public ULongWeightedElementGenerator(IRandom random, IList<TElement> list, Func<int, ulong> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class FloatWeightedIndexGenerator : WeightedIndexGenerator<float, float, uint>
		{
			public FloatWeightedIndexGenerator(IRandom random, int elementCount, float[] weights)
			{
			}

			public FloatWeightedIndexGenerator(IRandom random, int elementCount, Func<int, float> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class FloatWeightedElementGenerator<TElement> : WeightedElementGenerator<TElement, float, float, uint>
		{
			public FloatWeightedElementGenerator(IRandom random, IList<TElement> list, float[] weights)
			{
			}

			public FloatWeightedElementGenerator(IRandom random, IList<TElement> list, int elementCount, float[] weights)
			{
			}

			public FloatWeightedElementGenerator(IRandom random, IList<TElement> list, Func<int, float> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class DoubleWeightedIndexGenerator : WeightedIndexGenerator<double, double, ulong>
		{
			public DoubleWeightedIndexGenerator(IRandom random, int elementCount, double[] weights)
			{
			}

			public DoubleWeightedIndexGenerator(IRandom random, int elementCount, Func<int, double> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private class DoubleWeightedElementGenerator<TElement> : WeightedElementGenerator<TElement, double, double, ulong>
		{
			public DoubleWeightedElementGenerator(IRandom random, IList<TElement> list, double[] weights)
			{
			}

			public DoubleWeightedElementGenerator(IRandom random, IList<TElement> list, int elementCount, double[] weights)
			{
			}

			public DoubleWeightedElementGenerator(IRandom random, IList<TElement> list, Func<int, double> weightsAccessor)
			{
			}

			public override int NextIndex()
			{
				return 0;
			}

			protected override void SumWeights()
			{
			}
		}

		private static int SumWeights(int elementCount, sbyte[] weights)
		{
			return 0;
		}

		private static int SumWeights(int elementCount, sbyte[] weights, int[] cumulativeWeightSums)
		{
			return 0;
		}

		private static int SumWeights(int elementCount, Func<int, sbyte> weightsAccessor)
		{
			return 0;
		}

		private static uint SumWeights(int elementCount, byte[] weights)
		{
			return 0u;
		}

		private static uint SumWeights(int elementCount, byte[] weights, uint[] cumulativeWeightSums)
		{
			return 0u;
		}

		private static uint SumWeights(int elementCount, Func<int, byte> weightsAccessor)
		{
			return 0u;
		}

		private static int SumWeights(int elementCount, short[] weights)
		{
			return 0;
		}

		private static int SumWeights(int elementCount, short[] weights, int[] cumulativeWeightSums)
		{
			return 0;
		}

		private static int SumWeights(int elementCount, Func<int, short> weightsAccessor)
		{
			return 0;
		}

		private static uint SumWeights(int elementCount, ushort[] weights)
		{
			return 0u;
		}

		private static uint SumWeights(int elementCount, ushort[] weights, uint[] cumulativeWeightSums)
		{
			return 0u;
		}

		private static uint SumWeights(int elementCount, Func<int, ushort> weightsAccessor)
		{
			return 0u;
		}

		private static int SumWeights(int elementCount, int[] weights)
		{
			return 0;
		}

		private static int SumWeights(int elementCount, int[] weights, int[] cumulativeWeightSums)
		{
			return 0;
		}

		private static int SumWeights(int elementCount, Func<int, int> weightsAccessor)
		{
			return 0;
		}

		private static uint SumWeights(int elementCount, uint[] weights)
		{
			return 0u;
		}

		private static uint SumWeights(int elementCount, uint[] weights, uint[] cumulativeWeightSums)
		{
			return 0u;
		}

		private static uint SumWeights(int elementCount, Func<int, uint> weightsAccessor)
		{
			return 0u;
		}

		private static long SumWeights(int elementCount, long[] weights)
		{
			return 0L;
		}

		private static long SumWeights(int elementCount, long[] weights, long[] cumulativeWeightSums)
		{
			return 0L;
		}

		private static long SumWeights(int elementCount, Func<int, long> weightsAccessor)
		{
			return 0L;
		}

		private static ulong SumWeights(int elementCount, ulong[] weights)
		{
			return 0uL;
		}

		private static ulong SumWeights(int elementCount, ulong[] weights, ulong[] cumulativeWeightSums)
		{
			return 0uL;
		}

		private static ulong SumWeights(int elementCount, Func<int, ulong> weightsAccessor)
		{
			return 0uL;
		}

		private static float SumWeights(int elementCount, float[] weights)
		{
			return 0f;
		}

		private static float SumWeights(int elementCount, float[] weights, uint[] cumulativeWeightSums)
		{
			return 0f;
		}

		private static float SumWeights(int elementCount, Func<int, float> weightsAccessor)
		{
			return 0f;
		}

		private static double SumWeights(int elementCount, double[] weights)
		{
			return 0.0;
		}

		private static double SumWeights(int elementCount, double[] weights, ulong[] cumulativeWeightSums)
		{
			return 0.0;
		}

		private static double SumWeights(int elementCount, Func<int, double> weightsAccessor)
		{
			return 0.0;
		}

		public static int Index(this IRandom random, int length)
		{
			return 0;
		}

		public static uint Index(this IRandom random, uint length)
		{
			return 0u;
		}

		public static long Index(this IRandom random, long length)
		{
			return 0L;
		}

		public static ulong Index(this IRandom random, ulong length)
		{
			return 0uL;
		}

		public static int Index<TElement>(this IRandom random, IList<TElement> list)
		{
			return 0;
		}

		public static int RandomIndex<TElement>(this IList<TElement> list, IRandom random)
		{
			return 0;
		}

		public static TElement Element<TElement>(this IRandom random, IList<TElement> list)
		{
			return default(TElement);
		}

		public static TElement RandomElement<TElement>(this IList<TElement> list, IRandom random)
		{
			return default(TElement);
		}

		public static IRangeGenerator<int> MakeIndexGenerator(this IRandom random, int length)
		{
			return null;
		}

		public static IRangeGenerator<uint> MakeIndexGenerator(this IRandom random, uint length)
		{
			return null;
		}

		public static IRangeGenerator<long> MakeIndexGenerator(this IRandom random, long length)
		{
			return null;
		}

		public static IRangeGenerator<ulong> MakeIndexGenerator(this IRandom random, ulong length)
		{
			return null;
		}

		public static IRangeGenerator<int> MakeIndexGenerator<TElement>(this IRandom random, IList<TElement> list)
		{
			return null;
		}

		public static IElementGenerator<TElement> MakeElementGenerator<TElement>(this IRandom random, IList<TElement> list)
		{
			return null;
		}

		public static IRangeGenerator<int> MakeRandomIndexGenerator<TElement>(this IList<TElement> list, IRandom random)
		{
			return null;
		}

		public static IElementGenerator<TElement> MakeRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random)
		{
			return null;
		}

		public static int WeightedIndex(this IRandom random, sbyte[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, sbyte[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, sbyte[] weights, int weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, sbyte[] weights, int weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, sbyte> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, sbyte> weightsAccessor, int weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, sbyte[] weights)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, sbyte[] weights, int weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, sbyte> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, sbyte> weightsAccessor, int weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, byte[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, byte[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, byte[] weights, uint weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, byte[] weights, uint weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, byte> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, byte> weightsAccessor, uint weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, byte[] weights)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, byte[] weights, uint weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, byte> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, byte> weightsAccessor, uint weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, short[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, short[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, short[] weights, int weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, short[] weights, int weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, short> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, short> weightsAccessor, int weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, short[] weights)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, short[] weights, int weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, short> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, short> weightsAccessor, int weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, ushort[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, ushort[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, ushort[] weights, uint weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, ushort[] weights, uint weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, ushort> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, ushort> weightsAccessor, uint weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, ushort[] weights)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, ushort[] weights, uint weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, ushort> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, ushort> weightsAccessor, uint weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, int[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int[] weights, int weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, int[] weights, int weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, int> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, int> weightsAccessor, int weightSum)
		{
			return 0;
		}

		public static int WeightedIndexBinarySearch(this IRandom random, int[] cumulativeWeightSums, int weightSum)
		{
			return 0;
		}

		public static int WeightedIndexBinarySearch(this IRandom random, int elementCount, int[] cumulativeWeightSums, int weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, int[] weights)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, int[] weights, int weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, int> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, int> weightsAccessor, int weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndexBinarySearch<TElement>(this IList<TElement> list, IRandom random, int[] cumulativeWeightSums, int weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, uint[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, uint[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, uint[] weights, uint weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, uint[] weights, uint weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, uint> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, uint> weightsAccessor, uint weightSum)
		{
			return 0;
		}

		public static int WeightedIndexBinarySearch(this IRandom random, uint[] cumulativeWeightSums, uint weightSum)
		{
			return 0;
		}

		public static int WeightedIndexBinarySearch(this IRandom random, int elementCount, uint[] cumulativeWeightSums, uint weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, uint[] weights)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, uint[] weights, uint weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, uint> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, uint> weightsAccessor, uint weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndexBinarySearch<TElement>(this IList<TElement> list, IRandom random, uint[] cumulativeWeightSums, uint weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, long[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, long[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, long[] weights, long weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, long[] weights, long weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, long> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, long> weightsAccessor, long weightSum)
		{
			return 0;
		}

		public static int WeightedIndexBinarySearch(this IRandom random, long[] cumulativeWeightSums, long weightSum)
		{
			return 0;
		}

		public static int WeightedIndexBinarySearch(this IRandom random, int elementCount, long[] cumulativeWeightSums, long weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, long[] weights)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, long[] weights, long weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, long> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, long> weightsAccessor, long weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndexBinarySearch<TElement>(this IList<TElement> list, IRandom random, long[] cumulativeWeightSums, long weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, ulong[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, ulong[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, ulong[] weights, ulong weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, ulong[] weights, ulong weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, ulong> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, ulong> weightsAccessor, ulong weightSum)
		{
			return 0;
		}

		public static int WeightedIndexBinarySearch(this IRandom random, ulong[] cumulativeWeightSums, ulong weightSum)
		{
			return 0;
		}

		public static int WeightedIndexBinarySearch(this IRandom random, int elementCount, ulong[] cumulativeWeightSums, ulong weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, ulong[] weights)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, ulong[] weights, ulong weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, ulong> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, ulong> weightsAccessor, ulong weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndexBinarySearch<TElement>(this IList<TElement> list, IRandom random, ulong[] cumulativeWeightSums, ulong weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, float[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, float[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, float[] weights, float weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, float[] weights, float weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, float> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, float> weightsAccessor, float weightSum)
		{
			return 0;
		}

		public static int WeightedIndexBinarySearch(this IRandom random, float[] cumulativeWeightSums, float weightSum)
		{
			return 0;
		}

		public static int WeightedIndexBinarySearch(this IRandom random, int elementCount, float[] cumulativeWeightSums, float weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, float[] weights)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, float[] weights, float weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, float> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, float> weightsAccessor, float weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndexBinarySearch<TElement>(this IList<TElement> list, IRandom random, float[] cumulativeWeightSums, float weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, double[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, double[] weights)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, double[] weights, double weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, double[] weights, double weightSum)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, double> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedIndex(this IRandom random, int elementCount, Func<int, double> weightsAccessor, double weightSum)
		{
			return 0;
		}

		public static int WeightedIndexBinarySearch(this IRandom random, double[] cumulativeWeightSums, double weightSum)
		{
			return 0;
		}

		public static int WeightedIndexBinarySearch(this IRandom random, int elementCount, double[] cumulativeWeightSums, double weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, double[] weights)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, double[] weights, double weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, double> weightsAccessor)
		{
			return 0;
		}

		public static int WeightedRandomIndex<TElement>(this IList<TElement> list, IRandom random, Func<int, double> weightsAccessor, double weightSum)
		{
			return 0;
		}

		public static int WeightedRandomIndexBinarySearch<TElement>(this IList<TElement> list, IRandom random, double[] cumulativeWeightSums, double weightSum)
		{
			return 0;
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, sbyte[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, sbyte[] weights, int weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, sbyte> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, sbyte> weightsAccessor, int weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, sbyte[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, sbyte[] weights, int weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, sbyte> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, sbyte> weightsAccessor, int weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, byte[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, byte[] weights, uint weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, byte> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, byte> weightsAccessor, uint weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, byte[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, byte[] weights, uint weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, byte> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, byte> weightsAccessor, uint weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, short[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, short[] weights, int weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, short> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, short> weightsAccessor, int weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, short[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, short[] weights, int weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, short> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, short> weightsAccessor, int weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, ushort[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, ushort[] weights, uint weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, ushort> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, ushort> weightsAccessor, uint weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, ushort[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, ushort[] weights, uint weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, ushort> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, ushort> weightsAccessor, uint weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, int[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, int[] weights, int weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, int> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, int> weightsAccessor, int weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElementBinarySearch<TElement>(this IRandom random, IList<TElement> list, int[] cumulativeWeightSums, int weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, int[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, int[] weights, int weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, int> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, int> weightsAccessor, int weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElementBinarySearch<TElement>(this IList<TElement> list, IRandom random, int[] cumulativeWeightSums, int weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, uint[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, uint[] weights, uint weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, uint> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, uint> weightsAccessor, uint weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElementBinarySearch<TElement>(this IRandom random, IList<TElement> list, uint[] cumulativeWeightSums, uint weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, uint[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, uint[] weights, uint weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, uint> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, uint> weightsAccessor, uint weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElementBinarySearch<TElement>(this IList<TElement> list, IRandom random, uint[] cumulativeWeightSums, uint weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, long[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, long[] weights, long weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, long> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, long> weightsAccessor, long weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElementBinarySearch<TElement>(this IRandom random, IList<TElement> list, long[] cumulativeWeightSums, long weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, long[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, long[] weights, long weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, long> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, long> weightsAccessor, long weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElementBinarySearch<TElement>(this IList<TElement> list, IRandom random, long[] cumulativeWeightSums, long weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, ulong[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, ulong[] weights, ulong weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, ulong> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, ulong> weightsAccessor, ulong weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElementBinarySearch<TElement>(this IRandom random, IList<TElement> list, ulong[] cumulativeWeightSums, ulong weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, ulong[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, ulong[] weights, ulong weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, ulong> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, ulong> weightsAccessor, ulong weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElementBinarySearch<TElement>(this IList<TElement> list, IRandom random, ulong[] cumulativeWeightSums, ulong weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, float[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, float[] weights, float weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, float> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, float> weightsAccessor, float weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElementBinarySearch<TElement>(this IRandom random, IList<TElement> list, float[] cumulativeWeightSums, float weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, float[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, float[] weights, float weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, float> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, float> weightsAccessor, float weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElementBinarySearch<TElement>(this IList<TElement> list, IRandom random, float[] cumulativeWeightSums, float weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, double[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, double[] weights, double weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, double> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedElement<TElement>(this IRandom random, IList<TElement> list, Func<int, double> weightsAccessor, double weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedElementBinarySearch<TElement>(this IRandom random, IList<TElement> list, double[] cumulativeWeightSums, double weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, double[] weights)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, double[] weights, double weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, double> weightsAccessor)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElement<TElement>(this IList<TElement> list, IRandom random, Func<int, double> weightsAccessor, double weightSum)
		{
			return default(TElement);
		}

		public static TElement WeightedRandomElementBinarySearch<TElement>(this IList<TElement> list, IRandom random, double[] cumulativeWeightSums, double weightSum)
		{
			return default(TElement);
		}

		public static IWeightedIndexGenerator<sbyte, int> MakeWeightedIndexGenerator(this IRandom random, sbyte[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<sbyte, int> MakeWeightedIndexGenerator(this IRandom random, int elementCount, sbyte[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<sbyte, int> MakeWeightedIndexGenerator(this IRandom random, int elementCount, Func<int, sbyte> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, sbyte, int> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, sbyte[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, sbyte, int> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, int elementCount, sbyte[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, sbyte, int> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, Func<int, sbyte> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, sbyte, int> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, sbyte[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, sbyte, int> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, Func<int, sbyte> weightsAccessor)
		{
			return null;
		}

		public static IWeightedIndexGenerator<byte, uint> MakeWeightedIndexGenerator(this IRandom random, byte[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<byte, uint> MakeWeightedIndexGenerator(this IRandom random, int elementCount, byte[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<byte, uint> MakeWeightedIndexGenerator(this IRandom random, int elementCount, Func<int, byte> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, byte, uint> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, byte[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, byte, uint> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, int elementCount, byte[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, byte, uint> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, Func<int, byte> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, byte, uint> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, byte[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, byte, uint> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, Func<int, byte> weightsAccessor)
		{
			return null;
		}

		public static IWeightedIndexGenerator<short, int> MakeWeightedIndexGenerator(this IRandom random, short[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<short, int> MakeWeightedIndexGenerator(this IRandom random, int elementCount, short[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<short, int> MakeWeightedIndexGenerator(this IRandom random, int elementCount, Func<int, short> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, short, int> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, short[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, short, int> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, int elementCount, short[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, short, int> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, Func<int, short> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, short, int> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, short[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, short, int> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, Func<int, short> weightsAccessor)
		{
			return null;
		}

		public static IWeightedIndexGenerator<ushort, uint> MakeWeightedIndexGenerator(this IRandom random, ushort[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<ushort, uint> MakeWeightedIndexGenerator(this IRandom random, int elementCount, ushort[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<ushort, uint> MakeWeightedIndexGenerator(this IRandom random, int elementCount, Func<int, ushort> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, ushort, uint> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, ushort[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, ushort, uint> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, int elementCount, ushort[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, ushort, uint> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, Func<int, ushort> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, ushort, uint> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, ushort[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, ushort, uint> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, Func<int, ushort> weightsAccessor)
		{
			return null;
		}

		public static IWeightedIndexGenerator<int, int> MakeWeightedIndexGenerator(this IRandom random, int[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<int, int> MakeWeightedIndexGenerator(this IRandom random, int elementCount, int[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<int, int> MakeWeightedIndexGenerator(this IRandom random, int elementCount, Func<int, int> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, int, int> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, int[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, int, int> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, int elementCount, int[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, int, int> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, Func<int, int> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, int, int> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, int[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, int, int> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, Func<int, int> weightsAccessor)
		{
			return null;
		}

		public static IWeightedIndexGenerator<uint, uint> MakeWeightedIndexGenerator(this IRandom random, uint[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<uint, uint> MakeWeightedIndexGenerator(this IRandom random, int elementCount, uint[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<uint, uint> MakeWeightedIndexGenerator(this IRandom random, int elementCount, Func<int, uint> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, uint, uint> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, uint[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, uint, uint> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, int elementCount, uint[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, uint, uint> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, Func<int, uint> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, uint, uint> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, uint[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, uint, uint> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, Func<int, uint> weightsAccessor)
		{
			return null;
		}

		public static IWeightedIndexGenerator<long, long> MakeWeightedIndexGenerator(this IRandom random, long[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<long, long> MakeWeightedIndexGenerator(this IRandom random, int elementCount, long[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<long, long> MakeWeightedIndexGenerator(this IRandom random, int elementCount, Func<int, long> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, long, long> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, long[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, long, long> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, int elementCount, long[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, long, long> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, Func<int, long> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, long, long> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, long[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, long, long> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, Func<int, long> weightsAccessor)
		{
			return null;
		}

		public static IWeightedIndexGenerator<ulong, ulong> MakeWeightedIndexGenerator(this IRandom random, ulong[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<ulong, ulong> MakeWeightedIndexGenerator(this IRandom random, int elementCount, ulong[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<ulong, ulong> MakeWeightedIndexGenerator(this IRandom random, int elementCount, Func<int, ulong> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, ulong, ulong> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, ulong[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, ulong, ulong> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, int elementCount, ulong[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, ulong, ulong> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, Func<int, ulong> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, ulong, ulong> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, ulong[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, ulong, ulong> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, Func<int, ulong> weightsAccessor)
		{
			return null;
		}

		public static IWeightedIndexGenerator<float, float> MakeWeightedIndexGenerator(this IRandom random, float[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<float, float> MakeWeightedIndexGenerator(this IRandom random, int elementCount, float[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<float, float> MakeWeightedIndexGenerator(this IRandom random, int elementCount, Func<int, float> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, float, float> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, float[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, float, float> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, int elementCount, float[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, float, float> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, Func<int, float> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, float, float> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, float[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, float, float> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, Func<int, float> weightsAccessor)
		{
			return null;
		}

		public static IWeightedIndexGenerator<double, double> MakeWeightedIndexGenerator(this IRandom random, double[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<double, double> MakeWeightedIndexGenerator(this IRandom random, int elementCount, double[] weights)
		{
			return null;
		}

		public static IWeightedIndexGenerator<double, double> MakeWeightedIndexGenerator(this IRandom random, int elementCount, Func<int, double> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, double, double> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, double[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, double, double> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, int elementCount, double[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, double, double> MakeWeightedElementGenerator<TElement>(this IRandom random, IList<TElement> list, Func<int, double> weightsAccessor)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, double, double> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, double[] weights)
		{
			return null;
		}

		public static IWeightedElementGenerator<TElement, double, double> MakeWeightedRandomElementGenerator<TElement>(this IList<TElement> list, IRandom random, Func<int, double> weightsAccessor)
		{
			return null;
		}
	}
}
