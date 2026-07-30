using AudioSynthesis.Sf2;
using AudioSynthesis.Synthesis;

namespace AudioSynthesis.Bank.Patches
{
	public class MultiPatch : Patch
	{
		private class PatchInterval
		{
			public Patch patch;

			public byte startChannel;

			public byte startKey;

			public byte startVelocity;

			public byte endChannel;

			public byte endKey;

			public byte endVelocity;

			public PatchInterval(Patch patch, byte startChannel, byte endChannel, byte startKey, byte endKey, byte startVelocity, byte endVelocity)
			{
			}

			public bool CheckAllIntervals(int channel, int key, int velocity)
			{
				return false;
			}

			public bool CheckChannelAndKey(int channel, int key)
			{
				return false;
			}

			public bool CheckKeyAndVelocity(int key, int velocity)
			{
				return false;
			}

			public bool CheckKey(int key)
			{
				return false;
			}

			public override string ToString()
			{
				return null;
			}
		}

		private enum IntervalType
		{
			Channel_Key_Velocity = 0,
			Channel_Key = 1,
			Key_Velocity = 2,
			Key = 3
		}

		private IntervalType iType;

		private PatchInterval[] intervalList;

		public MultiPatch(string name)
			: base(null)
		{
		}

		public int FindPatches(int channel, int key, int velocity, Patch[] layers)
		{
			return 0;
		}

		public override bool Start(VoiceParameters voiceparams)
		{
			return false;
		}

		public override void Stop(VoiceParameters voiceparams)
		{
		}

		public override void Process(VoiceParameters voiceparams, int startIndex, int endIndex)
		{
		}

		public override void Load(DescriptorList description, AssetManager assets)
		{
		}

		public void LoadSf2(Sf2Region[] regions, AssetManager assets)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private void DetermineIntervalType()
		{
		}
	}
}
