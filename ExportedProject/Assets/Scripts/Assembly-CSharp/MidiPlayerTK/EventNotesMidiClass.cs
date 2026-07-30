using System;
using System.Collections.Generic;
using UnityEngine.Events;

namespace MidiPlayerTK
{
	[Serializable]
	public class EventNotesMidiClass : UnityEvent<List<MPTKEvent>>
	{
	}
}
