namespace UnityEngine.TextCore.Text
{
	internal static class TextGeneratorUtilities
	{
		public static readonly Vector2 largePositiveVector2;

		public static readonly Vector2 largeNegativeVector2;

		public static bool Approximately(float a, float b)
		{
			return false;
		}

		public static Color32 HexCharsToColor(char[] hexChars, int tagCount)
		{
			return default(Color32);
		}

		public static Color32 HexCharsToColor(char[] hexChars, int startIndex, int length)
		{
			return default(Color32);
		}

		public static int HexToInt(char hex)
		{
			return 0;
		}

		public static float ConvertToFloat(char[] chars, int startIndex, int length)
		{
			return 0f;
		}

		public static float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex)
		{
			lastIndex = default(int);
			return 0f;
		}

		public static Vector2 PackUV(float x, float y, float scale)
		{
			return default(Vector2);
		}

		public static void StringToCharArray(string sourceText, ref int[] charBuffer, ref TextProcessingStack<int> styleStack, TextGenerationSettings generationSettings)
		{
		}

		private static void ResizeInternalArray<T>(ref T[] array)
		{
		}

		private static bool IsTagName(ref string text, string tag, int index)
		{
			return false;
		}

		private static bool IsTagName(ref int[] text, string tag, int index)
		{
			return false;
		}

		private static bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref int[] charBuffer, ref int writeIndex, ref TextProcessingStack<int> styleStack, ref TextGenerationSettings generationSettings)
		{
			srcOffset = default(int);
			return false;
		}

		private static bool ReplaceOpeningStyleTag(ref string sourceText, int srcIndex, out int srcOffset, ref int[] charBuffer, ref int writeIndex, ref TextProcessingStack<int> styleStack, ref TextGenerationSettings generationSettings)
		{
			srcOffset = default(int);
			return false;
		}

		private static void ReplaceClosingStyleTag(ref int[] charBuffer, ref int writeIndex, ref TextProcessingStack<int> styleStack, ref TextGenerationSettings generationSettings)
		{
		}

		private static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode)
		{
			return null;
		}

		private static int GetUtf32(string text, int i)
		{
			return 0;
		}

		private static int GetUtf16(string text, int i)
		{
			return 0;
		}

		private static int GetTagHashCode(ref int[] text, int index, out int closeIndex)
		{
			closeIndex = default(int);
			return 0;
		}

		private static int GetTagHashCode(ref string text, int index, out int closeIndex)
		{
			closeIndex = default(int);
			return 0;
		}

		public static void FillCharacterVertexBuffers(int i, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		public static void FillSpriteVertexBuffers(int i, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		public static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo)
		{
		}

		public static void ResizeLineExtents(int size, TextInfo textInfo)
		{
		}

		public static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle)
		{
			return default(FontStyles);
		}

		public static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor)
		{
			return default(TextAlignment);
		}
	}
}
