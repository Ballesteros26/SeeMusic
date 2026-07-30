using System;
using System.Collections.Generic;

namespace NatML
{
	public abstract class MLModel : IDisposable
	{
		public MLFeatureType[] inputs { get; protected set; }

		public MLFeatureType[] outputs { get; protected set; }

		public IReadOnlyDictionary<string, string> metadata { get; protected set; }

		public virtual void Dispose()
		{
		}
	}
}
