namespace UnityEngine.VFX.Utility
{
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Collider))]
	internal class VFXRigidBodyCollisionEventBinder : VFXEventBinderBase
	{
		private ExposedProperty positionParameter;

		private ExposedProperty directionParameter;

		protected override void SetEventAttribute(object[] parameters)
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}
