using System.ComponentModel;

namespace Sanford.Multimedia.Midi
{
	[ImmutableObject(true)]
	public sealed class ChannelMessage : ShortMessage
	{
		public override MessageType MessageType => default(MessageType);

		public ChannelMessage(ChannelCommand command, int midiChannel, int data1, int data2)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		internal static int PackMidiChannel(int message, int midiChannel)
		{
			return 0;
		}

		internal static int PackCommand(int message, ChannelCommand command)
		{
			return 0;
		}
	}
}
