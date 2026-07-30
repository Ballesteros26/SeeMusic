namespace MidiPlayerTK
{
	public class fluid_revmodel
	{
		public enum fluid_revmodel_set_t
		{
			FLUID_REVMODEL_SET_ROOMSIZE = 1,
			FLUID_REVMODEL_SET_DAMPING = 2,
			FLUID_REVMODEL_SET_WIDTH = 4,
			FLUID_REVMODEL_SET_LEVEL = 8,
			FLUID_REVMODEL_SET_ALL = 15
		}

		public class fdn_delay_lpf
		{
			public float buffer;

			public float b0;

			public float a1;

			public void set_fdn_delay_lpf(float pb0, float pa1)
			{
			}
		}

		public class delay_line
		{
			public float[] line;

			public int size;

			public int line_in;

			public int line_out;

			public fdn_delay_lpf damping;

			public void clear_delay_line()
			{
			}
		}

		public class sinus_modulator
		{
			public float a1;

			public float buffer1;

			public float buffer2;

			public float reset_buffer2;

			public void set_mod_frequency(float freq, float sample_rate, float phase)
			{
			}

			public float get_mod_sinus()
			{
				return 0f;
			}
		}

		public class mod_delay_line
		{
			public delay_line dl;

			public sinus_modulator mod;

			private float center_pos_mod;

			private int mod_depth;

			private int index_rate;

			private int mod_rate;

			private float frac_pos_mod;

			private float buffer;

			public bool set_mod_delay_line(int delay_length, int pmod_depth, int pmod_rate)
			{
				return false;
			}

			public int get_mod_delay_line_length()
			{
				return 0;
			}

			public float get_mod_delay()
			{
				return 0f;
			}
		}

		public class fluid_late
		{
			public float samplerate;

			public float tone_buffer;

			public float b1;

			public float b2;

			public mod_delay_line[] mod_delay_lines;

			public float[] out_left_gain;

			public float[] out_right_gain;

			public void update_rev_time_damping(float proomsize, float pdamp)
			{
			}

			public void update_stereo_coefficient(float wet1)
			{
			}

			public bool create_mod_delay_lines(float sample_rate)
			{
				return false;
			}

			public bool create_fluid_rev_late(float psample_rate)
			{
				return false;
			}
		}

		private int FLUID_BUFSIZE;

		private const int NBR_DELAYS = 8;

		private const float DC_OFFSET = 0f;

		private const float SCALE_WET_WIDTH = 0.2f;

		private const float FIXED_GAIN = 0.1f;

		private const float SCALE_WET = 5f;

		private const float MIN_DC_REV_TIME = 0.7f;

		private const float MAX_DC_REV_TIME = 12.5f;

		private const float RANGE_REV_TIME = 11.8f;

		private const int MOD_DEPTH = 4;

		private const int MOD_RATE = 50;

		private const float MOD_FREQ = 1f;

		private const int INTERP_SAMPLES_NBR = 1;

		private const float MOD_PHASE = 45f;

		private const float FLUID_M_LN10 = 2.3025851f;

		private const float FDN_MATRIX_FACTOR = -0.25f;

		private float roomsize;

		private float damp;

		private float level;

		private float wet1;

		private float wet2;

		private float width;

		public fluid_late late;

		private float[] delay_out;

		public float Roomsize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Damp
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Level
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Width
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void fluid_revmodel_init()
		{
		}

		private void fluid_revmodel_update()
		{
		}

		public fluid_revmodel(float sample_rate, int bufsize)
		{
		}

		public void fluid_revmodel_set(int set, float proomsize, float pdamping, float pwidth, float plevel)
		{
		}

		private bool fluid_revmodel_samplerate_change(float psample_rate)
		{
			return false;
		}

		private void fluid_revmodel_reset()
		{
		}

		public void fluid_revmodel_processmix(float[] inp, float[] left_out, float[] right_out)
		{
		}
	}
}
