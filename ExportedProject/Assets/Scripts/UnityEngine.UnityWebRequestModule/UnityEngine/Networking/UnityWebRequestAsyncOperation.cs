using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	[StructLayout((LayoutKind)0)]
	[UsedByNativeCode]
	[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequestAsyncOperation.h")]
	[NativeHeader("UnityWebRequestScriptingClasses.h")]
	public class UnityWebRequestAsyncOperation : AsyncOperation
	{
		public UnityWebRequest webRequest { get; internal set; }
	}
}
