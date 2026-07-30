using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	public class NavigationMoveEvent : NavigationEventBase<NavigationMoveEvent>
	{
		public enum Direction
		{
			None = 0,
			Left = 1,
			Up = 2,
			Right = 3,
			Down = 4
		}

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector2 _003Cmove_003Ek__BackingField;

		public Direction direction { get; private set; }

		private Vector2 move
		{
			[CompilerGenerated]
			set
			{
				_003Cmove_003Ek__BackingField = value;
			}
		}

		internal static Direction DetermineMoveDirection(float x, float y, float deadZone = 0.6f)
		{
			return default(Direction);
		}

		public static NavigationMoveEvent GetPooled(Vector2 moveVector)
		{
			return null;
		}

		protected override void Init()
		{
		}
	}
}
