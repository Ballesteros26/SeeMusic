namespace RenderHeads.Media.AVProVideo
{
	public class AuthData
	{
		public string URL { get; set; }

		public string Token { get; set; }

		public byte[] KeyBytes { get; set; }

		public string KeyBase64
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Clear()
		{
		}
	}
}
