using Unity.Collections;
using Unity.Profiling;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements.UIR
{
	internal static class MeshBuilder
	{
		internal struct AllocMeshData
		{
			internal delegate MeshWriteData Allocator(uint vertexCount, uint indexCount, ref AllocMeshData allocatorData);

			internal Allocator alloc;

			internal Texture texture;

			internal TextureId svgTexture;

			internal Material material;

			internal MeshGenerationContext.MeshFlags flags;

			internal BMPAlloc colorAlloc;

			internal MeshWriteData Allocate(uint vertexCount, uint indexCount)
			{
				return null;
			}
		}

		private struct ClipCounts
		{
			public int firstClippedIndex;

			public int firstDegenerateIndex;

			public int lastClippedIndex;

			public int clippedTriangles;

			public int addedTriangles;

			public int degenerateTriangles;
		}

		private enum VertexClipEdge
		{
			None = 0,
			Left = 1,
			Top = 2,
			Right = 4,
			Bottom = 8
		}

		private static ProfilerMarker s_VectorGraphics9Slice;

		private static ProfilerMarker s_VectorGraphicsSplitTriangle;

		private static ProfilerMarker s_VectorGraphicsScaleTriangle;

		private static ProfilerMarker s_VectorGraphicsStretch;

		internal static readonly int s_MaxTextMeshVertices;

		private static readonly ushort[] slicedQuadIndices;

		private static readonly float[] k_TexCoordSlicesX;

		private static readonly float[] k_TexCoordSlicesY;

		private static readonly float[] k_PositionSlicesX;

		private static readonly float[] k_PositionSlicesY;

		private static VertexClipEdge[] s_AllClipEdges;

		internal static void MakeBorder(MeshGenerationContextUtils.BorderParams borderParams, float posZ, AllocMeshData meshAlloc)
		{
		}

		internal static void MakeSolidRect(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, AllocMeshData meshAlloc)
		{
		}

		internal static void MakeTexturedRect(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, AllocMeshData meshAlloc, ColorPage colorPage)
		{
		}

		private static Vertex ConvertTextVertexToUIRVertex(MeshInfo info, int index, Vector2 offset, VertexFlags flags = VertexFlags.IsText, bool isDynamicColor = false)
		{
			return default(Vertex);
		}

		private static Vertex ConvertTextVertexToUIRVertex(TextVertex textVertex, Vector2 offset)
		{
			return default(Vertex);
		}

		private static int LimitTextVertices(int vertexCount, bool logTruncation = true)
		{
			return 0;
		}

		internal static void MakeText(MeshInfo meshInfo, Vector2 offset, AllocMeshData meshAlloc, VertexFlags flags = VertexFlags.IsText, bool isDynamicColor = false)
		{
		}

		internal static void MakeText(NativeArray<TextVertex> uiVertices, Vector2 offset, AllocMeshData meshAlloc)
		{
		}

		internal static void UpdateText(NativeArray<TextVertex> uiVertices, Vector2 offset, Matrix4x4 transform, Color32 xformClipPages, Color32 ids, Color32 flags, Color32 opacityPageSettingIndex, NativeSlice<Vertex> vertices)
		{
		}

		private static void MakeQuad(Rect rcPosition, Rect rcTexCoord, Color color, float posZ, AllocMeshData meshAlloc, ColorPage colorPage)
		{
		}

		internal static void MakeSlicedQuad(ref MeshGenerationContextUtils.RectangleParams rectParams, float posZ, AllocMeshData meshAlloc)
		{
		}

		internal static void MakeVectorGraphics(MeshGenerationContextUtils.RectangleParams rectParams, int settingIndexOffset, AllocMeshData meshAlloc, out int finalVertexCount, out int finalIndexCount)
		{
			finalVertexCount = default(int);
			finalIndexCount = default(int);
		}

		internal static void MakeVectorGraphicsStretchBackground(Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Rect sourceUV, ScaleMode scaleMode, Color tint, int settingIndexOffset, AllocMeshData meshAlloc, out int finalVertexCount, out int finalIndexCount)
		{
			finalVertexCount = default(int);
			finalIndexCount = default(int);
		}

		private unsafe static void SplitTriangle(Vertex* vertices, ushort* indices, ref int vertexCount, int indexToProcess, ref int indexCount, float svgWidth, float svgHeight, Vector4 sliceLTRB, int sliceIndex)
		{
		}

		private unsafe static void ScaleSplittedTriangles(Vertex* vertices, int vertexCount, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB)
		{
		}

		internal static void MakeVectorGraphics9SliceBackground(Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB, bool stretch, Color tint, int settingIndexOffset, AllocMeshData meshAlloc)
		{
		}

		private static ClipCounts UpperBoundApproximateRectClippingResults(Vertex[] vertices, ushort[] indices, Vector4 clipRectMinMax)
		{
			return default(ClipCounts);
		}

		private static void RectClip(Vertex[] vertices, ushort[] indices, Vector4 clipRectMinMax, MeshWriteData mwd, ClipCounts cc, ref int newVertexCount)
		{
		}

		private unsafe static void RectClipTriangle(Vertex* vt, ushort* it, Vector4 clipRectMinMax, MeshWriteData mwd, ref ushort nextNewVertex)
		{
		}

		private unsafe static Vector3 GetVertexBaryCentricCoordinates(Vertex* vt, float x, float y)
		{
			return default(Vector3);
		}

		private unsafe static Vertex InterpolateVertexInTriangle(Vertex* vt, float x, float y, Vector3 uvw)
		{
			return default(Vertex);
		}

		private unsafe static Vertex InterpolateVertexInTriangleEdge(Vertex* vt, int e0, int e1, float t)
		{
			return default(Vertex);
		}

		private static float IntersectSegments(float ax, float ay, float bx, float by, float cx, float cy, float dx, float dy)
		{
			return 0f;
		}
	}
}
