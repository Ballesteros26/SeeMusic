using System;
using System.Runtime.CompilerServices;
using ImaginationOverflow.UniversalFileAssociation.Data;

namespace ImaginationOverflow.UniversalFileAssociation.Providers
{
	public class WindowsFileProvider : IFileProvider
	{
		private readonly bool _steamBuild;

		private string[] _extensions;

		public event Action<FileInformation> _fileReceived
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

		public event Action<FileInformation> FileReceived
		{
			add
			{
			}
			remove
			{
			}
		}

		public WindowsFileProvider(bool steamBuild)
		{
		}

		public bool Initialize()
		{
			return false;
		}

		private string GetExe(bool fromSteam, string steamAppId, out string args)
		{
			args = null;
			return null;
		}

		private void CheckArguments()
		{
		}

		public void PollInfoAfterPause()
		{
		}

		protected virtual void OnLinkReceived(FileInformation obj)
		{
		}
	}
}
