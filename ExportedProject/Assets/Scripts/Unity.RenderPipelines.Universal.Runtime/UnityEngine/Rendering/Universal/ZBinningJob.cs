using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.Rendering.Universal
{
	[BurstCompile]
	internal struct ZBinningJob : IJobFor
	{
		public const int batchCount = 64;

		[NativeDisableParallelForRestriction]
		public NativeArray<ZBin> bins;

		[ReadOnly]
		public NativeArray<LightMinMaxZ> minMaxZs;

		public int binOffset;

		public float zFactor;

		public void Execute(int index)
		{
		}
	}
}
