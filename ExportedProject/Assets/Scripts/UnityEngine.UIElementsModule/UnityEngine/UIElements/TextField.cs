namespace UnityEngine.UIElements
{
	public class TextField : TextInputBaseField<string>
	{
		public new class UxmlFactory : UxmlFactory<TextField, UxmlTraits>
		{
		}

		public new class UxmlTraits : TextInputBaseField<string>.UxmlTraits
		{
			private UxmlBoolAttributeDescription m_Multiline;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		private class TextInput : TextInputBase
		{
			private bool m_Multiline;

			private TextField parentTextField => null;

			public bool multiline
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public override bool isPasswordField
			{
				set
				{
				}
			}

			private void SetTextAlign()
			{
			}

			protected override string StringToValue(string str)
			{
				return null;
			}

			internal override void SyncTextEngine()
			{
			}

			protected override void ExecuteDefaultActionAtTarget(EventBase evt)
			{
			}

			protected override void ExecuteDefaultAction(EventBase evt)
			{
			}
		}

		public new static readonly string ussClassName;

		public new static readonly string labelUssClassName;

		public new static readonly string inputUssClassName;

		private TextInput textInput => null;

		public bool multiline
		{
			set
			{
			}
		}

		public override string value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TextField()
			: base((string)null, 0, '\0', (TextInputBase)null)
		{
		}

		public TextField(string label)
			: base((string)null, 0, '\0', (TextInputBase)null)
		{
		}

		public TextField(string label, int maxLength, bool multiline, bool isPasswordField, char maskChar)
			: base((string)null, 0, '\0', (TextInputBase)null)
		{
		}

		public override void SetValueWithoutNotify(string newValue)
		{
		}

		internal override void OnViewDataReady()
		{
		}
	}
}
