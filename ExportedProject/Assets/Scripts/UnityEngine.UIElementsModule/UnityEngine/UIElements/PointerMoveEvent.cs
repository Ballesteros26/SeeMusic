namespace UnityEngine.UIElements
{
	public sealed class PointerMoveEvent : PointerEventBase<PointerMoveEvent>
	{
		internal bool isHandledByDraggable { get; set; }

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
