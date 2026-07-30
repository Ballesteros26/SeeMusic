using System;
using ForieroEngine.MIDIUnified;
using ForieroEngine.Settings;
using UnityEngine;

[SettingsManager]
public class MIDISettings : Settings<MIDISettings>, ISettingsProvider
{
	[Serializable]
	public class MidiInstrumentsSettings
	{
		public bool initialize;

		public ProgramEnum[] instruments;
	}

	[Serializable]
	public class MidiInputSettings
	{
		public enum UpdateEnum
		{
			Update = 0,
			LateUpdate = 1,
			FixedUpdate = 2
		}

		public bool initialize;

		public bool active;

		[Tooltip("Messages will be queued in non-blocking queue and proceeded on separate thread.")]
		public bool threaded;

		[Range(1f, 10f)]
		[Tooltip("Queued Messages thread sleeping time in milliseconds.")]
		public int sleep;

		[Tooltip("Sending midi messages directly to outputs once they are received.")]
		public bool through;

		[Tooltip("Sending midi messages directly to Synth once they are received.")]
		public bool synth;

		public bool midiOut;

		[Tooltip("Update loop on which to proceed the messages.")]
		public UpdateEnum update;

		public bool useCustomVolume;

		[Range(0f, 1f)]
		[Tooltip("This value overrides volume data so you won't be able to hear pressed key dynamics.")]
		public float customVolume;

		[Tooltip("This value multiplies volume data to make it softer or louder.")]
		[Range(0f, 10f)]
		public float multiplyVolume;

		public ChannelEnum midiChannel;

		public bool cleanBuffer;

		[Header("Log")]
		public bool logAll;

		[Tooltip("1000_0000 : 1110_1111")]
		public bool logShortMessages;

		[Tooltip("11111_0000 : 1111_1111")]
		public bool logSystemMessages;
	}

	[Serializable]
	public class MidiOutputSettings
	{
		public bool active;

		[Tooltip("Messages will be queued in non-blocking queue and proceeded on separate thread.")]
		public bool threaded;

		[Range(1f, 10f)]
		[Tooltip("Queued Messages thread sleeping time in milliseconds.")]
		public int sleep;

		public bool synth;

		[Header("Log")]
		public bool logAll;

		[Tooltip("1000_0000 : 1110_1111")]
		public bool logShortMessages;

		[Tooltip("11111_0000 : 1111_1111")]
		public bool logSystemMessages;
	}

	[Serializable]
	public class MidiKeyboardInputSettings
	{
		public enum KeyboardInputType
		{
			ABCDEFG = 0,
			QUERTY = 1,
			Custom = 2,
			Undefined = int.MaxValue
		}

		public bool initialize;

		public bool active;

		public bool synth;

		public bool midiOut;

		public int keyboardOctave;

		public bool updateKeyboardOctave;

		public bool muteTonesWhenChangingOctave;

		[Range(0f, 1f)]
		public float customVolume;

		public ChannelEnum midiChannel;

		public KeyboardInputType keyboardInputType;

		public MidiKeyboardInputBinding keyboardInputBinding;
	}

	[Serializable]
	public class MidiPlaymakerInputSettings
	{
		public bool initialize;

		public bool active;

		public bool synth;

		public bool midiOut;

		public ChannelEnum midiChannel;

		public bool useCustomVolume;

		public float customVolume;
	}

	[Tooltip("Log MIDIUnified debug messages!")]
	public bool debug;

	[HideInInspector]
	public static string soundFontPersistentPath;

	[Header("Initialize MIDI?")]
	[Tooltip("If you don't want to initialize MIDIUnified at all set this to FALSE!")]
	public bool initialize;

	[Header("Company or App identifier")]
	public string appId;

	[Tooltip("If TRUE code will try to connect 'defaultMidiIn' port.")]
	[Header("Midi IN")]
	public bool forceDefaultMidiIn;

	[Tooltip("Set it to -1 if you want to skip auto default connection attempt!")]
	[Range(-1f, 10f)]
	public int defaultMidiIn;

	public string[] virtualIns;

	[Header("Midi OUT")]
	[Tooltip("If TRUE code will try to connect 'defaultMidiOut' port.")]
	public bool forceDefaultMidiOut;

	[Range(-1f, 10f)]
	[Tooltip("Set it to -1 if you want to skip auto default connection attempt!")]
	public int defaultMidiOut;

	public string[] virtualOuts;

	[Tooltip("Prevents connection of IN and OUT ports with the same name.")]
	[Header("Infinite Midi Loop")]
	public bool midiInOutExclusive;

	[Tooltip("Watch Midi IN/OUT infinite loop!")]
	public bool watchInfiniteLoop;

	[Tooltip("Threshold for infinite loop.")]
	public int infiniteLoopThreshold;

	[HideInInspector]
	public int synthChannelMask;

	[HideInInspector]
	public int channelMask;

	[Header("Midi Instruments")]
	[Tooltip("Ignore 'Program Messages' also called 'Instrument Messages' when midi file starts to play")]
	public bool ignoreProgramMessages;

	[Tooltip("MIDI Instruments Settings.")]
	public MidiInstrumentsSettings instrumentsSettings;

	[Tooltip("MIDI IN Settings.")]
	public MidiInputSettings inputSettings;

	[Tooltip("MIDI OUT Settings.")]
	public MidiOutputSettings outputSettings;

	[Tooltip("( MIDI ) Keyboard Settings. Please note that this is physical keyaboard on which you type. We map AWSEDFTGYHUJK to mimic real MIDI IN on your normal keyboard.")]
	public MidiKeyboardInputSettings keyboardSettings;

	[Tooltip("MIDI Playmaker Settings needs to be activated if you want to send and receive midi messages from Playmaker.")]
	public MidiPlaymakerInputSettings playmakerSettings;

	public static bool IsDebug => false;
}
