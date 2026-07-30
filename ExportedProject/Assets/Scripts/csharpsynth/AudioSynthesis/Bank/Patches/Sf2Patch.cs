using AudioSynthesis.Bank.Components.Generators;
using AudioSynthesis.Bank.Descriptors;
using AudioSynthesis.Sf2;
using AudioSynthesis.Synthesis;

namespace AudioSynthesis.Bank.Patches
{
	public class Sf2Patch : Patch
	{
		private int iniFilterFc;

		private double filterQ;

		private float initialAttn;

		private short keyOverride;

		private short velOverride;

		private short keynumToModEnvHold;

		private short keynumToModEnvDecay;

		private short keynumToVolEnvHold;

		private short keynumToVolEnvDecay;

		private PanComponent pan;

		private short modLfoToPitch;

		private short vibLfoToPitch;

		private short modEnvToPitch;

		private short modLfoToFilterFc;

		private short modEnvToFilterFc;

		private float modLfoToVolume;

		private AudioSynthesis.Bank.Components.Generators.Generator gen;

		private EnvelopeDescriptor mod_env;

		private EnvelopeDescriptor vel_env;

		private LfoDescriptor mod_lfo;

		private LfoDescriptor vib_lfo;

		private FilterDescriptor fltr;

		public Sf2Patch(string name)
			: base(null)
		{
		}

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

		public void Load(Sf2Region region, AssetManager assets)
		{
		}

		private void LoadGen(Sf2Region region, AssetManager assets)
		{
		}

		private void LoadEnvelopes(Sf2Region region)
		{
		}

		private void LoadLfos(Sf2Region region)
		{
		}

		private void LoadFilter(Sf2Region region)
		{
		}

		private static double CalculateModulator(SourceTypeEnum s, TransformEnum t, DirectionEnum d, PolarityEnum p, int value, int min, int max)
		{
			return 0.0;
		}
	}
}
