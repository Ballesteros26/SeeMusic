using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	public class RadioButtonGroup : BaseField<int>, IGroupBox
	{
		public new class UxmlFactory : UxmlFactory<RadioButtonGroup, UxmlTraits>
		{
		}

		public new class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription>
		{
			private UxmlStringAttributeDescription m_Choices;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		public new static readonly string ussClassName;

		private IEnumerable<string> m_Choices;

		private List<RadioButton> m_RadioButtons;

		private EventCallback<ChangeEvent<bool>> m_RadioButtonValueChangedCallback;

		public IEnumerable<string> choices
		{
			set
			{
			}
		}

		public RadioButtonGroup()
			: base((string)null)
		{
		}

		public RadioButtonGroup(string label, List<string> radioButtonChoices = null)
			: base((string)null)
		{
		}

		private void RadioButtonValueChangedCallback(ChangeEvent<bool> evt)
		{
		}

		public override void SetValueWithoutNotify(int newValue)
		{
		}

		private void UpdateRadioButtons()
		{
		}
	}
}
