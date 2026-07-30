using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	public sealed class ComputeShader : Object
	{
		[NativeMethod(Name = "ComputeShaderScripting::FindKernel", HasExplicitThis = true, IsFreeFunction = true, ThrowsException = true)]
		[RequiredByNativeCode]
		public int FindKernel(string name)
		{
			return 0;
		}

		[FreeFunction(Name = "ComputeShaderScripting::SetValue<float>", HasExplicitThis = true)]
		public void SetFloat(int nameID, float val)
		{
		}

		[FreeFunction(Name = "ComputeShaderScripting::SetValue<int>", HasExplicitThis = true)]
		public void SetInt(int nameID, int val)
		{
		}

		[FreeFunction(Name = "ComputeShaderScripting::SetValue<Vector4f>", HasExplicitThis = true)]
		public void SetVector(int nameID, Vector4 val)
		{
		}

		[FreeFunction(Name = "ComputeShaderScripting::SetArray<float>", HasExplicitThis = true)]
		private void SetFloatArray(int nameID, float[] values)
		{
		}

		[FreeFunction(Name = "ComputeShaderScripting::SetArray<int>", HasExplicitThis = true)]
		private void SetIntArray(int nameID, int[] values)
		{
		}

		[FreeFunction(Name = "ComputeShaderScripting::SetArray<Vector4f>", HasExplicitThis = true)]
		public void SetVectorArray(int nameID, Vector4[] values)
		{
		}

		[NativeMethod(Name = "ComputeShaderScripting::SetTexture", HasExplicitThis = true, IsFreeFunction = true, ThrowsException = true)]
		public void SetTexture(int kernelIndex, int nameID, [NotNull("ArgumentNullException")] Texture texture, int mipLevel)
		{
		}

		[FreeFunction(Name = "ComputeShaderScripting::SetBuffer", HasExplicitThis = true)]
		private void Internal_SetBuffer(int kernelIndex, int nameID, [NotNull("ArgumentNullException")] ComputeBuffer buffer)
		{
		}

		[FreeFunction(Name = "ComputeShaderScripting::SetBuffer", HasExplicitThis = true)]
		private void Internal_SetGraphicsBuffer(int kernelIndex, int nameID, [NotNull("ArgumentNullException")] GraphicsBuffer buffer)
		{
		}

		public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer)
		{
		}

		public void SetBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer)
		{
		}

		[FreeFunction(Name = "ComputeShaderScripting::SetConstantBuffer", HasExplicitThis = true)]
		private void SetConstantComputeBuffer(int nameID, [NotNull("ArgumentNullException")] ComputeBuffer buffer, int offset, int size)
		{
		}

		[NativeMethod(Name = "ComputeShaderScripting::GetKernelThreadGroupSizes", HasExplicitThis = true, IsFreeFunction = true, ThrowsException = true)]
		public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z)
		{
			x = default(uint);
			y = default(uint);
			z = default(uint);
		}

		[NativeName("DispatchComputeShader")]
		public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
		{
		}

		[FreeFunction("ComputeShaderScripting::EnableKeyword", HasExplicitThis = true)]
		public void EnableKeyword(string keyword)
		{
		}

		[FreeFunction("ComputeShaderScripting::DisableKeyword", HasExplicitThis = true)]
		public void DisableKeyword(string keyword)
		{
		}

		public void SetFloat(string name, float val)
		{
		}

		public void SetFloats(int nameID, params float[] values)
		{
		}

		public void SetInts(string name, params int[] values)
		{
		}

		public void SetInts(int nameID, params int[] values)
		{
		}

		public void SetBool(string name, bool val)
		{
		}

		public void SetTexture(int kernelIndex, string name, Texture texture)
		{
		}

		public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer)
		{
		}

		public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
		{
		}

		private void SetVector_Injected(int nameID, ref Vector4 val)
		{
		}
	}
}
