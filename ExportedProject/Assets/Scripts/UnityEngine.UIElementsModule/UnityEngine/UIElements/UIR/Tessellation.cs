using Unity.Collections;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	internal static class Tessellation
	{
		internal enum Edges
		{
			None = 0,
			Left = 1,
			Top = 2,
			Right = 4,
			Bottom = 8,
			All = 15
		}

		internal static float kEpsilon;

		internal static float kUnusedArc;

		internal static ushort kSubdivisions;

		private static ProfilerMarker s_MarkerTessellateRect;

		private static ProfilerMarker s_MarkerTessellateBorder;

		private static Edges[] s_AllEdges;

		public static void TessellateRect(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, MeshBuilder.AllocMeshData meshAlloc, bool computeUVs)
		{
		}

		public static void TessellateQuad(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, MeshBuilder.AllocMeshData meshAlloc)
		{
		}

		public static void TessellateBorder(MeshGenerationContextUtils.BorderParams borderParams, float posZ, MeshBuilder.AllocMeshData meshAlloc)
		{
		}

		private static void TessellateRoundedCorners(ref MeshGenerationContextUtils.RectangleParams rectParams, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		private static void TessellateRoundedBorders(ref MeshGenerationContextUtils.BorderParams border, float posZ, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		private static void TessellateRoundedCorner(Rect rect, Color32 color, float posZ, Vector2 radius, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		private static void TessellateRoundedBorder(Rect rect, Color32 leftColor, Color32 topColor, float posZ, Vector2 radius, float leftWidth, float topWidth, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		private static Vector2 IntersectLines(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
		{
			return default(Vector2);
		}

		private static int LooseCompare(float a, float b)
		{
			return 0;
		}

		private static void TessellateComplexBorderCorner(Rect rect, Vector2 radius, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		private static void TessellateQuad(Rect rect, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		private static void TessellateQuad(Rect rect, Edges smoothedEdges, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		private static int EdgesCount(Edges edges)
		{
			return 0;
		}

		private unsafe static void TessellateQuad(Rect rect, Edges smoothedEdges, Vector2* offsets, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		private static void EncodeStraightArc(ref Vertex v0, ref Vertex v1, ref Vertex center, float radius)
		{
		}

		private static void ExpandTriangle(ref Vector3 v0, ref Vector3 v1, Vector3 center, float factor)
		{
		}

		private static void TessellateQuadSingleEdge(Rect rect, Edges smoothedEdge, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		private static void TessellateStraightBorder(Rect rect, Edges smoothedEdge, float miterOffset, Color color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		private static Vector4 GetInterpolatedCircle(Vector2 p, ref Vertex v0, ref Vertex v1, ref Vertex v2)
		{
			return default(Vector4);
		}

		private static void ComputeBarycentricCoordinates(Vector2 p, Vector2 a, Vector2 b, Vector2 c, out float u, out float v, out float w)
		{
			u = default(float);
			v = default(float);
			w = default(float);
		}

		private static void TessellateFilledFan(Vector2 center, Vector2 radius, Vector2 miterOffset, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		private static void TessellateBorderedFan(Vector2 center, Vector2 outerRadius, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		private static void MirrorVertices(Rect rect, NativeSlice<Vertex> vertices, int vertexStart, int vertexCount, bool flipHorizontal)
		{
		}

		private static void FlipWinding(NativeSlice<ushort> indices, int indexStart, int indexCount)
		{
		}

		private static void ComputeUVs(Rect tessellatedRect, Rect textureRect, Rect uvRegion, NativeSlice<Vertex> vertices)
		{
		}
	}
}
