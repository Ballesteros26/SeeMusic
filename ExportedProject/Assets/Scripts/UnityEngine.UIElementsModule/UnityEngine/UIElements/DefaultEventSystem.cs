using System;

namespace UnityEngine.UIElements
{
	internal class DefaultEventSystem
	{
		public enum UpdateMode
		{
			Always = 0,
			IgnoreIfAppNotFocused = 1
		}

		internal interface IInput
		{
			int touchCount { get; }

			bool mousePresent { get; }

			bool GetButtonDown(string button);

			float GetAxisRaw(string axis);

			Touch GetTouch(int index);
		}

		private class Input : IInput
		{
			public int touchCount => 0;

			public bool mousePresent => false;

			public bool GetButtonDown(string button)
			{
				return false;
			}

			public float GetAxisRaw(string axis)
			{
				return 0f;
			}

			public Touch GetTouch(int index)
			{
				return default(Touch);
			}
		}

		private class NoInput : IInput
		{
			public int touchCount => 0;

			public bool mousePresent => false;

			public bool GetButtonDown(string button)
			{
				return false;
			}

			public float GetAxisRaw(string axis)
			{
				return 0f;
			}

			public Touch GetTouch(int index)
			{
				return default(Touch);
			}
		}

		internal static Func<bool> IsEditorRemoteConnected;

		private IInput m_Input;

		private readonly string m_HorizontalAxis;

		private readonly string m_VerticalAxis;

		private readonly string m_SubmitButton;

		private readonly string m_CancelButton;

		private readonly float m_InputActionsPerSecond;

		private readonly float m_RepeatDelay;

		private bool m_SendingTouchEvents;

		private Event m_Event;

		private BaseRuntimePanel m_FocusedPanel;

		private int m_ConsecutiveMoveCount;

		private Vector2 m_LastMoveVector;

		private float m_PrevActionTime;

		private bool isAppFocused => false;

		internal IInput input => null;

		public BaseRuntimePanel focusedPanel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private IInput GetDefaultInput()
		{
			return null;
		}

		private bool ShouldIgnoreEventsOnAppNotFocused()
		{
			return false;
		}

		public void Update(UpdateMode updateMode = UpdateMode.Always)
		{
		}

		private void SendIMGUIEvents()
		{
		}

		private void SendInputEvents()
		{
		}

		internal void SendFocusBasedEvent<TArg>(Func<TArg, EventBase> evtFactory, TArg arg)
		{
		}

		private void SendPositionBasedEvent<TArg>(Vector3 mousePosition, Vector3 delta, int pointerId, int? targetDisplay, Func<Vector3, Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false)
		{
		}

		private void UpdateFocusedPanel(BaseRuntimePanel runtimePanel)
		{
		}

		private static EventBase MakeTouchEvent(Touch touch, EventModifiers modifiers)
		{
			return null;
		}

		private bool ProcessTouchEvents()
		{
			return false;
		}

		private Vector2 GetRawMoveVector()
		{
			return default(Vector2);
		}

		private bool ShouldSendMoveFromInput()
		{
			return false;
		}

		private static Vector2 GetLocalScreenPosition(Event evt, out int? targetDisplay)
		{
			targetDisplay = null;
			return default(Vector2);
		}
	}
}
