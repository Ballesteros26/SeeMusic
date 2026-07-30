using System;
using System.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	internal class InlineStyleAccess : StyleValueCollection, IStyle
	{
		internal struct InlineRule
		{
			public StyleSheet sheet;

			public StyleRule rule;

			public StylePropertyId[] propertyIds;
		}

		private static StylePropertyReader s_StylePropertyReader;

		private List<StyleValueManaged> m_ValuesManaged;

		private bool m_HasInlineCursor;

		private StyleCursor m_InlineCursor;

		private bool m_HasInlineTextShadow;

		private StyleTextShadow m_InlineTextShadow;

		private bool m_HasInlineTransformOrigin;

		private StyleTransformOrigin m_InlineTransformOrigin;

		private bool m_HasInlineTranslate;

		private StyleTranslate m_InlineTranslateOperation;

		private bool m_HasInlineRotate;

		private StyleRotate m_InlineRotateOperation;

		private bool m_HasInlineScale;

		private StyleScale m_InlineScale;

		private InlineRule m_InlineRule;

		private VisualElement ve { get; set; }

		StyleCursor IStyle.cursor => default(StyleCursor);

		StyleTextShadow IStyle.textShadow => default(StyleTextShadow);

		StyleTransformOrigin IStyle.transformOrigin => default(StyleTransformOrigin);

		StyleTranslate IStyle.translate
		{
			get
			{
				return default(StyleTranslate);
			}
			set
			{
			}
		}

		StyleRotate IStyle.rotate => default(StyleRotate);

		StyleScale IStyle.scale => default(StyleScale);

		StyleColor IStyle.backgroundColor
		{
			set
			{
			}
		}

		StyleColor IStyle.borderBottomColor
		{
			set
			{
			}
		}

		StyleLength IStyle.borderBottomLeftRadius
		{
			set
			{
			}
		}

		StyleLength IStyle.borderBottomRightRadius
		{
			set
			{
			}
		}

		StyleFloat IStyle.borderBottomWidth
		{
			set
			{
			}
		}

		StyleColor IStyle.borderLeftColor
		{
			set
			{
			}
		}

		StyleFloat IStyle.borderLeftWidth
		{
			set
			{
			}
		}

		StyleColor IStyle.borderRightColor
		{
			set
			{
			}
		}

		StyleFloat IStyle.borderRightWidth
		{
			set
			{
			}
		}

		StyleColor IStyle.borderTopColor
		{
			set
			{
			}
		}

		StyleLength IStyle.borderTopLeftRadius
		{
			set
			{
			}
		}

		StyleLength IStyle.borderTopRightRadius
		{
			set
			{
			}
		}

		StyleFloat IStyle.borderTopWidth
		{
			set
			{
			}
		}

		StyleLength IStyle.bottom
		{
			set
			{
			}
		}

		StyleColor IStyle.color
		{
			set
			{
			}
		}

		StyleEnum<DisplayStyle> IStyle.display
		{
			get
			{
				return default(StyleEnum<DisplayStyle>);
			}
			set
			{
			}
		}

		StyleLength IStyle.flexBasis
		{
			set
			{
			}
		}

		StyleEnum<FlexDirection> IStyle.flexDirection
		{
			set
			{
			}
		}

		StyleFloat IStyle.flexGrow
		{
			set
			{
			}
		}

		StyleFloat IStyle.flexShrink
		{
			set
			{
			}
		}

		StyleLength IStyle.fontSize
		{
			set
			{
			}
		}

		StyleLength IStyle.height
		{
			set
			{
			}
		}

		StyleLength IStyle.left
		{
			set
			{
			}
		}

		StyleLength IStyle.marginBottom
		{
			set
			{
			}
		}

		StyleLength IStyle.marginLeft
		{
			set
			{
			}
		}

		StyleLength IStyle.marginRight
		{
			set
			{
			}
		}

		StyleLength IStyle.marginTop
		{
			set
			{
			}
		}

		StyleLength IStyle.maxHeight
		{
			set
			{
			}
		}

		StyleLength IStyle.minWidth
		{
			set
			{
			}
		}

		StyleFloat IStyle.opacity
		{
			set
			{
			}
		}

		StyleLength IStyle.paddingBottom
		{
			set
			{
			}
		}

		StyleLength IStyle.paddingLeft
		{
			set
			{
			}
		}

		StyleLength IStyle.paddingRight
		{
			set
			{
			}
		}

		StyleLength IStyle.paddingTop
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleEnum<Position> IStyle.position
		{
			set
			{
			}
		}

		StyleLength IStyle.right
		{
			set
			{
			}
		}

		StyleLength IStyle.top
		{
			set
			{
			}
		}

		StyleColor IStyle.unityBackgroundImageTintColor
		{
			set
			{
			}
		}

		StyleEnum<Visibility> IStyle.visibility
		{
			set
			{
			}
		}

		StyleLength IStyle.width
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		public InlineStyleAccess(VisualElement ve)
		{
		}

		~InlineStyleAccess()
		{
		}

		public void SetInlineRule(StyleSheet sheet, StyleRule rule)
		{
		}

		public bool IsValueSet(StylePropertyId id)
		{
			return false;
		}

		public void ApplyInlineStyles(ref ComputedStyle computedStyle)
		{
		}

		private bool SetStyleValue(StylePropertyId id, StyleLength inlineValue)
		{
			return false;
		}

		private bool SetStyleValue(StylePropertyId id, StyleFloat inlineValue)
		{
			return false;
		}

		private bool SetStyleValue(StylePropertyId id, StyleColor inlineValue)
		{
			return false;
		}

		private bool SetStyleValue<T>(StylePropertyId id, StyleEnum<T> inlineValue) where T : struct, IConvertible
		{
			return false;
		}

		private bool SetInlineTranslate(StyleTranslate inlineValue)
		{
			return false;
		}

		private void ApplyStyleTranslate(StyleTranslate translate)
		{
		}

		private void ApplyStyleValue(StyleValue value)
		{
		}

		private bool RemoveInlineStyle(StylePropertyId id)
		{
			return false;
		}

		private void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle newStyle)
		{
		}

		public bool TryGetInlineCursor(ref StyleCursor value)
		{
			return false;
		}

		public bool TryGetInlineTextShadow(ref StyleTextShadow value)
		{
			return false;
		}

		public bool TryGetInlineTransformOrigin(ref StyleTransformOrigin value)
		{
			return false;
		}

		public bool TryGetInlineTranslate(ref StyleTranslate value)
		{
			return false;
		}

		public bool TryGetInlineRotate(ref StyleRotate value)
		{
			return false;
		}

		public bool TryGetInlineScale(ref StyleScale value)
		{
			return false;
		}
	}
}
