namespace UnityEngine.UIElements
{
	public class ContextualMenuPopulateEvent : MouseEventBase<ContextualMenuPopulateEvent>
	{
		private ContextualMenuManager m_ContextualMenuManager;

		public DropdownMenu menu { get; private set; }

		public EventBase triggerEvent { get; private set; }

		protected override void Init()
		{
		}

		private void LocalInit()
		{
		}

		protected internal override void PostDispatch(IPanel panel)
		{
		}
	}
}
