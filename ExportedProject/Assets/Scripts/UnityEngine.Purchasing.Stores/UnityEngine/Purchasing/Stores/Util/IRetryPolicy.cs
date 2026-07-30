using System;

namespace UnityEngine.Purchasing.Stores.Util
{
	internal interface IRetryPolicy
	{
		void Invoke(Action<Action> actionToTry, Action? onRetryAction = null);
	}
}
