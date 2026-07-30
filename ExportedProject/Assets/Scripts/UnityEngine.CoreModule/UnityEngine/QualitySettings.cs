using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[NativeHeader("Runtime/Misc/PlayerSettings.h")]
	[NativeHeader("Runtime/Graphics/QualitySettings.h")]
	[StaticAccessor("GetQualitySettings()", StaticAccessorType.Dot)]
	public sealed class QualitySettings : Object
	{
		[NativeProperty("ShadowQuality")]
		public static ShadowQuality shadows
		{
			set
			{
			}
		}

		[NativeProperty("ShadowmaskMode")]
		public static ShadowmaskMode shadowmaskMode => default(ShadowmaskMode);

		public static int vSyncCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int antiAliasing
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool billboardsFaceCameraPosition => false;

		[StaticAccessor("QualitySettingsScripting", StaticAccessorType.DoubleColon)]
		public static int maxQueuedFrames => 0;

		[NativeProperty("QualitySettingsNames")]
		public static string[] names => null;

		public static ColorSpace activeColorSpace
		{
			[NativeName("GetColorSpace")]
			[StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
			get
			{
				return default(ColorSpace);
			}
		}

		[NativeName("GetCurrentIndex")]
		public static int GetQualityLevel()
		{
			return 0;
		}

		[NativeName("SetCurrentIndex")]
		public static void SetQualityLevel(int index, [DefaultValue("true")] bool applyExpensiveChanges)
		{
		}
	}
}
