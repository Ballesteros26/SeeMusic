using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using UnityEngine.Networking;

namespace MidiPlayerTK
{
	[Serializable]
	public class ImSoundFont
	{
		[CompilerGenerated]
		private sealed class _003CLoadLiveSF_003Ed__25 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public string pathSF;

			public MidiSynth[] synths;

			public int defaultBank;

			public int drumBank;

			public bool restartPlayer;

			private List<MidiFilePlayer> _003CplayerToRestart_003E5__2;

			private MidiSynth[] _003C_003E7__wrap2;

			private int _003C_003E7__wrap3;

			private MidiSynth _003Csynth_003E5__5;

			private UnityWebRequest _003Creq_003E5__6;

			float IEnumerator<float>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0f;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CLoadLiveSF_003Ed__25(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public string SoundFontName;

		public int DefaultBankNumber;

		public int DrumKitBankNumber;

		public const int MAXBANKPRESET = 129;

		public int LoadType;

		public int CompressionFormat;

		public string StrBankSelected;

		[XmlIgnore]
		public bool LiveSF;

		[XmlIgnore]
		public bool[] BankSelected;

		[XmlIgnore]
		public SFData HiSf;

		[XmlIgnore]
		public float[] SamplesData;

		[XmlIgnore]
		public ImBank[] Banks;

		public int IndexInstrumentBank => 0;

		public int IndexDrumBank => 0;

		public void SelectAllBanks()
		{
		}

		public void UnSelectAllBanks()
		{
		}

		public void InverseSelectedBanks()
		{
		}

		public int FirstBank()
		{
			return 0;
		}

		public int LastBank()
		{
			return 0;
		}

		public static ImSoundFont LoadMPTKSoundFont(string path, string name)
		{
			return null;
		}

		public static void LoadBanks(ImSoundFont imsf)
		{
		}

		public void SaveMPTK(string path, string name, bool onlyXML)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadLiveSF_003Ed__25))]
		public static IEnumerator<float> LoadLiveSF(string pathSF, int defaultBank = -1, int drumBank = -1, MidiSynth[] synths = null, bool restartPlayer = true)
		{
			return null;
		}

		public static void CreateDefaultSoundFont(SFData sfData, int defaultBank, int drumBank, MidiSynth[] synths = null, bool restartPlayer = true, List<MidiFilePlayer> playerToRestart = null)
		{
		}
	}
}
