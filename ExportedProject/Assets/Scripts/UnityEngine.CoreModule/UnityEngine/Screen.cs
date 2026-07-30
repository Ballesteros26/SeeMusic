using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/WindowLayout.h")]
	[StaticAccessor("GetScreenManager()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/ScreenManager.h")]
	public sealed class Screen
	{
		public static int width
		{
			[NativeMethod(Name = "GetWidth", IsThreadSafe = true)]
			get
			{
				return 0;
			}
		}

		public static int height
		{
			[NativeMethod(Name = "GetHeight", IsThreadSafe = true)]
			get
			{
				return 0;
			}
		}

		public static float dpi
		{
			[NativeName("GetDPI")]
			get
			{
				return 0f;
			}
		}

		public static ScreenOrientation orientation => default(ScreenOrientation);

		[NativeProperty("ScreenTimeout")]
		public static int sleepTimeout
		{
			set
			{
			}
		}

		public static Resolution currentResolution => default(Resolution);

		public static bool fullScreen
		{
			[NativeName("IsFullscreen")]
			get
			{
				return false;
			}
			[NativeName("RequestSetFullscreenFromScript")]
			set
			{
			}
		}

		private static ScreenOrientation GetScreenOrientation()
		{
			return default(ScreenOrientation);
		}

		[NativeName("RequestResolution")]
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, [DefaultValue("0")] int preferredRefreshRate)
		{
		}

		public static void SetResolution(int width, int height, bool fullscreen, [DefaultValue("0")] int preferredRefreshRate)
		{
		}

		public static void SetResolution(int width, int height, bool fullscreen)
		{
		}

		[SpecialName]
		private static void get_currentResolution_Injected(out Resolution ret)
		{
			ret = default(Resolution);
		}
	}
}
