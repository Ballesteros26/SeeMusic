using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace Unity.Collections.LowLevel.Unsafe
{
	[StaticAccessor("UnsafeUtility", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Export/Unsafe/UnsafeUtility.bindings.h")]
	public static class UnsafeUtility
	{
		private struct AlignOfHelper<T> where T : struct
		{
			public byte dummy;

			public T data;
		}

		[ThreadSafe(ThrowsException = true)]
		public unsafe static void* Malloc(long size, int alignment, Allocator allocator)
		{
			return null;
		}

		[ThreadSafe(ThrowsException = true)]
		public unsafe static void Free(void* memory, Allocator allocator)
		{
		}

		[ThreadSafe(ThrowsException = true)]
		public unsafe static void MemCpy(void* destination, void* source, long size)
		{
		}

		[ThreadSafe(ThrowsException = true)]
		public unsafe static void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count)
		{
		}

		[ThreadSafe(ThrowsException = true)]
		public unsafe static void MemSet(void* destination, byte value, long size)
		{
		}

		public unsafe static void MemClear(void* destination, long size)
		{
		}

		[ThreadSafe]
		public static int SizeOf(Type type)
		{
			return 0;
		}

		[ThreadSafe]
		public static bool IsBlittable(Type type)
		{
			return false;
		}

		private static bool IsBlittableValueType(Type t)
		{
			return false;
		}

		private static string GetReasonForTypeNonBlittableImpl(Type t, string name)
		{
			return null;
		}

		internal static bool IsArrayBlittable(Array arr)
		{
			return false;
		}

		internal static string GetReasonForArrayNonBlittable(Array arr)
		{
			return null;
		}

		public static int AlignOf<T>() where T : struct
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void CopyPtrToStructure<T>(void* ptr, out T output) where T : struct
		{
			output = default(T);
		}

		private unsafe static void InternalCopyPtrToStructure<T>(void* ptr, out T output) where T : struct
		{
			output = default(T);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static T ReadArrayElement<T>(void* source, int index)
		{
			return default(T);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static T ReadArrayElementWithStride<T>(void* source, int index, int stride)
		{
			return default(T);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void WriteArrayElement<T>(void* destination, int index, T value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void* AddressOf<T>(ref T output) where T : struct
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int SizeOf<T>() where T : struct
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int EnumToInt<T>(T enumValue) where T : struct, IConvertible
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void InternalEnumToInt<T>(ref T enumValue, ref int intValue)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool EnumEquals<T>(T lhs, T rhs) where T : struct, IConvertible
		{
			return false;
		}
	}
}
