using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ForieroEngine.MIDIUnified;
using UnityEngine;

public class MidiDispatcher : MonoBehaviour, IMidiSender
{
	private class MidiMessage
	{
		public int midiIndex;

		public int channel;

		public int volume;

		public float duration;

		public float delay;

		public bool played;

		public Action started;

		public Action finished;

		public bool remove;

		public int deviceId;
	}

	public static MidiDispatcher singleton;

	public string id;

	private static List<MidiMessage> dispatchedNotes;

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

	private void OnEnable()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public static void DispatchNote(int midiIndex, int volume, int channel, int deviceId = -1, float duration = 0f, float delay = 0f, Action started = null, Action finished = null)
	{
	}

	public static void SetupDispatcher()
	{
	}

	private void Update()
	{
	}
}
