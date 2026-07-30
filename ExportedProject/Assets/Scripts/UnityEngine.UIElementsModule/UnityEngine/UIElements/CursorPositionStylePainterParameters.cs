namespace UnityEngine.UIElements
{
	internal struct CursorPositionStylePainterParameters
	{
		public Rect rect;

		public string text;

		public Font font;

		public int fontSize;

		public FontStyle fontStyle;

		public TextAnchor anchor;

		public float wordWrapWidth;

		public bool richText;

		public int cursorIndex;

		public static CursorPositionStylePainterParameters GetDefault(VisualElement ve, string text)
		{
			return default(CursorPositionStylePainterParameters);
		}

		internal TextNativeSettings GetTextNativeSettings(float scaling)
		{
			return default(TextNativeSettings);
		}
	}
}
