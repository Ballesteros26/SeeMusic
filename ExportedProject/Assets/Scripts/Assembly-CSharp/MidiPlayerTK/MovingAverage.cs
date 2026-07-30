using System.Collections.Generic;

namespace MidiPlayerTK
{
	public class MovingAverage
	{
		private Queue<int> samples;

		private int windowSize;

		private int sampleAccumulator;

		public int Count => 0;

		public int Average => 0;

		public MovingAverage()
		{
		}

		public MovingAverage(int size)
		{
		}

		public void Add(int newSample)
		{
		}
	}
}
