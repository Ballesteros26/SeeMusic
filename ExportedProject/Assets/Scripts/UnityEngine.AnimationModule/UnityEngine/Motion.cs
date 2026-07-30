using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/Motion.h")]
	public class Motion : Object
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly bool _003CisAnimatorMotion_003Ek__BackingField;

		public bool isLooping
		{
			[NativeMethod("IsLooping")]
			get
			{
				return false;
			}
		}

		protected Motion()
		{
		}
	}
}
