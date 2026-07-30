using System;
using System.Runtime.InteropServices;
using Unity.Jobs;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Math/Matrix4x4.h")]
	[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
	public class BatchRendererGroup
	{
		public delegate JobHandle OnPerformCulling(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext);

		private IntPtr m_GroupHandle;

		private OnPerformCulling m_PerformCulling;

		[RequiredByNativeCode]
		private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters)
		{
		}
	}
}
