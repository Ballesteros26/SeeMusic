using ForieroEngine.MIDIUnified;
using ForieroEngine.MIDIUnified.Classes;
using ForieroEngine.MIDIUnified.Interfaces;

public class TestMidiController : MidiController<TestMidiController>, IMidiController, IMidiSender, IMidiReceiver
{
}
