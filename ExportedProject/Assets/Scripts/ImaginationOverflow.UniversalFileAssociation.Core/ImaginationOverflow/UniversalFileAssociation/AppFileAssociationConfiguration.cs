using System;
using System.Collections.Generic;
using ImaginationOverflow.UniversalFileAssociation.Data;
using UnityEngine;
using UnityEngine.Serialization;

namespace ImaginationOverflow.UniversalFileAssociation
{
	[Serializable]
	public class AppFileAssociationConfiguration
	{
		[SerializeField]
		private string _steamId;

		[SerializeField]
		private PlatformFileAssociationConfiguration _globalConfiguration;

		[FormerlySerializedAs("_customFileAssociationExtensions")]
		[SerializeField]
		private PlatformFileAssociationConfiguration[] customFileAssociationExtensions;

		public string SteamId => null;

		public List<FileExtension> Extensions => null;

		public PlatformFileAssociationConfiguration[] CustomFileAssociationExtensions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal void EnsureAllPlats()
		{
		}

		public List<FileExtension> GetPlatformFileAssociation(SupportedPlatforms plat, bool includeDefault = false)
		{
			return null;
		}

		private List<FileExtension> GetCustomOrDefault(SupportedPlatforms plat, Func<PlatformFileAssociationConfiguration, List<FileExtension>> func, bool includeDefault, List<FileExtension> global)
		{
			return null;
		}

		public PlatformFileAssociationConfiguration GetPlatConfiguration(SupportedPlatforms value)
		{
			return null;
		}

		private PlatformFileAssociationConfiguration[] EnsureAllPlats(PlatformFileAssociationConfiguration[] value)
		{
			return null;
		}
	}
}
