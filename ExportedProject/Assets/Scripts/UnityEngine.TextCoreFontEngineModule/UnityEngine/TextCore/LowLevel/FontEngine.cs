using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.LowLevel
{
	[NativeHeader("Modules/TextCoreFontEngine/Native/FontEngine.h")]
	public sealed class FontEngine
	{
		private static Glyph[] s_Glyphs;

		private static uint[] s_GlyphIndexes_MarshallingArray_A;

		private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN;

		private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT;

		private static GlyphRect[] s_FreeGlyphRects;

		private static GlyphRect[] s_UsedGlyphRects;

		private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray;

		private static Dictionary<uint, Glyph> s_GlyphLookupDictionary;

		public static FontEngineError InitializeFontEngine()
		{
			return default(FontEngineError);
		}

		[NativeMethod(Name = "TextCore::FontEngine::InitFontEngine", IsFreeFunction = true)]
		private static int InitializeFontEngine_Internal()
		{
			return 0;
		}

		public static FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex)
		{
			return default(FontEngineError);
		}

		[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		private static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex)
		{
			return 0;
		}

		public static FontEngineError LoadFontFace(Font font, int pointSize)
		{
			return default(FontEngineError);
		}

		[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		private static int LoadFontFace_With_Size_FromFont_Internal(Font font, int pointSize)
		{
			return 0;
		}

		public static FontEngineError LoadFontFace(Font font, int pointSize, int faceIndex)
		{
			return default(FontEngineError);
		}

		[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex)
		{
			return 0;
		}

		public static FontEngineError LoadFontFace(string familyName, string styleName, int pointSize)
		{
			return default(FontEngineError);
		}

		[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize)
		{
			return 0;
		}

		internal static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef)
		{
			fontRef = default(FontReference);
			return false;
		}

		[NativeMethod(Name = "TextCore::FontEngine::TryGetSystemFontReference", IsThreadSafe = true, IsFreeFunction = true)]
		private static bool TryGetSystemFontReference_Internal(string familyName, string styleName, out FontReference fontRef)
		{
			fontRef = default(FontReference);
			return false;
		}

		public static FaceInfo GetFaceInfo()
		{
			return default(FaceInfo);
		}

		[NativeMethod(Name = "TextCore::FontEngine::GetFaceInfo", IsThreadSafe = true, IsFreeFunction = true)]
		private static int GetFaceInfo_Internal(ref FaceInfo faceInfo)
		{
			return 0;
		}

		[NativeMethod(Name = "TextCore::FontEngine::GetGlyphIndex", IsThreadSafe = true, IsFreeFunction = true)]
		internal static uint GetGlyphIndex(uint unicode)
		{
			return 0u;
		}

		public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph)
		{
			glyph = null;
			return false;
		}

		[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithUnicodeValue", IsThreadSafe = true, IsFreeFunction = true)]
		private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct)
		{
			return false;
		}

		public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph)
		{
			glyph = null;
			return false;
		}

		[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithIndexValue", IsThreadSafe = true, IsFreeFunction = true)]
		private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct)
		{
			return false;
		}

		[NativeMethod(Name = "TextCore::FontEngine::SetTextureUploadMode", IsThreadSafe = true, IsFreeFunction = true)]
		internal static void SetTextureUploadMode(bool shouldUploadImmediately)
		{
		}

		internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph)
		{
			glyph = null;
			return false;
		}

		[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphToTexture", IsThreadSafe = true, IsFreeFunction = true)]
		private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph)
		{
			glyph = default(GlyphMarshallingStruct);
			return false;
		}

		internal static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs)
		{
			glyphs = null;
			return false;
		}

		[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphsToTexture", IsThreadSafe = true, IsFreeFunction = true)]
		private static bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] GlyphMarshallingStruct[] glyphs, ref int glyphCount)
		{
			return false;
		}

		internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes)
		{
			return null;
		}

		internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(List<uint> glyphIndexes, out int recordCount)
		{
			recordCount = default(int);
			return null;
		}

		[NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArrayFromKernTable", IsFreeFunction = true)]
		private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(uint[] glyphIndexes, out int recordCount)
		{
			recordCount = default(int);
			return 0;
		}

		[NativeMethod(Name = "TextCore::FontEngine::GetGlyphPairAdjustmentRecordsFromMarshallingArray", IsFreeFunction = true)]
		private static int GetPairAdjustmentRecordsFromMarshallingArray([Out] GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords)
		{
			return 0;
		}

		private static void GenericListToMarshallingArray<T>(ref List<T> srcList, ref T[] dstArray)
		{
		}

		private static void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount)
		{
		}

		[NativeMethod(Name = "TextCore::FontEngine::ResetAtlasTexture", IsFreeFunction = true)]
		internal static void ResetAtlasTexture(Texture2D texture)
		{
		}
	}
}
