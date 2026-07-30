using System.Collections.Generic;
using UnityEngine.Scripting;

namespace MidiPlayerTK
{
	public class MidiSet
	{
		public List<SoundFontInfo> SoundFonts;

		public int IndexSelectedSF;

		public List<string> MidiFiles;

		public SoundFontInfo ActiveSounFontInfo => null;

		[Preserve]
		public MidiSet()
		{
		}

		public void AddSoundFont(ImSoundFont imsf)
		{
		}

		public int LastIndexSoundFont()
		{
			return 0;
		}

		public void SetActiveSoundFont(int index)
		{
		}

		public void Save()
		{
		}

		public static MidiSet Load(string path)
		{
			return null;
		}

		public static MidiSet LoadRsc(string data)
		{
			return null;
		}
	}
}
