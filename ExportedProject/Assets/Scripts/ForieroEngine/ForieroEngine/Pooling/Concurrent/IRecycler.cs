namespace ForieroEngine.Pooling.Concurrent
{
	public interface IRecycler
	{
		int Count { get; }

		int AvailableCount { get; }

		int InUseCount { get; }

		IRecyclable Acquire();

		void Release(IRecyclable instance);
	}
	public interface IRecycler<T> : IRecycler where T : class, IRecyclable
	{
		new T Acquire();

		void Release(T instance);
	}
}
