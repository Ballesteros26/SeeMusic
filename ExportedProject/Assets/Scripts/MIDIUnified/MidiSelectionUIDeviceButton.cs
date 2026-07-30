using UnityEngine;
using UnityEngine.UI;

public class MidiSelectionUIDeviceButton : MonoBehaviour
{
	public enum Device
	{
		IN = 0,
		OUT = 1
	}

	public MidiSelectionUI midiSelectionUI;

	public Device device;

	public Text text;

	public Image image;

	public bool connected;

	public void OnClick()
	{
	}
}
