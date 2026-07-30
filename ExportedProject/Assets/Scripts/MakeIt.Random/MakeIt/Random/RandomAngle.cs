using System;

namespace MakeIt.Random
{
	public static class RandomAngle
	{
		private class AngleGenerator : IRangeGenerator<float>
		{
			private IRangeGenerator<float> _rangeGenerator;

			private float _scale;

			private AngleGenerator(IRangeGenerator<float> rangeGenerator, float scale)
			{
			}

			public static AngleGenerator CreateOO(IRandom random, float scale)
			{
				return null;
			}

			public static AngleGenerator CreateSignedOO(IRandom random, float scale)
			{
				return null;
			}

			public static AngleGenerator CreateCO(IRandom random, float scale)
			{
				return null;
			}

			public static AngleGenerator CreateSignedCO(IRandom random, float scale)
			{
				return null;
			}

			public static AngleGenerator CreateOC(IRandom random, float scale)
			{
				return null;
			}

			public static AngleGenerator CreateSignedOC(IRandom random, float scale)
			{
				return null;
			}

			public static AngleGenerator CreateCC(IRandom random, float scale)
			{
				return null;
			}

			public static AngleGenerator CreateSignedCC(IRandom random, float scale)
			{
				return null;
			}

			public float Next()
			{
				return 0f;
			}
		}

		private const float _floatDegreesPerTurn = 360f;

		private const float _floatDegreesPerHalfTurn = 180f;

		private const float _floatDegreesPerQuarterTurn = 90f;

		private const float _floatRadiansPerTurn = (float)Math.PI * 2f;

		private const float _floatRadiansPerHalfTurn = (float)Math.PI;

		private const float _floatRadiansPerQuarterTurn = (float)Math.PI / 2f;

		public static float AngleDegOO(this IRandom random)
		{
			return 0f;
		}

		public static float SignedAngleDegOO(this IRandom random)
		{
			return 0f;
		}

		public static float HalfAngleDegOO(this IRandom random)
		{
			return 0f;
		}

		public static float SignedHalfAngleDegOO(this IRandom random)
		{
			return 0f;
		}

		public static IRangeGenerator<float> MakeAngleDegOOGenerator(this IRandom random, bool signed = false, bool half = false)
		{
			return null;
		}

		public static float AngleRadOO(this IRandom random)
		{
			return 0f;
		}

		public static float SignedAngleRadOO(this IRandom random)
		{
			return 0f;
		}

		public static float HalfAngleRadOO(this IRandom random)
		{
			return 0f;
		}

		public static float SignedHalfAngleRadOO(this IRandom random)
		{
			return 0f;
		}

		public static IRangeGenerator<float> MakeAngleRadOOGenerator(this IRandom random, bool signed = false, bool half = false)
		{
			return null;
		}

		public static float AngleDegCO(this IRandom random)
		{
			return 0f;
		}

		public static float SignedAngleDegCO(this IRandom random)
		{
			return 0f;
		}

		public static float HalfAngleDegCO(this IRandom random)
		{
			return 0f;
		}

		public static float SignedHalfAngleDegCO(this IRandom random)
		{
			return 0f;
		}

		public static IRangeGenerator<float> MakeAngleDegCOGenerator(this IRandom random, bool signed = false, bool half = false)
		{
			return null;
		}

		public static float AngleRadCO(this IRandom random)
		{
			return 0f;
		}

		public static float SignedAngleRadCO(this IRandom random)
		{
			return 0f;
		}

		public static float HalfAngleRadCO(this IRandom random)
		{
			return 0f;
		}

		public static float SignedHalfAngleRadCO(this IRandom random)
		{
			return 0f;
		}

		public static IRangeGenerator<float> MakeAngleRadCOGenerator(this IRandom random, bool signed = false, bool half = false)
		{
			return null;
		}

		public static float AngleDegOC(this IRandom random)
		{
			return 0f;
		}

		public static float SignedAngleDegOC(this IRandom random)
		{
			return 0f;
		}

		public static float HalfAngleDegOC(this IRandom random)
		{
			return 0f;
		}

		public static float SignedHalfAngleDegOC(this IRandom random)
		{
			return 0f;
		}

		public static IRangeGenerator<float> MakeAngleDegOCGenerator(this IRandom random, bool signed = false, bool half = false)
		{
			return null;
		}

		public static float AngleRadOC(this IRandom random)
		{
			return 0f;
		}

		public static float SignedAngleRadOC(this IRandom random)
		{
			return 0f;
		}

		public static float HalfAngleRadOC(this IRandom random)
		{
			return 0f;
		}

		public static float SignedHalfAngleRadOC(this IRandom random)
		{
			return 0f;
		}

		public static IRangeGenerator<float> MakeAngleRadOCGenerator(this IRandom random, bool signed = false, bool half = false)
		{
			return null;
		}

		public static float AngleDegCC(this IRandom random)
		{
			return 0f;
		}

		public static float SignedAngleDegCC(this IRandom random)
		{
			return 0f;
		}

		public static float HalfAngleDegCC(this IRandom random)
		{
			return 0f;
		}

		public static float SignedHalfAngleDegCC(this IRandom random)
		{
			return 0f;
		}

		public static IRangeGenerator<float> MakeAngleDegCCGenerator(this IRandom random, bool signed = false, bool half = false)
		{
			return null;
		}

		public static float AngleRadCC(this IRandom random)
		{
			return 0f;
		}

		public static float SignedAngleRadCC(this IRandom random)
		{
			return 0f;
		}

		public static float HalfAngleRadCC(this IRandom random)
		{
			return 0f;
		}

		public static float SignedHalfAngleRadCC(this IRandom random)
		{
			return 0f;
		}

		public static IRangeGenerator<float> MakeAngleRadCCGenerator(this IRandom random, bool signed = false, bool half = false)
		{
			return null;
		}
	}
}
