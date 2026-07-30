namespace RenderHeads.Media.AVProVideo
{
	public class Subtitle
	{
		public int index;

		public string text;

		public double timeStart;

		public double timeEnd;

		public bool IsBefore(double time)
		{
			return false;
		}

		public bool IsTime(double time)
		{
			return false;
		}
	}
}
