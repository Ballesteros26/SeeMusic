using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
	internal class ProbeBrickPool
	{
		[DebuggerDisplay("Chunk ({x}, {y}, {z})")]
		public struct BrickChunkAlloc
		{
			public int x;

			public int y;

			public int z;

			internal int flattenIndex(int sx, int sy)
			{
				return 0;
			}
		}

		public struct DataLocation
		{
			internal Texture3D TexL0_L1rx;

			internal Texture3D TexL1_G_ry;

			internal Texture3D TexL1_B_rz;

			internal Texture3D TexL2_0;

			internal Texture3D TexL2_1;

			internal Texture3D TexL2_2;

			internal Texture3D TexL2_3;

			internal int width;

			internal int height;

			internal int depth;

			internal void Cleanup()
			{
			}
		}

		internal const int kBrickCellCount = 3;

		internal const int kBrickProbeCountPerDim = 4;

		internal const int kBrickProbeCountTotal = 64;

		private const int kMaxPoolWidth = 2048;

		private int m_AllocationSize;

		private ProbeVolumeTextureMemoryBudget m_MemoryBudget;

		private DataLocation m_Pool;

		private BrickChunkAlloc m_NextFreeChunk;

		private Stack<BrickChunkAlloc> m_FreeList;

		private ProbeVolumeSHBands m_SHBands;

		internal int estimatedVMemCost { get; private set; }

		internal ProbeBrickPool(int allocationSize, ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands)
		{
		}

		internal void EnsureTextureValidity()
		{
		}

		internal int GetChunkSize()
		{
			return 0;
		}

		internal int GetChunkSizeInProbeCount()
		{
			return 0;
		}

		internal int GetPoolWidth()
		{
			return 0;
		}

		internal int GetPoolHeight()
		{
			return 0;
		}

		internal Vector3Int GetPoolDimensions()
		{
			return default(Vector3Int);
		}

		internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr)
		{
		}

		internal void Clear()
		{
		}

		internal void Allocate(int numberOfBrickChunks, List<BrickChunkAlloc> outAllocations)
		{
		}

		internal void Deallocate(List<BrickChunkAlloc> allocations)
		{
		}

		internal void Update(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, ProbeVolumeSHBands bands)
		{
		}

		private static Vector3Int ProbeCountToDataLocSize(int numProbes)
		{
			return default(Vector3Int);
		}

		public static DataLocation CreateDataLocation(int numProbes, bool compressed, ProbeVolumeSHBands bands, out int allocatedBytes)
		{
			allocatedBytes = default(int);
			return default(DataLocation);
		}

		private static void SetPixel(ref Color[] data, int x, int y, int z, int dataLocWidth, int dataLocHeight, Color value)
		{
		}

		public static void FillDataLocation(ref DataLocation loc, SphericalHarmonicsL2[] shl2, ProbeVolumeSHBands bands)
		{
		}

		private void DerivePoolSizeFromBudget(int allocationSize, ProbeVolumeTextureMemoryBudget memoryBudget, out int width, out int height, out int depth)
		{
			width = default(int);
			height = default(int);
			depth = default(int);
		}

		internal void Cleanup()
		{
		}
	}
}
