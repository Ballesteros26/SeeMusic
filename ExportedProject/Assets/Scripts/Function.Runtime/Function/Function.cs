using Function.Graph;
using Function.Services;

namespace Function
{
	public sealed class Function
	{
		public readonly UserService Users;

		public readonly PredictorService Predictors;

		public readonly EnvironmentVariableService EnvironmentVariables;

		public readonly PredictionService Predictions;

		public readonly StorageService Storage;

		public readonly IGraphClient client;

		internal const string URL = "https://api.fxn.ai/graph";

		public Function(string accessKey = null, string url = null)
		{
		}

		public Function(IGraphClient client)
		{
		}
	}
}
