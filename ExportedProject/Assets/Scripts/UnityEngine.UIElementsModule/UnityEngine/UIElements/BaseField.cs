using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	public abstract class BaseField<TValueType> : BindableElement, INotifyValueChanged<TValueType>
	{
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			private UxmlStringAttributeDescription m_Label;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			internal static List<string> ParseChoiceList(string choicesFromBag)
			{
				return null;
			}
		}

		public static readonly string ussClassName;

		public static readonly string labelUssClassName;

		public static readonly string inputUssClassName;

		public static readonly string noLabelVariantUssClassName;

		public static readonly string labelDraggerVariantUssClassName;

		public static readonly string mixedValueLabelUssClassName;

		public static readonly string alignedFieldUssClassName;

		private static readonly string inspectorFieldUssClassName;

		protected internal static readonly string mixedValueString;

		protected internal static readonly PropertyName serializedPropertyCopyName;

		private static CustomStyleProperty<float> s_LabelWidthRatioProperty;

		private static CustomStyleProperty<float> s_LabelExtraPaddingProperty;

		private static CustomStyleProperty<float> s_LabelBaseMinWidthProperty;

		private float m_LabelWidthRatio;

		private float m_LabelExtraPadding;

		private float m_LabelBaseMinWidth;

		private VisualElement m_VisualInput;

		[SerializeField]
		private TValueType m_Value;

		private bool m_ShowMixedValue;

		private Label m_MixedValueLabel;

		private VisualElement m_CachedInspectorElement;

		private int m_CachedListAndFoldoutDepth;

		internal VisualElement visualInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected TValueType rawValue
		{
			get
			{
				return default(TValueType);
			}
			set
			{
			}
		}

		public virtual TValueType value
		{
			get
			{
				return default(TValueType);
			}
			set
			{
			}
		}

		public Label labelElement { get; private set; }

		public string label
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool showMixedValue => false;

		protected Label mixedValueLabel => null;

		internal BaseField(string label)
		{
		}

		protected BaseField(string label, VisualElement visualInput)
		{
		}

		private void OnAttachToPanel(AttachToPanelEvent e)
		{
		}

		private void OnCustomStyleResolved(CustomStyleResolvedEvent evt)
		{
		}

		private void OnInspectorFieldGeometryChanged(GeometryChangedEvent e)
		{
		}

		private void AlignLabel()
		{
		}

		protected virtual void UpdateMixedValueContent()
		{
		}

		public virtual void SetValueWithoutNotify(TValueType newValue)
		{
		}

		internal override void OnViewDataReady()
		{
		}

		internal override Rect GetTooltipRect()
		{
			return default(Rect);
		}
	}
}
