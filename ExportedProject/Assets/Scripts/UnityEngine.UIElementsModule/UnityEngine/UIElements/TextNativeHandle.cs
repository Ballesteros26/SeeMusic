using Unity.Collections;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	internal struct TextNativeHandle : ITextHandle
	{
		internal NativeArray<TextVertex> textVertices;

		private int m_PreviousTextParamsHash;

		public Vector2 MeasuredSizes { get; set; }

		public Vector2 RoundedSizes { get; set; }

		public static ITextHandle New()
		{
			return null;
		}

		public bool IsLegacy()
		{
			return false;
		}

		public float GetLineHeight(int characterIndex, MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint)
		{
			return 0f;
		}

		public TextInfo Update(MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint)
		{
			return null;
		}

		public NativeArray<TextVertex> GetVertices(MeshGenerationContextUtils.TextParams parms, float scaling)
		{
			return default(NativeArray<TextVertex>);
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

		public bool IsElided()
		{
			return false;
		}
	}
}
