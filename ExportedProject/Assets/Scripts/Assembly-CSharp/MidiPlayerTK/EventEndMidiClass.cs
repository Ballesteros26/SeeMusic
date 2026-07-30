using System;
using UnityEngine.Events;

namespace MidiPlayerTK
{
	[Serializable]
	public class EventEndMidiClass : UnityEvent<string, EventEndMidiEnum>
	{
	}
}
