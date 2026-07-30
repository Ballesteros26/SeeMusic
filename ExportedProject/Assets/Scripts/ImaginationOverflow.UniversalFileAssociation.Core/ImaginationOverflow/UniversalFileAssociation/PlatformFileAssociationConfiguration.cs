using System;
using System.Collections.Generic;
using ImaginationOverflow.UniversalFileAssociation.Data;
using UnityEngine;

namespace ImaginationOverflow.UniversalFileAssociation
{
	[Serializable]
	public class PlatformFileAssociationConfiguration
	{
		[SerializeField]
		private List<FileExtension> _fileAssociationExtension;

		[SerializeField]
		private bool _initialized;

		[SerializeField]
		private bool _disable;

		public bool IsInitialized => false;

		public List<FileExtension> FileAssociationExtension
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Disable => false;

		public PlatformFileAssociationConfiguration(bool init = false)
		{
		}
	}
}
