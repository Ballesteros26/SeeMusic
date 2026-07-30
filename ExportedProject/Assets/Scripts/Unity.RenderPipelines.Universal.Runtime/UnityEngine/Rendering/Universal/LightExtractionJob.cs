using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal
{
	[BurstCompile]
	internal struct LightExtractionJob : IJobFor
	{
		[ReadOnly]
		public NativeArray<VisibleLight> lights;

		public NativeArray<LightType> lightTypes;

		public NativeArray<float> radiuses;

		public NativeArray<float3> directions;

		public NativeArray<float3> positions;

		public NativeArray<float> coneRadiuses;

		public void Execute(int index)
		{
		}
	}
}
