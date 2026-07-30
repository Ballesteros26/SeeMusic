using UnityEngine;

namespace MidiPlayerTK
{
	[HelpURL("https://paxstellar.fr/prefab-midiinreader/")]
	[RequireComponent(typeof(AudioSource))]
	public class MidiInReader : MidiSynth
	{
		public bool MPTK_ReadMidiInput;

		[SerializeField]
		private bool realTimeRead;

		public float MPTK_DelayToRefreshDeviceMilliSeconds;

		private float timeTorefresh;

		[HideInInspector]
		public EventMidiClass OnEventInputMidi;

		public bool MPTK_RealTimeRead
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int MPTK_CountEndpoints => 0;

		public string MPTK_GetEndpointDescription(int index)
		{
			return null;
		}

		private new void Awake()
		{
		}

		private new void Start()
		{
		}

		public void OnApplicationQuit()
		{
		}

		public static void ErrorMidiPlugin()
		{
		}

		private void Update()
		{
		}

		private void ProcessEvent(MPTKEvent midievent)
		{
		}
	}
}
