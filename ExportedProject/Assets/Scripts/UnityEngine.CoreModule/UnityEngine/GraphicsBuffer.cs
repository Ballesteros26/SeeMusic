using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
	[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
	public sealed class GraphicsBuffer : IDisposable
	{
		[Flags]
		public enum Target
		{
			Vertex = 1,
			Index = 2,
			CopySource = 4,
			CopyDestination = 8,
			Structured = 0x10,
			Raw = 0x20,
			Append = 0x40,
			Counter = 0x80,
			IndirectArguments = 0x100,
			Constant = 0x200
		}

		internal IntPtr m_Ptr;

		public int count => 0;

		public int stride => 0;

		~GraphicsBuffer()
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		private static bool RequiresCompute(Target target)
		{
			return false;
		}

		private static bool IsVertexIndexOrCopyOnly(Target target)
		{
			return false;
		}

		[FreeFunction("GraphicsBuffer_Bindings::InitBuffer")]
		private static IntPtr InitBuffer(Target target, int count, int stride)
		{
			return (IntPtr)0;
		}

		[FreeFunction("GraphicsBuffer_Bindings::DestroyBuffer")]
		private static void DestroyBuffer(GraphicsBuffer buf)
		{
		}

		public GraphicsBuffer(Target target, int count, int stride)
		{
		}

		public void Release()
		{
		}
	}
}
