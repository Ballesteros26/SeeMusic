using System;
using UnityEngine;

namespace ForieroEngine.MIDIUnified.SysEx
{
	public static class SysEx
	{
		public static class MC
		{
			public static class MCParser
			{
				public static bool Parse(byte[] bytes)
				{
					return false;
				}

				private static bool ParseSongPositionPointer(byte[] bytes)
				{
					return false;
				}

				private static void ParseTick()
				{
				}
			}

			public static Action OnStart;

			public static Action OnStop;

			public static Action OnContinue;

			public static Action OnTimeSignature;

			public static Action OnTick;

			public static Action OnBeat;

			public static Action OnBar;

			private static long timestamps;

			private static double length;

			private static int total24thTicks;

			private static int total16thTicks;

			public static int ticks { get; private set; }

			public static int bar { get; private set; }

			public static int beat { get; private set; }

			public static int timeNumerator { get; private set; }

			public static int timeDenominator { get; private set; }

			private static double seconds
			{
				get
				{
					return 0.0;
				}
				set
				{
				}
			}

			private static double bpm
			{
				get
				{
					return 0.0;
				}
				set
				{
				}
			}

			public static void Reset()
			{
			}

			private static double BeatsToSeconds(int beats)
			{
				return 0.0;
			}

			private static int SecondsToBeats(double seconds)
			{
				return 0;
			}

			private static double BpmToMs(double bpm)
			{
				return 0.0;
			}

			private static double MsToBpm(double ms)
			{
				return 0.0;
			}

			public new static string ToString()
			{
				return null;
			}
		}

		public static class MTC
		{
			public enum FrameRate
			{
				FRAMERATE_24 = 0,
				FRAMERATE_25 = 1,
				FRAMERATE_30_DROP = 2,
				FRAMERATE_30 = 3
			}

			public enum Direction
			{
				BACKWARDS = -1,
				UNKNOWN = 0,
				FORWARDS = 1
			}

			public struct TimecodeFrame
			{
				public int hours;

				public int minutes;

				public int seconds;

				public int frames;

				public FrameRate frameRate;

				public int FramesInMilliseconds()
				{
					return 0;
				}

				public float FPS()
				{
					return 0f;
				}

				public override string ToString()
				{
					return null;
				}

				public float ToSeconds()
				{
					return 0f;
				}

				public void FromSeconds(float seconds, FrameRate frameRate = FrameRate.FRAMERATE_24)
				{
				}

				public void Reset()
				{
				}
			}

			public struct QuarterFrame
			{
				public TimecodeFrame timecodeFrame;

				public int count;

				public bool receivedFirst;

				public bool receivedLast;

				public int lastDataByte;

				public Direction direction;

				public void Reset()
				{
				}
			}

			public static class MTCParser
			{
				private const int FULLFRAME_LEN = 10;

				private const int QUARTERFRAME_LEN = 8;

				private static QuarterFrame quarterFrame;

				public static bool IsFullFrameTimeCode(byte[] bytes)
				{
					return false;
				}

				public static bool ParseFullFrame(byte[] bytes)
				{
					return false;
				}

				public static bool ParseQuarterFrame(byte[] bytes)
				{
					return false;
				}
			}

			public static Action OnMTCRealTimeFrame;

			public static TimecodeFrame mtcRealTimeFrame;

			public static Action OnMTCFullFrame;

			public static TimecodeFrame mtcFullFrame;
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Init()
		{
		}

		public static float ToMultiplier(this MTC.FrameRate frameRate)
		{
			return 0f;
		}

		public static float ToFPS(this MTC.FrameRate frameRate)
		{
			return 0f;
		}

		public static MTC.FrameRate ToFrameRate(float fps)
		{
			return default(MTC.FrameRate);
		}

		public static int FramesToMilliseconds(this MTC.FrameRate frameRate, int frames)
		{
			return 0;
		}

		public static int MillisecondsToFrames(this MTC.FrameRate frameRate, int milliseconds)
		{
			return 0;
		}
	}
}
