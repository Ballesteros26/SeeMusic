using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	public abstract class TextInputBaseField<TValueType> : BaseField<TValueType>
	{
		public new class UxmlTraits : BaseFieldTraits<string, UxmlStringAttributeDescription>
		{
			private UxmlIntAttributeDescription m_MaxLength;

			private UxmlBoolAttributeDescription m_Password;

			private UxmlStringAttributeDescription m_MaskCharacter;

			private UxmlStringAttributeDescription m_Text;

			private UxmlBoolAttributeDescription m_IsReadOnly;

			private UxmlBoolAttributeDescription m_IsDelayed;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		protected internal abstract class TextInputBase : VisualElement, ITextInputField, IEventHandler, ITextElement
		{
			private string m_OriginalText;

			private bool m_TouchScreenTextFieldInitialized;

			private IVisualElementScheduledItem m_HardwareKeyboardPoller;

			private Color m_SelectionColor;

			private Color m_CursorColor;

			private ITextHandle m_TextHandle;

			private string m_Text;

			bool ITextInputField.isReadOnly => false;

			public bool isReadOnly { get; set; }

			public int maxLength { get; set; }

			public char maskChar { get; set; }

			public virtual bool isPasswordField { get; set; }

			public bool doubleClickSelectsWord { get; set; }

			public bool tripleClickSelectsLine { get; set; }

			internal bool isDelayed { get; set; }

			internal bool isDragging { get; }

			private bool touchScreenTextField => false;

			private bool touchScreenTextFieldChanged => false;

			public Color selectionColor => default(Color);

			public Color cursorColor => default(Color);

			internal bool hasFocus => false;

			internal TextEditorEventHandler editorEventHandler { get; private set; }

			internal TextEditorEngine editorEngine { get; private set; }

			public string text
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			bool ITextInputField.hasFocus => false;

			TextEditorEngine ITextInputField.editorEngine => null;

			bool ITextInputField.isDelayed => false;

			public void ResetValueAndText()
			{
			}

			private void SaveValueAndText()
			{
			}

			private void RestoreValueAndText()
			{
			}

			private void UpdateText(string value)
			{
			}

			protected virtual TValueType StringToValue(string str)
			{
				return default(TValueType);
			}

			internal void UpdateValueFromText()
			{
			}

			internal TextInputBase()
			{
			}

			private void InitTextEditorEventHandler()
			{
			}

			private DropdownMenuAction.Status CutActionStatus(DropdownMenuAction a)
			{
				return default(DropdownMenuAction.Status);
			}

			private DropdownMenuAction.Status CopyActionStatus(DropdownMenuAction a)
			{
				return default(DropdownMenuAction.Status);
			}

			private DropdownMenuAction.Status PasteActionStatus(DropdownMenuAction a)
			{
				return default(DropdownMenuAction.Status);
			}

			private void ProcessMenuCommand(string command)
			{
			}

			private void Cut(DropdownMenuAction a)
			{
			}

			private void Copy(DropdownMenuAction a)
			{
			}

			private void Paste(DropdownMenuAction a)
			{
			}

			internal void OnInputCustomStyleResolved(CustomStyleResolvedEvent e)
			{
			}

			private void OnAttachToPanel(AttachToPanelEvent attachEvent)
			{
			}

			internal virtual void SyncTextEngine()
			{
			}

			internal string CullString(string s)
			{
				return null;
			}

			internal void OnGenerateVisualContent(MeshGenerationContext mgc)
			{
			}

			internal void DrawWithTextSelectionAndCursor(MeshGenerationContext mgc, string newText, float pixelsPerPoint)
			{
			}

			internal virtual bool AcceptCharacter(char c)
			{
				return false;
			}

			protected virtual void BuildContextualMenu(ContextualMenuPopulateEvent evt)
			{
			}

			private void OnDetectFocusChange()
			{
			}

			private void OnCursorIndexChange()
			{
			}

			protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
			{
				return default(Vector2);
			}

			internal override void ExecuteDefaultActionDisabledAtTarget(EventBase evt)
			{
			}

			protected override void ExecuteDefaultActionAtTarget(EventBase evt)
			{
			}

			private void ProcessEventAtTarget(EventBase evt)
			{
			}

			protected override void ExecuteDefaultAction(EventBase evt)
			{
			}

			void ITextInputField.SyncTextEngine()
			{
			}

			bool ITextInputField.AcceptCharacter(char c)
			{
				return false;
			}

			string ITextInputField.CullString(string s)
			{
				return null;
			}

			void ITextInputField.UpdateText(string value)
			{
			}

			void ITextInputField.UpdateValueFromText()
			{
			}

			private void DeferGUIStyleRectSync()
			{
			}

			private void OnPercentResolved(GeometryChangedEvent evt)
			{
			}

			private static void SyncGUIStyle(TextInputBase textInput, GUIStyle style)
			{
			}

			private static bool IsLayoutUsingPercent(VisualElement ve)
			{
				return false;
			}

			private static void AssignRect(RectOffset rect, int left, int top, int right, int bottom)
			{
			}
		}

		private static CustomStyleProperty<Color> s_SelectionColorProperty;

		private static CustomStyleProperty<Color> s_CursorColorProperty;

		private int m_VisualInputTabIndex;

		private TextInputBase m_TextInputBase;

		public new static readonly string ussClassName;

		public new static readonly string labelUssClassName;

		public new static readonly string inputUssClassName;

		public static readonly string singleLineInputUssClassName;

		public static readonly string multilineInputUssClassName;

		public static readonly string textInputUssName;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<bool> onIsReadOnlyChanged;

		protected internal TextInputBase textInputBase => null;

		private ITextHandle iTextHandle
		{
			[CompilerGenerated]
			set
			{
				_003CiTextHandle_003Ek__BackingField = value;
			}
		}

		protected string text
		{
			set
			{
			}
		}

		public bool isReadOnly
		{
			set
			{
			}
		}

		public bool isPasswordField
		{
			set
			{
			}
		}

		public int maxLength
		{
			set
			{
			}
		}

		public bool isDelayed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public char maskChar
		{
			set
			{
			}
		}

		protected TextInputBaseField(string label, int maxLength, char maskChar, TextInputBase textInputBase)
			: base((string)null)
		{
		}

		private void OnAttachToPanel(AttachToPanelEvent e)
		{
		}

		private void OnFieldCustomStyleResolved(CustomStyleResolvedEvent e)
		{
		}

		protected override void ExecuteDefaultActionAtTarget(EventBase evt)
		{
		}

		protected override void UpdateMixedValueContent()
		{
		}
	}
}
