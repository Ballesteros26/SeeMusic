namespace UnityEngine.UIElements
{
	internal class TextEditorEventHandler
	{
		protected TextEditorEngine editorEngine { get; private set; }

		protected ITextInputField textInputField { get; private set; }

		protected TextEditorEventHandler(TextEditorEngine editorEngine, ITextInputField textInputField)
		{
		}

		public virtual void ExecuteDefaultActionAtTarget(EventBase evt)
		{
		}

		public virtual void ExecuteDefaultAction(EventBase evt)
		{
		}
	}
}
