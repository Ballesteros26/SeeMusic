using System;

namespace ForieroEngine.Pooling.Concurrent
{
	public abstract class RecyclableObject : IRecyclable, IDisposable
	{
		private ReleaseInstanceDelegate Release;

		protected bool ObjectAcquired;

		public bool IsPooled => false;

		public abstract void Recycle();

		public void Bind(ReleaseInstanceDelegate releaser)
		{
		}

		public void OnAcquire()
		{
		}

		public void Dispose()
		{
		}

		public void TryRelease()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		~RecyclableObject()
		{
		}
	}
}
