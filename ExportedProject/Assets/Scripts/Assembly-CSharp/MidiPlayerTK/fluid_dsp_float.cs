namespace MidiPlayerTK
{
	public class fluid_dsp_float
	{
		private const int SINC_INTERP_ORDER = 7;

		private const int FLUID_INTERP_BITS = 8;

		private const uint FLUID_INTERP_BITS_MASK = 4278190080u;

		private const int FLUID_INTERP_BITS_SHIFT = 24;

		private const int FLUID_INTERP_MAX = 256;

		private const float FLUID_FRACT_MAX = 4.2949673E+09f;

		private static float[][] interp_coeff_linear;

		private static float[][] interp_coeff;

		private static float[][] sinc_table7;

		public static void fluid_dsp_float_config()
		{
		}

		public static int fluid_dsp_float_interpolate_none(fluid_voice voice)
		{
			return 0;
		}

		public static int fluid_dsp_float_interpolate_linear(fluid_voice voice)
		{
			return 0;
		}

		public static int fluid_dsp_float_interpolate_4th_order(fluid_voice voice)
		{
			return 0;
		}

		public static int fluid_dsp_float_interpolate_7th_order(fluid_voice voice)
		{
			return 0;
		}
	}
}
