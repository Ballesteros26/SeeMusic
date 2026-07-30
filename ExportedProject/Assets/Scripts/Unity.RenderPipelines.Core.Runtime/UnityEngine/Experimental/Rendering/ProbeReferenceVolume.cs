using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
	public class ProbeReferenceVolume
	{
		[Serializable]
		internal class Cell
		{
			public int index;

			public Vector3Int position;

			public List<ProbeBrickIndex.Brick> bricks;

			public Vector3[] probePositions;

			public SphericalHarmonicsL2[] sh;

			public float[] validity;

			public int minSubdiv;

			[NonSerialized]
			public int flatIdxInCellIndices;

			[NonSerialized]
			public bool loaded;
		}

		private class CellChunkInfo
		{
			public List<ProbeBrickPool.BrickChunkAlloc> chunks;
		}

		private class CellSortInfo : IComparable
		{
			internal string sourceAsset;

			internal Cell cell;

			internal float distanceToCamera;

			internal Vector3 position;

			public int CompareTo(object obj)
			{
				return 0;
			}
		}

		internal struct Volume : IEquatable<Volume>
		{
			internal Vector3 corner;

			internal Vector3 X;

			internal Vector3 Y;

			internal Vector3 Z;

			internal float maxSubdivisionMultiplier;

			internal float minSubdivisionMultiplier;

			public Volume(Matrix4x4 trs, float maxSubdivision, float minSubdivision)
			{
				corner = default(Vector3);
				X = default(Vector3);
				Y = default(Vector3);
				Z = default(Vector3);
				maxSubdivisionMultiplier = 0f;
				minSubdivisionMultiplier = 0f;
			}

			public Volume(Vector3 corner, Vector3 X, Vector3 Y, Vector3 Z, float maxSubdivision = 1f, float minSubdivision = 0f)
			{
				this.corner = default(Vector3);
				this.X = default(Vector3);
				this.Y = default(Vector3);
				this.Z = default(Vector3);
				maxSubdivisionMultiplier = 0f;
				minSubdivisionMultiplier = 0f;
			}

			public Volume(Volume copy)
			{
				corner = default(Vector3);
				X = default(Vector3);
				Y = default(Vector3);
				Z = default(Vector3);
				maxSubdivisionMultiplier = 0f;
				minSubdivisionMultiplier = 0f;
			}

			public Bounds CalculateAABB()
			{
				return default(Bounds);
			}

			public void CalculateCenterAndSize(out Vector3 center, out Vector3 size)
			{
				center = default(Vector3);
				size = default(Vector3);
			}

			public void Transform(Matrix4x4 trs)
			{
			}

			public override string ToString()
			{
				return null;
			}

			public bool Equals(Volume other)
			{
				return false;
			}
		}

		internal struct RefVolTransform
		{
			public Matrix4x4 refSpaceToWS;

			public Vector3 posWS;

			public Quaternion rot;

			public float scale;
		}

		public struct RuntimeResources
		{
			public ComputeBuffer index;

			public ComputeBuffer cellIndices;

			public Texture3D L0_L1rx;

			public Texture3D L1_G_ry;

			public Texture3D L1_B_rz;

			public Texture3D L2_0;

			public Texture3D L2_1;

			public Texture3D L2_2;

			public Texture3D L2_3;
		}

		internal struct RegId
		{
			internal int id;

			public bool IsValid()
			{
				return false;
			}

			public void Invalidate()
			{
			}

			public static bool operator ==(RegId lhs, RegId rhs)
			{
				return false;
			}

			public static bool operator !=(RegId lhs, RegId rhs)
			{
				return false;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct ExtraDataActionInput
		{
		}

		private struct InitInfo
		{
			public Vector3Int pendingMinCellPosition;

			public Vector3Int pendingMaxCellPosition;
		}

		private class CellInstancedDebugProbes
		{
			public List<Matrix4x4[]> probeBuffers;

			public List<MaterialPropertyBlock> props;

			public Hash128 cellHash;

			public Vector3 cellPosition;
		}

		private const int kProbeIndexPoolAllocationSize = 128;

		private bool m_IsInitialized;

		private int m_ID;

		private RefVolTransform m_Transform;

		private int m_MaxSubdivision;

		private ProbeBrickPool m_Pool;

		private ProbeBrickIndex m_Index;

		private ProbeCellIndices m_CellIndices;

		private List<ProbeBrickPool.BrickChunkAlloc> m_TmpSrcChunks;

		private float[] m_PositionOffsets;

		private Dictionary<RegId, List<ProbeBrickPool.BrickChunkAlloc>> m_Registry;

		private Bounds m_CurrGlobalBounds;

		internal Dictionary<int, Cell> cells;

		private Dictionary<int, CellChunkInfo> m_ChunkInfo;

		internal ProbeVolumeSceneData sceneData;

		public Action<ExtraDataActionInput> retrieveExtraDataAction;

		private bool m_BricksLoaded;

		private Dictionary<Cell, RegId> m_CellToBricks;

		private Dictionary<RegId, ProbeBrickIndex.CellIndexUpdateInfo> m_BricksToCellUpdateInfo;

		private Dictionary<string, ProbeVolumeAsset> m_PendingAssetsToBeLoaded;

		private Dictionary<string, ProbeVolumeAsset> m_PendingAssetsToBeUnloaded;

		private Dictionary<string, ProbeVolumeAsset> m_ActiveAssets;

		private List<CellSortInfo> m_CellsToBeLoaded;

		private Dictionary<int, int> m_CellRefCounting;

		private bool m_NeedLoadAsset;

		private bool m_ProbeReferenceVolumeInit;

		private bool m_EnabledBySRP;

		private InitInfo m_PendingInitInfo;

		private bool m_NeedsIndexRebuild;

		private bool m_HasChangedIndex;

		private int m_CBShaderID;

		private int m_NumberOfCellsLoadedPerFrame;

		private ProbeVolumeTextureMemoryBudget m_MemoryBudget;

		private ProbeVolumeSHBands m_SHBands;

		internal bool clearAssetsOnVolumeClear;

		private static ProbeReferenceVolume _instance;

		private const int kProbesPerBatch = 1023;

		private DebugUI.Widget[] m_DebugItems;

		private Mesh m_DebugMesh;

		private Material m_DebugMaterial;

		private List<CellInstancedDebugProbes> m_CellDebugData;

		private Plane[] m_DebugFrustumPlanes;

		internal float dilationValidtyThreshold;

		internal Dictionary<Volume, List<ProbeBrickIndex.Brick>> realtimeSubdivisionInfo;

		internal bool isInitialized => false;

		internal bool enabledBySRP => false;

		public ProbeVolumeSHBands shBands => default(ProbeVolumeSHBands);

		public ProbeVolumeTextureMemoryBudget memoryBudget => default(ProbeVolumeTextureMemoryBudget);

		public static ProbeReferenceVolume instance => null;

		internal ProbeVolumeDebug debugDisplay { get; }

		public Color[] subdivisionDebugColors { get; }

		private void InvalidateAllCellRefs()
		{
		}

		public void SetNumberOfCellsLoadedPerFrame(int numberOfCells)
		{
		}

		public void Initialize(in ProbeVolumeSystemParameters parameters)
		{
		}

		public void SetEnableStateFromSRP(bool srpEnablesPV)
		{
		}

		internal void ForceSHBand(ProbeVolumeSHBands shBands)
		{
		}

		public void Cleanup()
		{
		}

		public int GetVideoMemoryCost()
		{
			return 0;
		}

		private void RemoveCell(Cell cell)
		{
		}

		private void AddCell(Cell cell, List<ProbeBrickPool.BrickChunkAlloc> chunks)
		{
		}

		private bool CheckCompatibilityWithCollection(ProbeVolumeAsset asset, Dictionary<string, ProbeVolumeAsset> collection)
		{
			return false;
		}

		internal void AddPendingAssetLoading(ProbeVolumeAsset asset)
		{
		}

		internal void AddPendingAssetRemoval(ProbeVolumeAsset asset)
		{
		}

		internal void RemovePendingAsset(ProbeVolumeAsset asset)
		{
		}

		private void PerformPendingIndexChangeAndInit()
		{
		}

		internal void SetMinBrickAndMaxSubdiv(float minBrickSize, int maxSubdiv)
		{
		}

		private void LoadAsset(ProbeVolumeAsset asset)
		{
		}

		private void PerformPendingLoading()
		{
		}

		private void PerformPendingDeletion()
		{
		}

		private int GetNumberOfBricksAtSubdiv(Cell cell, out Vector3Int minValidLocalIdxAtMaxRes, out Vector3Int sizeOfValidIndicesAtMaxRes)
		{
			minValidLocalIdxAtMaxRes = default(Vector3Int);
			sizeOfValidIndicesAtMaxRes = default(Vector3Int);
			return 0;
		}

		private bool GetCellIndexUpdate(Cell cell, out ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo)
		{
			cellUpdateInfo = default(ProbeBrickIndex.CellIndexUpdateInfo);
			return false;
		}

		private void LoadPendingCells(bool loadAll = false)
		{
		}

		public void PerformPendingOperations(bool loadAllCells = false)
		{
		}

		private void InitProbeReferenceVolume(int allocationSize, ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands)
		{
		}

		public void SortPendingCells(Vector3 cameraPosition)
		{
		}

		private ProbeReferenceVolume()
		{
		}

		public RuntimeResources GetRuntimeResources()
		{
			return default(RuntimeResources);
		}

		internal void SetTRS(Vector3 position, Quaternion rotation, float minBrickSize)
		{
		}

		internal void SetMaxSubdivision(int maxSubdivision)
		{
		}

		internal static int CellSize(int subdivisionLevel)
		{
			return 0;
		}

		internal float BrickSize(int subdivisionLevel)
		{
			return 0f;
		}

		internal float MinBrickSize()
		{
			return 0f;
		}

		internal float MaxBrickSize()
		{
			return 0f;
		}

		internal Matrix4x4 GetRefSpaceToWS()
		{
			return default(Matrix4x4);
		}

		internal RefVolTransform GetTransform()
		{
			return default(RefVolTransform);
		}

		internal int GetMaxSubdivision()
		{
			return 0;
		}

		internal int GetMaxSubdivision(float multiplier)
		{
			return 0;
		}

		internal float GetDistanceBetweenProbes(int subdivisionLevel)
		{
			return 0f;
		}

		internal float MinDistanceBetweenProbes()
		{
			return 0f;
		}

		public bool DataHasBeenLoaded()
		{
			return false;
		}

		internal void Clear()
		{
		}

		private RegId AddBricks(List<ProbeBrickIndex.Brick> bricks, ProbeBrickPool.DataLocation dataloc, ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, out List<ProbeBrickPool.BrickChunkAlloc> ch_list)
		{
			ch_list = null;
			return default(RegId);
		}

		private void ReleaseBricks(RegId id)
		{
		}

		public void UpdateConstantBuffer(CommandBuffer cmd, ProbeVolumeShadingParameters parameters)
		{
		}

		private void CleanupLoadedData()
		{
		}

		public void RenderDebug(Camera camera)
		{
		}

		private void InitializeDebug(Mesh debugProbeMesh, Shader debugProbeShader)
		{
		}

		private void CleanupDebug()
		{
		}

		private void RefreshDebug<T>(DebugUI.Field<T> field, T value)
		{
		}

		private void DebugCellIndexChanged<T>(DebugUI.Field<T> field, T value)
		{
		}

		private void RegisterDebug()
		{
		}

		private void UnregisterDebug(bool destroyPanel)
		{
		}

		private bool ShouldCullCell(Vector3 cellPosition, Transform cameraTransform, Plane[] frustumPlanes)
		{
			return false;
		}

		private void DrawProbeDebug(Camera camera)
		{
		}

		private void ClearDebugData()
		{
		}

		private void CreateInstancedProbes()
		{
		}

		private void OnClearLightingdata()
		{
		}
	}
}
