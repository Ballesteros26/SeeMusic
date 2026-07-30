using System;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	public static class Helper
	{
		public sealed class ExpectedPluginVersion
		{
			public const string Windows = "2.8.5";

			public const string WinRT = "2.8.5";

			public const string Android = "2.9.1";

			public const string Apple = "2.9.1";
		}

		public const string AVProVideoVersion = "2.9.1";

		public const string UnityBaseTextureName = "_MainTex";

		public const string UnityBaseTextureName_URP = "_BaseMap";

		public const string UnityBaseTextureName_HDRP = "_BaseColorMap";

		public const double SecondsToHNS = 10000000.0;

		public const double MilliSecondsToHNS = 10000.0;

		private static Matrix4x4 PortraitMatrix;

		private static Matrix4x4 PortraitFlippedMatrix;

		private static Matrix4x4 LandscapeFlippedMatrix;

		public static string GetPath(MediaPathType location)
		{
			return null;
		}

		public static string GetFilePath(string path, MediaPathType location)
		{
			return null;
		}

		public static string GetFriendlyResolutionName(int width, int height, float fps)
		{
			return null;
		}

		public static string GetErrorMessage(ErrorCode code)
		{
			return null;
		}

		public static string GetPlatformName(Platform platform)
		{
			return null;
		}

		public static string[] GetPlatformNames()
		{
			return null;
		}

		public static void LogInfo(string message, UnityEngine.Object context = null)
		{
		}

		public static int GetUnityAudioSampleRate()
		{
			return 0;
		}

		public static int GetUnityAudioSpeakerCount()
		{
			return 0;
		}

		public static TimeRange GetTimelineRange(double duration, TimeRanges seekable)
		{
			return default(TimeRange);
		}

		public static string GetTimeString(double timeSeconds, bool showMilliseconds = false)
		{
			return null;
		}

		public static Orientation GetOrientation(float[] t)
		{
			return default(Orientation);
		}

		public static Matrix4x4 GetMatrixForOrientation(Orientation ori)
		{
			return default(Matrix4x4);
		}

		public static Matrix4x4 Matrix4x4FromAffineTransform(float[] affineXfrm)
		{
			return default(Matrix4x4);
		}

		public static int ConvertTimeSecondsToFrame(double seconds, float frameRate)
		{
			return 0;
		}

		public static double ConvertFrameToTimeSeconds(int frame, float frameRate)
		{
			return 0.0;
		}

		public static double FindNextKeyFrameTimeSeconds(double seconds, float frameRate, int keyFrameInterval)
		{
			return 0.0;
		}

		public static DateTime ConvertSecondsSince1970ToDateTime(double secondsSince1970)
		{
			return default(DateTime);
		}

		[PreserveSig]
		private static extern int GetShortPathName(string pathName, StringBuilder shortName, int cbShortName);

		internal static string ConvertLongPathToShortDOS83Path(string path)
		{
			return null;
		}

		public static Texture2D GetReadableTexture(Texture inputTexture, bool requiresVerticalFlip, Orientation ori, Texture2D targetTexture = null)
		{
			return null;
		}

		public static Texture2D GetReadableTexture(RenderTexture inputTexture, Texture2D targetTexture = null)
		{
			return null;
		}
	}
}
