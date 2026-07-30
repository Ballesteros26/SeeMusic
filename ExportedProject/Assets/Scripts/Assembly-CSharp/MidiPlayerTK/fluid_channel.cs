namespace MidiPlayerTK
{
	public class fluid_channel
	{
		public int channum;

		public int banknum;

		public int prognum;

		public HiPreset preset;

		private MidiSynth synth;

		public short key_pressure;

		public short channel_pressure;

		public short pitch_bend;

		public short pitch_wheel_sensitivity;

		public short[] cc;

		public fluid_tuning tuning;

		public double[] gens;

		public bool[] gen_abs;

		public mptk_channel mptkChannel;

		public fluid_channel()
		{
		}

		public fluid_channel(MidiSynth psynth, int pchanum)
		{
		}

		private void fluid_channel_init()
		{
		}

		private void fluid_channel_init_ctrl()
		{
		}

		public void fluid_channel_cc(MPTKController numController, int valueController)
		{
		}

		public void fluid_channel_pitch_bend(int val)
		{
		}
	}
}
