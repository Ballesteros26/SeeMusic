using AudioSynthesis.Bank.Components.Generators;
using AudioSynthesis.Bank.Descriptors;
using AudioSynthesis.Synthesis;

namespace AudioSynthesis.Bank.Patches
{
	public class SfzPatch : Patch
	{
		private float sfzVolume;

		private float ampKeyTrack;

		private float ampVelTrack;

		private PanComponent sfzPan;

		private short ampRootKey;

		private Generator gen;

		private EnvelopeDescriptor ptch_env;

		private EnvelopeDescriptor fltr_env;

		private EnvelopeDescriptor amp_env;

		private LfoDescriptor ptch_lfo;

		private LfoDescriptor fltr_lfo;

		private LfoDescriptor amp_lfo;

		private FilterDescriptor fltr;

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
