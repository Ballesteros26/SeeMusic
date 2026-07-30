using AudioSynthesis.Synthesis;

namespace AudioSynthesis.Bank.Patches
{
	public abstract class Patch
	{
		protected string patchName;

		protected int exTarget;

		protected int exGroup;

		public int ExclusiveGroupTarget => 0;

		public int ExclusiveGroup => 0;

		public string Name => null;

		protected Patch(string name)
		{
		}

		public abstract void Process(VoiceParameters voiceparams, int startIndex, int endIndex);

		public abstract bool Start(VoiceParameters voiceparams);

		public abstract void Stop(VoiceParameters voiceparams);

		public abstract void Load(DescriptorList description, AssetManager assets);

		public override string ToString()
		{
			return null;
		}
	}
}
