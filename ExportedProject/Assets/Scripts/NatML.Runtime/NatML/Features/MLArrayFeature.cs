using System;
using System.Collections.Generic;
using NatML.API.Types;
using NatML.Types;
using Unity.Collections;
using UnityEngine;

namespace NatML.Features
{
	public sealed class MLArrayFeature<T> : MLFeature, IMLEdgeFeature, IMLCloudFeature where T : unmanaged
	{
		private readonly T[] array;

		private unsafe readonly T* buffer;

		private readonly int[] strides;

		private static readonly Dtype[] Dtypes;

		private static readonly Dictionary<Type, List<TextureFormat>> TextureFormats;

		public int[] shape => null;

		public int elementCount => 0;

		public T this[in int idx]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public T this[in int idx0, in int idx1]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public T this[in int idx0, in int idx1, in int idx2]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public T this[in int idx0, in int idx1, in int idx2, in int idx3]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public T this[in int idx0, in int idx1, in int idx2, in int idx3, in int idx4]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public T this[params int[] idx]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public MLArrayFeature(T[] data, int[] shape = null)
			: base(null)
		{
		}

		public MLArrayFeature(NativeArray<T> data, int[] shape = null)
			: base(null)
		{
		}

		public unsafe MLArrayFeature(T* data, int[] shape = null)
			: base(null)
		{
		}

		public MLArrayFeature(T[] data, MLArrayType type)
			: base(null)
		{
		}

		public MLArrayFeature(NativeArray<T> data, MLArrayType type)
			: base(null)
		{
		}

		public unsafe MLArrayFeature(T* data, MLArrayType type)
			: base(null)
		{
		}

		public MLArrayFeature(MLEdgeFeature feature)
			: base(null)
		{
		}

		public MLArrayFeature(MLCloudFeature feature)
			: base(null)
		{
		}

		public MLArrayFeature<T> Flatten(int startDim = 0, int endDim = -1)
		{
			return null;
		}

		public MLArrayFeature<T> Permute(params int[] dims)
		{
			return null;
		}

		public MLArrayFeature<T> Squeeze(int dim = -1)
		{
			return null;
		}

		public MLArrayFeature<T> View(params int[] shape)
		{
			return null;
		}

		public void CopyTo<U>(MLArrayFeature<U> destination) where U : struct
		{
		}

		public void CopyTo(Texture2D destination, bool upload = true)
		{
		}

		public T[] ToArray()
		{
			return null;
		}

		public U[] ToArray<U>() where U : struct
		{
			return null;
		}

		public ref T GetPinnableReference()
		{
			throw null;
		}

		MLEdgeFeature IMLEdgeFeature.Create(MLFeatureType type)
		{
			return default(MLEdgeFeature);
		}

		MLCloudFeature IMLCloudFeature.Create(MLFeatureType _)
		{
			return default(MLCloudFeature);
		}

		private static int[] ComputeStrides(int[] shape)
		{
			return null;
		}

		private static T[] GetFeatureData(MLCloudFeature feature)
		{
			return null;
		}
	}
}
