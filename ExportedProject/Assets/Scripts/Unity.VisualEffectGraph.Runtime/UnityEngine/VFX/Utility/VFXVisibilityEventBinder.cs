namespace UnityEngine.VFX.Utility
{
	[RequireComponent(typeof(Renderer))]
	internal class VFXVisibilityEventBinder : VFXEventBinderBase
	{
		public enum Activation
		{
			OnBecameVisible = 0,
			OnBecameInvisible = 1
		}

		public Activation activation;

		protected override void SetEventAttribute(object[] parameters)
		{
		}

		private void OnBecameVisible()
		{
		}

		private void OnBecameInvisible()
		{
		}
	}
}
