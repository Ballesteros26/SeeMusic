namespace UnityEngine.VFX.Utility
{
	[RequireComponent(typeof(VFXPropertyBinder))]
	[ExecuteInEditMode]
	public abstract class VFXBinderBase : MonoBehaviour
	{
		protected VFXPropertyBinder binder;

		public abstract bool IsValid(VisualEffect component);

		public virtual void Reset()
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public abstract void UpdateBinding(VisualEffect component);

		public override string ToString()
		{
			return null;
		}
	}
}
