public class Song
{
	private string filePath;

	public string title { get; private set; }

	public string artist { get; private set; }

	public string album { get; private set; }

	public Song(string filePath, string title, string artist, string album)
	{
	}

	public byte[] GetBytes()
	{
		return null;
	}
}
