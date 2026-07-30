namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	internal class FileFilter
	{
		public bool caseSensitive;

		public bool folderRecursive;

		public bool exactFileNameMatch;

		public bool exactFolderMatch;

		public string filterPath;

		public string filterExtension;

		public string filterFileName;

		public bool MatchesPath(string filePath, string root = null)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
