using AudioSynthesis.Bank.Components;
using AudioSynthesis.Bank.Components.Generators;

namespace AudioSynthesis.Synthesis
{
	public class VoiceParameters
	{
		public int channel;

		public int note;

		public int velocity;

		public bool noteOffPending;

		public VoiceStateEnum state;

		public int pitchOffset;

		public float volOffset;

		public float[] blockBuffer;

		public UnionData[] pData;

		public SynthParameters synthParams;

		public GeneratorParameters[] generatorParams;

		public Envelope[] envelopes;

		public Filter[] filters;

		public Lfo[] lfos;

		private float mix1;

		private float mix2;

		public float CombinedVolume => 0f;

		public void Reset()
		{
		}

		public void MixMonoToMonoInterp(int startIndex, float volume)
		{
		}

		public void MixMonoToStereoInterp(int startIndex, float leftVol, float rightVol)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
