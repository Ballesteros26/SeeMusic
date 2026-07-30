using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public static class math
	{
		[StructLayout((LayoutKind)2)]
		internal struct IntFloatUnion
		{
			[FieldOffset(0)]
			public int intValue;

			[FieldOffset(0)]
			public float floatValue;
		}

		[StructLayout((LayoutKind)2)]
		internal struct LongDoubleUnion
		{
			[FieldOffset(0)]
			public long longValue;

			[FieldOffset(0)]
			public double doubleValue;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(double2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 float2(float x, float y)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 float3(float x, float y, float z)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float3x3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(float x, float y, float z, float w)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(float3 xyz, float w)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float4x4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 int2(int x, int y)
		{
			return default(int2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(int2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(int3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(int4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int asint(float x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 asuint(int2 x)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 asuint(int3 x)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 asuint(int4 x)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint asuint(float x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 asuint(float2 x)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 asuint(float3 x)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 asuint(float4 x)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long aslong(double x)
		{
			return 0L;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong asulong(double x)
		{
			return 0uL;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float asfloat(int x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float asfloat(uint x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 asfloat(uint2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 asfloat(uint3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double asdouble(long x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double asdouble(ulong x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool isinf(double x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int min(int x, int y)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float min(float x, float y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 min(float2 x, float2 y)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 min(float3 x, float3 y)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double min(double x, double y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 min(double2 x, double2 y)
		{
			return default(double2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int max(int x, int y)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint max(uint x, uint y)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float max(float x, float y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 max(float2 x, float2 y)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 max(float3 x, float3 y)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float lerp(float x, float y, float s)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int clamp(int x, int a, int b)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float clamp(float x, float a, float b)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int abs(int x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float abs(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 abs(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double abs(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float dot(float2 x, float2 y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float dot(float3 x, float3 y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float dot(float4 x, float4 y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double dot(double2 x, double2 y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float tan(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float cos(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 cos(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float sin(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 sin(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float pow(float x, float y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float sqrt(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double sqrt(double x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float rsqrt(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 normalize(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float length(float2 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float length(float3 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float length(float4 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double length(double2 x)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float lengthsq(float3 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float lengthsq(float4 x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float distance(float2 x, float2 y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double distance(double2 x, double2 y)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float distancesq(float3 x, float3 y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float distancesq(float4 x, float4 y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 cross(float3 x, float3 y)
		{
			return default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool any(float2 x)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint select(uint a, uint b, bool c)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sincos(float3 x, out float3 s, out float3 c)
		{
			s = default(float3);
			c = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float radians(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint csum(uint2 x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint csum(uint3 x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint csum(uint4 x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float f16tof32(uint x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint fold_to_uint(double x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint2 fold_to_uint(double2 x)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 float3x3(quaternion rotation)
		{
			return default(float3x3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 mul(float4x4 a, float4 b)
		{
			return default(float4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 mul(float4x4 a, float4x4 b)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion quaternion(float4 value)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion mul(quaternion a, quaternion b)
		{
			return default(quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(quaternion q)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 uint2(uint x, uint y)
		{
			return default(uint2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(uint2 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 uint3(uint x, uint y, uint z)
		{
			return default(uint3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(uint3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(uint x, uint y, uint z, uint w)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(uint4 v)
		{
			return 0u;
		}
	}
}
