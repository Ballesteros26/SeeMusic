using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	internal class NavigationTabEvent : NavigationEventBase<NavigationTabEvent>
	{
		public enum Direction
		{
			None = 0,
			Next = 1,
			Previous = 2
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Direction _003Cdirection_003Ek__BackingField;

		private Direction direction
		{
			[CompilerGenerated]
			set
			{
				_003Cdirection_003Ek__BackingField = value;
			}
		}

		internal static Direction DetermineMoveDirection(int moveValue)
		{
			return default(Direction);
		}

		public static NavigationTabEvent GetPooled(int moveValue)
		{
			return null;
		}

		protected override void Init()
		{
		}
	}
}
