using System.IO;

namespace AudioSynthesis.Bank.Descriptors
{
	public class EnvelopeDescriptor
	{
		public float DelayTime;

		public float AttackTime;

		public short AttackGraph;

		public float HoldTime;

		public float DecayTime;

		public short DecayGraph;

		public float SustainTime;

		public float ReleaseTime;

		public short ReleaseGraph;

		public float SustainLevel;

		public float PeakLevel;

		public float StartLevel;

		public float Depth;

		public float Vel2Delay;

		public float Vel2Attack;

		public float Vel2Hold;

		public float Vel2Decay;

		public float Vel2Sustain;

		public float Vel2Release;

		public float Vel2Depth;

		public int Read(BinaryReader reader)
		{
			return 0;
		}

		private void ApplyDefault()
		{
		}

		private void CheckValidParameters()
		{
		}
	}
}
