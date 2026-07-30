using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ImaginationOverflow.UniversalFileAssociation.Data;

namespace ImaginationOverflow.UniversalFileAssociation.Providers
{
	public class LinuxFileProvider : IFileProvider
	{
		private readonly bool _steamBuild;

		private List<FileExtension> _associations;

		private event Action<FileInformation> _fileReceived
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

		public LinuxFileProvider(bool steamBuild)
		{
		}

		public bool Initialize()
		{
			return false;
		}

		private static string GetPrevVersion(string saveFile)
		{
			return null;
		}

		private void RegisterAllNewMimetypes(List<FileExtension> fileAssociations)
		{
		}

		private void SetupMimeType(List<FileExtension> fileAssociation, string desktopFilename)
		{
		}

		private void StartProcessWithDebug(string filename, string args)
		{
		}

		private static void HandleDesktopFile(string desktopFile, string steamAppId)
		{
		}

		private void HandleMimefile(List<FileExtension> fileExtensions, string desktopFilename, string mimeapps)
		{
		}

		private string RemoveMimeFromContent(List<FileExtension> fileExtensions, string str)
		{
			return null;
		}

		private string GetMimeTypeFor(FileExtension fileExt)
		{
			return null;
		}

		private void CheckArguments()
		{
		}

		public void PollInfoAfterPause()
		{
		}

		protected virtual void OnFileReceived(FileInformation obj)
		{
		}
	}
}
