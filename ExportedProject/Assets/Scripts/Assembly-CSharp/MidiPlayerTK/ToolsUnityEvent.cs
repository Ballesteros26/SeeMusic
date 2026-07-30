using UnityEngine.Events;

namespace MidiPlayerTK
{
	public static class ToolsUnityEvent
	{
		public static bool HasPersistantEvent(this EventMidiClass evt)
		{
			return false;
		}

		public static bool HasPersistantEvent(this UnityEvent evt)
		{
			return false;
		}

		public static bool HasPersistantEvent(this EventNotesMidiClass evt)
		{
			return false;
		}

		public static bool HasPersistantEvent(this EventStartMidiClass evt)
		{
			return false;
		}

		public static bool HasPersistantEvent(this EventEndMidiClass evt)
		{
			return false;
		}

		public static bool HasPersistantEvent(this EventSynthClass evt)
		{
			return false;
		}
	}
}
