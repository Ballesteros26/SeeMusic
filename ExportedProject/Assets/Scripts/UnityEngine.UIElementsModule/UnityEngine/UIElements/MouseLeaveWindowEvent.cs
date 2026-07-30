namespace UnityEngine.UIElements
{
	public class MouseLeaveWindowEvent : MouseEventBase<MouseLeaveWindowEvent>
	{
		protected override void Init()
		{
		}

		private void LocalInit()
		{
		}

		public new static MouseLeaveWindowEvent GetPooled(Event systemEvent)
		{
			return null;
		}

		protected internal override void PostDispatch(IPanel panel)
		{
		}
	}
}
