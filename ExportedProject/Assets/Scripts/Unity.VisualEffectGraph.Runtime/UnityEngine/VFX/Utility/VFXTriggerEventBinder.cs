using System.Collections.Generic;

namespace UnityEngine.VFX.Utility
{
	[RequireComponent(typeof(Collider))]
	internal class VFXTriggerEventBinder : VFXEventBinderBase
	{
		public enum Activation
		{
			OnEnter = 0,
			OnExit = 1,
			OnStay = 2
		}

		public List<Collider> colliders;

		public Activation activation;

		private ExposedProperty positionParameter;

		protected override void SetEventAttribute(object[] parameters)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}
	}
}
