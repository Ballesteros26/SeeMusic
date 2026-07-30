using UnityEngine.Scripting;

namespace MidiPlayerTK
{
	public class SoundFontInfo
	{
		public string Name;

		public int PatchCount;

		public int WaveCount;

		public long WaveSize;

		public string SF2Path;

		[Preserve]
		public SoundFontInfo()
		{
		}
	}
}
