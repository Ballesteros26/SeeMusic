using System;

namespace UnityEngine.UIElements
{
	internal class EventCallbackFunctor<TEventType> : EventCallbackFunctorBase where TEventType : EventBase<TEventType>, new()
	{
		private readonly EventCallback<TEventType> m_Callback;

		private readonly long m_EventTypeId;

		public EventCallbackFunctor(EventCallback<TEventType> callback, CallbackPhase phase, InvokePolicy invokePolicy = InvokePolicy.Default)
			: base(default(CallbackPhase), default(InvokePolicy))
		{
		}

		public override void Invoke(EventBase evt, PropagationPhase propagationPhase)
		{
		}

		public override bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			return false;
		}
	}
}
