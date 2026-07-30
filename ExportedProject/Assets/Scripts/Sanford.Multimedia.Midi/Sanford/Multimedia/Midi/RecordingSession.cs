using System.Collections.Generic;

namespace Sanford.Multimedia.Midi
{
	public class RecordingSession
	{
		private struct TimestampedMessage
		{
			public int ticks;

			public IMidiMessage message;

			public TimestampedMessage(int ticks, IMidiMessage message)
			{
				this.ticks = 0;
				this.message = null;
			}
		}

		private class TimestampComparer : IComparer<TimestampedMessage>
		{
			public int Compare(TimestampedMessage x, TimestampedMessage y)
			{
				return 0;
			}
		}

		private IClock clock;

		private List<TimestampedMessage> buffer;

		private Track result;

		public Track Result => null;

		public RecordingSession(IClock clock)
		{
		}

		public void Build()
		{
		}

		public void Record(ChannelMessage message)
		{
		}
	}
}
