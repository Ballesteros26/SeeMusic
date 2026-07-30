using System.Runtime.InteropServices;

namespace RenderHeads.Media.AVProVideo
{
	[StructLayout((LayoutKind)0, Pack = 1, Size = 16)]
	public struct TimeRange
	{
		public double startTime;

		public double duration;

		public double StartTime => 0.0;

		public double EndTime => 0.0;

		public double Duration => 0.0;

		public TimeRange(double startTime, double duration)
		{
			this.startTime = 0.0;
			this.duration = 0.0;
		}
	}
}
