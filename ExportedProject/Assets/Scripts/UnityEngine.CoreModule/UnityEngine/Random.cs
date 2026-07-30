using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
	public static class Random
	{
		[Serializable]
		public struct State
		{
			[SerializeField]
			private int s0;

			[SerializeField]
			private int s1;

			[SerializeField]
			private int s2;

			[SerializeField]
			private int s3;
		}

		[StaticAccessor("GetScriptingRand()", StaticAccessorType.Dot)]
		public static State state
		{
			get
			{
				return default(State);
			}
			set
			{
			}
		}

		public static float value
		{
			[FreeFunction]
			get
			{
				return 0f;
			}
		}

		public static Vector3 insideUnitSphere
		{
			[FreeFunction]
			get
			{
				return default(Vector3);
			}
		}

		public static Quaternion rotation
		{
			[FreeFunction]
			get
			{
				return default(Quaternion);
			}
		}

		[NativeMethod("SetSeed")]
		[StaticAccessor("GetScriptingRand()", StaticAccessorType.Dot)]
		public static void InitState(int seed)
		{
		}

		[FreeFunction]
		public static float Range(float minInclusive, float maxInclusive)
		{
			return 0f;
		}

		public static int Range(int minInclusive, int maxExclusive)
		{
			return 0;
		}

		[FreeFunction]
		private static int RandomRangeInt(int minInclusive, int maxExclusive)
		{
			return 0;
		}

		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax)
		{
			return default(Color);
		}

		[SpecialName]
		private static void get_state_Injected(out State ret)
		{
			ret = default(State);
		}

		[SpecialName]
		private static void set_state_Injected(ref State value)
		{
		}

		[SpecialName]
		private static void get_insideUnitSphere_Injected(out Vector3 ret)
		{
			ret = default(Vector3);
		}

		[SpecialName]
		private static void get_rotation_Injected(out Quaternion ret)
		{
			ret = default(Quaternion);
		}
	}
}
