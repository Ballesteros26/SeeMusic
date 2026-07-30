namespace MidiPlayerTK
{
	public class fluid_revmodelV1
	{
		public class fluid_allpass
		{
			public float feedback;

			public float[] buffer;

			public int bufsize;

			public int bufidx;

			public void fluid_allpass_setbuffer(float[] buf, int size)
			{
			}

			public void fluid_allpass_init()
			{
			}

			public void fluid_allpass_setfeedback(float val)
			{
			}

			public float fluid_allpass_getfeedback()
			{
				return 0f;
			}
		}

		public class fluid_comb
		{
			public float feedback;

			public float filterstore;

			public float damp1;

			public float damp2;

			public float[] buffer;

			public int bufsize;

			public int bufidx;

			public void fluid_comb_setbuffer(float[] buf, int size)
			{
			}

			public void fluid_comb_init()
			{
			}

			public void fluid_comb_setdamp(float val)
			{
			}

			public float fluid_comb_getdamp()
			{
				return 0f;
			}

			public void fluid_comb_setfeedback(float val)
			{
			}

			public float fluid_comb_getfeedback()
			{
				return 0f;
			}
		}

		private const float DC_OFFSET = 1E-08f;

		private const int numcombs = 8;

		private const int numallpasses = 4;

		private const float fixedgain = 0.015f;

		private const float scalewet = 3f;

		private const float scaledamp = 1f;

		private const float scaleroom = 0.28f;

		private const float offsetroom = 0.7f;

		private const float initialroom = 0.5f;

		private const float initialdamp = 0.2f;

		private const int initialwet = 1;

		private const int initialdry = 0;

		private const int initialwidth = 1;

		private const int stereospread = 23;

		private const int combtuningL1 = 1116;

		private const int combtuningR1 = 1139;

		private const int combtuningL2 = 1188;

		private const int combtuningR2 = 1211;

		private const int combtuningL3 = 1277;

		private const int combtuningR3 = 1300;

		private const int combtuningL4 = 1356;

		private const int combtuningR4 = 1379;

		private const int combtuningL5 = 1422;

		private const int combtuningR5 = 1445;

		private const int combtuningL6 = 1491;

		private const int combtuningR6 = 1514;

		private const int combtuningL7 = 1557;

		private const int combtuningR7 = 1580;

		private const int combtuningL8 = 1617;

		private const int combtuningR8 = 1640;

		private const int allpasstuningL1 = 556;

		private const int allpasstuningR1 = 579;

		private const int allpasstuningL2 = 441;

		private const int allpasstuningR2 = 464;

		private const int allpasstuningL3 = 341;

		private const int allpasstuningR3 = 364;

		private const int allpasstuningL4 = 225;

		private const int allpasstuningR4 = 248;

		private float roomsize;

		private float damp;

		private float wet;

		private float wet1;

		private float wet2;

		private float width;

		private float gain;

		private fluid_comb[] combL;

		private fluid_comb[] combR;

		private fluid_allpass[] allpassL;

		private fluid_allpass[] allpassR;

		private float[] bufcombL1;

		private float[] bufcombR1;

		private float[] bufcombL2;

		private float[] bufcombR2;

		private float[] bufcombL3;

		private float[] bufcombR3;

		private float[] bufcombL4;

		private float[] bufcombR4;

		private float[] bufcombL5;

		private float[] bufcombR5;

		private float[] bufcombL6;

		private float[] bufcombR6;

		private float[] bufcombL7;

		private float[] bufcombR7;

		private float[] bufcombL8;

		private float[] bufcombR8;

		private float[] bufallpassL1;

		private float[] bufallpassR1;

		private float[] bufallpassL2;

		private float[] bufallpassR2;

		private float[] bufallpassL3;

		private float[] bufallpassR3;

		private float[] bufallpassL4;

		private float[] bufallpassR4;

		private int FLUID_BUFSIZE;

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

		public fluid_revmodelV1(float sample_rate, int bufsize)
		{
		}

		public void fluid_revmodel_init()
		{
		}

		public void fluid_revmodel_reset()
		{
		}

		public void fluid_revmodel_processreplace(float[] inp, float[] left_out, float[] right_out)
		{
		}

		public void fluid_revmodel_processmix(float[] inp, float[] left_out, float[] right_out)
		{
		}

		public void fluid_revmodel_update()
		{
		}

		public void fluid_revmodel_set(int set, float proomsize, float pdamping, float pwidth, float plevel)
		{
		}

		public void fluid_revmodel_setroomsize(float value)
		{
		}

		public float fluid_revmodel_getroomsize()
		{
			return 0f;
		}

		public void fluid_revmodel_setdamp(float value)
		{
		}

		public float fluid_revmodel_getdamp()
		{
			return 0f;
		}

		public void fluid_revmodel_setlevel(float value)
		{
		}

		public float fluid_revmodel_getlevel()
		{
			return 0f;
		}

		public void fluid_revmodel_setwidth(float value)
		{
		}

		public float fluid_revmodel_getwidth()
		{
			return 0f;
		}
	}
}
