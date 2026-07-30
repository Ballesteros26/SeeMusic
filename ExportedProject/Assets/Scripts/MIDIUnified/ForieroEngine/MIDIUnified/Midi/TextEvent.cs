using System.IO;

namespace ForieroEngine.MIDIUnified.Midi
{
	public class TextEvent : MetaEvent
	{
		private string text;

		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TextEvent(BinaryReader br, int length)
		{
		}

		public TextEvent(string text, MetaEventType metaEventType, long absoluteTime)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public override void Export(ref long absoluteTime, BinaryWriter writer)
		{
		}
	}
}
