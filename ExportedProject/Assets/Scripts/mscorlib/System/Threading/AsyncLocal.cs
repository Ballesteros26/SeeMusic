namespace System.Threading
{
	public sealed class AsyncLocal<T>
	{
		private readonly Action<AsyncLocalValueChangedArgs<T>> m_valueChangedHandler;
	}
}
