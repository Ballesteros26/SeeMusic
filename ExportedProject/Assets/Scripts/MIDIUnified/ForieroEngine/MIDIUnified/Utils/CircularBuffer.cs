namespace ForieroEngine.MIDIUnified.Utils
{
	public class CircularBuffer
	{
		private byte[] buffer;

		private int writePosition;

		private int readPosition;

		private int byteCount;

		private object lockObject;

		public int MaxLength => 0;

		public int Count => 0;

		public CircularBuffer(int size)
		{
		}

		public int Write(byte[] data, int offset, int count)
		{
			return 0;
		}

		public int Read(byte[] data, int offset, int count)
		{
			return 0;
		}

		public void Reset()
		{
		}

		public void Advance(int count)
		{
		}
	}
}
