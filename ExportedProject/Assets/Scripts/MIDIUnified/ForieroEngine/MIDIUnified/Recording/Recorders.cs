using System;
using System.Collections.Generic;
using Sanford.Multimedia.Midi;
using UnityEngine;

namespace ForieroEngine.MIDIUnified.Recording
{
	public static class Recorders
	{
		public static class AudioListenerR
		{
			public static readonly string fileName;

			public static void Start(AudioListener audioListener)
			{
			}

			public static void Stop(AudioListener audioListener)
			{
			}
		}

		public static class AudioSource
		{
			public static readonly string fileName;

			public static void Start(UnityEngine.AudioSource audioSource)
			{
			}

			public static void Stop(UnityEngine.AudioSource audioSource)
			{
			}
		}

		public static class Microphone
		{
			public static readonly string fileName;

			public static void Start(string microphoneName = null)
			{
			}

			public static void Stop(string microphoneName = null)
			{
			}
		}

		public static class MidiEvents
		{
			public class MidiEventsRecorder : IDisposable
			{
				public readonly string fileName;

				private MidiInternalClock clock;

				private RecordingSession session;

				private ForieroEngine.MIDIUnified.MidiEvents midiEvents;

				private void OnDisable()
				{
				}

				private void OnDestroy()
				{
				}

				public void StartRecording(IMidiSender sender)
				{
				}

				public MidiEventsRecorder(string fileName)
				{
				}

				public void Dispose()
				{
				}

				public void StopRecording()
				{
				}
			}

			public static string fileName;

			public static List<MidiEventsRecorder> recorders;

			public static void Start(IMidiSender sender, string fileName = null)
			{
			}

			public static void Stop(string fileName = null)
			{
			}
		}

		public static class Synth
		{
			public static readonly string fileName;

			public static void Start(AudioClip bgClip = null, float volume = 1f, float speed = 1f, int semitone = 0)
			{
			}

			public static void Stop()
			{
			}
		}

		public static string MicrophoneExistsOrDefault(this string microphoneName)
		{
			return null;
		}
	}
}
