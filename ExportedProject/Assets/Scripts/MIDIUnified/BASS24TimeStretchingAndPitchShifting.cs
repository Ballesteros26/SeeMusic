using System;
using UnityEngine;
using UnityEngine.UI;

public class BASS24TimeStretchingAndPitchShifting : MonoBehaviour
{
	public MidiSeqKaraokeScript midiScript;

	public Slider speedSlider;

	public Slider semitoneSlider;

	public Text speedText;

	public Text semitoneText;

	public Text playPauseText;

	public Text timeText;

	private TimeSpan t;

	private DateTime dateTime;

	private string time;

	private MidiSeqStates state;

	public void Play()
	{
	}

	public void Stop()
	{
	}

	public void OnSpeedSliderChange()
	{
	}

	public void OnSemitoneSliderChange()
	{
	}

	private void Update()
	{
	}
}
