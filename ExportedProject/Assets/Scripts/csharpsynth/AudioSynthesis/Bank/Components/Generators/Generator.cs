using AudioSynthesis.Bank.Descriptors;

namespace AudioSynthesis.Bank.Components.Generators
{
	public abstract class Generator
	{
		internal static readonly SineGenerator DefaultSine;

		internal static readonly SawGenerator DefaultSaw;

		internal static readonly SquareGenerator DefaultSquare;

		internal static readonly TriangleGenerator DefaultTriangle;

		protected LoopModeEnum loopMethod;

		protected double loopStart;

		protected double loopEnd;

		protected double start;

		protected double end;

		protected double startOffset;

		protected double genPeriod;

		protected double freq;

		protected short root;

		protected short noteTrack;

		protected short velTrack;

		protected short tuneCents;

		public LoopModeEnum LoopMode
		{
			get
			{
				return default(LoopModeEnum);
			}
			set
			{
			}
		}

		public double LoopStartPhase
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double LoopEndPhase
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double StartPhase
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double EndPhase
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double Offset
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double Period
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double Frequency
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public short RootKey
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public short KeyTrack
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public short VelocityTrack
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public short Tune
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Generator(GeneratorDescriptor description)
		{
		}

		public void Release(GeneratorParameters generatorParams)
		{
		}

		public abstract float GetValue(double phase);

		public abstract void GetValues(GeneratorParameters generatorParams, float[] blockBuffer, double increment);

		public override string ToString()
		{
			return null;
		}
	}
}
