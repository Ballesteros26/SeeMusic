using System;

namespace Unity.Burst
{
	public static class BurstRuntime
	{
		internal class PreserveAttribute : Attribute
		{
		}

		[Preserve]
		internal static void PreventRequiredAttributeStrip()
		{
		}

		[Preserve]
		internal unsafe static void Log(byte* message, int logType, byte* fileName, int lineNumber)
		{
		}
	}
}
