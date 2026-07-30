using ForieroEngine.MIDIUnified.Synthesizer;
using ForieroEngine.Settings;
using UnityEngine;

[SettingsManager]
public class MIDISynthSettings : Settings<MIDISynthSettings>, ISettingsProvider
{
	[Tooltip("Dispatch midi messages via non blocking threaded queue.")]
	[Header("Threading")]
	public bool threaded;

	[Range(1f, 10f)]
	[Tooltip("Queued Messages thread sleeping time in milliseconds.")]
	public int sleep;

	public bool active;

	[Header("Wwise")]
	public bool wwise;

	[Header("Platform Synthesizers")]
	[Tooltip("ANDROID synthetizer settings.")]
	public Synth.SynthSettingsANDROID android;

	[Tooltip("IOS synthetizer settings.")]
	public Synth.SynthSettingsIOS ios;

	[Tooltip("OSX synthetizer settings.")]
	public Synth.SynthSettingsOSX osx;

	[Tooltip("LINUX synthetizer settings.")]
	public Synth.SynthSettingsLINUX linux;

	[Tooltip("WIN synthetizer settings.")]
	public Synth.SynthSettingsWIN win;

	[Tooltip("WSA ( WINDOWS 10 ) synthetizer settings.")]
	public Synth.SynthSettingsWSA wsa;

	[Tooltip("WEBGL synthetizer settings.")]
	public Synth.SynthSettingsWEBGL webgl;

	public static Synth.SynthSettings GetPlatformSettings()
	{
		return null;
	}
}
