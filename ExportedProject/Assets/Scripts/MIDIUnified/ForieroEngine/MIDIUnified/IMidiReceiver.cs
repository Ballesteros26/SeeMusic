namespace ForieroEngine.MIDIUnified
{
	public interface IMidiReceiver
	{
		string Id { get; }

		void OnMidiMessageReceived(int aCommand, int aData1, int aData2, int aDeviceId);
	}
}
