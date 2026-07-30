using AudioSynthesis.Bank.Components.Generators;
using AudioSynthesis.Bank.Descriptors;
using AudioSynthesis.Synthesis;

namespace AudioSynthesis.Bank.Patches
{
	public class BasicPatch : Patch
	{
		private Generator gen;

		private EnvelopeDescriptor env;

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
	}
}
