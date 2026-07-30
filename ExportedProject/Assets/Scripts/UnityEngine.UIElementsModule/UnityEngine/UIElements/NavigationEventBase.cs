namespace UnityEngine.UIElements
{
	public abstract class NavigationEventBase<T> : EventBase<T>, INavigationEvent where T : NavigationEventBase<T>, new()
	{
		protected override void Init()
		{
		}

		private void LocalInit()
		{
		}
	}
}
