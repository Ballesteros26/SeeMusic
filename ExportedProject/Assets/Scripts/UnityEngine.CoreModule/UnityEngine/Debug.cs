using System;
using System.Diagnostics;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
	public class Debug
	{
		internal static readonly ILogger s_DefaultLogger;

		internal static ILogger s_Logger;

		public static ILogger unityLogger => null;

		[StaticAccessor("GetBuildSettings()", StaticAccessorType.Dot)]
		[NativeProperty(TargetType = TargetType.Field)]
		public static bool isDebugBuild => false;

		[ExcludeFromDocs]
		public static void DrawLine(Vector3 start, Vector3 end, Color color)
		{
		}

		[FreeFunction("DebugDrawLine", IsThreadSafe = true)]
		public static void DrawLine(Vector3 start, Vector3 end, [DefaultValue("Color.white")] Color color, [DefaultValue("0.0f")] float duration, [DefaultValue("true")] bool depthTest)
		{
		}

		[ThreadSafe]
		public unsafe static int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder)
		{
			return 0;
		}

		public static void Log(object message)
		{
		}

		public static void Log(object message, Object context)
		{
		}

		public static void LogFormat(string format, params object[] args)
		{
		}

		public static void LogError(object message)
		{
		}

		public static void LogError(object message, Object context)
		{
		}

		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		public static void LogErrorFormat(Object context, string format, params object[] args)
		{
		}

		public static void LogException(Exception exception)
		{
		}

		public static void LogException(Exception exception, Object context)
		{
		}

		public static void LogWarning(object message)
		{
		}

		public static void LogWarning(object message, Object context)
		{
		}

		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		public static void LogWarningFormat(Object context, string format, params object[] args)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, string message)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertion(object message)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertionFormat(string format, params object[] args)
		{
		}

		[RequiredByNativeCode]
		internal static bool CallOverridenDebugHandler(Exception exception, Object obj)
		{
			return false;
		}

		[RequiredByNativeCode]
		internal static bool IsLoggingEnabled()
		{
			return false;
		}

		private static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, [DefaultValue("Color.white")] ref Color color, [DefaultValue("0.0f")] float duration, [DefaultValue("true")] bool depthTest)
		{
		}
	}
}
