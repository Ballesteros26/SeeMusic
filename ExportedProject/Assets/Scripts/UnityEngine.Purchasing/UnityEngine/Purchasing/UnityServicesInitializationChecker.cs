namespace UnityEngine.Purchasing
{
	internal class UnityServicesInitializationChecker : IUnityServicesInitializationChecker
	{
		private readonly ILogger m_Logger;

		public UnityServicesInitializationChecker(ILogger logger)
		{
		}

		public void CheckAndLogWarning()
		{
		}

		private bool IsUninitialized()
		{
			return false;
		}

		private void LogWarning()
		{
		}
	}
}
