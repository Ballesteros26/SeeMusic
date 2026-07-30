using System;
using System.Runtime.CompilerServices;
using ForieroEngine.MIDIUnified;
using ForieroEngine.MIDIUnified.Plugins;
using UnityEngine;

[AddComponentMenu("MIDIUnified/Generators/MidiInput")]
public class MidiInput : MonoBehaviour, IMidiSender
{
	public delegate void MidiBytesEventHandler(byte[] bytes, int deviceId);

	public static MidiInput singleton;

	public static Action<MidiInput> OnInitialized;

	public string id;

	private int _volume;

	private int _command;

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

	public static event MidiBytesEventHandler MidiBytesEvent
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

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void FixedUpdate()
	{
	}

	public void ProcessMidiMessage(MidiMessage midiMessage)
	{
	}

	private void ProcessMidiInMessages()
	{
	}
}
