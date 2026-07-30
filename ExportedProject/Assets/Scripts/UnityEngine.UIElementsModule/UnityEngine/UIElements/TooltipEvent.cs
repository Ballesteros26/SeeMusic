using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	public class TooltipEvent : EventBase<TooltipEvent>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string _003Ctooltip_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Rect _003Crect_003Ek__BackingField;

		public string tooltip
		{
			[CompilerGenerated]
			set
			{
				_003Ctooltip_003Ek__BackingField = value;
			}
		}

		public Rect rect
		{
			[CompilerGenerated]
			set
			{
				_003Crect_003Ek__BackingField = value;
			}
		}

		protected override void Init()
		{
		}

		private void LocalInit()
		{
		}
	}
}
