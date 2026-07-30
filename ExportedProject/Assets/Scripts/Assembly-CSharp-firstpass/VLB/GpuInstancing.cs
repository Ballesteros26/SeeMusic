using UnityEngine;

namespace VLB
{
	public static class GpuInstancing
	{
		public const bool isSupported = true;

		public static bool forceEnableDepthBlend => false;

		public static void SetMaterialProperties(Material material, bool enableInstancing)
		{
		}

		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return false;
		}

		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reason)
		{
			return false;
		}

		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
}
