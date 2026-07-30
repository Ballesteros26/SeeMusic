namespace UnityEngine.UIElements
{
	public abstract class CallbackEventHandler : IEventHandler
	{
		private EventCallbackRegistry m_CallbackRegistry;

		public void RegisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
		}

		internal void RegisterCallback<TEventType>(EventCallback<TEventType> callback, InvokePolicy invokePolicy, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
		}

		public void UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
		}

		public abstract void SendEvent(EventBase e);

		internal abstract void SendEvent(EventBase e, DispatchMode dispatchMode);

		internal void HandleEventAtTargetPhase(EventBase evt)
		{
		}

		public virtual void HandleEvent(EventBase evt)
		{
		}

		public bool HasTrickleDownHandlers()
		{
			return false;
		}

		public bool HasBubbleUpHandlers()
		{
			return false;
		}

		protected virtual void ExecuteDefaultActionAtTarget(EventBase evt)
		{
		}

		protected virtual void ExecuteDefaultAction(EventBase evt)
		{
		}

		internal virtual void ExecuteDefaultActionDisabledAtTarget(EventBase evt)
		{
		}

		internal virtual void ExecuteDefaultActionDisabled(EventBase evt)
		{
		}
	}
}
