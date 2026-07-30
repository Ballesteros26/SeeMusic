namespace ForieroEngine.MIDIUnified.Plugins
{
	public struct MidiMessage
	{
		public byte CommandAndChannel;

		public byte Data1;

		public byte Data2;

		public int DataSize;

		public byte[] Data;

		public int DeviceId;

		public bool Editor;

		public bool Through;

		public bool Synth;

		public double Time;

		public byte Command => 0;

		public byte Channel => 0;

		public MidiMessage(MidiMessage m)
		{
			CommandAndChannel = 0;
			Data1 = 0;
			Data2 = 0;
			DataSize = 0;
			Data = null;
			DeviceId = 0;
			Editor = false;
			Through = false;
			Synth = false;
			Time = 0.0;
		}

		public MidiMessage(int aCommand, int aChannel, int aData1, int aData2, int aDeviceId = -1, bool anEditor = false, bool through = false, bool synth = false, double time = -1.0)
		{
			CommandAndChannel = 0;
			Data1 = 0;
			Data2 = 0;
			DataSize = 0;
			Data = null;
			DeviceId = 0;
			Editor = false;
			Through = false;
			Synth = false;
			Time = 0.0;
		}

		public MidiMessage(int aCommand, int aData1, int aData2, int aDeviceId = -1, bool anEditor = false, bool through = false, bool synth = false, double time = -1.0)
		{
			CommandAndChannel = 0;
			Data1 = 0;
			Data2 = 0;
			DataSize = 0;
			Data = null;
			DeviceId = 0;
			Editor = false;
			Through = false;
			Synth = false;
			Time = 0.0;
		}

		public void CopyData(NativeMidiMessage m)
		{
		}

		public void SetShortMessageBytes(byte[] bytes)
		{
		}

		public void SetSystemMessageBytes(byte[] bytes, int size)
		{
		}

		public byte[] GetShortMessageBytes()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public void Log(string prefix = "", string format = "X")
		{
		}
	}
}
