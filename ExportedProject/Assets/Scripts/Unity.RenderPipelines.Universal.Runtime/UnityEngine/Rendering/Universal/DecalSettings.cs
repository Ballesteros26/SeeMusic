using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	internal class DecalSettings
	{
		public DecalTechniqueOption technique;

		public float maxDrawDistance;

		public DBufferSettings dBufferSettings;

		public DecalScreenSpaceSettings screenSpaceSettings;
	}
}
