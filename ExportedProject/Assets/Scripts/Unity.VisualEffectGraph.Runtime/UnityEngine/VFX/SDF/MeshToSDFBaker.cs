using System;
using System.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.VFX.SDF
{
	public class MeshToSDFBaker : IDisposable
	{
		private struct Triangle
		{
			private Vector3 a;

			private Vector3 b;

			private Vector3 c;
		}

		private static class ShaderProperties
		{
			internal static int indicesBuffer;

			internal static int verticesBuffer;

			internal static int vertexPositionOffset;

			internal static int vertexStride;

			internal static int indexStride;

			internal static int coordFlipBuffer;

			internal static int verticesOutBuffer;

			internal static int aabbBuffer;

			internal static int worldToClip;

			internal static int currentAxis;

			internal static int voxelsBuffer;

			internal static int rw_trianglesUV;

			internal static int trianglesUV;

			internal static int voxelsTexture;

			internal static int voxelsTmpTexture;

			internal static int rayMap;

			internal static int nTriangles;

			internal static int minBoundsExtended;

			internal static int maxBoundsExtended;

			internal static int maxExtent;

			internal static int upperBoundCount;

			internal static int counter;

			internal static int dimX;

			internal static int dimY;

			internal static int dimZ;

			internal static int size;

			internal static int inputBuffer;

			internal static int inputCounter;

			internal static int auxBuffer;

			internal static int resultBuffer;

			internal static int numElem;

			internal static int exclusive;

			internal static int dispatchWidth;

			internal static int src;

			internal static int dest;

			internal static int signMap;

			internal static int threshold;

			internal static int signMapTmp;

			internal static int normalizeFactor;

			internal static int numNeighbours;

			internal static int passId;

			internal static int needNormalize;

			internal static int offset;

			internal static int offsetRayMap;

			internal static int triangleIDs;

			internal static int accumCounter;

			internal static int distanceTexture;

			internal static int sdfOffset;
		}

		internal class Kernels
		{
			internal int inBucketSum;

			internal int blockSums;

			internal int finalSum;

			internal int toTextureNormalized;

			internal int copyTextures;

			internal int jfa;

			internal int distanceTransform;

			internal int copyBuffers;

			internal int generateRayMapLocal;

			internal int rayMapScanX;

			internal int rayMapScanY;

			internal int rayMapScanZ;

			internal int signPass6Rays;

			internal int signPassNeighbors;

			internal int toBlockSumBuffer;

			internal int clearTexturesAndBuffers;

			internal int copyToBuffer;

			internal int generateTrianglesUV;

			internal int conservativeRasterization;

			internal int chooseDirectionTriangleOnly;

			internal int surfaceClosing;

			internal Kernels(ComputeShader computeShader)
			{
			}
		}

		private RenderTexture m_RayMap;

		private RenderTexture m_SignMap;

		private RenderTexture m_SignMapBis;

		private RenderTexture[] m_RenderTextureViews;

		private GraphicsBuffer m_CounterBuffer;

		private GraphicsBuffer m_AccumCounterBuffer;

		private GraphicsBuffer m_TrianglesInVoxels;

		private GraphicsBuffer m_TrianglesUV;

		private GraphicsBuffer m_TmpBuffer;

		private GraphicsBuffer m_AccumSumBlocks;

		private GraphicsBuffer m_SumBlocksBuffer;

		private GraphicsBuffer m_InSumBlocksBuffer;

		private GraphicsBuffer m_SumBlocksAdditional;

		private GraphicsBuffer m_IndicesBuffer;

		private GraphicsBuffer m_VerticesBuffer;

		private GraphicsBuffer m_VerticesOutBuffer;

		private GraphicsBuffer m_CoordFlipBuffer;

		private GraphicsBuffer m_AabbBuffer;

		private int m_VertexBufferOffset;

		private int m_ThreadGroupSize;

		private int m_SignPassesCount;

		private float m_InOutThreshold;

		private Material[] m_Material;

		private Matrix4x4[] m_WorldToClip;

		private Matrix4x4[] m_ProjMat;

		private Matrix4x4[] m_ViewMat;

		private int m_nStepsJFA;

		private Kernels m_Kernels;

		private Mesh m_Mesh;

		private RenderTexture m_textureVoxel;

		private RenderTexture m_textureVoxelBis;

		private RenderTexture m_DistanceTexture;

		private GraphicsBuffer m_bufferVoxel;

		private ComputeShader m_computeShader;

		private int m_maxResolution;

		private float m_MaxExtent;

		private float m_SdfOffset;

		private int nTriangles;

		private Vector3 m_SizeBox;

		private Vector3 m_Center;

		private CommandBuffer m_Cmd;

		private bool m_OwnsCommandBuffer;

		private bool m_IsDisposed;

		private int[] m_Dimensions;

		private int[] m_OffsetRayMap;

		private float[] m_MinBoundsExtended;

		private float[] m_MaxBoundsExtended;

		internal static uint kMaxRecommandedGridSize;

		internal static uint kMaxAbsoluteGridSize;

		private static int kNbActualRT;

		internal VFXRuntimeResources m_RuntimeResources;

		public RenderTexture SdfTexture => null;

		private RenderTexture RayMap => null;

		private void InitMeshFromList(List<Mesh> meshes, List<Matrix4x4> transforms)
		{
		}

		private void InitCommandBuffer()
		{
		}

		private int GetTotalVoxelCount()
		{
			return 0;
		}

		private void InitSizeBox()
		{
		}

		public Vector3Int GetGridSize()
		{
			return default(Vector3Int);
		}

		public Vector3 GetActualBoxSize()
		{
			return default(Vector3);
		}

		public MeshToSDFBaker(Vector3 sizeBox, Vector3 center, int maxRes, Mesh mesh, int signPassesCount = 1, float threshold = 0.5f, float sdfOffset = 0f, CommandBuffer cmd = null)
		{
		}

		public MeshToSDFBaker(Vector3 sizeBox, Vector3 center, int maxRes, List<Mesh> meshes, List<Matrix4x4> transforms, int signPassesCount = 1, float threshold = 0.5f, float sdfOffset = 0f, CommandBuffer cmd = null)
		{
		}

		~MeshToSDFBaker()
		{
		}

		public void Reinit(Vector3 sizeBox, Vector3 center, int maxRes, Mesh mesh, int signPassesCount = 1, float threshold = 0.5f, float sdfOffset = 0f)
		{
		}

		public void Reinit(Vector3 sizeBox, Vector3 center, int maxRes, List<Mesh> meshes, List<Matrix4x4> transforms, int signPassesCount = 1, float threshold = 0.5f, float sdfOffset = 0f)
		{
		}

		private void InitTextures()
		{
		}

		private void Init()
		{
		}

		private void UpdateCameras()
		{
		}

		private Matrix4x4 ComputeOrthographicWorldToClip(Vector3 pos, Quaternion rot, float width, float height, float near, float far, out Matrix4x4 proj, out Matrix4x4 view)
		{
			proj = default(Matrix4x4);
			view = default(Matrix4x4);
			return default(Matrix4x4);
		}

		private int iDivUp(int a, int b)
		{
			return 0;
		}

		private Vector2Int GetThreadGroupsCount(int nbThreads, int threadCountPerGroup)
		{
			return default(Vector2Int);
		}

		private void PrefixSumCount()
		{
		}

		private void SurfaceClosing()
		{
		}

		private RenderTexture GetTextureVoxelPrincipal(int step)
		{
			return null;
		}

		private RenderTexture GetTextureVoxelBis(int step)
		{
			return null;
		}

		private void JFA()
		{
		}

		private void GenerateRayMap()
		{
		}

		private RenderTexture GetSignMapPrincipal(int step)
		{
			return null;
		}

		private RenderTexture GetSignMapBis(int step)
		{
			return null;
		}

		private void SignPass()
		{
		}

		public void BakeSDF()
		{
		}

		private void InitMeshBuffers()
		{
		}

		private void FirstDraw()
		{
		}

		private void SecondDraw()
		{
		}

		private void BuildGeometry()
		{
		}

		private void InitGeometryBuffers(int upperBoundCount)
		{
		}

		private void InitPrefixSumBuffers()
		{
		}

		private void ClearRenderTexturesAndBuffers()
		{
		}

		private void PerformDistanceTransformWinding()
		{
		}

		private void ReleaseBuffersAndTextures()
		{
		}

		public void Dispose()
		{
		}

		private void CreateGraphicsBufferIfNeeded(ref GraphicsBuffer gb, int length, int stride)
		{
		}

		private void ReleaseGraphicsBuffer(ref GraphicsBuffer gb)
		{
		}

		private void CreateRenderTextureIfNeeded(ref RenderTexture rt, RenderTextureDescriptor rtDesc)
		{
		}

		private void ReleaseRenderTexture(ref RenderTexture rt)
		{
		}
	}
}
