using System;

namespace MakeIt.Random
{
	public static class RandomEnum
	{
		private abstract class ByValueEnumGeneratorBase<TEnum> : IEnumGenerator<TEnum> where TEnum : struct
		{
			protected TEnum[] _values;

			public ByValueEnumGeneratorBase()
			{
			}

			public abstract TEnum Next();

			public abstract string NextName();

			public abstract TEnum Next(out string name);
		}

		private class ByValueEnumGenerator<TEnum> : ByValueEnumGeneratorBase<TEnum>, IEnumGenerator<TEnum> where TEnum : struct
		{
			private IRangeGenerator<int> _indexGenerator;

			public ByValueEnumGenerator(IRandom random)
			{
			}

			public override TEnum Next()
			{
				return default(TEnum);
			}

			public override string NextName()
			{
				return null;
			}

			public override TEnum Next(out string name)
			{
				name = null;
				return default(TEnum);
			}
		}

		private abstract class ByValueWeightedEnumGenerator<TEnum, TWeight, TWeightSum> : ByValueEnumGeneratorBase<TEnum> where TEnum : struct
		{
			protected IWeightedIndexGenerator<TWeight, TWeightSum> _indexGenerator;

			public override TEnum Next()
			{
				return default(TEnum);
			}

			public override string NextName()
			{
				return null;
			}

			public override TEnum Next(out string name)
			{
				name = null;
				return default(TEnum);
			}
		}

		private class ByValueSByteWeightedEnumGenerator<TEnum> : ByValueWeightedEnumGenerator<TEnum, sbyte, int> where TEnum : struct
		{
			public ByValueSByteWeightedEnumGenerator(IRandom random, Func<TEnum, sbyte> weightsAccessor)
			{
			}
		}

		private class ByValueByteWeightedEnumGenerator<TEnum> : ByValueWeightedEnumGenerator<TEnum, byte, uint> where TEnum : struct
		{
			public ByValueByteWeightedEnumGenerator(IRandom random, Func<TEnum, byte> weightsAccessor)
			{
			}
		}

		private class ByValueShortWeightedEnumGenerator<TEnum> : ByValueWeightedEnumGenerator<TEnum, short, int> where TEnum : struct
		{
			public ByValueShortWeightedEnumGenerator(IRandom random, Func<TEnum, short> weightsAccessor)
			{
			}
		}

		private class ByValueUShortWeightedEnumGenerator<TEnum> : ByValueWeightedEnumGenerator<TEnum, ushort, uint> where TEnum : struct
		{
			public ByValueUShortWeightedEnumGenerator(IRandom random, Func<TEnum, ushort> weightsAccessor)
			{
			}
		}

		private class ByValueIntWeightedEnumGenerator<TEnum> : ByValueWeightedEnumGenerator<TEnum, int, int> where TEnum : struct
		{
			public ByValueIntWeightedEnumGenerator(IRandom random, Func<TEnum, int> weightsAccessor)
			{
			}
		}

		private class ByValueUIntWeightedEnumGenerator<TEnum> : ByValueWeightedEnumGenerator<TEnum, uint, uint> where TEnum : struct
		{
			public ByValueUIntWeightedEnumGenerator(IRandom random, Func<TEnum, uint> weightsAccessor)
			{
			}
		}

		private class ByValueLongWeightedEnumGenerator<TEnum> : ByValueWeightedEnumGenerator<TEnum, long, long> where TEnum : struct
		{
			public ByValueLongWeightedEnumGenerator(IRandom random, Func<TEnum, long> weightsAccessor)
			{
			}
		}

		private class ByValueULongWeightedEnumGenerator<TEnum> : ByValueWeightedEnumGenerator<TEnum, ulong, ulong> where TEnum : struct
		{
			public ByValueULongWeightedEnumGenerator(IRandom random, Func<TEnum, ulong> weightsAccessor)
			{
			}
		}

		private class ByValueFloatWeightedEnumGenerator<TEnum> : ByValueWeightedEnumGenerator<TEnum, float, float> where TEnum : struct
		{
			public ByValueFloatWeightedEnumGenerator(IRandom random, Func<TEnum, float> weightsAccessor)
			{
			}
		}

		private class ByValueDoubleWeightedEnumGenerator<TEnum> : ByValueWeightedEnumGenerator<TEnum, double, double> where TEnum : struct
		{
			public ByValueDoubleWeightedEnumGenerator(IRandom random, Func<TEnum, double> weightsAccessor)
			{
			}
		}

		private abstract class ByNameEnumGeneratorBase<TEnum> : IEnumGenerator<TEnum> where TEnum : struct
		{
			protected TEnum[] _values;

			protected string[] _names;

			public ByNameEnumGeneratorBase()
			{
			}

			public abstract TEnum Next();

			public abstract string NextName();

			public abstract TEnum Next(out string name);
		}

		private class ByNameEnumGenerator<TEnum> : ByNameEnumGeneratorBase<TEnum> where TEnum : struct
		{
			private IRangeGenerator<int> _indexGenerator;

			public ByNameEnumGenerator(IRandom random)
			{
			}

			public override TEnum Next()
			{
				return default(TEnum);
			}

			public override string NextName()
			{
				return null;
			}

			public override TEnum Next(out string name)
			{
				name = null;
				return default(TEnum);
			}
		}

		private abstract class ByNameWeightedEnumGenerator<TEnum, TWeight, TWeightSum> : ByNameEnumGeneratorBase<TEnum> where TEnum : struct
		{
			protected IWeightedIndexGenerator<TWeight, TWeightSum> _indexGenerator;

			public override TEnum Next()
			{
				return default(TEnum);
			}

			public override string NextName()
			{
				return null;
			}

			public override TEnum Next(out string name)
			{
				name = null;
				return default(TEnum);
			}
		}

		private class ByNameSByteWeightedEnumGenerator<TEnum> : ByNameWeightedEnumGenerator<TEnum, sbyte, int> where TEnum : struct
		{
			public ByNameSByteWeightedEnumGenerator(IRandom random, Func<string, sbyte> weightsAccessor)
			{
			}
		}

		private class ByNameByteWeightedEnumGenerator<TEnum> : ByNameWeightedEnumGenerator<TEnum, byte, uint> where TEnum : struct
		{
			public ByNameByteWeightedEnumGenerator(IRandom random, Func<string, byte> weightsAccessor)
			{
			}
		}

		private class ByNameShortWeightedEnumGenerator<TEnum> : ByNameWeightedEnumGenerator<TEnum, short, int> where TEnum : struct
		{
			public ByNameShortWeightedEnumGenerator(IRandom random, Func<string, short> weightsAccessor)
			{
			}
		}

		private class ByNameUShortWeightedEnumGenerator<TEnum> : ByNameWeightedEnumGenerator<TEnum, ushort, uint> where TEnum : struct
		{
			public ByNameUShortWeightedEnumGenerator(IRandom random, Func<string, ushort> weightsAccessor)
			{
			}
		}

		private class ByNameIntWeightedEnumGenerator<TEnum> : ByNameWeightedEnumGenerator<TEnum, int, int> where TEnum : struct
		{
			public ByNameIntWeightedEnumGenerator(IRandom random, Func<string, int> weightsAccessor)
			{
			}
		}

		private class ByNameUIntWeightedEnumGenerator<TEnum> : ByNameWeightedEnumGenerator<TEnum, uint, uint> where TEnum : struct
		{
			public ByNameUIntWeightedEnumGenerator(IRandom random, Func<string, uint> weightsAccessor)
			{
			}
		}

		private class ByNameLongWeightedEnumGenerator<TEnum> : ByNameWeightedEnumGenerator<TEnum, long, long> where TEnum : struct
		{
			public ByNameLongWeightedEnumGenerator(IRandom random, Func<string, long> weightsAccessor)
			{
			}
		}

		private class ByNameULongWeightedEnumGenerator<TEnum> : ByNameWeightedEnumGenerator<TEnum, ulong, ulong> where TEnum : struct
		{
			public ByNameULongWeightedEnumGenerator(IRandom random, Func<string, ulong> weightsAccessor)
			{
			}
		}

		private class ByNameFloatWeightedEnumGenerator<TEnum> : ByNameWeightedEnumGenerator<TEnum, float, float> where TEnum : struct
		{
			public ByNameFloatWeightedEnumGenerator(IRandom random, Func<string, float> weightsAccessor)
			{
			}
		}

		private class ByNameDoubleWeightedEnumGenerator<TEnum> : ByNameWeightedEnumGenerator<TEnum, double, double> where TEnum : struct
		{
			public ByNameDoubleWeightedEnumGenerator(IRandom random, Func<string, double> weightsAccessor)
			{
			}
		}

		public static IEnumGenerator<TEnum> MakeEnumGenerator<TEnum>(this IRandom random, bool byName = false) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<TEnum, sbyte> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<string, sbyte> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<TEnum, byte> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<string, byte> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<TEnum, short> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<string, short> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<TEnum, ushort> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<string, ushort> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<TEnum, int> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<string, int> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<TEnum, uint> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<string, uint> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<TEnum, long> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<string, long> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<TEnum, ulong> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<string, ulong> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<TEnum, float> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<string, float> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<TEnum, double> weightsAccessor) where TEnum : struct
		{
			return null;
		}

		public static IEnumGenerator<TEnum> MakeWeightedEnumGenerator<TEnum>(this IRandom random, Func<string, double> weightsAccessor) where TEnum : struct
		{
			return null;
		}
	}
}
