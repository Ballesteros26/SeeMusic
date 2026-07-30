using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	public abstract class PointerEventBase<T> : EventBase<T>, IPointerEvent, IPointerEventInternal where T : PointerEventBase<T>, new()
	{
		public int pointerId { get; protected set; }

		public string pointerType { get; protected set; }

		public bool isPrimary { get; protected set; }

		public int button { get; protected set; }

		public int pressedButtons { get; protected set; }

		public Vector3 position { get; protected set; }

		public Vector3 localPosition { get; protected set; }

		public Vector3 deltaPosition { get; protected set; }

		public float deltaTime { get; protected set; }

		public int clickCount { get; protected set; }

		public float pressure { get; protected set; }

		public float tangentialPressure { get; protected set; }

		public float altitudeAngle { get; protected set; }

		public float azimuthAngle { get; protected set; }

		public float twist { get; protected set; }

		public Vector2 radius { get; protected set; }

		public Vector2 radiusVariance { get; protected set; }

		public EventModifiers modifiers { get; protected set; }

		public bool shiftKey => false;

		public bool ctrlKey => false;

		public bool commandKey => false;

		public bool altKey => false;

		public bool actionKey => false;

		bool IPointerEventInternal.triggeredByOS
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		bool IPointerEventInternal.recomputeTopElementUnderPointer
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override IEventHandler currentTarget
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		protected override void Init()
		{
		}

		private void LocalInit()
		{
		}

		private static bool IsMouse(Event systemEvent)
		{
			return false;
		}

		public static T GetPooled(Event systemEvent)
		{
			return null;
		}

		public static T GetPooled(Touch touch, EventModifiers modifiers = EventModifiers.None)
		{
			return null;
		}

		internal static T GetPooled(IPointerEvent triggerEvent, Vector2 position, int pointerId)
		{
			return null;
		}

		public static T GetPooled(IPointerEvent triggerEvent)
		{
			return null;
		}

		protected internal override void PreDispatch(IPanel panel)
		{
		}

		protected internal override void PostDispatch(IPanel panel)
		{
		}
	}
}
