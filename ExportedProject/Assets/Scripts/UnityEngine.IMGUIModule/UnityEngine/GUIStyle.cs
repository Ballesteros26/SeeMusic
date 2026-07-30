using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[NativeHeader("IMGUIScriptingClasses.h")]
	[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
	[RequiredByNativeCode]
	public sealed class GUIStyle
	{
		[NonSerialized]
		internal IntPtr m_Ptr;

		[NonSerialized]
		private GUIStyleState m_Normal;

		[NonSerialized]
		private GUIStyleState m_Hover;

		[NonSerialized]
		private GUIStyleState m_Active;

		[NonSerialized]
		private GUIStyleState m_Focused;

		[NonSerialized]
		private GUIStyleState m_OnNormal;

		[NonSerialized]
		private GUIStyleState m_OnHover;

		[NonSerialized]
		private GUIStyleState m_OnActive;

		[NonSerialized]
		private GUIStyleState m_OnFocused;

		[NonSerialized]
		private RectOffset m_Border;

		[NonSerialized]
		private RectOffset m_Padding;

		[NonSerialized]
		private RectOffset m_Margin;

		[NonSerialized]
		private RectOffset m_Overflow;

		[NonSerialized]
		private string m_Name;

		internal static bool showKeyboardFocus;

		private static GUIStyle s_None;

		[NativeProperty("Name", false, TargetType.Function)]
		internal string rawName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[NativeProperty("Font", false, TargetType.Function)]
		public Font font
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[NativeProperty("m_ImagePosition", false, TargetType.Field)]
		public ImagePosition imagePosition => default(ImagePosition);

		[NativeProperty("m_Alignment", false, TargetType.Field)]
		public TextAnchor alignment
		{
			set
			{
			}
		}

		[NativeProperty("m_WordWrap", false, TargetType.Field)]
		public bool wordWrap
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[NativeProperty("m_Clipping", false, TargetType.Field)]
		public TextClipping clipping
		{
			set
			{
			}
		}

		[NativeProperty("m_ContentOffset", false, TargetType.Field)]
		public Vector2 contentOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		[NativeProperty("m_FixedWidth", false, TargetType.Field)]
		public float fixedWidth => 0f;

		[NativeProperty("m_FixedHeight", false, TargetType.Field)]
		public float fixedHeight => 0f;

		[NativeProperty("m_StretchWidth", false, TargetType.Field)]
		public bool stretchWidth
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[NativeProperty("m_StretchHeight", false, TargetType.Field)]
		public bool stretchHeight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[NativeProperty("m_FontSize", false, TargetType.Field)]
		public int fontSize
		{
			set
			{
			}
		}

		[NativeProperty("m_FontStyle", false, TargetType.Field)]
		public FontStyle fontStyle
		{
			set
			{
			}
		}

		[NativeProperty("m_RichText", false, TargetType.Field)]
		public bool richText
		{
			set
			{
			}
		}

		[NativeProperty("m_ClipOffset", false, TargetType.Field)]
		internal Vector2 Internal_clipOffset
		{
			set
			{
			}
		}

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GUIStyleState normal => null;

		public GUIStyleState hover => null;

		public GUIStyleState active => null;

		public RectOffset border
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RectOffset margin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RectOffset padding
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float lineHeight => 0f;

		public static GUIStyle none => null;

		public bool isHeightDependantOnWidth => false;

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = true)]
		private static IntPtr Internal_Create(GUIStyle self)
		{
			return (IntPtr)0;
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Copy", IsThreadSafe = true)]
		private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other)
		{
			return (IntPtr)0;
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = true)]
		private static void Internal_Destroy(IntPtr self)
		{
		}

		[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = true, HasExplicitThis = true)]
		private IntPtr GetStyleStatePtr(int idx)
		{
			return (IntPtr)0;
		}

		[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = true)]
		private IntPtr GetRectOffsetPtr(int idx)
		{
			return (IntPtr)0;
		}

		[FreeFunction(Name = "GUIStyle_Bindings::AssignRectOffset", HasExplicitThis = true)]
		private void AssignRectOffset(int idx, IntPtr srcRectOffset)
		{
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetLineHeight")]
		private static float Internal_GetLineHeight(IntPtr target)
		{
			return 0f;
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = true)]
		private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = true)]
		private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on)
		{
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_DrawCursor", HasExplicitThis = true)]
		private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor)
		{
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_DrawWithTextSelection", HasExplicitThis = true)]
		private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor)
		{
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorPixelPosition", HasExplicitThis = true)]
		internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
		{
			return default(Vector2);
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorStringIndex", HasExplicitThis = true)]
		internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition)
		{
			return 0;
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetSelectedRenderedText", HasExplicitThis = true)]
		internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex)
		{
			return null;
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSize", HasExplicitThis = true)]
		internal Vector2 Internal_CalcSize(GUIContent content)
		{
			return default(Vector2);
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = true)]
		internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize)
		{
			return default(Vector2);
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = true)]
		private float Internal_CalcHeight(GUIContent content, float width)
		{
			return 0f;
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = true)]
		private Vector2 Internal_CalcMinMaxWidth(GUIContent content)
		{
			return default(Vector2);
		}

		[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
		internal static void SetMouseTooltip(string tooltip, Rect screenRect)
		{
		}

		[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
		internal static bool IsTooltipActive(string tooltip)
		{
			return false;
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorFlashOffset")]
		private static float Internal_GetCursorFlashOffset()
		{
			return 0f;
		}

		[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
		internal static void SetDefaultFont(Font font)
		{
		}

		public GUIStyle()
		{
		}

		public GUIStyle(GUIStyle other)
		{
		}

		~GUIStyle()
		{
		}

		public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
		}

		public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
		}

		public void Draw(Rect position, GUIContent content, int controlID)
		{
		}

		public void Draw(Rect position, GUIContent content, int controlID, bool on)
		{
		}

		public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover)
		{
		}

		private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
		}

		public void DrawCursor(Rect position, GUIContent content, int controlID, int character)
		{
		}

		internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor)
		{
		}

		internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition)
		{
		}

		public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter)
		{
		}

		public static implicit operator GUIStyle(string str)
		{
			return null;
		}

		public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
		{
			return default(Vector2);
		}

		public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition)
		{
			return 0;
		}

		public Vector2 CalcSize(GUIContent content)
		{
			return default(Vector2);
		}

		internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints)
		{
			return default(Vector2);
		}

		public float CalcHeight(GUIContent content, float width)
		{
			return 0f;
		}

		public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth)
		{
			minWidth = default(float);
			maxWidth = default(float);
		}

		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		private void get_contentOffset_Injected(out Vector2 ret)
		{
			ret = default(Vector2);
		}

		[SpecialName]
		private void set_contentOffset_Injected(ref Vector2 value)
		{
		}

		[SpecialName]
		private void set_Internal_clipOffset_Injected(ref Vector2 value)
		{
		}

		private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
		}

		private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on)
		{
		}

		private void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor)
		{
		}

		private void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor)
		{
		}

		private void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition)
		{
			return 0;
		}

		private string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex)
		{
			return null;
		}

		private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect)
		{
		}
	}
}
