using System;
using ForieroEngine.Settings;
using UnityEngine;

[SettingsManager]
public class MIDISoundSettings : Settings<MIDISoundSettings>, ISettingsProvider
{
	[Serializable]
	public class PlatformSettings
	{
		public enum OutputSampleRateDividerEnum
		{
			One = 1,
			Two = 2,
			Four = 4
		}

		[Tooltip("AudioSettings.outputSampleRate / outputSampleRateDivider")]
		public OutputSampleRateDividerEnum outputSampleRateDivider;

		public int BASS_CONFIG_UPDATEPERIOD;

		public int BASS_CONFIG_BUFFER;

		public bool BASS_INFO_MIN_BUFFER;

		public int sampleRate => 0;
	}

	public bool init;

	[Header("BASS24NET License Login Required. http://bass.radio42.com/")]
	public string userName;

	[Password]
	public string regKey;

	[Header("Platform settings")]
	public PlatformSettings android;

	public PlatformSettings ios;

	public PlatformSettings wsa;

	public PlatformSettings windows;

	public PlatformSettings linux;

	public PlatformSettings osx;

	public PlatformSettings other;

	public static bool initialized;

	public static PlatformSettings settings => null;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void AutoInit()
	{
	}

	public static void Init(int frequency = -1)
	{
	}

	public static void Register(string userName, string regKey)
	{
	}

	public static void Free()
	{
	}
}
