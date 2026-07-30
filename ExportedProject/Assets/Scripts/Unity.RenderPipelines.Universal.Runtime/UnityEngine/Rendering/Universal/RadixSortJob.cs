using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.Rendering.Universal
{
	[BurstCompile]
	internal struct RadixSortJob : IJob
	{
		public NativeArray<uint> keys;

		public NativeArray<int> indices;

		public void Execute()
		{
		}
	}
}
