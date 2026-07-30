using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	public class DropdownField : BaseField<string>
	{
		public new class UxmlFactory : UxmlFactory<DropdownField, UxmlTraits>
		{
		}

		public new class UxmlTraits : BaseField<string>.UxmlTraits
		{
			private UxmlIntAttributeDescription m_Index;

			private UxmlStringAttributeDescription m_Choices;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		private class PopupTextElement : TextElement
		{
			protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
			{
				return default(Vector2);
			}
		}

		internal List<string> m_Choices;

		private TextElement m_TextElement;

		private VisualElement m_ArrowElement;

		internal Func<string, string> m_FormatSelectedValueCallback;

		internal Func<string, string> m_FormatListItemCallback;

		internal Func<IGenericMenu> createMenuCallback;

		private int m_Index;

		internal static readonly string ussClassNameBasePopupField;

		internal static readonly string textUssClassNameBasePopupField;

		internal static readonly string arrowUssClassNameBasePopupField;

		internal static readonly string labelUssClassNameBasePopupField;

		internal static readonly string inputUssClassNameBasePopupField;

		internal static readonly string ussClassNamePopupField;

		internal static readonly string labelUssClassNamePopupField;

		internal static readonly string inputUssClassNamePopupField;

		protected TextElement textElement => null;

		public int index
		{
			set
			{
			}
		}

		public virtual List<string> choices
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

		internal string GetValueToDisplay()
		{
			return null;
		}

		internal string GetListItemToDisplay(string value)
		{
			return null;
		}

		public DropdownField()
			: base((string)null)
		{
		}

		public DropdownField(string label)
			: base((string)null)
		{
		}

		internal void AddMenuItems(IGenericMenu menu)
		{
		}

		private void ChangeValueFromMenu(string menuItem)
		{
		}

		public override void SetValueWithoutNotify(string newValue)
		{
		}

		protected override void ExecuteDefaultActionAtTarget(EventBase evt)
		{
		}

		private void ShowMenu()
		{
		}

		protected override void UpdateMixedValueContent()
		{
		}
	}
}
