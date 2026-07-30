namespace UnityEngine.VFX.Utility
{
	[RequireComponent(typeof(Collider))]
	internal class VFXMouseEventBinder : VFXEventBinderBase
	{
		public enum Activation
		{
			OnMouseUp = 0,
			OnMouseDown = 1,
			OnMouseEnter = 2,
			OnMouseExit = 3,
			OnMouseOver = 4,
			OnMouseDrag = 5
		}

		public Activation activation;

		private ExposedProperty position;

		[Tooltip("Computes intersection in world space and sets it to the position EventAttribute")]
		public bool RaycastMousePosition;

		protected override void SetEventAttribute(object[] parameters)
		{
		}

		private static Vector2 GetMousePosition()
		{
			return default(Vector2);
		}

		private void DoOnMouseDown()
		{
		}

		private void DoOnMouseUp()
		{
		}

		private void DoOnMouseDrag()
		{
		}

		private void DoOnMouseOver()
		{
		}

		private void DoOnMouseEnter()
		{
		}

		private void DoOnMouseExit()
		{
		}

		private void OnMouseDown()
		{
		}

		private void OnMouseUp()
		{
		}

		private void OnMouseDrag()
		{
		}

		private void OnMouseOver()
		{
		}

		private void OnMouseEnter()
		{
		}

		private void OnMouseExit()
		{
		}
	}
}
