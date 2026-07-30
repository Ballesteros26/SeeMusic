using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	public abstract class ContextualMenuManager
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CdisplayMenuHandledOSX_003Ek__BackingField;

		public abstract void DisplayMenuIfEventMatches(EventBase evt, IEventHandler eventHandler);

		protected internal abstract void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent);
	}
}
