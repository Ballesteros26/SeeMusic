using System;
using System.Runtime.CompilerServices;
using ImaginationOverflow.UniversalFileAssociation.Data;

namespace ImaginationOverflow.UniversalFileAssociation.Providers
{
	public class EditorFileProvider : IFileProvider
	{
		public event Action<FileInformation> FileReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public bool Initialize()
		{
			return false;
		}

		public void PollInfoAfterPause()
		{
		}
	}
}
