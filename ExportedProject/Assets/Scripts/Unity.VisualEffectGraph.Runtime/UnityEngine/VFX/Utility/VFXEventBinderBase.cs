namespace UnityEngine.VFX.Utility
{
	internal abstract class VFXEventBinderBase : MonoBehaviour
	{
		[SerializeField]
		protected VisualEffect target;

		public string EventName;

		[SerializeField]
		[HideInInspector]
		protected VFXEventAttribute eventAttribute;

		protected virtual void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private void UpdateCacheEventAttribute()
		{
		}

		protected abstract void SetEventAttribute(object[] parameters = null);

		protected void SendEventToVisualEffect(params object[] parameters)
		{
		}
	}
}
