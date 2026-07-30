namespace ForieroEngine.MIDIUnified
{
	public interface IMidiSender
	{
		string Id { get; }

		event ShortMessageEventHandler ShortMessageEvent;
	}
}
