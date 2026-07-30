using System;
using System.Runtime.CompilerServices;
using ForieroEngine.MIDIUnified;
using UnityEngine;

[AddComponentMenu("MIDIUnified/Generators/MidiKeyboardInput")]
public class MidiKeyboardInput : MonoBehaviour, IMidiSender
{
	private enum AccidentalState
	{
		none = 0,
		sharp = 1,
		flat = -1
	}

	public static MidiKeyboardInput singleton;

	public static Action<MidiKeyboardInput> OnInitialized;

	public string id;

	private AccidentalState accidentalState;

	private MidiKeyboardInputBinding.KeyBindings ABCDEFGBindings;

	private MidiKeyboardInputBinding.KeyBindings QUERTYBindings;

	private MidiKeyboardInputBinding.KeyBindings keyBindings;

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

	private void Update()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void MuteTones()
	{
	}

	private void KeyDown(int aMidiIdx)
	{
	}

	private void KeyUp(int aMidiIdx)
	{
	}

	private void SendShortMessage(CommandEnum aCommand, int aData1, int aData2, int deviceId)
	{
	}

	private void ProceedKeyboardInput()
	{
	}
}
