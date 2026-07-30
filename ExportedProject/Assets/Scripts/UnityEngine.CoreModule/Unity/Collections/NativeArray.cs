using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine.Internal;

namespace Unity.Collections
{
	[NativeContainer]
	[NativeContainerSupportsMinMaxWriteRestriction]
	[DebuggerTypeProxy(typeof(NativeArrayDebugView<>))]
	[NativeContainerSupportsDeferredConvertListToArray]
	[NativeContainerSupportsDeallocateOnJobCompletion]
	[DebuggerDisplay("Length = {Length}")]
	public struct NativeArray<T> : IDisposable, IEnumerable<T>, IEnumerable, IEquatable<NativeArray<T>> where T : struct
	{
		[ExcludeFromDocs]
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			private NativeArray<T> m_Array;

			private int m_Index;

			private T value;

			public T Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return default(T);
				}
			}

			object IEnumerator.Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return null;
				}
			}

			public Enumerator(ref NativeArray<T> array)
			{
				m_Array = default(NativeArray<T>);
				m_Index = 0;
				value = default(T);
			}

			public void Dispose()
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		[NativeDisableUnsafePtrRestriction]
		internal unsafe void* m_Buffer;

		internal int m_Length;

		internal Allocator m_AllocatorLabel;

		public int Length
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
			}
		}

		public T this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(T);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[WriteAccessRequired]
			set
			{
			}
		}

		public bool IsCreated
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public unsafe NativeArray(int length, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
		{
			m_Buffer = null;
			m_Length = 0;
			m_AllocatorLabel = default(Allocator);
		}

		public unsafe NativeArray(T[] array, Allocator allocator)
		{
			m_Buffer = null;
			m_Length = 0;
			m_AllocatorLabel = default(Allocator);
		}

		public unsafe NativeArray(NativeArray<T> array, Allocator allocator)
		{
			m_Buffer = null;
			m_Length = 0;
			m_AllocatorLabel = default(Allocator);
		}

		private static void Allocate(int length, Allocator allocator, out NativeArray<T> array)
		{
			array = default(NativeArray<T>);
		}

		[WriteAccessRequired]
		public void Dispose()
		{
		}

		public JobHandle Dispose(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		[WriteAccessRequired]
		public void CopyFrom(T[] array)
		{
		}

		[WriteAccessRequired]
		public void CopyFrom(NativeArray<T> array)
		{
		}

		public void CopyTo(T[] array)
		{
		}

		public T[] ToArray()
		{
			return null;
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public bool Equals(NativeArray<T> other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static void Copy(NativeArray<T> src, NativeArray<T> dst)
		{
		}

		public static void Copy(T[] src, NativeArray<T> dst)
		{
		}

		public static void Copy(NativeArray<T> src, T[] dst)
		{
		}

		public static void Copy(NativeArray<T> src, NativeArray<T> dst, int length)
		{
		}

		public static void Copy(NativeArray<T> src, T[] dst, int length)
		{
		}

		public static void Copy(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
		}

		public static void Copy(T[] src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
		}

		public static void Copy(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length)
		{
		}

		private NativeArray<U> InternalReinterpret<U>(int length) where U : struct
		{
			return default(NativeArray<U>);
		}

		public NativeArray<U> Reinterpret<U>() where U : struct
		{
			return default(NativeArray<U>);
		}

		public NativeArray<U> Reinterpret<U>(int expectedTypeSize) where U : struct
		{
			return default(NativeArray<U>);
		}

		public NativeArray<T> GetSubArray(int start, int length)
		{
			return default(NativeArray<T>);
		}
	}
}
