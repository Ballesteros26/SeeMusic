using System;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[NativeHeader("Modules/UIElementsNative/TextNative.bindings.h")]
	internal static class TextNative
	{
		public static Vector2 GetCursorPosition(TextNativeSettings settings, Rect rect, int cursorIndex)
		{
			return default(Vector2);
		}

		public static float ComputeTextWidth(TextNativeSettings settings)
		{
			return 0f;
		}

		public static float ComputeTextHeight(TextNativeSettings settings)
		{
			return 0f;
		}

		public static NativeArray<TextVertex> GetVertices(TextNativeSettings settings)
		{
			return default(NativeArray<TextVertex>);
		}

		public static Vector2 GetOffset(TextNativeSettings settings, Rect screenRect)
		{
			return default(Vector2);
		}

		public static float ComputeTextScaling(Matrix4x4 worldMatrix, float pixelsPerPoint)
		{
			return 0f;
		}

		[FreeFunction(Name = "TextNative::ComputeTextWidth")]
		private static float DoComputeTextWidth(TextNativeSettings settings)
		{
			return 0f;
		}

		[FreeFunction(Name = "TextNative::ComputeTextHeight")]
		private static float DoComputeTextHeight(TextNativeSettings settings)
		{
			return 0f;
		}

		[FreeFunction(Name = "TextNative::GetCursorPosition")]
		private static Vector2 DoGetCursorPosition(TextNativeSettings settings, Rect rect, int cursorPosition)
		{
			return default(Vector2);
		}

		[FreeFunction(Name = "TextNative::GetVertices")]
		private static void GetVertices(TextNativeSettings settings, IntPtr buffer, int vertexSize, ref int vertexCount)
		{
		}

		[FreeFunction(Name = "TextNative::GetOffset")]
		private static Vector2 DoGetOffset(TextNativeSettings settings, Rect rect)
		{
			return default(Vector2);
		}

		private static float DoComputeTextWidth_Injected(ref TextNativeSettings settings)
		{
			return 0f;
		}

		private static float DoComputeTextHeight_Injected(ref TextNativeSettings settings)
		{
			return 0f;
		}

		private static void DoGetCursorPosition_Injected(ref TextNativeSettings settings, ref Rect rect, int cursorPosition, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void GetVertices_Injected(ref TextNativeSettings settings, IntPtr buffer, int vertexSize, ref int vertexCount)
		{
		}

		private static void DoGetOffset_Injected(ref TextNativeSettings settings, ref Rect rect, out Vector2 ret)
		{
			ret = default(Vector2);
		}
	}
}
