using UnityEngine;

namespace Unity.Services.Core.Internal
{
	internal abstract class AsyncOperationBase : CustomYieldInstruction
	{
		public override bool keepWaiting => false;

		public abstract bool IsCompleted { get; }
	}
}
