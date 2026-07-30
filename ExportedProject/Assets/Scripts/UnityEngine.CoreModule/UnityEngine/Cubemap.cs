using System;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/CubemapTexture.h")]
	[ExcludeFromPreset]
	public sealed class Cubemap : Texture
	{
		public override bool isReadable => false;

		[FreeFunction("CubemapScripting::Create")]
		private static bool Internal_CreateImpl([Writable] Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex)
		{
			return false;
		}

		private static void Internal_Create([Writable] Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex)
		{
		}

		[FreeFunction(Name = "CubemapScripting::Apply", HasExplicitThis = true)]
		private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
		{
		}

		[NativeName("SetPixel")]
		private void SetPixelImpl(int image, int mip, int x, int y, Color color)
		{
		}

		internal bool ValidateFormat(TextureFormat format, int width)
		{
			return false;
		}

		internal bool ValidateFormat(GraphicsFormat format, int width)
		{
			return false;
		}

		[ExcludeFromDocs]
		public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags)
		{
		}

		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags)
		{
		}

		public Cubemap(int width, TextureFormat format, int mipCount)
		{
		}

		[ExcludeFromDocs]
		public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount)
		{
		}

		internal Cubemap(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex)
		{
		}

		internal Cubemap(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex)
		{
		}

		public Cubemap(int width, TextureFormat textureFormat, bool mipChain)
		{
		}

		[ExcludeFromDocs]
		public void SetPixel(CubemapFace face, int x, int y, Color color)
		{
		}

		public void SetPixel(CubemapFace face, int x, int y, Color color, [DefaultValue("0")] int mip)
		{
		}

		public void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable)
		{
		}

		[ExcludeFromDocs]
		public void Apply()
		{
		}

		private static void ValidateIsNotCrunched(TextureCreationFlags flags)
		{
		}

		private void SetPixelImpl_Injected(int image, int mip, int x, int y, ref Color color)
		{
		}
	}
}
