namespace UnityEngine.UIElements
{
	internal class VisualElementPanelActivator
	{
		private IVisualElementPanelActivatable m_Activatable;

		public bool isActive { get; private set; }

		public bool isDetaching { get; private set; }

		public VisualElementPanelActivator(IVisualElementPanelActivatable activatable)
		{
		}

		public void SetActive(bool action)
		{
		}

		public void SendActivation()
		{
		}

		public void SendDeactivation()
		{
		}

		private void OnEnter(AttachToPanelEvent evt)
		{
		}

		private void OnLeave(DetachFromPanelEvent evt)
		{
		}
	}
}
