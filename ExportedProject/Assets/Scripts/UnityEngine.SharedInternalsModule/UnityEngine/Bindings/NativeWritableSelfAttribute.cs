using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	[AttributeUsage(AttributeTargets.Method)]
	[VisibleToOtherModules]
	internal sealed class NativeWritableSelfAttribute : Attribute
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CWritableSelf_003Ek__BackingField;

		public bool WritableSelf
		{
			[CompilerGenerated]
			set
			{
				_003CWritableSelf_003Ek__BackingField = value;
			}
		}
	}
}
