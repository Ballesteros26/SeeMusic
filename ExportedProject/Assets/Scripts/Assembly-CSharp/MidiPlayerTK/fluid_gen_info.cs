namespace MidiPlayerTK
{
	public class fluid_gen_info
	{
		public int num;

		public int init;

		public int nrpn_scale;

		public float min;

		public float max;

		public float def;

		public bool RealTimeChange;

		public string Description;

		public static fluid_gen_info[] FluidGenInfo;

		public fluid_gen_info()
		{
		}

		public fluid_gen_info(int pnum, int pinit, int pscale, float pmin, float pmax, float pdef, bool preplace, string pinfo)
		{
		}

		public static void fluid_gen_set_default_values(HiGen[] gens)
		{
		}

		public void fluid_gen_set_default_values()
		{
		}
	}
}
