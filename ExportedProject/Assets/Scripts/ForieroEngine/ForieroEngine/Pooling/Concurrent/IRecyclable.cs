using System;

namespace ForieroEngine.Pooling.Concurrent
{
	public interface IRecyclable : IDisposable
	{
		void Recycle();

		void Bind(ReleaseInstanceDelegate releaser);

		void OnAcquire();
	}
}
