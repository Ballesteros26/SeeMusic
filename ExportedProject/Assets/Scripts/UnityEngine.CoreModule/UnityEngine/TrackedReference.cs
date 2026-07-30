using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[UsedByNativeCode]
	public class TrackedReference
	{
		internal IntPtr m_Ptr;
	}
}
