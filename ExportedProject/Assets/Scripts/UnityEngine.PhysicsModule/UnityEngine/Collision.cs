using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode]
	public class Collision
	{
		internal Vector3 m_Impulse;

		internal Vector3 m_RelativeVelocity;

		internal Component m_Body;

		internal Collider m_Collider;

		internal int m_ContactCount;

		internal ContactPoint[] m_ReusedContacts;

		internal ContactPoint[] m_LegacyContacts;

		public ContactPoint[] contacts => null;
	}
}
