using System.IO;

namespace ImaginationOverflow.UniversalFileAssociation.Data
{
	public class FileInformation
	{
		private string _name;

		public Stream Stream { get; set; }

		public string Path { get; set; }

		public string Name => null;

		public ulong Size { get; set; }

		public void CopyActivatedFileToStream(Stream destination)
		{
		}
	}
}
