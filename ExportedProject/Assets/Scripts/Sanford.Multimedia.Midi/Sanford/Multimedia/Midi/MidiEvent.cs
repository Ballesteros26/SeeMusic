namespace Sanford.Multimedia.Midi
{
	public class MidiEvent
	{
		private object owner;

		private int absoluteTicks;

		private IMidiMessage message;

		private MidiEvent next;

		private MidiEvent previous;

		public int AbsoluteTicks => 0;

		public IMidiMessage MidiMessage => null;

		internal MidiEvent Next
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal MidiEvent Previous
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal MidiEvent(object owner, int absoluteTicks, IMidiMessage message)
		{
		}

		internal void SetAbsoluteTicks(int absoluteTicks)
		{
		}
	}
}
