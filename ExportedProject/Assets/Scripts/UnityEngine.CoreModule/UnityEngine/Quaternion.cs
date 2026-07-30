using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeType(Header = "Runtime/Math/Quaternion.h")]
	[UsedByNativeCode]
	[Il2CppEagerStaticClassConstruction]
	[NativeHeader("Runtime/Math/MathScripting.h")]
	[DefaultMember("Item")]
	public struct Quaternion : IEquatable<Quaternion>, IFormattable
	{
		public float x;

		public float y;

		public float z;

		public float w;

		private static readonly Quaternion identityQuaternion;

		public const float kEpsilon = 1E-06f;

		public static Quaternion identity
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Quaternion);
			}
		}

		public Vector3 eulerAngles
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
		}

		[FreeFunction(IsThreadSafe = true)]
		public static Quaternion Inverse(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[FreeFunction("QuaternionScripting::Slerp", IsThreadSafe = true)]
		public static Quaternion Slerp(Quaternion a, Quaternion b, float t)
		{
			return default(Quaternion);
		}

		[FreeFunction("QuaternionScripting::Lerp", IsThreadSafe = true)]
		public static Quaternion Lerp(Quaternion a, Quaternion b, float t)
		{
			return default(Quaternion);
		}

		[FreeFunction("EulerToQuaternion", IsThreadSafe = true)]
		private static Quaternion Internal_FromEulerRad(Vector3 euler)
		{
			return default(Quaternion);
		}

		[FreeFunction("QuaternionScripting::ToEuler", IsThreadSafe = true)]
		private static Vector3 Internal_ToEulerRad(Quaternion rotation)
		{
			return default(Vector3);
		}

		[FreeFunction("QuaternionScripting::AngleAxis", IsThreadSafe = true)]
		public static Quaternion AngleAxis(float angle, Vector3 axis)
		{
			return default(Quaternion);
		}

		[FreeFunction("QuaternionScripting::LookRotation", IsThreadSafe = true)]
		public static Quaternion LookRotation(Vector3 forward, [DefaultValue("Vector3.up")] Vector3 upwards)
		{
			return default(Quaternion);
		}

		[ExcludeFromDocs]
		public static Quaternion LookRotation(Vector3 forward)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Quaternion(float x, float y, float z, float w)
		{
			this.x = 0f;
			this.y = 0f;
			this.z = 0f;
			this.w = 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion operator *(Quaternion lhs, Quaternion rhs)
		{
			return default(Quaternion);
		}

		public static Vector3 operator *(Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsEqualUsingDot(float dot)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Quaternion lhs, Quaternion rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(Quaternion lhs, Quaternion rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(Quaternion a, Quaternion b)
		{
			return 0f;
		}

		private static Vector3 Internal_MakePositive(Vector3 euler)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion Euler(float x, float y, float z)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion Euler(Vector3 euler)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(Quaternion other)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(string format)
		{
			return null;
		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		private static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void LookRotation_Injected(ref Vector3 forward, [DefaultValue("Vector3.up")] ref Vector3 upwards, out Quaternion ret)
		{
			ret = default(Quaternion);
		}
	}
}
