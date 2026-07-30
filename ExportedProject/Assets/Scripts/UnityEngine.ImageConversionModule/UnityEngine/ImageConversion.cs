using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	[NativeHeader("Modules/ImageConversion/ScriptBindings/ImageConversion.bindings.h")]
	public static class ImageConversion
	{
		[NativeMethod(Name = "ImageConversionBindings::EncodeToTGA", IsFreeFunction = true, ThrowsException = true)]
		public static byte[] EncodeToTGA(this Texture2D tex)
		{
			return null;
		}

		[NativeMethod(Name = "ImageConversionBindings::EncodeToPNG", IsFreeFunction = true, ThrowsException = true)]
		public static byte[] EncodeToPNG(this Texture2D tex)
		{
			return null;
		}

		[NativeMethod(Name = "ImageConversionBindings::EncodeToJPG", IsFreeFunction = true, ThrowsException = true)]
		public static byte[] EncodeToJPG(this Texture2D tex, int quality)
		{
			return null;
		}

		public static byte[] EncodeToJPG(this Texture2D tex)
		{
			return null;
		}

		[NativeMethod(Name = "ImageConversionBindings::EncodeToEXR", IsFreeFunction = true, ThrowsException = true)]
		public static byte[] EncodeToEXR(this Texture2D tex, Texture2D.EXRFlags flags)
		{
			return null;
		}

		public static byte[] EncodeToEXR(this Texture2D tex)
		{
			return null;
		}

		[NativeMethod(Name = "ImageConversionBindings::LoadImage", IsFreeFunction = true)]
		public static bool LoadImage([NotNull("ArgumentNullException")] this Texture2D tex, byte[] data, bool markNonReadable)
		{
			return false;
		}

		public static bool LoadImage(this Texture2D tex, byte[] data)
		{
			return false;
		}

		public static NativeArray<byte> EncodeNativeArrayToJPG<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, uint rowBytes = 0u, int quality = 75) where T : struct
		{
			return default(NativeArray<byte>);
		}

		[FreeFunction("ImageConversionBindings::UnsafeEncodeNativeArrayToJPG", true)]
		private unsafe static void* UnsafeEncodeNativeArrayToJPG(void* array, ref int sizeInBytes, GraphicsFormat format, uint width, uint height, uint rowBytes = 0u, int quality = 75)
		{
			return null;
		}
	}
}
