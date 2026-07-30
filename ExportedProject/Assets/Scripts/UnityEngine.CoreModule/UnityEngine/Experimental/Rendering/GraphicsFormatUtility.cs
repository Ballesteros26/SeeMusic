using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
	[NativeHeader("Runtime/Graphics/TextureFormat.h")]
	[NativeHeader("Runtime/Graphics/Format.h")]
	[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
	public class GraphicsFormatUtility
	{
		private static readonly GraphicsFormat[] tableNoStencil;

		private static readonly GraphicsFormat[] tableStencil;

		[FreeFunction("GetTextureGraphicsFormat")]
		internal static GraphicsFormat GetFormat([NotNull("NullExceptionObject")] Texture texture)
		{
			return default(GraphicsFormat);
		}

		public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB)
		{
			return default(GraphicsFormat);
		}

		[FreeFunction(IsThreadSafe = true)]
		private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB)
		{
			return default(GraphicsFormat);
		}

		public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB)
		{
			return default(GraphicsFormat);
		}

		[FreeFunction]
		private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB)
		{
			return default(GraphicsFormat);
		}

		public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			return default(GraphicsFormat);
		}

		[FreeFunction(IsThreadSafe = true)]
		private static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits)
		{
			return default(GraphicsFormat);
		}

		internal static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits)
		{
			return default(GraphicsFormat);
		}

		[FreeFunction(IsThreadSafe = true)]
		public static int GetDepthBits(GraphicsFormat format)
		{
			return 0;
		}

		public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits)
		{
			return default(GraphicsFormat);
		}

		[FreeFunction(IsThreadSafe = true)]
		public static bool IsSRGBFormat(GraphicsFormat format)
		{
			return false;
		}

		[FreeFunction(IsThreadSafe = true)]
		public static GraphicsFormat GetSRGBFormat(GraphicsFormat format)
		{
			return default(GraphicsFormat);
		}

		[FreeFunction(IsThreadSafe = true)]
		public static GraphicsFormat GetLinearFormat(GraphicsFormat format)
		{
			return default(GraphicsFormat);
		}

		[FreeFunction(IsThreadSafe = true)]
		public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format)
		{
			return default(RenderTextureFormat);
		}

		[FreeFunction(IsThreadSafe = true)]
		public static uint GetComponentCount(GraphicsFormat format)
		{
			return 0u;
		}

		[FreeFunction(IsThreadSafe = true)]
		public static string GetFormatString(GraphicsFormat format)
		{
			return null;
		}

		[FreeFunction("IsAnyCompressedTextureFormat", true)]
		internal static bool IsCompressedTextureFormat(TextureFormat format)
		{
			return false;
		}

		[FreeFunction(IsThreadSafe = true)]
		private static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage)
		{
			return false;
		}

		internal static bool CanDecompressFormat(GraphicsFormat format)
		{
			return false;
		}

		[FreeFunction(IsThreadSafe = true)]
		public static bool IsAlphaOnlyFormat(GraphicsFormat format)
		{
			return false;
		}

		[FreeFunction(IsThreadSafe = true)]
		public static bool IsDepthFormat(GraphicsFormat format)
		{
			return false;
		}

		[FreeFunction(IsThreadSafe = true)]
		public static bool IsStencilFormat(GraphicsFormat format)
		{
			return false;
		}

		[FreeFunction(IsThreadSafe = true)]
		public static bool IsPVRTCFormat(GraphicsFormat format)
		{
			return false;
		}

		public static bool IsCrunchFormat(TextureFormat format)
		{
			return false;
		}

		[FreeFunction(IsThreadSafe = true)]
		public static FormatSwizzle GetSwizzleR(GraphicsFormat format)
		{
			return default(FormatSwizzle);
		}

		[FreeFunction(IsThreadSafe = true)]
		public static FormatSwizzle GetSwizzleG(GraphicsFormat format)
		{
			return default(FormatSwizzle);
		}

		[FreeFunction(IsThreadSafe = true)]
		public static FormatSwizzle GetSwizzleB(GraphicsFormat format)
		{
			return default(FormatSwizzle);
		}

		[FreeFunction(IsThreadSafe = true)]
		public static FormatSwizzle GetSwizzleA(GraphicsFormat format)
		{
			return default(FormatSwizzle);
		}

		[FreeFunction(IsThreadSafe = true)]
		public static uint GetBlockSize(GraphicsFormat format)
		{
			return 0u;
		}
	}
}
