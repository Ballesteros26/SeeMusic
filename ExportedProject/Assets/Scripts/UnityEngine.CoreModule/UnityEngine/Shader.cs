using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	[NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
	[NativeHeader("Runtime/Misc/ResourceManager.h")]
	[NativeHeader("Runtime/Shaders/Shader.h")]
	[NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	public sealed class Shader : Object
	{
		public bool isSupported
		{
			[NativeMethod("IsSupported")]
			get
			{
				return false;
			}
		}

		public static string globalRenderPipeline
		{
			set
			{
			}
		}

		public static Shader Find(string name)
		{
			return null;
		}

		[FreeFunction("ShaderScripting::EnableKeyword")]
		public static void EnableKeyword(string keyword)
		{
		}

		[FreeFunction("ShaderScripting::DisableKeyword")]
		public static void DisableKeyword(string keyword)
		{
		}

		[FreeFunction("ShaderScripting::TagToID")]
		internal static int TagToID(string name)
		{
			return 0;
		}

		[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = true)]
		public static int PropertyToID(string name)
		{
			return 0;
		}

		[FreeFunction("ShaderScripting::SetGlobalFloat")]
		private static void SetGlobalFloatImpl(int name, float value)
		{
		}

		[FreeFunction("ShaderScripting::SetGlobalVector")]
		private static void SetGlobalVectorImpl(int name, Vector4 value)
		{
		}

		[FreeFunction("ShaderScripting::SetGlobalMatrix")]
		private static void SetGlobalMatrixImpl(int name, Matrix4x4 value)
		{
		}

		[FreeFunction("ShaderScripting::SetGlobalTexture")]
		private static void SetGlobalTextureImpl(int name, Texture value)
		{
		}

		[FreeFunction("ShaderScripting::SetGlobalConstantBuffer")]
		private static void SetGlobalConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
		{
		}

		[FreeFunction("ShaderScripting::GetGlobalFloat")]
		private static float GetGlobalFloatImpl(int name)
		{
			return 0f;
		}

		[FreeFunction("ShaderScripting::GetGlobalVector")]
		private static Vector4 GetGlobalVectorImpl(int name)
		{
			return default(Vector4);
		}

		[FreeFunction("ShaderScripting::GetGlobalTexture")]
		private static Texture GetGlobalTextureImpl(int name)
		{
			return null;
		}

		public static void SetGlobalInt(string name, int value)
		{
		}

		public static void SetGlobalInt(int nameID, int value)
		{
		}

		public static void SetGlobalFloat(string name, float value)
		{
		}

		public static void SetGlobalFloat(int nameID, float value)
		{
		}

		public static void SetGlobalVector(string name, Vector4 value)
		{
		}

		public static void SetGlobalVector(int nameID, Vector4 value)
		{
		}

		public static void SetGlobalColor(string name, Color value)
		{
		}

		public static void SetGlobalColor(int nameID, Color value)
		{
		}

		public static void SetGlobalMatrix(string name, Matrix4x4 value)
		{
		}

		public static void SetGlobalMatrix(int nameID, Matrix4x4 value)
		{
		}

		public static void SetGlobalTexture(string name, Texture value)
		{
		}

		public static void SetGlobalTexture(int nameID, Texture value)
		{
		}

		public static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
		{
		}

		public static float GetGlobalFloat(string name)
		{
			return 0f;
		}

		public static Vector4 GetGlobalVector(int nameID)
		{
			return default(Vector4);
		}

		public static Texture GetGlobalTexture(string name)
		{
			return null;
		}

		private Shader()
		{
		}

		private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value)
		{
		}

		private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value)
		{
		}

		private static void GetGlobalVectorImpl_Injected(int name, out Vector4 ret)
		{
			ret = default(Vector4);
		}
	}
}
