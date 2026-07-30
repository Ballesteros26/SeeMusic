using System.Collections.Generic;

namespace UnityEngine.TextCore.Text
{
	internal class TextGenerator
	{
		protected struct SpecialCharacter
		{
			public Character character;

			public FontAsset fontAsset;

			public Material material;

			public int materialIndex;

			public SpecialCharacter(Character character, int materialIndex)
			{
				this.character = null;
				fontAsset = null;
				material = null;
				this.materialIndex = 0;
			}
		}

		private static TextGenerator s_TextGenerator;

		private Vector3[] m_RectTransformCorners;

		private float m_MarginWidth;

		private float m_MarginHeight;

		private int[] m_CharBuffer;

		private float m_PreferredWidth;

		private float m_PreferredHeight;

		private FontAsset m_CurrentFontAsset;

		private Material m_CurrentMaterial;

		private int m_CurrentMaterialIndex;

		private TextProcessingStack<MaterialReference> m_MaterialReferenceStack;

		private float m_Padding;

		private SpriteAsset m_CurrentSpriteAsset;

		private int m_TotalCharacterCount;

		private float m_FontScale;

		private float m_FontSize;

		private float m_FontScaleMultiplier;

		private float m_CurrentFontSize;

		private TextProcessingStack<float> m_SizeStack;

		private FontStyles m_FontStyleInternal;

		private FontStyleStack m_FontStyleStack;

		private TextFontWeight m_FontWeightInternal;

		private TextProcessingStack<TextFontWeight> m_FontWeightStack;

		private TextAlignment m_LineJustification;

		private TextProcessingStack<TextAlignment> m_LineJustificationStack;

		private float m_BaselineOffset;

		private TextProcessingStack<float> m_BaselineOffsetStack;

		private Color32 m_FontColor32;

		private Color32 m_HtmlColor;

		private Color32 m_UnderlineColor;

		private Color32 m_StrikethroughColor;

		private TextProcessingStack<Color32> m_ColorStack;

		private TextProcessingStack<Color32> m_UnderlineColorStack;

		private TextProcessingStack<Color32> m_StrikethroughColorStack;

		private TextProcessingStack<Color32> m_HighlightColorStack;

		private TextColorGradient m_ColorGradientPreset;

		private TextProcessingStack<TextColorGradient> m_ColorGradientStack;

		private TextProcessingStack<int> m_ActionStack;

		private bool m_IsFxMatrixSet;

		private float m_LineOffset;

		private float m_LineHeight;

		private float m_CSpacing;

		private float m_MonoSpacing;

		private float m_XAdvance;

		private float m_TagLineIndent;

		private float m_TagIndent;

		private TextProcessingStack<float> m_IndentStack;

		private bool m_TagNoParsing;

		private int m_CharacterCount;

		private int m_FirstCharacterOfLine;

		private int m_LastCharacterOfLine;

		private int m_FirstVisibleCharacterOfLine;

		private int m_LastVisibleCharacterOfLine;

		private float m_MaxLineAscender;

		private float m_MaxLineDescender;

		private int m_LineNumber;

		private int m_LineVisibleCharacterCount;

		private int m_FirstOverflowCharacterIndex;

		private int m_PageNumber;

		private float m_MarginLeft;

		private float m_MarginRight;

		private float m_Width;

		private Extents m_MeshExtents;

		private float m_MaxCapHeight;

		private float m_MaxAscender;

		private float m_MaxDescender;

		private bool m_IsNewPage;

		private bool m_IsNonBreakingSpace;

		private WordWrapState m_SavedWordWrapState;

		private WordWrapState m_SavedLineState;

		private int m_LoopCountA;

		private TextElementType m_TextElementType;

		private bool m_IsParsingText;

		private int m_SpriteIndex;

		private Color32 m_SpriteColor;

		private TextElement m_CachedTextElement;

		private Color32 m_HighlightColor;

		private float m_CharWidthAdjDelta;

		private Matrix4x4 m_FxMatrix;

		private float m_MaxFontSize;

		private float m_MinFontSize;

		private bool m_IsCharacterWrappingEnabled;

		private float m_StartOfLineAscender;

		private float m_LineSpacingDelta;

		private bool m_IsMaskingEnabled;

		private MaterialReference[] m_MaterialReferences;

		private int m_SpriteCount;

		private TextProcessingStack<int> m_StyleStack;

		private int m_SpriteAnimationId;

		private uint[] m_InternalTextParsingBuffer;

		private RichTextTagAttribute[] m_Attributes;

		private XmlTagAttribute[] m_XmlAttribute;

		private char[] m_RichTextTag;

		private Dictionary<int, int> m_MaterialReferenceIndexLookup;

		private bool m_IsCalculatingPreferredValues;

		private SpriteAsset m_DefaultSpriteAsset;

		private bool m_TintSprite;

		protected SpecialCharacter m_Ellipsis;

		protected SpecialCharacter m_Underline;

		private bool m_IsUsingBold;

		private bool m_IsSdfShader;

		private TextElementInfo[] m_InternalTextElementInfo;

		private int m_RecursiveCount;

		private static TextGenerator GetTextGenerator()
		{
			return null;
		}

		public static void GenerateText(TextGenerationSettings settings, TextInfo textInfo)
		{
		}

		public static Vector2 GetCursorPosition(TextInfo textInfo, Rect screenRect, int index, bool inverseYAxis = true)
		{
			return default(Vector2);
		}

		public static Vector2 GetPreferredValues(TextGenerationSettings settings, TextInfo textInfo)
		{
			return default(Vector2);
		}

		private void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		private void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		private void SaveWordWrappingState(ref WordWrapState state, int index, int count, TextInfo textInfo)
		{
		}

		protected int RestoreWordWrappingState(ref WordWrapState state, TextInfo textInfo)
		{
			return 0;
		}

		protected bool ValidateHtmlTag(int[] chars, int startIndex, out int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			endIndex = default(int);
			return false;
		}

		private void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		private void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		private void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		private void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		private static void ClearMesh(bool updateMesh, TextInfo textInfo)
		{
		}

		private void EnableMasking()
		{
		}

		private void DisableMasking()
		{
		}

		private void SetArraySizes(int[] chars, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		internal TextElement GetTextElement(TextGenerationSettings generationSettings, uint unicode, FontAsset fontAsset, FontStyles fontStyle, TextFontWeight fontWeight, out bool isUsingAlternativeTypeface)
		{
			isUsingAlternativeTypeface = default(bool);
			return null;
		}

		private void ComputeMarginSize(Rect rect, Vector4 margins)
		{
		}

		protected void GetSpecialCharacters(TextGenerationSettings generationSettings)
		{
		}

		protected void GetEllipsisSpecialCharacter(TextGenerationSettings generationSettings)
		{
		}

		protected void GetUnderlineSpecialCharacter(TextGenerationSettings generationSettings)
		{
		}

		private float GetPaddingForMaterial(Material material, bool extraPadding)
		{
			return 0f;
		}

		private Vector2 GetPreferredValuesInternal(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			return default(Vector2);
		}

		protected virtual Vector2 CalculatePreferredValues(float defaultFontSize, Vector2 marginSize, bool ignoreTextAutoSizing, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			return default(Vector2);
		}
	}
}
