namespace AudioSynthesis.Synthesis
{
	public class SynthParameters
	{
		public byte program;

		public byte bankSelect;

		public byte channelAfterTouch;

		public CCValue pan;

		public CCValue volume;

		public CCValue expression;

		public CCValue modRange;

		public CCValue pitchBend;

		public byte pitchBendRangeCoarse;

		public byte pitchBendRangeFine;

		public short masterCoarseTune;

		public CCValue masterFineTune;

		public bool holdPedal;

		public bool legatoPedal;

		public CCValue rpn;

		internal Synthesizer synth;

		public float currentVolume;

		public int currentPitch;

		public int currentMod;

		public PanComponent currentPan;

		public SynthParameters(Synthesizer synth)
		{
		}

		public void ResetControllers()
		{
		}

		internal void UpdateCurrentVolume()
		{
		}

		internal void UpdateCurrentPitch()
		{
		}

		internal void UpdateCurrentMod()
		{
		}

		internal void UpdateCurrentPan()
		{
		}
	}
}
