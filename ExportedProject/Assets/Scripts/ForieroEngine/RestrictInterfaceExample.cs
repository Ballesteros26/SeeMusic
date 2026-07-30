using UnityEngine;

public class RestrictInterfaceExample : MonoBehaviour, ITEST
{
	[RestrictInterface(typeof(ITEST))]
	public Object[] m_LayoutElement;
}
