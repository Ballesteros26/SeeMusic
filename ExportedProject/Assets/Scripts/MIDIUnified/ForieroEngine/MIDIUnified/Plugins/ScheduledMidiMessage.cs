namespace ForieroEngine.MIDIUnified.Plugins
{
	public struct ScheduledMidiMessage
	{
		public MidiMessage midiMessage;

		public ITimeProvider timeProvider;

		public double time;
	}
}
