using System;

namespace MakeIt.Random.Detail
{
	public static class Distributions
	{
		public struct FloatZigguratSegment
		{
			public uint n;

			public float s;

			public FloatZigguratSegment(uint n, float s)
			{
				this.n = 0u;
				this.s = 0f;
			}
		}

		public struct DoubleZigguratSegment
		{
			public ulong n;

			public double s;

			public DoubleZigguratSegment(ulong n, double s)
			{
				this.n = 0uL;
				this.s = 0.0;
			}
		}

		public class OneSidedFloatZigguratTable
		{
			public FloatZigguratSegment[] segments;

			public float[] segmentUpperBounds;

			public uint mask;

			public int shift;

			public OneSidedFloatZigguratTable(FloatZigguratSegment[] segments, float[] segmentUpperBounds, uint mask, int shift)
			{
			}
		}

		public class OneSidedDoubleZigguratTable
		{
			public DoubleZigguratSegment[] segments;

			public double[] segmentUpperBounds;

			public ulong mask;

			public int shift;

			public OneSidedDoubleZigguratTable(DoubleZigguratSegment[] segments, double[] segmentUpperBounds, ulong mask, int shift)
			{
			}
		}

		public class TwoSidedSymmetricFloatZigguratTable
		{
			public FloatZigguratSegment[] segments;

			public float[] segmentUpperBounds;

			public int threshold;

			public int mask;

			public int shift;

			public TwoSidedSymmetricFloatZigguratTable(FloatZigguratSegment[] segments, float[] segmentUpperBounds, int threshold, int mask, int shift)
			{
			}
		}

		public class TwoSidedSymmetricDoubleZigguratTable
		{
			public DoubleZigguratSegment[] segments;

			public double[] segmentUpperBounds;

			public long threshold;

			public long mask;

			public int shift;

			public TwoSidedSymmetricDoubleZigguratTable(DoubleZigguratSegment[] segments, double[] segmentUpperBounds, long threshold, long mask, int shift)
			{
			}
		}

		public static class NormalFloat
		{
			public static readonly TwoSidedSymmetricFloatZigguratTable zigguratTable;

			public static float F(float x)
			{
				return 0f;
			}

			public static float SampleFallback(IRandom random, float xMin)
			{
				return 0f;
			}

			public static float Sample(IRandom random, TwoSidedSymmetricFloatZigguratTable ziggurat)
			{
				return 0f;
			}
		}

		public static class NormalDouble
		{
			public static readonly TwoSidedSymmetricDoubleZigguratTable zigguratTable;

			public static double F(double x)
			{
				return 0.0;
			}

			public static double Inv(double y)
			{
				return 0.0;
			}

			public static double CDF(double x)
			{
				return 0.0;
			}

			public static double SampleFallback(IRandom random, double xMin)
			{
				return 0.0;
			}

			public static double Sample(IRandom random, TwoSidedSymmetricDoubleZigguratTable ziggurat)
			{
				return 0.0;
			}
		}

		public static class ExponentialFloat
		{
			public static readonly OneSidedFloatZigguratTable zigguratTable;

			public static float F(float x)
			{
				return 0f;
			}

			public static float SampleFallback(IRandom random, float xMin)
			{
				return 0f;
			}

			public static float Sample(IRandom random, OneSidedFloatZigguratTable ziggurat)
			{
				return 0f;
			}
		}

		public static class ExponentialDouble
		{
			public static readonly OneSidedDoubleZigguratTable zigguratTable;

			public static double F(double x)
			{
				return 0.0;
			}

			public static double Inv(double y)
			{
				return 0.0;
			}

			public static double CDF(double x)
			{
				return 0.0;
			}

			public static double SampleFallback(IRandom random, double xMin)
			{
				return 0.0;
			}

			public static double Sample(IRandom random, OneSidedDoubleZigguratTable ziggurat)
			{
				return 0.0;
			}
		}

		public static OneSidedFloatZigguratTable GenerateOneSidedFloatZigguratTable(int tableSizeMagnitidue, Func<double, double> f, Func<double, double> fInv, Func<double, double> fCDF, double totalArea, double acceptableError)
		{
			return null;
		}

		public static OneSidedDoubleZigguratTable GenerateOneSidedDoubleZigguratTable(int tableSizeMagnitidue, Func<double, double> f, Func<double, double> fInv, Func<double, double> fCDF, double totalArea, double acceptableError)
		{
			return null;
		}

		public static TwoSidedSymmetricFloatZigguratTable GenerateTwoSidedSymmetricFloatZigguratTable(int tableSizeMagnitidue, Func<double, double> f, Func<double, double> fInv, Func<double, double> fCDF, double totalArea, double acceptableError)
		{
			return null;
		}

		public static TwoSidedSymmetricDoubleZigguratTable GenerateTwoSidedSymmetricDoubleZigguratTable(int tableSizeMagnitidue, Func<double, double> f, Func<double, double> fInv, Func<double, double> fCDF, double totalArea, double acceptableError)
		{
			return null;
		}

		private static double[] GenerateZigguratTableXValues(int segmentCount, Func<double, double> f, Func<double, double> fInv, Func<double, double> fCDF, double totalArea, double activeArea, double acceptableError)
		{
			return null;
		}

		private static double CalculateZigguratTableError(double r, int segmentCount, Func<double, double> f, Func<double, double> fInv, Func<double, double> fCDF, double totalArea, double[] x)
		{
			return 0.0;
		}
	}
}
