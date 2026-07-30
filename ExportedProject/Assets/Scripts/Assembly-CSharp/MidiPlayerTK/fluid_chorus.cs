namespace MidiPlayerTK
{
	public class fluid_chorus
	{
		public enum fluid_chorus_mod
		{
			FLUID_CHORUS_MOD_SINE = 0,
			FLUID_CHORUS_MOD_TRIANGLE = 1
		}

		public enum fluid_chorus_set_t
		{
			FLUID_CHORUS_SET_NR = 1,
			FLUID_CHORUS_SET_LEVEL = 2,
			FLUID_CHORUS_SET_SPEED = 4,
			FLUID_CHORUS_SET_DEPTH = 8,
			FLUID_CHORUS_SET_TYPE = 16,
			FLUID_CHORUS_SET_ALL = 31
		}

		private const int MAX_CHORUS = 99;

		private const int MAX_LEVEL = 10;

		private const float MIN_SPEED_HZ = 0.1f;

		private const int MAX_SPEED_HZ = 5;

		private const float SCALE_WET_WIDTH = 0.2f;

		private const float SCALE_WET = 1f;

		private const int MAX_SAMPLES = 2048;

		private const int LOW_MOD_DEPTH = 176;

		private const float HIGH_MOD_DEPTH = 1024f;

		private const float RANGE_MOD_DEPTH = 848f;

		private const int LOW_MOD_RATE = 5;

		private const int HIGH_MOD_RATE = 4;

		private const int RANGE_MOD_RATE = -1;

		private const int INTERP_SAMPLES_NBR = 1;

		private fluid_chorus_mod type;

		private float depth_ms;

		private float level;

		private float speed_Hz;

		private int number_blocks;

		private float sample_rate;

		private float width;

		private float wet1;

		private float wet2;

		private float[] line;

		private int size;

		private int line_in;

		private float center_pos_mod;

		private int mod_depth;

		private int index_rate;

		private int mod_rate;

		private int FLUID_BUFSIZE;

		private modulator[] mod;

		public fluid_chorus(float psample_rate, int bufsize)
		{
		}

		private void set_sinus_frequency(sinus_modulator mod, float freq, float sample_rate, float phase)
		{
		}

		private float get_mod_sinus(sinus_modulator mod)
		{
			return 0f;
		}

		private void set_triangle_frequency(triang_modulator mod, float freq, float sample_rate, float frac_phase)
		{
		}

		private float get_mod_triang(triang_modulator mod)
		{
			return 0f;
		}

		private float get_mod_delay(modulator mod)
		{
			return 0f;
		}

		private void set_center_position()
		{
		}

		private bool new_mod_delay_line(int delay_length)
		{
			return false;
		}

		private void fluid_chorus_reset()
		{
		}

		public void fluid_chorus_set(int set, int nr, float plevel, float speed, float pdepth_ms, fluid_chorus_mod ptype, float pwidth)
		{
		}

		public void fluid_chorus_processmix(float[] inp, float[] left_out, float[] right_out)
		{
		}
	}
}
