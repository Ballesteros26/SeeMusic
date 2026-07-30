using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal
{
	[BurstCompile]
	internal struct MinMaxZJob : IJobFor
	{
		public float4x4 worldToViewMatrix;

		[ReadOnly]
		public NativeArray<VisibleLight> lights;

		public NativeArray<LightMinMaxZ> minMaxZs;

		public NativeArray<float> meanZs;

		public void Execute(int index)
		{
		}
	}
}
