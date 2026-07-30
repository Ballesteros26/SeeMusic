using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
	[NativeHeader("Modules/IMGUI/GUI.bindings.h")]
	public class GUI
	{
		public enum ToolbarButtonSize
		{
			Fixed = 0,
			FitToContents = 1
		}

		public delegate void WindowFunction(int id);

		public abstract class Scope : IDisposable
		{
			private bool m_Disposed;

			internal virtual void Dispose(bool disposing)
			{
			}

			~Scope()
			{
			}

			public void Dispose()
			{
			}

			protected abstract void CloseScope();
		}

		private static int s_ScrollControlId;

		private static int s_HotTextField;

		private static readonly int s_BoxHash;

		private static readonly int s_ButonHash;

		private static readonly int s_RepeatButtonHash;

		private static readonly int s_ToggleHash;

		private static readonly int s_ButtonGridHash;

		private static readonly int s_SliderHash;

		private static readonly int s_BeginGroupHash;

		private static readonly int s_ScrollviewHash;

		private static GUISkin s_Skin;

		internal static Rect s_ToolTipRect;

		public static Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public static Color backgroundColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public static Color contentColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public static bool changed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int depth
		{
			set
			{
			}
		}

		internal static bool usePageScrollbars => false;

		internal static Material blendMaterial
		{
			[FreeFunction("GetGUIBlendMaterial")]
			get
			{
				return null;
			}
		}

		internal static Material blitMaterial
		{
			[FreeFunction("GetGUIBlitMaterial")]
			get
			{
				return null;
			}
		}

		internal static Material roundedRectMaterial
		{
			[FreeFunction("GetGUIRoundedRectMaterial")]
			get
			{
				return null;
			}
		}

		internal static Material roundedRectWithColorPerBorderMaterial
		{
			[FreeFunction("GetGUIRoundedRectWithColorPerBorderMaterial")]
			get
			{
				return null;
			}
		}

		internal static int scrollTroughSide { get; set; }

		internal static DateTime nextScrollStepTime { get; set; }

		public static GUISkin skin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static Matrix4x4 matrix
		{
			get
			{
				return default(Matrix4x4);
			}
			set
			{
			}
		}

		internal static GenericStack scrollViewStates { get; }

		internal static void GrabMouseControl(int id)
		{
		}

		internal static bool HasMouseControl(int id)
		{
			return false;
		}

		internal static void ReleaseMouseControl()
		{
		}

		[FreeFunction("GetGUIState().SetNameOfNextControl")]
		public static void SetNextControlName(string name)
		{
		}

		internal static void InternalRepaintEditorWindow()
		{
		}

		private static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout)
		{
			return default(Rect);
		}

		public static void DragWindow(Rect position)
		{
		}

		static GUI()
		{
		}

		internal static void DoSetSkin(GUISkin newSkin)
		{
		}

		public static void Label(Rect position, string text)
		{
		}

		public static void Label(Rect position, GUIContent content)
		{
		}

		public static void Label(Rect position, GUIContent content, GUIStyle style)
		{
		}

		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend)
		{
		}

		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect)
		{
		}

		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius)
		{
		}

		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius)
		{
		}

		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses)
		{
		}

		internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners)
		{
		}

		internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners)
		{
		}

		internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect)
		{
			return false;
		}

		public static void Box(Rect position, string text)
		{
		}

		public static void Box(Rect position, string text, GUIStyle style)
		{
		}

		public static void Box(Rect position, GUIContent content, GUIStyle style)
		{
		}

		public static bool Button(Rect position, string text)
		{
			return false;
		}

		public static bool Button(Rect position, string text, GUIStyle style)
		{
			return false;
		}

		public static bool Button(Rect position, GUIContent content, GUIStyle style)
		{
			return false;
		}

		internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style)
		{
			return false;
		}

		private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType)
		{
			return false;
		}

		public static string TextField(Rect position, string text, int maxLength)
		{
			return null;
		}

		internal static string PasswordFieldGetStrToShow(string password, char maskChar)
		{
			return null;
		}

		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style)
		{
		}

		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText)
		{
		}

		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar)
		{
		}

		private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor)
		{
		}

		private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor)
		{
		}

		private static void HandleTextFieldEventForDesktopWithForcedKeyboard(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, TextEditor editor)
		{
		}

		public static bool Toggle(Rect position, bool value, GUIContent content)
		{
			return false;
		}

		public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style)
		{
			return false;
		}

		internal static int Toolbar(Rect position, int selected, GUIContent[] contents, string[] controlNames, GUIStyle style, ToolbarButtonSize buttonSize, bool[] contentsEnabled = null)
		{
			return 0;
		}

		public static int SelectionGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style)
		{
			return 0;
		}

		internal static void FindStyles(ref GUIStyle style, out GUIStyle firstStyle, out GUIStyle midStyle, out GUIStyle lastStyle, string first, string mid, string last)
		{
			firstStyle = null;
			midStyle = null;
			lastStyle = null;
		}

		internal static int CalcTotalHorizSpacing(int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle)
		{
			return 0;
		}

		internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style)
		{
			return false;
		}

		private static void DoLabel(Rect position, GUIContent content, GUIStyle style)
		{
		}

		internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style)
		{
			return false;
		}

		internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style)
		{
			return false;
		}

		private static int DoButtonGrid(Rect position, int selected, GUIContent[] contents, string[] controlNames, int itemsPerRow, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, ToolbarButtonSize buttonSize, bool[] contentsEnabled = null)
		{
			return 0;
		}

		private static Rect[] CalcGridRects(Rect position, GUIContent[] contents, int xCount, float elemWidth, float elemHeight, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, ToolbarButtonSize buttonSize)
		{
			return null;
		}

		public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb)
		{
			return 0f;
		}

		public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent = null)
		{
			return 0f;
		}

		public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style)
		{
			return 0f;
		}

		internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style)
		{
			return false;
		}

		public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style)
		{
			return 0f;
		}

		internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz)
		{
			return 0f;
		}

		public static void BeginGroup(Rect position, GUIContent content, GUIStyle style)
		{
		}

		internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset)
		{
		}

		public static void EndGroup()
		{
		}

		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect)
		{
			return default(Vector2);
		}

		internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background)
		{
			return default(Vector2);
		}

		public static void EndScrollView()
		{
		}

		public static void EndScrollView(bool handleScrollWheel)
		{
		}

		public static Rect Window(int id, Rect clientRect, WindowFunction func, string text)
		{
			return default(Rect);
		}

		public static Rect Window(int id, Rect clientRect, WindowFunction func, string text, GUIStyle style)
		{
			return default(Rect);
		}

		public static Rect Window(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style)
		{
			return default(Rect);
		}

		private static Rect DoWindow(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout)
		{
			return default(Rect);
		}

		[RequiredByNativeCode]
		internal static void CallWindowDelegate(WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style)
		{
		}

		[SpecialName]
		private static void get_color_Injected(out Color ret)
		{
			ret = default(Color);
		}

		[SpecialName]
		private static void set_color_Injected(ref Color value)
		{
		}

		[SpecialName]
		private static void get_backgroundColor_Injected(out Color ret)
		{
			ret = default(Color);
		}

		[SpecialName]
		private static void set_backgroundColor_Injected(ref Color value)
		{
		}

		[SpecialName]
		private static void get_contentColor_Injected(out Color ret)
		{
			ret = default(Color);
		}

		[SpecialName]
		private static void set_contentColor_Injected(ref Color value)
		{
		}

		private static void Internal_DoWindow_Injected(int id, int instanceID, ref Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout, out Rect ret)
		{
			ret = default(Rect);
		}

		private static void DragWindow_Injected(ref Rect position)
		{
		}
	}
}
