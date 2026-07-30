namespace MidiPlayerTK
{
	public class fluid_iir_filter
	{
		private fluid_iir_filter_type type;

		private fluid_iir_filter_flags flags;

		private float b02;

		private float b1;

		private float a1;

		private float a2;

		private float b02_incr;

		private float b1_incr;

		private float a1_incr;

		private float a2_incr;

		private int filter_coeff_incr_count;

		private bool compensate_incr;

		private float hist1;

		private float hist2;

		private bool filter_startup;

		private float fres;

		private float last_fres;

		private float q_lin;

		private float filter_gain;

		private int FLUID_BUFSIZE;

		public fluid_iir_filter(int bufsize)
		{
		}

		public void fluid_iir_filter_apply(float[] dsp_buf, int count)
		{
		}

		public void fluid_iir_filter_init(fluid_iir_filter_type ptype, fluid_iir_filter_flags pflags)
		{
		}

		public void fluid_iir_filter_reset()
		{
		}

		public void fluid_iir_filter_set_fres(float pfres)
		{
		}

		private static float fluid_iir_filter_q_from_dB(float q_dB, float offset)
		{
			return 0f;
		}

		public void fluid_iir_filter_set_q(float pq, float offset)
		{
		}

		private void fluid_iir_filter_calculate_coefficients(int transition_samples, float output_rate)
		{
		}

		public void fluid_iir_filter_calc(float output_rate, float fres_mod, float offset)
		{
		}
	}
}
