using ForieroEngine.MIDIUnified;
using UnityEngine;
using UnityEngine.EventSystems;

public class SynthReaction : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler
{
	public NoteEnum note;

	public AccidentalEnum accidental;

	public OctaveEnum octave;

	public ChannelEnum channel;

	public int value;

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}
}
