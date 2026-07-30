using AudioSynthesis.Bank.Patches;

namespace AudioSynthesis.Synthesis
{
	internal class Voice
	{
		private Patch patch;

		private VoiceParameters voiceparams;

		public Patch Patch => null;

		public VoiceParameters VoiceParams => null;

		public void Start()
		{
		}

		public void Stop()
		{
		}

		public void StopImmediately()
		{
		}

		public void Process(int startIndex, int endIndex)
		{
		}

		public void Configure(int channel, int note, int velocity, Patch patch, SynthParameters synthParams)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
