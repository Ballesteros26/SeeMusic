using System;

namespace ForieroEngine.MIDIUnified
{
	public struct NativeMidiMessage
	{
		public byte command;

		public byte data1;

		public byte data2;

		public int dataSize;

		public IntPtr data;

		public int deviceId;

		public override string ToString()
		{
			return null;
		}
	}
}
