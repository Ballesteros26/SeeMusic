namespace UnityEngine.UIElements
{
	internal class TextEditorEngine : TextEditor
	{
		internal delegate void OnDetectFocusChangeFunction();

		internal delegate void OnIndexChangeFunction();

		private OnDetectFocusChangeFunction m_DetectFocusChangeFunction;

		private OnIndexChangeFunction m_IndexChangeFunction;

		internal override Rect localPosition => default(Rect);

		public TextEditorEngine(OnDetectFocusChangeFunction detectFocusChange, OnIndexChangeFunction indexChangeFunction)
		{
		}

		internal override void OnDetectFocusChange()
		{
		}

		internal override void OnCursorIndexChange()
		{
		}

		internal override void OnSelectIndexChange()
		{
		}
	}
}
