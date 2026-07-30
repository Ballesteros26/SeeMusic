namespace UnityEngine.VFX.Utility
{
	[RequireComponent(typeof(VisualEffect))]
	[ExecuteAlways]
	public abstract class VFXOutputEventAbstractHandler : MonoBehaviour
	{
		public bool executeInEditor;

		public ExposedProperty outputEvent;

		public abstract bool canExecuteInEditor { get; }

		protected VisualEffect m_VisualEffect { get; private set; }

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void OnOutputEventRecieved(VFXOutputEventArgs args)
		{
		}

		public abstract void OnVFXOutputEvent(VFXEventAttribute eventAttribute);
	}
}
