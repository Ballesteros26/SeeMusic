using System.Collections.Generic;
using UnityEngine;

namespace MidiPlayerTK
{
	public class MPTKFootPrint : MonoBehaviour
	{
		public class FootPrint
		{
			public string Name;

			public ulong Ident;

			public List<MPTKEvent> Notes;

			public float ScoreTempo;

			public int NoteCount => 0;

			public override string ToString()
			{
				return null;
			}
		}

		public List<FootPrint> MPTK_MidiLib;

		public bool Verbose;

		private int firstNote;

		private int lastNote;

		private uint shiftLeft;

		private ulong masque;

		private int countNote;

		private uint maxNote;

		private MidiFileLoader midiFileLoader;

		public int SettingFirstNote
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int SettingLastNote
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public uint SettingShiftLeft
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public int SettingCountNote
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void Configuration()
		{
		}

		private void Awake()
		{
		}

		public void MPTK_Clear()
		{
		}

		public void MPTK_AddOne(string name)
		{
		}

		public void MPTK_AddMultiple(string filter = null)
		{
		}

		public List<FootPrint> MPTK_Search(List<MPTKEvent> sequence, int countnote = -1, float tempoScore = -1f)
		{
			return null;
		}

		private List<int> Decode(ulong footprint, int countNote)
		{
			return null;
		}

		public FootPrint MPTK_Encode(List<MPTKEvent> sequence)
		{
			return null;
		}
	}
}
