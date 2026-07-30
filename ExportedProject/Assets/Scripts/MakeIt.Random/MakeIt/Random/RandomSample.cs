using MakeIt.Random.Detail;
using UnityEngine;

namespace MakeIt.Random
{
	public static class RandomSample
	{
		private class FloatUniformSampleGenerator : ISampleGenerator<float>
		{
			private IRandom _random;

			private float _x0;

			private float _range;

			public FloatUniformSampleGenerator(IRandom random, float x0, float x1)
			{
			}

			public float Next()
			{
				return 0f;
			}
		}

		private class DoubleUniformSampleGenerator : ISampleGenerator<double>
		{
			private IRandom _random;

			private double _x0;

			private double _range;

			public DoubleUniformSampleGenerator(IRandom random, double x0, double x1)
			{
			}

			public double Next()
			{
				return 0.0;
			}
		}

		private class FloatTriangularSampleGenerator : ISampleGenerator<float>
		{
			private IRandom _random;

			private float _split;

			private float _x0;

			private float _x1;

			private float _rangeLowerRange;

			private float _rangeUpperRange;

			public FloatTriangularSampleGenerator(IRandom random, float x0, float x1, float x2)
			{
			}

			public float Next()
			{
				return 0f;
			}
		}

		private class DoubleTriangularSampleGenerator : ISampleGenerator<double>
		{
			private IRandom _random;

			private double _split;

			private double _x0;

			private double _x2;

			private double _rangeLowerRange;

			private double _rangeUpperRange;

			public DoubleTriangularSampleGenerator(IRandom random, double x0, double x1, double x2)
			{
			}

			public double Next()
			{
				return 0.0;
			}
		}

		private class FloatTrapezoidalSampleGenerator : ISampleGenerator<float>
		{
			private IRandom _random;

			private float _lowerSplit;

			private float _upperSplit;

			private float _x0;

			private float _x1;

			private float _x3;

			private float _rangeLowerRange;

			private float _rangeUpperRange;

			private float _modeScale;

			public FloatTrapezoidalSampleGenerator(IRandom random, float x0, float x1, float x2, float x3)
			{
			}

			public float Next()
			{
				return 0f;
			}
		}

		private class DoubleTrapezoidalSampleGenerator : ISampleGenerator<double>
		{
			private IRandom _random;

			private double _lowerSplit;

			private double _upperSplit;

			private double _x0;

			private double _x1;

			private double _x3;

			private double _rangeLowerRange;

			private double _rangeUpperRange;

			private double _modeScale;

			public DoubleTrapezoidalSampleGenerator(IRandom random, double x0, double x1, double x2, double x3)
			{
			}

			public double Next()
			{
				return 0.0;
			}
		}

		private abstract class FloatLinearSampleGenerator : ISampleGenerator<float>
		{
			protected IRandom _random;

			protected float _a;

			protected float _aTimesFour;

			protected float _b;

			protected float _bSquared;

			protected float _c0;

			protected float _scaledArea;

			public static ISampleGenerator<float> Create(IRandom random, float x0, float y0, float x1, float y1)
			{
				return null;
			}

			public abstract float Next();
		}

		private class PositiveYInterceptFloatLinearSampleGenerator : FloatLinearSampleGenerator
		{
			public override float Next()
			{
				return 0f;
			}
		}

		private class NegativeYInterceptFloatLinearSampleGenerator : FloatLinearSampleGenerator
		{
			public override float Next()
			{
				return 0f;
			}
		}

		private abstract class DoubleLinearSampleGenerator : ISampleGenerator<double>
		{
			protected IRandom _random;

			protected double _a;

			protected double _aTimesFour;

			protected double _b;

			protected double _bSquared;

			protected double _c0;

			protected double _scaledArea;

			public static ISampleGenerator<double> Create(IRandom random, double x0, double y0, double x1, double y1)
			{
				return null;
			}

			public abstract double Next();
		}

		private class PositiveYInterceptDoubleLinearSampleGenerator : DoubleLinearSampleGenerator
		{
			public override double Next()
			{
				return 0.0;
			}
		}

		private class NegativeYInterceptDoubleLinearSampleGenerator : DoubleLinearSampleGenerator
		{
			public override double Next()
			{
				return 0.0;
			}
		}

		private class FloatHermiteSplineSampleGenerator : ISampleGenerator<float>
		{
			protected IRandom _random;

			protected float _xDelta;

			protected float _x0;

			protected float _k4;

			protected float _k3;

			protected float _k2;

			protected float _k1;

			protected float _area;

			public static ISampleGenerator<float> Create(IRandom random, float x0, float y0, float m0, float x1, float y1, float m1)
			{
				return null;
			}

			public float Next()
			{
				return 0f;
			}
		}

		private class DoubleHermiteSplineSampleGenerator : ISampleGenerator<double>
		{
			protected IRandom _random;

			protected double _xDelta;

			protected double _x0;

			protected double _k4;

			protected double _k3;

			protected double _k2;

			protected double _k1;

			protected double _area;

			public static ISampleGenerator<double> Create(IRandom random, double x0, double y0, double m0, double x1, double y1, double m1)
			{
				return null;
			}

			public double Next()
			{
				return 0.0;
			}
		}

		private class FloatNormalSampleGenerator : ISampleGenerator<float>
		{
			private IRandom _random;

			private float _mean;

			private float _standardDeviation;

			private Distributions.TwoSidedSymmetricFloatZigguratTable _zigguratTable;

			public FloatNormalSampleGenerator(IRandom random, float mean, float standardDeviation, Distributions.TwoSidedSymmetricFloatZigguratTable zigguratTable)
			{
			}

			public float Next()
			{
				return 0f;
			}
		}

		private class TruncatedFloatNormalSampleGenerator : ISampleGenerator<float>
		{
			private IRandom _random;

			private float _mean;

			private float _standardDeviation;

			private float _min;

			private float _max;

			private Distributions.TwoSidedSymmetricFloatZigguratTable _zigguratTable;

			public TruncatedFloatNormalSampleGenerator(IRandom random, float mean, float standardDeviation, float min, float max, Distributions.TwoSidedSymmetricFloatZigguratTable zigguratTable)
			{
			}

			public float Next()
			{
				return 0f;
			}
		}

		private class DoubleNormalSampleGenerator : ISampleGenerator<double>
		{
			private IRandom _random;

			private double _mean;

			private double _standardDeviation;

			private Distributions.TwoSidedSymmetricDoubleZigguratTable _zigguratTable;

			public DoubleNormalSampleGenerator(IRandom random, double mean, double standardDeviation, Distributions.TwoSidedSymmetricDoubleZigguratTable zigguratTable)
			{
			}

			public double Next()
			{
				return 0.0;
			}
		}

		private class TruncatedDoubleNormalSampleGenerator : ISampleGenerator<double>
		{
			private IRandom _random;

			private double _mean;

			private double _standardDeviation;

			private double _min;

			private double _max;

			private Distributions.TwoSidedSymmetricDoubleZigguratTable _zigguratTable;

			public TruncatedDoubleNormalSampleGenerator(IRandom random, double mean, double standardDeviation, double min, double max, Distributions.TwoSidedSymmetricDoubleZigguratTable zigguratTable)
			{
			}

			public double Next()
			{
				return 0.0;
			}
		}

		private class FloatExponentialSampleGenerator : ISampleGenerator<float>
		{
			private IRandom _random;

			private float _eventRate;

			private Distributions.OneSidedFloatZigguratTable _zigguratTable;

			public FloatExponentialSampleGenerator(IRandom random, float eventRate, Distributions.OneSidedFloatZigguratTable zigguratTable)
			{
			}

			public float Next()
			{
				return 0f;
			}
		}

		private class TruncatedFloatExponentialSampleGenerator : ISampleGenerator<float>
		{
			private IRandom _random;

			private float _eventRate;

			private float _max;

			private Distributions.OneSidedFloatZigguratTable _zigguratTable;

			public TruncatedFloatExponentialSampleGenerator(IRandom random, float eventRate, float max, Distributions.OneSidedFloatZigguratTable zigguratTable)
			{
			}

			public float Next()
			{
				return 0f;
			}
		}

		private class DoubleExponentialSampleGenerator : ISampleGenerator<double>
		{
			private IRandom _random;

			private double _eventRate;

			private Distributions.OneSidedDoubleZigguratTable _zigguratTable;

			public DoubleExponentialSampleGenerator(IRandom random, double eventRate, Distributions.OneSidedDoubleZigguratTable zigguratTable)
			{
			}

			public double Next()
			{
				return 0.0;
			}
		}

		private class TruncatedDoubleExponentialSampleGenerator : ISampleGenerator<double>
		{
			private IRandom _random;

			private double _eventRate;

			private double _max;

			private Distributions.OneSidedDoubleZigguratTable _zigguratTable;

			public TruncatedDoubleExponentialSampleGenerator(IRandom random, double eventRate, double max, Distributions.OneSidedDoubleZigguratTable zigguratTable)
			{
			}

			public double Next()
			{
				return 0.0;
			}
		}

		private class FloatPiecewiseUniformSampleGenerator : ISampleGenerator<float>
		{
			private IRandom _random;

			private float[] _x;

			private uint[] _cdf;

			public static FloatPiecewiseUniformSampleGenerator FromPositions(IRandom random, float[] x, float[] y)
			{
				return null;
			}

			public static FloatPiecewiseUniformSampleGenerator FromPositions(IRandom random, Vector2[] p, float xLast)
			{
				return null;
			}

			public static FloatPiecewiseUniformSampleGenerator FromWeights(IRandom random, float[] x, float[] weights)
			{
				return null;
			}

			public float Next()
			{
				return 0f;
			}
		}

		private class DoublePiecewiseUniformSampleGenerator : ISampleGenerator<double>
		{
			private IRandom _random;

			private double[] _x;

			private ulong[] _cdf;

			public static DoublePiecewiseUniformSampleGenerator FromPositions(IRandom random, double[] x, double[] y)
			{
				return null;
			}

			public static DoublePiecewiseUniformSampleGenerator FromWeights(IRandom random, double[] x, double[] weights)
			{
				return null;
			}

			public double Next()
			{
				return 0.0;
			}
		}

		private class FloatPiecewiseLinearSampleGenerator : ISampleGenerator<float>
		{
			private struct SegmentData
			{
				public float a;

				public float aTimesFour;

				public float b;

				public float bSquared;

				public float c0;

				public float scaledArea;

				public SegmentData(float x0, float y0, float x1, float y1)
				{
					a = 0f;
					aTimesFour = 0f;
					b = 0f;
					bSquared = 0f;
					c0 = 0f;
					scaledArea = 0f;
				}
			}

			private IRandom _random;

			private SegmentData[] _segments;

			private uint[] _cdf;

			public FloatPiecewiseLinearSampleGenerator(IRandom random, float[] x, float[] y)
			{
			}

			public FloatPiecewiseLinearSampleGenerator(IRandom random, Vector2[] p)
			{
			}

			public float Next()
			{
				return 0f;
			}
		}

		private class DoublePiecewiseLinearSampleGenerator : ISampleGenerator<double>
		{
			private struct SegmentData
			{
				public double a;

				public double aTimesFour;

				public double b;

				public double bSquared;

				public double c0;

				public double scaledArea;

				public SegmentData(double x0, double y0, double x1, double y1)
				{
					a = 0.0;
					aTimesFour = 0.0;
					b = 0.0;
					bSquared = 0.0;
					c0 = 0.0;
					scaledArea = 0.0;
				}
			}

			private IRandom _random;

			private SegmentData[] _segments;

			private ulong[] _cdf;

			public DoublePiecewiseLinearSampleGenerator(IRandom random, double[] x, double[] y)
			{
			}

			public double Next()
			{
				return 0.0;
			}
		}

		private class FloatPiecewiseHermiteSampleGenerator : ISampleGenerator<float>
		{
			private struct SegmentData
			{
				public float xDelta;

				public float x0;

				public float k4;

				public float k3;

				public float k2;

				public float k1;

				public float area;

				public SegmentData(float x0, float y0, float m0, float x1, float y1, float m1)
				{
					xDelta = 0f;
					this.x0 = 0f;
					k4 = 0f;
					k3 = 0f;
					k2 = 0f;
					k1 = 0f;
					area = 0f;
				}
			}

			private delegate void GetFrameDelegate(int index, out float x, out float y, out float m);

			private IRandom _random;

			private SegmentData[] _segments;

			private uint[] _cdf;

			public FloatPiecewiseHermiteSampleGenerator(IRandom random, float[] x, float[] y, float[] m)
			{
			}

			public FloatPiecewiseHermiteSampleGenerator(IRandom random, Vector2[] p, float[] m)
			{
			}

			public FloatPiecewiseHermiteSampleGenerator(IRandom random, Keyframe[] keyframes)
			{
			}

			public FloatPiecewiseHermiteSampleGenerator(IRandom random, AnimationCurve curve)
			{
			}

			private void Initialize(int frameCount, GetFrameDelegate getFront, GetFrameDelegate getBack)
			{
			}

			public float Next()
			{
				return 0f;
			}
		}

		private class DoublePiecewiseHermiteSampleGenerator : ISampleGenerator<double>
		{
			private struct SegmentData
			{
				public double xDelta;

				public double x0;

				public double k4;

				public double k3;

				public double k2;

				public double k1;

				public double area;

				public SegmentData(double x0, double y0, double m0, double x1, double y1, double m1)
				{
					xDelta = 0.0;
					this.x0 = 0.0;
					k4 = 0.0;
					k3 = 0.0;
					k2 = 0.0;
					k1 = 0.0;
					area = 0.0;
				}
			}

			private delegate void GetFrameDelegate(int index, out double x, out double y, out double m);

			private IRandom _random;

			private SegmentData[] _segments;

			private ulong[] _cdf;

			public DoublePiecewiseHermiteSampleGenerator(IRandom random, double[] x, double[] y, double[] m)
			{
			}

			private void Initialize(int frameCount, GetFrameDelegate getFront, GetFrameDelegate getBack)
			{
			}

			public double Next()
			{
				return 0.0;
			}
		}

		public static float UniformSample(this IRandom random, float x0, float x1)
		{
			return 0f;
		}

		public static ISampleGenerator<float> MakeUniformSampleGenerator(this IRandom random, float x0, float x1)
		{
			return null;
		}

		public static double UniformSample(this IRandom random, double x0, double x1)
		{
			return 0.0;
		}

		public static ISampleGenerator<double> MakeUniformSampleGenerator(this IRandom random, double x0, double x1)
		{
			return null;
		}

		public static float TriangularSample(this IRandom random, float x0, float x1, float x2)
		{
			return 0f;
		}

		public static ISampleGenerator<float> MakeTriangularSampleGenerator(this IRandom random, float x0, float x1, float x2)
		{
			return null;
		}

		public static double TriangularSample(this IRandom random, double x0, double x1, double x2)
		{
			return 0.0;
		}

		public static ISampleGenerator<double> MakeTriangularSampleGenerator(this IRandom random, double x0, double x1, double x2)
		{
			return null;
		}

		public static float TrapezoidalSample(this IRandom random, float x0, float x1, float x2, float x3)
		{
			return 0f;
		}

		public static ISampleGenerator<float> MakeTrapezoidalSampleGenerator(this IRandom random, float x0, float x1, float x2, float x3)
		{
			return null;
		}

		public static double TrapezoidalSample(this IRandom random, double x0, double x1, double x2, double x3)
		{
			return 0.0;
		}

		public static ISampleGenerator<double> MakeTrapezoidalSampleGenerator(this IRandom random, double x0, double x1, double x2, double x3)
		{
			return null;
		}

		public static float LinearSample(this IRandom random, float x0, float y0, float x1, float y1)
		{
			return 0f;
		}

		public static float LinearSample(this IRandom random, Vector2 p0, Vector2 p1)
		{
			return 0f;
		}

		private static float LinearSample(this IRandom random, float x0, float y0, float x1, float y1, float n)
		{
			return 0f;
		}

		public static ISampleGenerator<float> MakeLinearSampleGenerator(this IRandom random, float x0, float y0, float x1, float y1)
		{
			return null;
		}

		public static ISampleGenerator<float> MakeLinearSampleGenerator(this IRandom random, Vector2 p0, Vector2 p1)
		{
			return null;
		}

		public static double LinearSample(this IRandom random, double x0, double y0, double x1, double y1)
		{
			return 0.0;
		}

		private static double LinearSample(this IRandom random, double x0, double y0, double x1, double y1, double n)
		{
			return 0.0;
		}

		public static ISampleGenerator<double> MakeLinearSampleGenerator(this IRandom random, double x0, double y0, double x1, double y1)
		{
			return null;
		}

		private static void CalculateHermiteSplineCDFCoefficients(float x0, float y0, float m0, float x1, float y1, float m1, out float k4, out float k3, out float k2, out float k1, out float area)
		{
			k4 = default(float);
			k3 = default(float);
			k2 = default(float);
			k1 = default(float);
			area = default(float);
		}

		private static float FindRoot(float k4, float k3, float k2, float k1, float area, float t)
		{
			return 0f;
		}

		public static float HermiteSplineSample(this IRandom random, float x0, float y0, float m0, float x1, float y1, float m1)
		{
			return 0f;
		}

		public static float HermiteSplineSample(this IRandom random, Vector2 p0, float m0, Vector2 p1, float m1)
		{
			return 0f;
		}

		public static float HermiteSplineSample(this IRandom random, Keyframe kf0, Keyframe kf1)
		{
			return 0f;
		}

		public static float HermiteSplineSample(this IRandom random, AnimationCurve curve, int segmentIndex = 0)
		{
			return 0f;
		}

		private static float HermiteSplineSample(this IRandom random, float x0, float y0, float m0, float x1, float y1, float m1, float t)
		{
			return 0f;
		}

		public static ISampleGenerator<float> MakeHermiteSplineSampleGenerator(this IRandom random, float x0, float y0, float m0, float x1, float y1, float m1)
		{
			return null;
		}

		public static ISampleGenerator<float> MakeHermiteSplineSampleGenerator(this IRandom random, Vector2 p0, float m0, Vector2 p1, float m1)
		{
			return null;
		}

		public static ISampleGenerator<float> MakeHermiteSplineSampleGenerator(this IRandom random, Keyframe kf0, Keyframe kf1)
		{
			return null;
		}

		public static ISampleGenerator<float> MakeHermiteSplineSampleGenerator(this IRandom random, AnimationCurve curve, int segmentIndex = 0)
		{
			return null;
		}

		private static void CalculateHermiteSplineCDFCoefficients(double x0, double y0, double m0, double x1, double y1, double m1, out double k4, out double k3, out double k2, out double k1, out double area)
		{
			k4 = default(double);
			k3 = default(double);
			k2 = default(double);
			k1 = default(double);
			area = default(double);
		}

		private static double FindRoot(double k4, double k3, double k2, double k1, double area, double t)
		{
			return 0.0;
		}

		public static double HermiteSplineSample(this IRandom random, double x0, double y0, double m0, double x1, double y1, double m1)
		{
			return 0.0;
		}

		private static double HermiteSplineSample(this IRandom random, double x0, double y0, double m0, double x1, double y1, double m1, double t)
		{
			return 0.0;
		}

		public static ISampleGenerator<double> MakeHermiteSplineSampleGenerator(this IRandom random, double x0, double y0, double m0, double x1, double y1, double m1)
		{
			return null;
		}

		public static float NormalSample(this IRandom random, float mean, float standardDeviation)
		{
			return 0f;
		}

		public static float NormalSample(this IRandom random, float mean, float standardDeviation, float min, float max)
		{
			return 0f;
		}

		public static ISampleGenerator<float> MakeNormalSampleGenerator(this IRandom random, float mean, float standardDeviation)
		{
			return null;
		}

		public static ISampleGenerator<float> MakeNormalSampleGenerator(this IRandom random, float mean, float standardDeviation, Distributions.TwoSidedSymmetricFloatZigguratTable lookupTable)
		{
			return null;
		}

		public static ISampleGenerator<float> MakeNormalSampleGenerator(this IRandom random, float mean, float standardDeviation, int lookupTableSize, double epsilon = 1E-10)
		{
			return null;
		}

		public static ISampleGenerator<float> MakeNormalSampleGenerator(this IRandom random, float mean, float standardDeviation, float min, float max)
		{
			return null;
		}

		public static ISampleGenerator<float> MakeNormalSampleGenerator(this IRandom random, float mean, float standardDeviation, float min, float max, Distributions.TwoSidedSymmetricFloatZigguratTable lookupTable)
		{
			return null;
		}

		public static ISampleGenerator<float> MakeNormalSampleGenerator(this IRandom random, float mean, float standardDeviation, float min, float max, int lookupTableSize, double epsilon = 1E-10)
		{
			return null;
		}

		public static double NormalSample(this IRandom random, double mean, double standardDeviation)
		{
			return 0.0;
		}

		public static double NormalSample(this IRandom random, double mean, double standardDeviation, double min, double max)
		{
			return 0.0;
		}

		public static ISampleGenerator<double> MakeNormalSampleGenerator(this IRandom random, double mean, double standardDeviation)
		{
			return null;
		}

		public static ISampleGenerator<double> MakeNormalSampleGenerator(this IRandom random, double mean, double standardDeviation, Distributions.TwoSidedSymmetricDoubleZigguratTable lookupTable)
		{
			return null;
		}

		public static ISampleGenerator<double> MakeNormalSampleGenerator(this IRandom random, double mean, double standardDeviation, int lookupTableSize, double epsilon = 1E-10)
		{
			return null;
		}

		public static ISampleGenerator<double> MakeNormalSampleGenerator(this IRandom random, double mean, double standardDeviation, double min, double max)
		{
			return null;
		}

		public static ISampleGenerator<double> MakeNormalSampleGenerator(this IRandom random, double mean, double standardDeviation, double min, double max, Distributions.TwoSidedSymmetricDoubleZigguratTable lookupTable)
		{
			return null;
		}

		public static ISampleGenerator<double> MakeNormalSampleGenerator(this IRandom random, double mean, double standardDeviation, double min, double max, int lookupTableSize, double epsilon = 1E-10)
		{
			return null;
		}

		public static float ExponentialSample(this IRandom random, float eventRate)
		{
			return 0f;
		}

		public static float ExponentialSample(this IRandom random, float eventRate, float max)
		{
			return 0f;
		}

		public static ISampleGenerator<float> MakeExponentialSampleGenerator(this IRandom random, float eventRate)
		{
			return null;
		}

		public static ISampleGenerator<float> MakeExponentialSampleGenerator(this IRandom random, float eventRate, Distributions.OneSidedFloatZigguratTable lookupTable)
		{
			return null;
		}

		public static ISampleGenerator<float> MakeExponentialSampleGenerator(this IRandom random, float eventRate, int lookupTableSize, double epsilon = 1E-10)
		{
			return null;
		}

		public static ISampleGenerator<float> MakeExponentialSampleGenerator(this IRandom random, float eventRate, float max)
		{
			return null;
		}

		public static ISampleGenerator<float> MakeExponentialSampleGenerator(this IRandom random, float eventRate, float max, Distributions.OneSidedFloatZigguratTable lookupTable)
		{
			return null;
		}

		public static ISampleGenerator<float> MakeExponentialSampleGenerator(this IRandom random, float eventRate, float max, int lookupTableSize, double epsilon = 1E-10)
		{
			return null;
		}

		public static double ExponentialSample(this IRandom random, double eventRate)
		{
			return 0.0;
		}

		public static double ExponentialSample(this IRandom random, double eventRate, double max)
		{
			return 0.0;
		}

		public static ISampleGenerator<double> MakeExponentialSampleGenerator(this IRandom random, double eventRate)
		{
			return null;
		}

		public static ISampleGenerator<double> MakeExponentialSampleGenerator(this IRandom random, double eventRate, Distributions.OneSidedDoubleZigguratTable lookupTable)
		{
			return null;
		}

		public static ISampleGenerator<double> MakeExponentialSampleGenerator(this IRandom random, double eventRate, int lookupTableSize, double epsilon = 1E-10)
		{
			return null;
		}

		public static ISampleGenerator<double> MakeExponentialSampleGenerator(this IRandom random, double eventRate, double max)
		{
			return null;
		}

		public static ISampleGenerator<double> MakeExponentialSampleGenerator(this IRandom random, double eventRate, double max, Distributions.OneSidedDoubleZigguratTable lookupTable)
		{
			return null;
		}

		public static ISampleGenerator<double> MakeExponentialSampleGenerator(this IRandom random, double eventRate, double max, int lookupTableSize, double epsilon = 1E-10)
		{
			return null;
		}

		private static int BinarySearch(uint n, uint[] cdf)
		{
			return 0;
		}

		private static int BinarySearch(ulong n, ulong[] cdf)
		{
			return 0;
		}

		public static float PiecewiseUniformSample(this IRandom random, float[] x, float[] y)
		{
			return 0f;
		}

		public static float PiecewiseUniformSample(this IRandom random, Vector2[] p, float xLast)
		{
			return 0f;
		}

		public static float PiecewiseWeightedUniformSample(this IRandom random, float[] x, float[] weights)
		{
			return 0f;
		}

		public static ISampleGenerator<float> MakePiecewiseUniformSampleGenerator(this IRandom random, float[] x, float[] y)
		{
			return null;
		}

		public static ISampleGenerator<float> MakePiecewiseUniformSampleGenerator(this IRandom random, Vector2[] p, float xLast)
		{
			return null;
		}

		public static ISampleGenerator<float> MakePiecewiseWeightedUniformSampleGenerator(this IRandom random, float[] x, float[] weights)
		{
			return null;
		}

		public static double PiecewiseUniformSample(this IRandom random, double[] x, double[] y)
		{
			return 0.0;
		}

		public static double PiecewiseWeightedUniformSample(this IRandom random, double[] x, double[] weights)
		{
			return 0.0;
		}

		public static ISampleGenerator<double> MakePiecewiseUniformSampleGenerator(this IRandom random, double[] x, double[] y)
		{
			return null;
		}

		public static ISampleGenerator<double> MakePiecewiseWeightedUniformSampleGenerator(this IRandom random, double[] x, double[] weights)
		{
			return null;
		}

		public static float PiecewiseLinearSample(this IRandom random, float[] x, float[] y)
		{
			return 0f;
		}

		public static float PiecewiseLinearSample(this IRandom random, Vector2[] p)
		{
			return 0f;
		}

		public static ISampleGenerator<float> MakePiecewiseLinearSampleGenerator(this IRandom random, float[] x, float[] y)
		{
			return null;
		}

		public static ISampleGenerator<float> MakePiecewiseLinearSampleGenerator(this IRandom random, Vector2[] p)
		{
			return null;
		}

		public static double PiecewiseLinearSample(this IRandom random, double[] x, double[] y)
		{
			return 0.0;
		}

		public static ISampleGenerator<double> MakePiecewiseLinearSampleGenerator(this IRandom random, double[] x, double[] y)
		{
			return null;
		}

		public static float PiecewiseHermiteSample(this IRandom random, float[] x, float[] y, float[] m)
		{
			return 0f;
		}

		public static float PiecewiseHermiteSample(this IRandom random, Vector2[] p, float[] m)
		{
			return 0f;
		}

		public static float PiecewiseHermiteSample(this IRandom random, Keyframe[] keyframes)
		{
			return 0f;
		}

		public static float PiecewiseHermiteSample(this IRandom random, AnimationCurve curve)
		{
			return 0f;
		}

		public static ISampleGenerator<float> MakePiecewiseHermiteSampleGenerator(this IRandom random, float[] x, float[] y, float[] m)
		{
			return null;
		}

		public static ISampleGenerator<float> MakePiecewiseHermiteSampleGenerator(this IRandom random, Vector2[] p, float[] m)
		{
			return null;
		}

		public static ISampleGenerator<float> MakePiecewiseHermiteSampleGenerator(this IRandom random, Keyframe[] keyframes)
		{
			return null;
		}

		public static ISampleGenerator<float> MakePiecewiseHermiteSampleGenerator(this IRandom random, AnimationCurve curve)
		{
			return null;
		}

		public static double PiecewiseHermiteSample(this IRandom random, double[] x, double[] y, double[] m)
		{
			return 0.0;
		}

		public static ISampleGenerator<double> MakePiecewiseHermiteSampleGenerator(this IRandom random, double[] x, double[] y, double[] m)
		{
			return null;
		}
	}
}
