namespace UnityEngine.UIElements
{
	internal class KeyboardTextEditorEventHandler : TextEditorEventHandler
	{
		internal bool m_Changed;

		private bool m_Dragged;

		private bool m_DragToPosition;

		private bool m_SelectAllOnMouseUp;

		private string m_PreDrawCursorText;

		private bool m_IsClicking;

		private Vector2 m_ClickStartPosition;

		private readonly Event m_ImguiEvent;

		private bool isClicking
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public KeyboardTextEditorEventHandler(TextEditorEngine editorEngine, ITextInputField textInputField)
			: base(null, null)
		{
		}

		public override void ExecuteDefaultActionAtTarget(EventBase evt)
		{
		}

		private void OnFocus(FocusEvent _)
		{
		}

		private void OnBlur(BlurEvent _)
		{
		}

		private void OnMouseDown(MouseDownEvent evt)
		{
		}

		private void OnMouseUp(MouseUpEvent evt)
		{
		}

		private void OnMouseMove(MouseMoveEvent evt)
		{
		}

		private void ProcessDragMove(MouseMoveEvent evt)
		{
		}

		private bool MoveDistanceQualifiesForDrag(Vector2 start, Vector2 current)
		{
			return false;
		}

		private void OnKeyDown(KeyDownEvent evt)
		{
		}

		private void OnValidateCommandEvent(ValidateCommandEvent evt)
		{
		}

		private void OnExecuteCommandEvent(ExecuteCommandEvent evt)
		{
		}

		public void PreDrawCursor(string newText)
		{
		}

		public void PostDrawCursor()
		{
		}
	}
}
