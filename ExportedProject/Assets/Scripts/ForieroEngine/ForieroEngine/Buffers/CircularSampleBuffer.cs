namespace ForieroEngine.Buffers
{
	public class CircularSampleBuffer
	{
		private float[] _buffer;

		private int _writePosition;

		private int _readPosition;

		public int Count { get; private set; }

		public CircularSampleBuffer(int size)
		{
		}

		public void Clear()
		{
		}

		public int Write(float[] data, int offset, int count)
		{
			return 0;
		}

		public int Read(float[] data, int offset, int count)
		{
			return 0;
		}
	}
}
