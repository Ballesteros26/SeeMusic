using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	internal struct TextCoreHandle : ITextHandle
	{
		private Vector2 m_PreferredSize;

		private int m_PreviousGenerationSettingsHash;

		private UnityEngine.TextCore.Text.TextGenerationSettings m_CurrentGenerationSettings;

		private static UnityEngine.TextCore.Text.TextGenerationSettings s_LayoutSettings;

		private TextInfo m_TextInfoMesh;

		private static TextInfo s_TextInfoLayout;

		private bool isDirty;

		public Vector2 MeasuredSizes { get; set; }

		public Vector2 RoundedSizes { get; set; }

		internal TextInfo textInfoMesh => null;

		internal static TextInfo textInfoLayout => null;

		public static ITextHandle New()
		{
			return null;
		}

		public bool IsLegacy()
		{
			return false;
		}

		public bool IsDirty(MeshGenerationContextUtils.TextParams parms)
		{
			return false;
		}

		public Vector2 GetCursorPosition(CursorPositionStylePainterParameters parms, float scaling)
		{
			return default(Vector2);
		}

		public float ComputeTextWidth(MeshGenerationContextUtils.TextParams parms, float scaling)
		{
			return 0f;
		}

		public float ComputeTextHeight(MeshGenerationContextUtils.TextParams parms, float scaling)
		{
			return 0f;
		}

		public float GetLineHeight(int characterIndex, MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint)
		{
			return 0f;
		}

		public TextInfo Update(MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint)
		{
			return null;
		}

		private void UpdatePreferredValues(MeshGenerationContextUtils.TextParams parms)
		{
		}

		private static TextOverflowMode GetTextOverflowMode(MeshGenerationContextUtils.TextParams textParams)
		{
			return default(TextOverflowMode);
		}

		private static void UpdateGenerationSettingsCommon(MeshGenerationContextUtils.TextParams painterParams, UnityEngine.TextCore.Text.TextGenerationSettings settings)
		{
		}

		public bool IsElided()
		{
			return false;
		}
	}
}
