using ForieroEngine.MIDIUnified;
using UnityEngine;

[AddComponentMenu("MIDIUnified/Listeners/MidiEventsTemplate")]
public class MidiEventsTemplate : MonoBehaviour
{
	public bool hookMidiOut;

	public bool hookSequencer;

	public bool hookKeyboard;

	public bool hookInput;

	public bool hookPlaymaker;

	public bool hookSynthSequencer;

	public MidiOutMonitor midiOutMonitor;

	public MidiSeqKaraokeScript midiSequencerScript;

	public MidiKeyboardInput midiKeyboardInput;

	public MidiInput midiInput;

	public MidiPlayMakerInput midiPlayMakerInput;

	public bool rawMidi;

	public bool noteOn;

	public bool noteOff;

	public bool pedalOn;

	public bool pedalOff;

	private MidiEvents midiEvents;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void RawMidi(int aCommand, int aData1, int aData2, int deviceId)
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

	private void ControllerEventHandler(ControllerEnum aControllerCommand, int aValue, int aChannel)
	{
	}
}
