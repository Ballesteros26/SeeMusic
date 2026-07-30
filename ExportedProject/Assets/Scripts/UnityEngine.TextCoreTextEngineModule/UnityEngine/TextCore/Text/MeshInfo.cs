namespace UnityEngine.TextCore.Text
{
	internal struct MeshInfo
	{
		private static readonly Color32 k_DefaultColor;

		public int vertexCount;

		public Vector3[] vertices;

		public Vector2[] uvs0;

		public Vector2[] uvs2;

		public Color32[] colors32;

		public int[] triangles;

		public Material material;

		public MeshInfo(int size)
		{
			vertexCount = 0;
			vertices = null;
			uvs0 = null;
			uvs2 = null;
			colors32 = null;
			triangles = null;
			material = null;
		}

		internal void ResizeMeshInfo(int size)
		{
		}

		internal void Clear(bool uploadChanges)
		{
		}

		internal void ClearUnusedVertices()
		{
		}

		internal void SortGeometry(VertexSortingOrder order)
		{
		}

		internal void SwapVertexData(int src, int dst)
		{
		}
	}
}
