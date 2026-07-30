using AudioSynthesis.Bank.Descriptors;

namespace AudioSynthesis.Bank.Components
{
	public class Envelope
	{
		private class EnvelopeStage
		{
			public int time;

			public float[] graph;

			public float scale;

			public float offset;

			public bool reverse;
		}

		private EnvelopeStateEnum envState;

		private EnvelopeStage[] stages;

		private EnvelopeStage stage;

		private int index;

		private float value;

		private float depth;

		public float Value => 0f;

		public EnvelopeStateEnum CurrentState => default(EnvelopeStateEnum);

		public float Depth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void QuickSetup(int sampleRate, float velocity, EnvelopeDescriptor envelopeInfo)
		{
		}

		public void QuickSetupSf2(int sampleRate, int note, short keyNumToHold, short keyNumToDecay, bool isVolumeEnvelope, EnvelopeDescriptor envelopeInfo)
		{
		}

		public void Increment(int samples)
		{
		}

		public void Release(float lowerLimit)
		{
		}

		public void ReleaseSf2VolumeEnvelope()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
