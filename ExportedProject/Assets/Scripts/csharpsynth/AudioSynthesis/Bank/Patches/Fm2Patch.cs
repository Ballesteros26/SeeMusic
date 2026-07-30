using AudioSynthesis.Bank.Components.Generators;
using AudioSynthesis.Bank.Descriptors;
using AudioSynthesis.Synthesis;

namespace AudioSynthesis.Bank.Patches
{
	public class Fm2Patch : Patch
	{
		public enum SyncMode
		{
			Soft = 0,
			Hard = 1
		}

		private SyncMode sync;

		private double mIndex;

		private double cIndex;

		private double feedBack;

		private Generator cGen;

		private Generator mGen;

		private EnvelopeDescriptor cEnv;

		private EnvelopeDescriptor mEnv;

		private LfoDescriptor lfo;

		public override bool Start(VoiceParameters voiceparams)
		{
			return false;
		}

		public override void Stop(VoiceParameters voiceparams)
		{
		}

		public override void Process(VoiceParameters voiceparams, int startIndex, int endIndex)
		{
		}

		public override void Load(DescriptorList description, AssetManager assets)
		{
		}

		public static SyncMode GetSyncModeFromString(string value)
		{
			return default(SyncMode);
		}
	}
}
