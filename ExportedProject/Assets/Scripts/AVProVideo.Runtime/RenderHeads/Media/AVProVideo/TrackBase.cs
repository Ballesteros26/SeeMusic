namespace RenderHeads.Media.AVProVideo
{
	public class TrackBase
	{
		internal int Uid { get; private set; }

		public TrackType TrackType { get; private set; }

		public string DisplayName { get; private set; }

		public string Name { get; private set; }

		public string Language { get; private set; }

		public bool IsDefault { get; private set; }

		protected TrackBase()
		{
		}

		internal TrackBase(TrackType trackType, int uid, string name, string language, bool isDefault)
		{
		}

		protected string CreateDisplayName()
		{
			return null;
		}
	}
}
