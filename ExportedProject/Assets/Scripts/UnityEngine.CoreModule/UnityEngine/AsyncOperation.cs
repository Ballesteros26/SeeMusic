using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Misc/AsyncOperation.h")]
	[NativeHeader("Runtime/Export/Scripting/AsyncOperation.bindings.h")]
	public class AsyncOperation : YieldInstruction
	{
		internal IntPtr m_Ptr;

		private Action<AsyncOperation> m_completeCallback;

		public bool isDone
		{
			[NativeMethod("IsDone")]
			get
			{
				return false;
			}
		}

		public event Action<AsyncOperation> completed
		{
			add
			{
			}
			remove
			{
			}
		}

		[StaticAccessor("AsyncOperationBindings", StaticAccessorType.DoubleColon)]
		[NativeMethod(IsThreadSafe = true)]
		private static void InternalDestroy(IntPtr ptr)
		{
		}

		~AsyncOperation()
		{
		}

		[RequiredByNativeCode]
		internal void InvokeCompletionEvent()
		{
		}
	}
}
