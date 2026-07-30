using System.Collections.Generic;

namespace AudioSynthesis.Synthesis
{
	internal class VoiceManager
	{
		public class VoiceNode
		{
			public Voice Value;

			public VoiceNode Next;
		}

		public VoiceStealEnum stealingMethod;

		public int polyphony;

		public LinkedList<Voice> freeVoices;

		public LinkedList<Voice> activeVoices;

		public VoiceNode[,] registry;

		private Voice[] voicePool;

		private Stack<VoiceNode> vnodes;

		public VoiceManager(int voiceCount)
		{
		}

		public Voice GetFreeVoice()
		{
			return null;
		}

		public void AddToRegistry(Voice voice)
		{
		}

		public void RemoveFromRegistry(int channel, int note)
		{
		}

		public void RemoveFromRegistry(Voice voice)
		{
		}

		public void ClearRegistry()
		{
		}

		public void UnloadPatches()
		{
		}

		private Voice StealOldest()
		{
			return null;
		}

		private Voice StealQuietestVoice()
		{
			return null;
		}
	}
}
