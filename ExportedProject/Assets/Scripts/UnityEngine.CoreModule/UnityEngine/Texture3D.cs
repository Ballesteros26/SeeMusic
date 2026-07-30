using System;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[ExcludeFromPreset]
	[NativeHeader("Runtime/Graphics/Texture3D.h")]
	public sealed class Texture3D : Texture
	{
		public override bool isReadable => false;

		[NativeName("SetPixel")]
		private void SetPixelImpl(int mip, int x, int y, int z, Color color)
		{
		}

		[FreeFunction("Texture3DScripting::Create")]
		private static bool Internal_CreateImpl([Writable] Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex)
		{
			return false;
		}

		private static void Internal_Create([Writable] Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex)
		{
		}

		[FreeFunction(Name = "Texture3DScripting::Apply", HasExplicitThis = true)]
		private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
		{
		}

		[FreeFunction(Name = "Texture3DScripting::SetPixels", HasExplicitThis = true, ThrowsException = true)]
		public void SetPixels([Unmarshalled] Color[] colors, int miplevel)
		{
		}

		public void SetPixels(Color[] colors)
		{
		}

		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags)
		{
		}

		[RequiredByNativeCode]
		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags)
		{
		}

		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, [DefaultValue("-1")] int mipCount)
		{
		}

		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount)
		{
		}

		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, [DefaultValue("IntPtr.Zero")] IntPtr nativeTex)
		{
		}

		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain)
		{
		}

		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, [DefaultValue("IntPtr.Zero")] IntPtr nativeTex)
		{
		}

		public void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable)
		{
		}

		[ExcludeFromDocs]
		public void Apply(bool updateMipmaps)
		{
		}

		[ExcludeFromDocs]
		public void Apply()
		{
		}

		public void SetPixel(int x, int y, int z, Color color, [DefaultValue("0")] int mipLevel)
		{
		}

		private static void ValidateIsNotCrunched(TextureCreationFlags flags)
		{
		}

		private void SetPixelImpl_Injected(int mip, int x, int y, int z, ref Color color)
		{
		}
	}
}
