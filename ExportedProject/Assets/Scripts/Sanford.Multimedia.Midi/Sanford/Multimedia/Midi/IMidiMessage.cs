namespace Sanford.Multimedia.Midi
{
	public interface IMidiMessage
	{
		MessageType MessageType { get; }

		byte[] GetBytes();
	}
}
