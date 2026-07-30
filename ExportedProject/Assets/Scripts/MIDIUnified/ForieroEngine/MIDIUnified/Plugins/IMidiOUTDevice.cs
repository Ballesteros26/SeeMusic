namespace ForieroEngine.MIDIUnified.Plugins
{
	public interface IMidiOUTDevice : IMidiDevice
	{
		int SendMessage(byte command, byte data1, byte data2, int deviceId = -1, bool editor = false);

		int SendData(byte[] data, int deviceId = -1, bool editor = false);
	}
}
