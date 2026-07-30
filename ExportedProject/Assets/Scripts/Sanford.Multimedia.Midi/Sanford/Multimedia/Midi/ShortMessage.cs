namespace Sanford.Multimedia.Midi
{
	public class ShortMessage : MidiMessageBase, IMidiMessage
	{
		protected int msg;

		private byte[] message;

		private bool rawMessageBuilt;

		public byte[] Bytes => null;

		public virtual MessageType MessageType => default(MessageType);

		public byte[] GetBytes()
		{
			return null;
		}

		private static byte[] BuildByteMessage(int intMessage)
		{
			return null;
		}

		internal static int PackData1(int message, int data1)
		{
			return 0;
		}

		internal static int PackData2(int message, int data2)
		{
			return 0;
		}

		internal static int UnpackStatus(int message)
		{
			return 0;
		}

		internal static int UnpackData1(int message)
		{
			return 0;
		}

		internal static int UnpackData2(int message)
		{
			return 0;
		}
	}
}
