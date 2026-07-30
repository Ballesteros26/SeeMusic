namespace ForieroEngine.MIDIUnified.Plugins
{
	public interface IMidiINDevice : IMidiDevice
	{
		int PopMessage(out MidiMessage midiMessage, bool editor = false);
	}
}
