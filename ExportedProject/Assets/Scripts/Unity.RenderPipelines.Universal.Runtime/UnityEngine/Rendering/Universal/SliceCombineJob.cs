using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal
{
	[BurstCompile]
	internal struct SliceCombineJob : IJobFor
	{
		public int2 tileResolution;

		public int wordsPerTile;

		[ReadOnly]
		public NativeArray<uint> sliceLightMasksH;

		[ReadOnly]
		public NativeArray<uint> sliceLightMasksV;

		[NativeDisableParallelForRestriction]
		public NativeArray<uint> lightMasks;

		public void Execute(int idY)
		{
		}
	}
}
