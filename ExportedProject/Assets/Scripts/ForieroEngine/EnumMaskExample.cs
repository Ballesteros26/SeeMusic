using System;
using UnityEngine;

public class EnumMaskExample : MonoBehaviour
{
	[Flags]
	public enum Flags
	{
		foo = 1,
		bar = 2,
		baz = 4,
		qux = 8
	}

	[EnumMask]
	public Flags m_Flags;
}
