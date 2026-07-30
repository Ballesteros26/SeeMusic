using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal
{
	[BurstCompile]
	internal struct SliceCullingJob : IJobFor
	{
		private struct Cone
		{
			public float3 tip;

			public float3 direction;

			public float height;

			public float radius;
		}

		private struct Sphere
		{
			public float3 center;

			public float radius;
		}

		private struct Plane
		{
			public float3 normal;

			public float distanceToOrigin;
		}

		public float scale;

		public float3 viewOrigin;

		public float3 viewForward;

		public float3 viewRight;

		public float3 viewUp;

		[ReadOnly]
		public NativeArray<LightType> lightTypes;

		[ReadOnly]
		public NativeArray<float> radiuses;

		[ReadOnly]
		public NativeArray<float3> directions;

		[ReadOnly]
		public NativeArray<float3> positions;

		[ReadOnly]
		public NativeArray<float> coneRadiuses;

		public int lightsPerTile;

		[NativeDisableParallelForRestriction]
		public NativeArray<uint> sliceLightMasks;

		public void Execute(int index)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool ContainsLight(Plane leftPlane, Plane rightPlane, int lightIndex)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Plane ComputePlane(float3 p0, float3 p1, float3 p2)
		{
			return default(Plane);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool SphereBehindPlane(Sphere sphere, Plane plane)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool PointBehindPlane(float3 p, Plane plane)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ConeBehindPlane(Cone cone, Plane plane)
		{
			return false;
		}
	}
}
