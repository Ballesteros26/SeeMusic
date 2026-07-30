using System.Collections;

namespace RenderHeads.Media.AVProVideo
{
	public class TimeRanges : IEnumerable
	{
		internal TimeRange[] _ranges;

		internal double _minTime;

		internal double _maxTime;

		public TimeRange this[int index] => default(TimeRange);

		public int Count => 0;

		public double MinTime => 0.0;

		public double MaxTime => 0.0;

		public double Duration => 0.0;

		internal TimeRanges()
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		internal TimeRanges(TimeRange[] ranges)
		{
		}

		internal void CalculateRange()
		{
		}
	}
}
