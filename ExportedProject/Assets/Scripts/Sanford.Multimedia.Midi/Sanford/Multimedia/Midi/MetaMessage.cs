using System.ComponentModel;

namespace Sanford.Multimedia.Midi
{
	[ImmutableObject(true)]
	public sealed class MetaMessage : MidiMessageBase, IMidiMessage
	{
		public static readonly MetaMessage EndOfTrackMessage;

		private MetaType type;

		private byte[] data;

		private int hashCode;

		public byte this[int index] => 0;

		public int Length => 0;

		public MetaType MetaType => default(MetaType);

		public MessageType MessageType => default(MessageType);

		public MetaMessage(MetaType type, byte[] data)
		{
		}

		public byte[] GetBytes()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		private void CalculateHashCode()
		{
		}

		private bool ValidateDataLength(MetaType type, int length)
		{
			return false;
		}
	}
}
