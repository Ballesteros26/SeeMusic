using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace VideoKit.Utilities
{
	internal sealed class SharedSignal
	{
		private readonly int count;

		private readonly HashSet<object> record;

		public bool signaled
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			get;
			private set; }

		public event Action OnSignal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public SharedSignal(int count)
		{
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void Signal(object key)
		{
		}
	}
}
