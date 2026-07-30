using AudioSynthesis.Bank.Components.Generators;
using AudioSynthesis.Bank.Descriptors;

namespace AudioSynthesis.Bank.Components
{
	public class Lfo
	{
		private LfoStateEnum lfoState;

		private double phase;

		private double value;

		private double increment;

		private double frequency;

		private double depth;

		private int delayTime;

		private Generator generator;

		public double Value => 0.0;

		public double Depth
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public void QuickSetup(int sampleRate, LfoDescriptor lfoInfo)
		{
		}

		public void Increment(int amount)
		{
		}

		public void Reset()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
