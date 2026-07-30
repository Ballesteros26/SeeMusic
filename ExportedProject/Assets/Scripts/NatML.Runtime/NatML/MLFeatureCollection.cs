using System;
using System.Collections;
using System.Collections.Generic;

namespace NatML
{
	public readonly struct MLFeatureCollection<TFeature> : IReadOnlyList<TFeature>, IEnumerable<TFeature>, IEnumerable, IReadOnlyCollection<TFeature>, IDisposable where TFeature : IDisposable
	{
		private readonly TFeature[] features;

		public int Count => 0;

		public TFeature this[int index] => default(TFeature);

		public MLFeatureCollection(TFeature[] features)
		{
			this.features = null;
		}

		public void Dispose()
		{
		}

		IEnumerator<TFeature> IEnumerable<TFeature>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public static implicit operator TFeature[](MLFeatureCollection<TFeature> collection)
		{
			return null;
		}

		public static implicit operator MLFeatureCollection<TFeature>(TFeature[] features)
		{
			return default(MLFeatureCollection<TFeature>);
		}
	}
}
