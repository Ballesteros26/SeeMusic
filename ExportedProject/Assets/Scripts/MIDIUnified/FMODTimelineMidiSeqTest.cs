using ForieroEngine.MIDIUnified;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FMODTimelineMidiSeqTest : MonoBehaviour
{
	[RestrictInterface(typeof(IMidiSender))]
	public Object generator;

	public FMODTimelineMidiSeq timelineMidiSeq;

	public string one;

	public string two;

	public string three;

	public string four;

	public Slider slider;

	public TextMeshProUGUI text;

	private MidiEvents _me;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}
}
