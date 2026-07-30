using System.Runtime.CompilerServices;
using ImaginationOverflow.UniversalFileAssociation.Data;
using UnityEngine;

namespace ImaginationOverflow.UniversalFileAssociation
{
	public sealed class FileAssociationManager
	{
		private IFileProvider _currProvider;

		private GameObject _go;

		private FileInformation _storedActivation;

		public static FileAssociationManager Instance { get; private set; }

		public bool IsSteamBuild { get; }

		public event FileActivationHandler FileActivated
		{
			add
			{
			}
			remove
			{
			}
		}

		private event FileActivationHandler _activated
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

		static FileAssociationManager()
		{
		}

		private FileAssociationManager()
		{
		}

		private void RegisterIfNecessary()
		{
		}

		private void CreatePauseGameObject()
		{
		}

		private void CurrProviderFileReceived(FileInformation s)
		{
		}

		private void StoreActivation(FileInformation s)
		{
		}

		private bool OnActivated(FileInformation s)
		{
			return false;
		}

		internal void GameCameFromPause()
		{
		}
	}
}
