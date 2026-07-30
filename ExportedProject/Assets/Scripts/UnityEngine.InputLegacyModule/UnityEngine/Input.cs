using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Input/InputBindings.h")]
	public class Input
	{
		[NativeThrows]
		public static bool anyKey => false;

		[NativeThrows]
		public static bool anyKeyDown => false;

		[NativeThrows]
		public static Vector3 mousePosition => default(Vector3);

		[NativeThrows]
		public static Vector2 mouseScrollDelta => default(Vector2);

		public static IMECompositionMode imeCompositionMode
		{
			get
			{
				return default(IMECompositionMode);
			}
			set
			{
			}
		}

		public static string compositionString => null;

		public static Vector2 compositionCursorPos
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public static bool mousePresent
		{
			[FreeFunction("GetMousePresent")]
			get
			{
				return false;
			}
		}

		public static int touchCount
		{
			[FreeFunction("GetTouchCount")]
			get
			{
				return 0;
			}
		}

		public static bool touchSupported
		{
			[FreeFunction("IsTouchSupported")]
			get
			{
				return false;
			}
		}

		public static Touch[] touches => null;

		[NativeThrows]
		private static bool GetKeyInt(KeyCode key)
		{
			return false;
		}

		[NativeThrows]
		private static bool GetKeyUpInt(KeyCode key)
		{
			return false;
		}

		[NativeThrows]
		private static bool GetKeyDownInt(KeyCode key)
		{
			return false;
		}

		[NativeThrows]
		public static float GetAxis(string axisName)
		{
			return 0f;
		}

		[NativeThrows]
		public static float GetAxisRaw(string axisName)
		{
			return 0f;
		}

		[NativeThrows]
		public static bool GetButton(string buttonName)
		{
			return false;
		}

		[NativeThrows]
		public static bool GetButtonDown(string buttonName)
		{
			return false;
		}

		[NativeThrows]
		public static bool GetButtonUp(string buttonName)
		{
			return false;
		}

		[NativeThrows]
		public static bool GetMouseButton(int button)
		{
			return false;
		}

		[NativeThrows]
		public static bool GetMouseButtonDown(int button)
		{
			return false;
		}

		[NativeThrows]
		public static bool GetMouseButtonUp(int button)
		{
			return false;
		}

		[NativeThrows]
		public static Touch GetTouch(int index)
		{
			return default(Touch);
		}

		public static bool GetKey(KeyCode key)
		{
			return false;
		}

		public static bool GetKeyUp(KeyCode key)
		{
			return false;
		}

		public static bool GetKeyDown(KeyCode key)
		{
			return false;
		}

		internal static bool CheckDisabled()
		{
			return false;
		}

		private static void GetTouch_Injected(int index, out Touch ret)
		{
			ret = default(Touch);
		}

		[SpecialName]
		private static void get_mousePosition_Injected(out Vector3 ret)
		{
			ret = default(Vector3);
		}

		[SpecialName]
		private static void get_mouseScrollDelta_Injected(out Vector2 ret)
		{
			ret = default(Vector2);
		}

		[SpecialName]
		private static void get_compositionCursorPos_Injected(out Vector2 ret)
		{
			ret = default(Vector2);
		}

		[SpecialName]
		private static void set_compositionCursorPos_Injected(ref Vector2 value)
		{
		}
	}
}
