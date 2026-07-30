namespace UnityEngine
{
	public class GUILayout
	{
		private sealed class LayoutedWindow
		{
			private readonly GUI.WindowFunction m_Func;

			private readonly Rect m_ScreenRect;

			private readonly GUILayoutOption[] m_Options;

			private readonly GUIStyle m_Style;

			internal LayoutedWindow(GUI.WindowFunction f, Rect screenRect, GUIContent content, GUILayoutOption[] options, GUIStyle style)
			{
			}

			public void DoWindow(int windowID)
			{
			}
		}

		public class HorizontalScope : GUI.Scope
		{
			public HorizontalScope(params GUILayoutOption[] options)
			{
			}

			protected override void CloseScope()
			{
			}
		}

		public class VerticalScope : GUI.Scope
		{
			public VerticalScope(params GUILayoutOption[] options)
			{
			}

			public VerticalScope(GUIStyle style, params GUILayoutOption[] options)
			{
			}

			protected override void CloseScope()
			{
			}
		}

		public class AreaScope : GUI.Scope
		{
			public AreaScope(Rect screenRect)
			{
			}

			protected override void CloseScope()
			{
			}
		}

		public class ScrollViewScope : GUI.Scope
		{
			public Vector2 scrollPosition { get; private set; }

			public bool handleScrollWheel { get; set; }

			public ScrollViewScope(Vector2 scrollPosition, params GUILayoutOption[] options)
			{
			}

			protected override void CloseScope()
			{
			}
		}

		public static void Label(string text, params GUILayoutOption[] options)
		{
		}

		public static void Label(string text, GUIStyle style, params GUILayoutOption[] options)
		{
		}

		private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
		}

		public static void Box(string text, params GUILayoutOption[] options)
		{
		}

		private static void DoBox(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
		}

		public static bool Button(string text, params GUILayoutOption[] options)
		{
			return false;
		}

		public static bool Button(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return false;
		}

		private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return false;
		}

		public static string TextField(string text, params GUILayoutOption[] options)
		{
			return null;
		}

		public static string TextField(string text, int maxLength, params GUILayoutOption[] options)
		{
			return null;
		}

		private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options)
		{
			return null;
		}

		public static bool Toggle(bool value, string text, params GUILayoutOption[] options)
		{
			return false;
		}

		private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return false;
		}

		public static int Toolbar(int selected, string[] texts, params GUILayoutOption[] options)
		{
			return 0;
		}

		public static int Toolbar(int selected, GUIContent[] contents, GUIStyle style, params GUILayoutOption[] options)
		{
			return 0;
		}

		public static int Toolbar(int selected, GUIContent[] contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
		{
			return 0;
		}

		public static int Toolbar(int selected, GUIContent[] contents, bool[] enabled, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
		{
			return 0;
		}

		public static int SelectionGrid(int selected, string[] texts, int xCount, params GUILayoutOption[] options)
		{
			return 0;
		}

		public static int SelectionGrid(int selected, GUIContent[] contents, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return 0;
		}

		public static float HorizontalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return 0f;
		}

		private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options)
		{
			return 0f;
		}

		public static void Space(float pixels)
		{
		}

		public static void FlexibleSpace()
		{
		}

		public static void BeginHorizontal(params GUILayoutOption[] options)
		{
		}

		public static void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
		}

		public static void EndHorizontal()
		{
		}

		public static void BeginVertical(params GUILayoutOption[] options)
		{
		}

		public static void BeginVertical(GUIStyle style, params GUILayoutOption[] options)
		{
		}

		public static void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
		}

		public static void EndVertical()
		{
		}

		public static void BeginArea(Rect screenRect)
		{
		}

		public static void BeginArea(Rect screenRect, GUIStyle style)
		{
		}

		public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style)
		{
		}

		public static void EndArea()
		{
		}

		public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options)
		{
			return default(Vector2);
		}

		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)
		{
			return default(Vector2);
		}

		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
		{
			return default(Vector2);
		}

		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
		{
			return default(Vector2);
		}

		public static void EndScrollView()
		{
		}

		internal static void EndScrollView(bool handleScrollWheel)
		{
		}

		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, params GUILayoutOption[] options)
		{
			return default(Rect);
		}

		private static Rect DoWindow(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return default(Rect);
		}

		public static GUILayoutOption Width(float width)
		{
			return null;
		}

		public static GUILayoutOption MinWidth(float minWidth)
		{
			return null;
		}

		public static GUILayoutOption MaxWidth(float maxWidth)
		{
			return null;
		}

		public static GUILayoutOption Height(float height)
		{
			return null;
		}

		public static GUILayoutOption MaxHeight(float maxHeight)
		{
			return null;
		}

		public static GUILayoutOption ExpandWidth(bool expand)
		{
			return null;
		}

		public static GUILayoutOption ExpandHeight(bool expand)
		{
			return null;
		}
	}
}
