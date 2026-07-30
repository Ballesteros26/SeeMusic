using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/ScreenCapture/Public/CaptureScreenshot.h")]
	public static class ScreenCapture
	{
		public enum StereoScreenCaptureMode
		{
			LeftEye = 1,
			RightEye = 2,
			BothEyes = 3
		}

		public static Texture2D CaptureScreenshotAsTexture()
		{
			return null;
		}

		public static void CaptureScreenshotIntoRenderTexture(RenderTexture renderTexture)
		{
		}

		private static Texture2D CaptureScreenshotAsTexture(int superSize, StereoScreenCaptureMode stereoScreenCaptureMode)
		{
			return null;
		}
	}
}
