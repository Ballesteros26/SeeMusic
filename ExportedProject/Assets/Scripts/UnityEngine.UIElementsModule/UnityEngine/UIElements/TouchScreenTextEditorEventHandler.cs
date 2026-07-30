namespace UnityEngine.UIElements
{
	internal class TouchScreenTextEditorEventHandler : TextEditorEventHandler
	{
		private IVisualElementScheduledItem m_TouchKeyboardPoller;

		private VisualElement m_LastPointerDownTarget;

		public TouchScreenTextEditorEventHandler(TextEditorEngine editorEngine, ITextInputField textInputField)
			: base(null, null)
		{
		}

		private void PollTouchScreenKeyboard()
		{
		}

		private void DoPollTouchScreenKeyboard()
		{
		}

		public override void ExecuteDefaultActionAtTarget(EventBase evt)
		{
		}
	}
}
