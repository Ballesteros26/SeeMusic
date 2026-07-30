using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
	[NativeHeader("Runtime/Camera/RenderSettings.h")]
	[StaticAccessor("GetRenderSettings()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
	public sealed class RenderSettings : Object
	{
		[NativeProperty("UseFog")]
		public static bool fog
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static Color ambientSkyColor => default(Color);

		public static Color ambientEquatorColor => default(Color);

		public static Color ambientGroundColor => default(Color);

		public static Color subtractiveShadowColor => default(Color);

		[NativeProperty("SkyboxMaterial")]
		public static Material skybox => null;

		public static Light sun => null;

		public static SphericalHarmonicsL2 ambientProbe
		{
			[NativeMethod("GetFinalAmbientProbe")]
			get
			{
				return default(SphericalHarmonicsL2);
			}
		}

		public static float reflectionIntensity => 0f;

		[SpecialName]
		private static void get_ambientSkyColor_Injected(out Color ret)
		{
			ret = default(Color);
		}

		[SpecialName]
		private static void get_ambientEquatorColor_Injected(out Color ret)
		{
			ret = default(Color);
		}

		[SpecialName]
		private static void get_ambientGroundColor_Injected(out Color ret)
		{
			ret = default(Color);
		}

		[SpecialName]
		private static void get_subtractiveShadowColor_Injected(out Color ret)
		{
			ret = default(Color);
		}

		[SpecialName]
		private static void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret)
		{
			ret = default(SphericalHarmonicsL2);
		}
	}
}
