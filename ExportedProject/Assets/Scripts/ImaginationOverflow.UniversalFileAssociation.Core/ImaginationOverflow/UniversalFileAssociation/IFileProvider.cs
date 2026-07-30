using System;
using ImaginationOverflow.UniversalFileAssociation.Data;

namespace ImaginationOverflow.UniversalFileAssociation
{
	public interface IFileProvider
	{
		event Action<FileInformation> FileReceived;

		bool Initialize();

		void PollInfoAfterPause();
	}
}
