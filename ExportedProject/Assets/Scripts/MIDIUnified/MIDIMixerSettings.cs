using ForieroEngine.Settings;
using UnityEngine.Audio;

[SettingsManager]
public class MIDIMixerSettings : Settings<MIDIMixerSettings>, ISettingsProvider
{
	public AudioMixer mixer;

	public AudioMixerGroup metronome;

	public AudioMixerGroup microphone;

	public AudioMixerGroup accompaniment;

	public AudioMixerGroup instrument;
}
