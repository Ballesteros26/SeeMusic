using System;
using System.Threading;
using ForieroEngine.Collections.NonBlocking;
using ForieroEngine.MIDIUnified.Plugins;
using UnityEngine;

namespace ForieroEngine.MIDIUnified.Synthesizer
{
	public static class Synth
	{
		private class BASS24SynthProvider : SynthProvider, ISynthRecorder
		{
			private static class Plugin
			{
				public static int Start(Settings settings)
				{
					return 0;
				}

				public static int Stop()
				{
					return 0;
				}

				public static int SendShortMessage(int Command, int Data1, int Data2)
				{
					return 0;
				}
			}

			public override int Start(Settings settings)
			{
				return 0;
			}

			public override int Stop()
			{
				return 0;
			}

			public override int SendShortMessage(int Command, int Data1, int Data2)
			{
				return 0;
			}

			public void StartRecording(AudioClip bgClip = null, float volume = 1f, float speed = 1f, int semitone = 0)
			{
			}

			public void StopRecording()
			{
			}
		}

		private abstract class SynthProvider : ISynthProvider
		{
			public abstract int Start(Settings settings);

			public abstract int Stop();

			public abstract int SendShortMessage(int Command, int Data1, int Data2);
		}

		private class CSHARPSynthProvider : SynthProvider, ISynthRecorder
		{
			private static class Plugin
			{
				public static int Start(Settings settings)
				{
					return 0;
				}

				public static int Stop()
				{
					return 0;
				}

				public static int SendShortMessage(int Command, int Data1, int Data2)
				{
					return 0;
				}
			}

			public override int Start(Settings settings)
			{
				return 0;
			}

			public override int Stop()
			{
				return 0;
			}

			public override int SendShortMessage(int Command, int Data1, int Data2)
			{
				return 0;
			}

			public void StartRecording(AudioClip bgClip = null, float volume = 1f, float speed = 1f, int semitone = 0)
			{
			}

			public void StopRecording()
			{
			}
		}

		private class FLUIDSynthProvider : SynthProvider, ISynthRecorder
		{
			private static class Plugin
			{
				public static int Start(Settings settings)
				{
					return 0;
				}

				public static int Stop()
				{
					return 0;
				}

				public static int SendShortMessage(int Command, int Data1, int Data2)
				{
					return 0;
				}
			}

			public override int Start(Settings settings)
			{
				return 0;
			}

			public override int Stop()
			{
				return 0;
			}

			public override int SendShortMessage(int Command, int Data1, int Data2)
			{
				return 0;
			}

			public void StartRecording(AudioClip bgClip = null, float volume = 1f, float speed = 1f, int semitone = 0)
			{
			}

			public void StopRecording()
			{
			}
		}

		private class NATIVESynthProvider : SynthProvider
		{
			public static SynthSettingsIOS.SoundBankEnum soundBank;

			public override int Start(Settings settings)
			{
				return 0;
			}

			public override int Stop()
			{
				return 0;
			}

			public override int SendShortMessage(int Command, int Data1, int Data2)
			{
				return 0;
			}
		}

		private class TINYSOUNDFONDSynthProvider : SynthProvider, ISynthRecorder
		{
			private static class Plugin
			{
				public static int Start(Settings settings)
				{
					return 0;
				}

				public static int Stop()
				{
					return 0;
				}

				public static int SendShortMessage(int Command, int Data1, int Data2)
				{
					return 0;
				}
			}

			public override int Start(Settings settings)
			{
				return 0;
			}

			public override int Stop()
			{
				return 0;
			}

			public override int SendShortMessage(int Command, int Data1, int Data2)
			{
				return 0;
			}

			public void StartRecording(AudioClip bgClip = null, float volume = 1f, float speed = 1f, int semitone = 0)
			{
			}

			public void StopRecording()
			{
			}
		}

		public struct Settings
		{
			public int sampleRate;

			public int channels;

			public int polyphony;
		}

		public enum SynthEnum
		{
			NONE = 0,
			NATIVE = 1,
			BASS24 = 2,
			CSHARP = 3
		}

		[Serializable]
		public abstract class SynthSettings
		{
			public enum OutputSampleRateDividerEnum
			{
				One = 1,
				Two = 2,
				Four = 4
			}

			[Tooltip("AudioSettings.outputSampleRate / outputSampleRateDivider")]
			public OutputSampleRateDividerEnum outputSampleRateDivider;

			[Tooltip("Number of maximum simultaneously playing tones.")]
			[Range(1f, 256f)]
			public int polyphony;

			[Range(1f, 16f)]
			public int channels;

			public bool preinit;

			[Range(0f, 4f)]
			public float volume;

			public int sampleRate => 0;

			public abstract SynthEnum GetSynthEnum();

			public ISynthProvider CreateSynthProvider()
			{
				return null;
			}
		}

		[Serializable]
		public class SynthSettingsWSA : SynthSettings
		{
			public enum SynthEnum
			{
				NONE = 0,
				BASS24 = 2,
				CSHARP = 3
			}

			public SynthEnum synthesizer;

			public override Synth.SynthEnum GetSynthEnum()
			{
				return default(Synth.SynthEnum);
			}
		}

		[Serializable]
		public class SynthSettingsWEBGL : SynthSettings
		{
			public enum SynthEnum
			{
				NONE = 0,
				CSHARP = 3
			}

			public SynthEnum synthesizer;

			public override Synth.SynthEnum GetSynthEnum()
			{
				return default(Synth.SynthEnum);
			}
		}

		[Serializable]
		public class SynthSettingsOSX : SynthSettings
		{
			public enum SynthEnum
			{
				NONE = 0,
				BASS24 = 2,
				NATIVE = 1,
				CSHARP = 3
			}

			public SynthEnum synthesizer;

			public override Synth.SynthEnum GetSynthEnum()
			{
				return default(Synth.SynthEnum);
			}
		}

		[Serializable]
		public class SynthSettingsLINUX : SynthSettings
		{
			public enum SynthEnum
			{
				NONE = 0,
				BASS24 = 2,
				NATIVE = 1,
				CSHARP = 3
			}

			public SynthEnum synthesizer;

			public override Synth.SynthEnum GetSynthEnum()
			{
				return default(Synth.SynthEnum);
			}
		}

		[Serializable]
		public class SynthSettingsWIN : SynthSettings
		{
			public enum SynthEnum
			{
				NONE = 0,
				BASS24 = 2,
				CSHARP = 3
			}

			public SynthEnum synthesizer;

			public override Synth.SynthEnum GetSynthEnum()
			{
				return default(Synth.SynthEnum);
			}
		}

		[Serializable]
		public class SynthSettingsIOS : SynthSettings
		{
			public enum SynthEnum
			{
				NONE = 0,
				BASS24 = 2,
				NATIVE = 1,
				CSHARP = 3
			}

			public enum SoundBankEnum
			{
				sf2 = 0,
				dls = 1,
				aupreset = 2
			}

			public SynthEnum synthesizer;

			public SoundBankEnum soundBank;

			public override Synth.SynthEnum GetSynthEnum()
			{
				return default(Synth.SynthEnum);
			}
		}

		[Serializable]
		public class SynthSettingsANDROID : SynthSettings
		{
			public enum SynthEnum
			{
				NONE = 0,
				BASS24 = 2,
				CSHARP = 3
			}

			public SynthEnum synthesizer;

			public override Synth.SynthEnum GetSynthEnum()
			{
				return default(Synth.SynthEnum);
			}
		}

		private static class MidiThread
		{
			private static bool _terminating;

			private static Thread _thread;

			public static void Initialise()
			{
			}

			public static void ClearQueue()
			{
			}

			private static void SynthThread()
			{
			}

			public static void Terminate()
			{
			}
		}

		private static ISynthProvider _provider;

		private static ISynthRecorder _recorder;

		public static SynthSettings settings;

		private static bool _initialized;

		public static bool threaded;

		public static int sleep;

		private static readonly NonBlockingQueue<MidiMessage> Messages;

		private static readonly NonBlockingQueue<ScheduledMidiMessage> ScheduledMessages;

		public static bool initialized => false;

		public static void Init()
		{
		}

		public static void ClearQueue()
		{
		}

		public static void Start()
		{
		}

		private static void PreInit()
		{
		}

		public static void Stop()
		{
		}

		public static void SendScheduledShortMessage(double time, ITimeProvider timeProvider, int aCommand, int aChannel, int aData1, int aData2)
		{
		}

		public static void SendScheduledShortMessage(double time, ITimeProvider timeProvider, int aChannelCommand, int aData1, int aData2)
		{
		}

		public static void SendMidiMessage(MidiMessage m)
		{
		}

		public static void SendShortMessage(int aCommand, int aChannel, int aData1, int aData2)
		{
		}

		public static void SendShortMessage(int aChannelCommand, int aData1, int aData2)
		{
		}

		private static void SendShortMessageInternal(int aChannelCommand, int aData1, int aData2)
		{
		}

		public static void StartRecording(AudioClip bgClip = null, float volume = 1f, float speed = 1f, int semitone = 0)
		{
		}

		public static void StopRecording()
		{
		}

		public static void Terminate()
		{
		}
	}
}
