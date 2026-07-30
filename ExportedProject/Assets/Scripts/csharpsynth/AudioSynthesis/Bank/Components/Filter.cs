using AudioSynthesis.Bank.Descriptors;

namespace AudioSynthesis.Bank.Components
{
	public class Filter
	{
		private FilterTypeEnum filterType;

		private float a1;

		private float a2;

		private float b1;

		private float b2;

		private float m1;

		private float m2;

		private float m3;

		private double cutOff;

		private double resonance;

		private bool coeffUpdateRequired;

		public double Cutoff
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public bool CoeffNeedsUpdating => false;

		public bool Enabled => false;

		public void Disable()
		{
		}

		public void QuickSetup(int sampleRate, int note, float velocity, FilterDescriptor filterInfo)
		{
		}

		public void ApplyFilter(float[] data)
		{
		}

		public void ApplyFilterInterp(float[] data, int sampleRate)
		{
		}

		public void UpdateCoeff(int sampleRate)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private float[] GenerateFilterCoeff(double fc, double q)
		{
			return null;
		}
	}
}
