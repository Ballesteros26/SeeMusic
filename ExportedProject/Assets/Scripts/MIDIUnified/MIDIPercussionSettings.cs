using System.Collections.Generic;
using ForieroEngine.MIDIUnified;
using ForieroEngine.Settings;
using UnityEngine;

[SettingsManager]
public class MIDIPercussionSettings : Settings<MIDIPercussionSettings>, ISettingsProvider
{
	public bool initialize;

	[Tooltip(null)]
	public int maxScheduledUnits;

	[Tooltip(null)]
	public PercussionEnum metronomeHeavy;

	[Range(0f, 1f)]
	[Tooltip(null)]
	public float metronomeHeavyVolume;

	[Tooltip(null)]
	public PercussionEnum metronomeLight;

	[Range(0f, 1f)]
	[Tooltip(null)]
	public float metronomeLightVolume;

	[Tooltip(null)]
	public PercussionEnum metronomeSubdivision;

	[Tooltip(null)]
	[Range(0f, 1f)]
	public float metronomeSubdivisionVolume;

	public bool metronomeSubdivisionsEnabled;

	[Tooltip(null)]
	public PercussionEnum rhythm;

	[Range(0f, 1f)]
	[Tooltip(null)]
	public float rhythmVolume;

	[Tooltip(null)]
	public AudioClip[] percussionClips;

	private readonly SortedDictionary<PercussionEnum, AudioClip> _percussionClips;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void InitBeforeSceneLoad()
	{
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
	private static void InitAfterSceneLoad()
	{
	}

	public static void InitPercussion()
	{
	}

	private AudioClip GetAudioClipInternal(PercussionEnum percussionEnum)
	{
		return null;
	}

	public AudioClip GetAudioClip(PercussionEnum percussionEnum)
	{
		return null;
	}

	public static PercussionEnum GetPercussionEnum(BeatType beatType)
	{
		return default(PercussionEnum);
	}

	public static float GetPercussionVolume(BeatType beatType)
	{
		return 0f;
	}

	public static int GetPercussionAttack(BeatType beatType)
	{
		return 0;
	}
}
