namespace UnityEngine.UIElements
{
	public class TextElement : BindableElement, ITextElement, INotifyValueChanged<string>
	{
		public new class UxmlFactory : UxmlFactory<TextElement, UxmlTraits>
		{
		}

		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			private UxmlStringAttributeDescription m_Text;

			private UxmlBoolAttributeDescription m_EnableRichText;

			private UxmlBoolAttributeDescription m_DisplayTooltipWhenElided;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		public static readonly string ussClassName;

		private ITextHandle m_TextHandle;

		internal static int maxTextVertices;

		[SerializeField]
		private string m_Text;

		private bool m_EnableRichText;

		private bool m_DisplayTooltipWhenElided;

		internal static readonly string k_EllipsisText;

		private bool m_WasElided;

		private bool m_UpdateTextParams;

		private MeshGenerationContextUtils.TextParams m_TextParams;

		private int m_PreviousTextParamsHashCode;

		internal ITextHandle textHandle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool enableRichText
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool displayTooltipWhenElided
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isElided { get; private set; }

		string INotifyValueChanged<string>.value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void HandleEvent(EventBase evt)
		{
		}

		private void OnGeometryChanged(GeometryChangedEvent e)
		{
		}

		private void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
		}

		internal string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition)
		{
			return null;
		}

		private void UpdateTooltip()
		{
		}

		private void UpdateVisibleText()
		{
		}

		private bool ShouldElide()
		{
			return false;
		}

		private bool TextLibraryCanElide()
		{
			return false;
		}

		public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode)
		{
			return default(Vector2);
		}

		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
		{
			return default(Vector2);
		}

		void INotifyValueChanged<string>.SetValueWithoutNotify(string newValue)
		{
		}
	}
}
