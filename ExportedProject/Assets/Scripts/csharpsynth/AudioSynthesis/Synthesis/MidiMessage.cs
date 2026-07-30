namespace AudioSynthesis.Synthesis
{
	public struct MidiMessage
	{
		public int delta;

		public byte channel;

		public byte command;

		public byte data1;

		public byte data2;

		public override string ToString()
		{
			return null;
		}
	}
}
