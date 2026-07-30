using ForieroEngine.MIDIUnified;
using UnityEngine;

public class MidiSenderMonitor : MonoBehaviour
{
	[RestrictInterface(typeof(IMidiSender))]
	public Object midiGenerator;

	public bool log;

	public string logName;

	public Color logColor;

	private MidiEvents _midiEvents;

	private IMidiSender MidiSender => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}
}
