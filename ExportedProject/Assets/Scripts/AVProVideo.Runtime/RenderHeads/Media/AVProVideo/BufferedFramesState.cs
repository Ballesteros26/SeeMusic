using System.Runtime.InteropServices;

namespace RenderHeads.Media.AVProVideo
{
	[StructLayout((LayoutKind)0, Pack = 1, Size = 28)]
	public struct BufferedFramesState
	{
		public int freeFrameCount;

		public int bufferedFrameCount;

		public long minTimeStamp;

		public long maxTimeStamp;

		public int prerolledCount;
	}
}
