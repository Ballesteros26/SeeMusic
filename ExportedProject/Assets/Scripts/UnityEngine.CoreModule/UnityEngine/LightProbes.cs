using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Runtime/Export/Graphics/Graphics.bindings.h")]
	public sealed class LightProbes : Object
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action tetrahedralizationCompleted;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action needsRetetrahedralization;

		[RequiredByNativeCode]
		private static void Internal_CallTetrahedralizationCompletedFunction()
		{
		}

		[RequiredByNativeCode]
		private static void Internal_CallNeedsRetetrahedralizationFunction()
		{
		}
	}
}
