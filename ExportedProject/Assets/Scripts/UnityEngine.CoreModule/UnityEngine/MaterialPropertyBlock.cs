using System;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
	[NativeHeader("Runtime/Shaders/ShaderPropertySheet.h")]
	[NativeHeader("Runtime/Math/SphericalHarmonicsL2.h")]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	public sealed class MaterialPropertyBlock
	{
		internal IntPtr m_Ptr;

		[ThreadSafe]
		[NativeName("SetFloatFromScript")]
		private void SetFloatImpl(int name, float value)
		{
		}

		[ThreadSafe]
		[NativeName("SetVectorFromScript")]
		private void SetVectorImpl(int name, Vector4 value)
		{
		}

		[ThreadSafe]
		[NativeName("SetColorFromScript")]
		private void SetColorImpl(int name, Color value)
		{
		}

		[NativeName("SetMatrixFromScript")]
		[ThreadSafe]
		private void SetMatrixImpl(int name, Matrix4x4 value)
		{
		}

		[ThreadSafe]
		[NativeName("SetTextureFromScript")]
		private void SetTextureImpl(int name, [NotNull("ArgumentNullException")] Texture value)
		{
		}

		[ThreadSafe]
		[NativeName("SetRenderTextureFromScript")]
		private void SetRenderTextureImpl(int name, [NotNull("ArgumentNullException")] RenderTexture value, RenderTextureSubElement element)
		{
		}

		[NativeName("SetFloatArrayFromScript")]
		[ThreadSafe]
		private void SetFloatArrayImpl(int name, float[] values, int count)
		{
		}

		[ThreadSafe]
		[NativeName("SetVectorArrayFromScript")]
		private void SetVectorArrayImpl(int name, Vector4[] values, int count)
		{
		}

		[NativeName("SetMatrixArrayFromScript")]
		[ThreadSafe]
		private void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count)
		{
		}

		[NativeMethod(Name = "MaterialPropertyBlockScripting::Create", IsFreeFunction = true)]
		private static IntPtr CreateImpl()
		{
			return (IntPtr)0;
		}

		[NativeMethod(Name = "MaterialPropertyBlockScripting::Destroy", IsFreeFunction = true, IsThreadSafe = true)]
		private static void DestroyImpl(IntPtr mpb)
		{
		}

		[ThreadSafe]
		private void Clear(bool keepMemory)
		{
		}

		public void Clear()
		{
		}

		private void SetFloatArray(int name, float[] values, int count)
		{
		}

		private void SetVectorArray(int name, Vector4[] values, int count)
		{
		}

		private void SetMatrixArray(int name, Matrix4x4[] values, int count)
		{
		}

		~MaterialPropertyBlock()
		{
		}

		private void Dispose()
		{
		}

		public void SetInt(string name, int value)
		{
		}

		public void SetInt(int nameID, int value)
		{
		}

		public void SetFloat(string name, float value)
		{
		}

		public void SetFloat(int nameID, float value)
		{
		}

		public void SetVector(string name, Vector4 value)
		{
		}

		public void SetVector(int nameID, Vector4 value)
		{
		}

		public void SetColor(string name, Color value)
		{
		}

		public void SetColor(int nameID, Color value)
		{
		}

		public void SetMatrix(string name, Matrix4x4 value)
		{
		}

		public void SetMatrix(int nameID, Matrix4x4 value)
		{
		}

		public void SetTexture(string name, Texture value)
		{
		}

		public void SetTexture(int nameID, Texture value)
		{
		}

		public void SetTexture(int nameID, RenderTexture value, RenderTextureSubElement element)
		{
		}

		public void SetFloatArray(string name, float[] values)
		{
		}

		public void SetVectorArray(string name, Vector4[] values)
		{
		}

		public void SetVectorArray(int nameID, Vector4[] values)
		{
		}

		public void SetMatrixArray(string name, Matrix4x4[] values)
		{
		}

		private void SetVectorImpl_Injected(int name, ref Vector4 value)
		{
		}

		private void SetColorImpl_Injected(int name, ref Color value)
		{
		}

		private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value)
		{
		}
	}
}
