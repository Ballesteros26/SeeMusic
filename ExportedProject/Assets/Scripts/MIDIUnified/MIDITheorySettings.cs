using ForieroEngine.MIDIUnified;
using ForieroEngine.Settings;
using UnityEngine;

[SettingsManager]
public class MIDITheorySettings : Settings<MIDITheorySettings>, ISettingsProvider
{
	public KeySignatureEnum keySignature;

	public TheorySystemEnum theorySystem;

	public TonesSystemEnum tonesSystem;

	[Header("Solfege")]
	public SolfegeSystemEnum solfegeSystem;

	public SolfegeDisplayEnum solfegeDisplay;
}
