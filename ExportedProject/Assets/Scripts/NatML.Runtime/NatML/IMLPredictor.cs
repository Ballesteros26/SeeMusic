using System;

namespace NatML
{
	public interface IMLPredictor<TOutput> : IDisposable
	{
		TOutput Predict(params MLFeature[] inputs);
	}
}
