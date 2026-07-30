using System;

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	public class HashGeneratorResult
	{
		private string summaryCodeHash;

		private BuildHashes buildHashes;

		[Obsolete("Please use SummaryHash property instead.")]
		public string CodeHash => null;

		public string SummaryHash => null;

		public FileHash[] FileHashes => null;

		public string ErrorMessage { get; private set; }

		public bool Success => false;

		internal static HashGeneratorResult FromError(string errorMessage)
		{
			return null;
		}

		internal static HashGeneratorResult FromBuildHashes(BuildHashes buildHashes)
		{
			return null;
		}

		public bool HasFileHash(string hash)
		{
			return false;
		}
	}
}
