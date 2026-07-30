using System;
using System.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR.Implementation
{
	internal class UIRStylePainter : IStylePainter, IDisposable
	{
		internal struct Entry
		{
			public NativeSlice<Vertex> vertices;

			public NativeSlice<ushort> indices;

			public Material material;

			public Texture custom;

			public Texture font;

			public float fontTexSDFScale;

			public TextureId texture;

			public RenderChainCommand customCommand;

			public BMPAlloc clipRectID;

			public VertexFlags addFlags;

			public bool uvIsDisplacement;

			public bool isTextEntry;

			public bool isClipRegisterEntry;

			public int stencilRef;

			public int maskDepth;
		}

		internal struct ClosingInfo
		{
			public bool needsClosing;

			public bool popViewMatrix;

			public bool popScissorClip;

			public bool blitAndPopRenderTexture;

			public bool PopDefaultMaterial;

			public RenderChainCommand clipUnregisterDrawCommand;

			public NativeSlice<Vertex> clipperRegisterVertices;

			public NativeSlice<ushort> clipperRegisterIndices;

			public int clipperRegisterIndexOffset;

			public int maskStencilRef;
		}

		internal struct TempDataAlloc<T> : IDisposable where T : struct
		{
			private int maxPoolElemCount;

			private NativeArray<T> pool;

			private List<NativeArray<T>> excess;

			private uint takenFromPool;

			public TempDataAlloc(int maxPoolElems)
			{
				maxPoolElemCount = 0;
				pool = default(NativeArray<T>);
				excess = null;
				takenFromPool = 0u;
			}

			public void Dispose()
			{
			}

			internal NativeSlice<T> Alloc(uint count)
			{
				return default(NativeSlice<T>);
			}

			internal void SessionDone()
			{
			}
		}

		private RenderChain m_Owner;

		private List<Entry> m_Entries;

		private AtlasBase m_Atlas;

		private VectorImageManager m_VectorImageManager;

		private Entry m_CurrentEntry;

		private ClosingInfo m_ClosingInfo;

		private int m_MaskDepth;

		private int m_StencilRef;

		private BMPAlloc m_ClipRectID;

		private int m_SVGBackgroundEntryIndex;

		private TempDataAlloc<Vertex> m_VertsPool;

		private TempDataAlloc<ushort> m_IndicesPool;

		private List<MeshWriteData> m_MeshWriteDataPool;

		private int m_NextMeshWriteDataPoolItem;

		private MeshBuilder.AllocMeshData.Allocator m_AllocRawVertsIndicesDelegate;

		private MeshBuilder.AllocMeshData.Allocator m_AllocThroughDrawMeshDelegate;

		private MeshBuilder.AllocMeshData.Allocator m_AllocThroughDrawGradientsDelegate;

		public MeshGenerationContext meshGenerationContext { get; }

		public VisualElement currentElement { get; private set; }

		public List<Entry> entries => null;

		public ClosingInfo closingInfo => default(ClosingInfo);

		public int totalVertices { get; private set; }

		public int totalIndices { get; private set; }

		protected bool disposed { get; private set; }

		public VisualElement visualElement => null;

		private MeshWriteData GetPooledMeshWriteData()
		{
			return null;
		}

		private MeshWriteData AllocRawVertsIndices(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData)
		{
			return null;
		}

		private MeshWriteData AllocThroughDrawMesh(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData)
		{
			return null;
		}

		private MeshWriteData AllocThroughDrawGradients(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData)
		{
			return null;
		}

		public UIRStylePainter(RenderChain renderChain)
		{
		}

		public void Dispose()
		{
		}

		protected void Dispose(bool disposing)
		{
		}

		public void Begin(VisualElement ve)
		{
		}

		public void LandClipUnregisterMeshDrawCommand(RenderChainCommand cmd)
		{
		}

		public void LandClipRegisterMesh(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, int indexOffset)
		{
		}

		public MeshWriteData AddGradientsEntry(int vertexCount, int indexCount, TextureId texture, Material material, MeshGenerationContext.MeshFlags flags)
		{
			return null;
		}

		public MeshWriteData DrawMesh(int vertexCount, int indexCount, Texture texture, Material material, MeshGenerationContext.MeshFlags flags)
		{
			return null;
		}

		public void DrawText(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint)
		{
		}

		internal void DrawTextNative(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint)
		{
		}

		internal void DrawTextCore(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint)
		{
		}

		public void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams)
		{
		}

		public void DrawBorder(MeshGenerationContextUtils.BorderParams borderParams)
		{
		}

		public void DrawImmediate(Action callback, bool cullingEnabled)
		{
		}

		public void DrawVisualElementBackground()
		{
		}

		public void DrawVisualElementBorder()
		{
		}

		public void ApplyVisualElementClipping()
		{
		}

		private ushort[] AdjustSpriteWinding(Vector2[] vertices, ushort[] indices)
		{
			return null;
		}

		public void DrawSprite(MeshGenerationContextUtils.RectangleParams rectParams)
		{
		}

		private void ApplyInset(ref MeshGenerationContextUtils.RectangleParams rectParams, Texture tex)
		{
		}

		public void DrawVectorImage(MeshGenerationContextUtils.RectangleParams rectParams)
		{
		}

		internal void Reset()
		{
		}

		private void ValidateMeshWriteData()
		{
		}

		private void GenerateStencilClipEntryForRoundedRectBackground()
		{
		}

		private void GenerateStencilClipEntryForSVGBackground()
		{
		}
	}
}
