using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace NatML
{
	public sealed class MLAsyncPredictor<TOutput> : IMLPredictor<Task<TOutput>>, IDisposable
	{
		public readonly IMLPredictor<TOutput> predictor;

		private readonly ConcurrentQueue<(MLFeature[] inputs, TaskCompletionSource<TOutput> tcs)> queue;

		private readonly AutoResetEvent fence;

		private readonly CancellationTokenSource cts;

		private readonly Task task;

		public bool readyForPrediction
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			private set;
		}

		public Task<TOutput> Predict(params MLFeature[] inputs)
		{
			return null;
		}

		public void Dispose()
		{
		}

		internal MLAsyncPredictor(IMLPredictor<TOutput> predictor)
		{
		}
	}
}
