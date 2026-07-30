using System;
using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	public class VideoRender
	{
		[Flags]
		public enum ResolveFlags
		{
			Mipmaps = 1,
			PackedAlpha = 2,
			StereoLeft = 4,
			StereoRight = 8,
			ColorspaceSRGB = 0x10
		}

		public const string Shader_IMGUI = "AVProVideo/Internal/IMGUI/Texture Transparent";

		public const string Shader_Resolve = "AVProVideo/Internal/Resolve";

		public const string Shader_ResolveOES = "AVProVideo/Internal/ResolveOES";

		public const string Shader_Preview = "AVProVideo/Internal/Preview";

		public const string Keyword_AlphaPackTopBottom = "ALPHAPACK_TOP_BOTTOM";

		public const string Keyword_AlphaPackLeftRight = "ALPHAPACK_LEFT_RIGHT";

		public const string Keyword_AlphaPackNone = "ALPHAPACK_NONE";

		public const string Keyword_StereoTopBottom = "STEREO_TOP_BOTTOM";

		public const string Keyword_StereoLeftRight = "STEREO_LEFT_RIGHT";

		public const string Keyword_StereoCustomUV = "STEREO_CUSTOM_UV";

		public const string Keyword_StereoTwoTextures = "STEREO_TWOTEXTURES";

		public const string Keyword_StereoNone = "MONOSCOPIC";

		public const string Keyword_StereoDebug = "STEREO_DEBUG";

		public const string Keyword_LayoutEquirect180 = "LAYOUT_EQUIRECT180";

		public const string Keyword_LayoutNone = "LAYOUT_NONE";

		public const string Keyword_ForceEyeNone = "FORCEEYE_NONE";

		public const string Keyword_ForceEyeLeft = "FORCEEYE_LEFT";

		public const string Keyword_ForceEyeRight = "FORCEEYE_RIGHT";

		public const string Keyword_ApplyGamma = "APPLY_GAMMA";

		public static readonly LazyShaderProperty PropChromaTex;

		public static readonly LazyShaderProperty PropVertScale;

		public static readonly LazyShaderProperty PropApplyGamma;

		public static readonly LazyShaderProperty PropStereo;

		public static readonly LazyShaderProperty PropAlphaPack;

		public static readonly LazyShaderProperty PropLayout;

		public static readonly LazyShaderProperty PropViewMatrix;

		public static readonly LazyShaderProperty PropTextureMatrix;

		public static string Keyword_UseHSBC;

		public static readonly LazyShaderProperty PropHue;

		public static readonly LazyShaderProperty PropSaturation;

		public static readonly LazyShaderProperty PropContrast;

		public static readonly LazyShaderProperty PropBrightness;

		public static readonly LazyShaderProperty PropInvGamma;

		public static Material CreateResolveMaterial(bool usingAndroidOES)
		{
			return null;
		}

		public static Material CreateIMGUIMaterial()
		{
			return null;
		}

		public static void SetupLayoutMaterial(Material material, VideoMapping mapping)
		{
		}

		public static void SetupStereoEyeModeMaterial(Material material, StereoEye mode)
		{
		}

		public static void SetupStereoMaterial(Material material, StereoPacking packing)
		{
		}

		public static void SetupGlobalDebugStereoTinting(bool enabled)
		{
		}

		public static void SetupAlphaPackedMaterial(Material material, AlphaPacking packing)
		{
		}

		public static void SetupGammaMaterial(Material material, bool playerSupportsLinear)
		{
		}

		public static void SetupTextureMatrix(Material material, float[] transform)
		{
		}

		public static void SetupTextureMatrix(Material material, Matrix4x4 transform)
		{
		}

		public static void SetupVerticalFlipMaterial(Material material, bool flip)
		{
		}

		public static Texture GetTexture(MediaPlayer mediaPlayer, int textureIndex)
		{
			return null;
		}

		public static void SetupMaterialForMedia(Material material, MediaPlayer mediaPlayer, int texturePropId = -1, Texture fallbackTexture = null, bool forceFallbackTexture = false)
		{
		}

		internal static void SetupMaterial(Material material, bool flipVertically, bool playerSupportsLinear, Matrix4x4 ycbcrTransform, Texture ycbcrTexture, Matrix4x4 textureTransform, VideoMapping mapping = VideoMapping.Normal, StereoPacking stereoPacking = StereoPacking.None, AlphaPacking alphaPacking = AlphaPacking.None)
		{
		}

		public static void SetupResolveMaterial(Material material, VideoResolveOptions options)
		{
		}

		public static RenderTexture ResolveVideoToRenderTexture(Material resolveMaterial, RenderTexture targetTexture, ITextureProducer texture, ResolveFlags flags, ScaleMode scaleMode = ScaleMode.StretchToFill)
		{
			return null;
		}

		public static void GetResolveTextureSize(AlphaPacking alphaPacking, StereoPacking stereoPacking, StereoEye eyeMode, float pixelAspectRatio, Matrix4x4 textureXfrm, ref int width, ref int height)
		{
		}

		public static bool RequiresResolve(ITextureProducer texture)
		{
			return false;
		}

		public static void DrawTexture(Rect destRect, Texture texture, ScaleMode scaleMode, AlphaPacking alphaPacking, float pixelAspectRatio, Material material)
		{
		}
	}
}
