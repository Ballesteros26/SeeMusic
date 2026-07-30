using System.Runtime.CompilerServices;
using ForieroEngine.MIDIUnified;
using UnityEngine;

[AddComponentMenu("MIDIUnified/Listeners/MidiOutMonitor")]
public class MidiOutMonitor : MonoBehaviour, IMidiSender
{
	public string id;

	public static MidiOutMonitor singleton;

	public bool rawMessage;

	public bool command;

	public bool channel;

	public bool noteOn;

	public bool noteOff;

	public bool pedalOn;

	public bool pedalOff;

	private MidiEvents midiEvents;

	private ShortMessageEventHandler shortMessageEventHandler;

	public string Id => null;

	public event ShortMessageEventHandler ShortMessageEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void ShortMessage(int aCommand, int aData1, int aData2, int deviceId)
	{
	}

	private void NoteOn(int aNote, int aVolume, int aChannel)
	{
	}

	private void NoteOff(int aNote, int aVolume, int aChannel)
	{
	}

	private void PedalOn(PedalEnum aPedal, int aValue, int aChannel)
	{
	}

	private void PedalOff(PedalEnum aPedal, int aValue, int aChannel)
	{
	}
}
