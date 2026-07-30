namespace UnityEngine.Purchasing
{
	internal class TransactionLog
	{
		private readonly ILogger logger;

		private readonly string persistentDataPath;

		public TransactionLog(ILogger logger, string persistentDataPath)
		{
		}

		public bool HasRecordOf(string transactionID)
		{
			return false;
		}

		public void Record(string transactionID)
		{
		}

		private string GetRecordPath(string transactionID)
		{
			return null;
		}

		internal static string ComputeHash(string transactionID)
		{
			return null;
		}
	}
}
