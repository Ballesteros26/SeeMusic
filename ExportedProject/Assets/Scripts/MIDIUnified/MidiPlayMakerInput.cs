using System;
using System.Runtime.CompilerServices;
using ForieroEngine.MIDIUnified;
using UnityEngine;

[AddComponentMenu("MIDIUnified/Generators/MidiPlayMakerInput")]
public class MidiPlayMakerInput : MonoBehaviour, IMidiSender
{
	private class MidiOutHelper
	{
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

		public void SetInstrument(ProgramEnum anInstrument, ChannelEnum aChannel = ChannelEnum.C0)
		{
		}

		public void SetInstrument(int anInstrument, int aChannel = 0)
		{
		}

		public void NoteOn(int aNoteIndex, int aVolume = 80, int aChannel = 0)
		{
		}

		public void NoteOn(NoteEnum aNote, AccidentalEnum anAccidental, OctaveEnum anOctave, int aVolume = 80, ChannelEnum aChannel = ChannelEnum.C0)
		{
		}

		public void NoteOff(int aNoteIndex, int aChannel = 0)
		{
		}

		public void NoteOff(NoteEnum aNote, AccidentalEnum anAccidental, OctaveEnum anOctave, ChannelEnum aChannel = ChannelEnum.C0)
		{
		}

		public void Pedal(int aPedal, int aValue, int aChannel = 0)
		{
		}

		public void Pedal(PedalEnum aPedal, int aValue, ChannelEnum aChannel = ChannelEnum.C0)
		{
		}

		public void SendControl(ControllerEnum aControl, int aValue, ChannelEnum aChannel = ChannelEnum.C0)
		{
		}

		public void SendControl(int aControl, int aValue, int aChannel = 0)
		{
		}

		public void AllSoundOff()
		{
		}

		public void ResetAllControllers()
		{
		}

		public void SendShortMessage(int aCommand, int aData1, int aData2, int deviceId)
		{
		}
	}

	public static MidiPlayMakerInput singleton;

	public static Action<MidiPlayMakerInput> OnInitialized;

	public string id;

	private ShortMessageEventHandler shortMessageEventHandler;

	private MidiOutHelper midiOutHelper;

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

	public ChannelEnum GetMidiChannel()
	{
		return default(ChannelEnum);
	}

	public void SetInstrument(ProgramEnum anInstrument, ChannelEnum aChannel)
	{
	}

	public void SetInstrument(int anInstrument)
	{
	}

	public void NoteOn(int aNoteIndex, int aVolume)
	{
	}

	public void NoteOn(NoteEnum aNote, AccidentalEnum anAccidental, OctaveEnum anOctave, int aVolume)
	{
	}

	public void NoteOff(int aNoteIndex)
	{
	}

	public void NoteOff(NoteEnum aNote, AccidentalEnum anAccidental, OctaveEnum anOctave)
	{
	}

	public void Pedal(int aPedal, int aValue)
	{
	}

	public void Pedal(PedalEnum aPedal, int aValue)
	{
	}

	public void SendControl(ControllerEnum aControl, int aValue)
	{
	}

	public void SendControl(int aControl, int aValue)
	{
	}

	public void AllSoundOff()
	{
	}

	public void ResetAllControllers()
	{
	}

	private void ShortMessageHelper(int aCommand, int aData1, int aData2, int deviceId)
	{
	}

	public void SendShortMessage(int aCommand, int aData1, int aData2, int deviceId)
	{
	}
}
