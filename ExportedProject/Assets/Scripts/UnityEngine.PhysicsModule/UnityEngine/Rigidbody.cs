using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/Physics/Rigidbody.h")]
	public class Rigidbody : Component
	{
		public Vector3 velocity
		{
			set
			{
			}
		}

		public Vector3 angularVelocity
		{
			set
			{
			}
		}

		public bool useGravity
		{
			set
			{
			}
		}

		public Quaternion rotation
		{
			set
			{
			}
		}

		public void AddForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		[SpecialName]
		private void set_velocity_Injected(ref Vector3 value)
		{
		}

		[SpecialName]
		private void set_angularVelocity_Injected(ref Vector3 value)
		{
		}

		[SpecialName]
		private void set_rotation_Injected(ref Quaternion value)
		{
		}

		private void AddForce_Injected(ref Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}
	}
}
