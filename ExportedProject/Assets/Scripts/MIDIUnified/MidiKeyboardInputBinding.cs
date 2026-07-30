using System;
using ForieroEngine.MIDIUnified;
using ForieroEngine.Settings;
using UnityEngine;

[SettingsManager]
public class MidiKeyboardInputBinding : Settings<MidiKeyboardInputBinding>, ISettingsProvider
{
	[Serializable]
	public class KeyBinding
	{
		public KeyCode keyCode;

		public ToneEnum toneEnum;

		[Range(-1f, 1f)]
		public int octaveShift;
	}

	[Serializable]
	public class KeyBindings
	{
		public KeyBinding[] keyBindings;
	}

	public KeyBindings keyBindings;
}
