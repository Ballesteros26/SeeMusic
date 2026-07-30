using System.Runtime.CompilerServices;
using ForieroEngine.MIDIUnified;
using UnityEngine;

public class FMODMidiSeq : MonoBehaviour, IMidiSender
{
	public string id;

	[HideInInspector]
	public MidiSeqKaraoke midiSeq;

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

	public void Initialize(byte[] midiBytes, double startTime, string name = null)
	{
	}

	public void ManualUpdate(double t)
	{
	}
}
