namespace MidiPlayerTK
{
	public class fluid_conv
	{
		public const float FLUID_PEAK_ATTENUATION = 960f;

		public const int FLUID_CENTS_HZ_SIZE = 1200;

		public const int FLUID_VEL_CB_SIZE = 128;

		public const int FLUID_CB_AMP_SIZE = 961;

		public const int FLUID_ATTEN_AMP_SIZE = 1441;

		public const int FLUID_PAN_SIZE = 1002;

		public const float M_LN10 = 2.3025851f;

		public const float M_LN2 = 0.6931472f;

		public const float FLUID_ATTEN_POWER_FACTOR = -531.509f;

		public static float[] fluid_ct2hz_tab;

		public static float[] fluid_cb2amp_tab;

		public static float[] fluid_atten2amp_tab;

		public static float[] fluid_posbp_tab;

		public static float[] fluid_concave_tab;

		public static float[] fluid_convex_tab;

		public static float[] fluid_pan_tab;

		public static void fluid_conversion_config()
		{
		}

		public static float fluid_ct2hz_real(float cents)
		{
			return 0f;
		}

		public static float fluid_ct2hz(float cents)
		{
			return 0f;
		}

		public static float fluid_cb2amp(float cb)
		{
			return 0f;
		}

		public static float fluid_atten2amp(float atten)
		{
			return 0f;
		}

		public static float fluid_tc2sec_delay(float tc)
		{
			return 0f;
		}

		public static float fluid_tc2sec_attack(float tc)
		{
			return 0f;
		}

		public static float fluid_tc2sec_release(float tc)
		{
			return 0f;
		}

		public static float fluid_act2hz(float c)
		{
			return 0f;
		}

		public static float fluid_hz2ct(float f)
		{
			return 0f;
		}

		public static float fluid_pan(float c, bool left)
		{
			return 0f;
		}

		public static float fluid_concave(float val)
		{
			return 0f;
		}

		public static float fluid_convex(float val)
		{
			return 0f;
		}
	}
}
