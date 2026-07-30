using System.Collections.Generic;

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	public class BuildHashes
	{
		public string BuildPath { get; }

		public FileHash[] FileHashes { get; }

		public string SummaryHash { get; }

		internal BuildHashes(string buildPath, List<FileHash> fileHashes, SHA1Wrapper sha1)
		{
		}

		internal BuildHashes(string buildPath, FileHash[] fileHashes, string summaryHash)
		{
		}

		public bool HasFileHash(string hash)
		{
			return false;
		}

		public void PrintToConsole()
		{
		}

		private string CalculateSummaryCodeHash(List<FileHash> fileHashes, SHA1Wrapper sha1)
		{
			return null;
		}
	}
}
