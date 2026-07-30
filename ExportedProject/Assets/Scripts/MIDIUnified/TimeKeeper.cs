using System.Runtime.CompilerServices;
using ForieroEngine.MIDIUnified;
using UnityEngine;

public class TimeKeeper : MonoBehaviour, IMidiSender
{
	public string id;

	private float msElapsed;

	private static TimeKeeper singleton;

	public static int beat;

	private static int beatsNumerator;

	private static int beatsDenominator;

	public static int beatsPerMinute;

	public static int upBeatVolume;

	public static int downBeatVolume;

	public static int ms;

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

	public static event TimeKeeperBeatDelegate OnBeat
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

	public static event TimeKeeperBeatDelegate OnStart
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

	public static event TimeKeeperBeatDelegate OnStop
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

	public static event TimeKeeperBeatDelegate OnChange
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

	public static int BeatsPerMinuteToMS(int beatsPerMinute)
	{
		return 0;
	}

	public static int MSToBeatsPerMinute(int ms)
	{
		return 0;
	}

	public static float GetTimeInterval()
	{
		return 0f;
	}

	public static void SetBeats(int aBeatsNumerator)
	{
	}

	public static bool IsRunning()
	{
		return false;
	}

	public static void SetBeatsPerMinute(int aBeatsPerMinute)
	{
	}

	public static void Start(int aBeatsNumerator, int aBeatsDenominator, int aBeatsPerMinute)
	{
	}

	public static void Stop()
	{
	}

	private static void OnInternalTimer()
	{
	}

	public static void BeatEvent(int aBeat, int aBeatsNumerator, int aBeatsDenominator)
	{
	}

	public static void PlayBeat(int aBeat)
	{
	}
}
