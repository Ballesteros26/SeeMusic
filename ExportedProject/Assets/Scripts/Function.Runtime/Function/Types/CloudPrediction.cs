using System;
using Function.Internal;

namespace Function.Types
{
	[Serializable]
	[Preserve]
	public class CloudPrediction : Prediction
	{
		public object[]? results;

		public float? latency;

		public string? error;

		public string? logs;
	}
}
