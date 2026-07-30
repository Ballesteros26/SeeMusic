using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace MidiPlayerTK
{
	[HelpURL("https://paxstellar.fr/midiplayerglobal/")]
	public class MidiPlayerGlobal : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CInitThread_003Ed__65 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

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
			public _003CInitThread_003Ed__65(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CLoadSoundFontThread_003Ed__73 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public bool restartPlayer;

			private MidiSynth[] _003Csynths_003E5__2;

			private List<MidiFilePlayer> _003CplayerToRestart_003E5__3;

			private MidiSynth[] _003C_003E7__wrap3;

			private int _003C_003E7__wrap4;

			private MidiSynth _003Csynth_003E5__6;

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
			public _003CLoadSoundFontThread_003Ed__73(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSelectSoundFontThread_003Ed__87 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public string name;

			public bool restartPlayer;

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
			public _003CSelectSoundFontThread_003Ed__87(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private static MidiPlayerGlobal instance;

		public const string SoundfontsDB = "SoundfontsDB";

		public const string MidiFilesDB = "MidiDB";

		public const string SongFilesDB = "SongDB";

		public const string ExtensionMidiFile = ".bytes";

		public const string ExtensionSoundFileDot = ".txt";

		public const string ExtensionSoundFileFileData = "_data.bytes";

		public const string FilenameMidiSet = "MidiSet";

		public const string PathSF2 = "SoundFont";

		public const string PathToWave = "wave";

		public const string ErrorNoSoundFont = "No SoundFont ready found. Load and choose a SoundFont from the Unity Editor menu 'Maestro/SoundFont Setup'";

		public const string ErrorNoPreset = "No Preset found in the SoundFont selected.\nHave you extracted them?\nCheck from the Unity Editor menu 'Maestro/SoundFont Setup'";

		public const string ErrorNoMidiFile = "No MIDI found in the MIDI DB. Add MIDI file from the Unity Editor menu 'Maestro/MIDI File Setup'";

		public const string HelpDefSoundFont = "Add or Select SoundFont from the Unity Editor menu 'Maestro' (Alt-f)";

		[HideInInspector]
		public string PathToResources;

		public static string PathToSoundfonts;

		public static string PathToMidiFile;

		public static string PathToMidiSet;

		public static int MPTK_CountWaveLoaded;

		public static bool MPTK_SoundFontLoaded;

		public bool LoadSoundFontAtStartup;

		public bool LoadWaveAtStartup;

		public static TimeSpan timeToLoadSoundFont;

		public static TimeSpan timeToLoadWave;

		public static ImSoundFont ImSFCurrent;

		public UnityEvent InstanceOnEventPresetLoaded;

		public static MidiSet CurrentMidiSet;

		public static string WavePath;

		private static AudioListener AudioListener;

		private static bool Initialized;

		public static List<MPTKListItem> MPTK_ListMidi;

		public static List<MPTKListItem> MPTK_ListPreset;

		public static List<MPTKListItem> MPTK_ListBank;

		public static List<MPTKListItem> MPTK_ListPresetDrum;

		private static float startupdate;

		public string MPTK_LiveSoundFont;

		public static MidiPlayerGlobal Instance => null;

		public static string MPTK_PathToResources => null;

		public static TimeSpan MPTK_TimeToLoadSoundFont => default(TimeSpan);

		public static TimeSpan MPTK_TimeToLoadWave => default(TimeSpan);

		public static bool MPTK_SoundFontIsReady => false;

		public static int MPTK_CountPresetLoaded => 0;

		public static bool MPTK_LoadSoundFontAtStartup
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool MPTK_LoadWaveAtStartup
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static UnityEvent OnEventPresetLoaded
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static List<string> MPTK_ListSoundFont => null;

		private MidiPlayerGlobal()
		{
		}

		public static int MPTK_FindMidi(string name)
		{
			return 0;
		}

		public static float MPTK_DistanceToListener(Transform trf)
		{
			return 0f;
		}

		public static void InitPath()
		{
		}

		private void Awake()
		{
		}

		public void InitInstance()
		{
		}

		private void OnApplicationQuit()
		{
		}

		public static string MPTK_PresetName(int patch)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CInitThread_003Ed__65))]
		private IEnumerator<float> InitThread()
		{
			return null;
		}

		public static void MPTK_Stop()
		{
		}

		public static void MPTK_Quit()
		{
		}

		public static bool MPTK_IsReady(float delay = 0.5f)
		{
			return false;
		}

		public static bool MPTK_SelectBankInstrument(int nbank)
		{
			return false;
		}

		public static bool MPTK_SelectBankDrum(int nbank)
		{
			return false;
		}

		public static string MPTK_GetPatchName(int bank, int patch)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLoadSoundFontThread_003Ed__73))]
		private static IEnumerator<float> LoadSoundFontThread(bool restartPlayer = true)
		{
			return null;
		}

		private static void LoadSoundFont()
		{
		}

		public static void LoadCurrentSF()
		{
		}

		private static void LoadAudioClip()
		{
		}

		private static void LoadWave()
		{
		}

		public static void LoadWave(HiSample smpl)
		{
		}

		public static void BuildBankList()
		{
		}

		public static void BuildPresetList(bool forInstrument)
		{
		}

		public static void BuildMidiList()
		{
		}

		private static void LoadMidiSetFromRsc()
		{
		}

		public void EndLoadingSF()
		{
		}

		public static void ErrorDetail(Exception ex)
		{
		}

		public static void MPTK_SelectSoundFont(string name, bool restartPlayer = true)
		{
		}

		[IteratorStateMachine(typeof(_003CSelectSoundFontThread_003Ed__87))]
		private static IEnumerator<float> SelectSoundFontThread(string name, bool restartPlayer = true)
		{
			return null;
		}

		private static void SelectSoundFont(string name)
		{
		}

		public static bool MPTK_LoadLiveSF(string pPathSF = null, int defaultBank = -1, int drumBank = -1, bool restartPlayer = true)
		{
			return false;
		}

		public static bool MPTK_MergeLiveSF(string pPathSF)
		{
			return false;
		}
	}
}
