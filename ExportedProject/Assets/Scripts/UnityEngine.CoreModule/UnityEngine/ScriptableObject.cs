using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[ExtensionOfNativeClass]
	[RequiredByNativeCode]
	[NativeClass(null)]
	[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
	public class ScriptableObject : Object
	{
		public static ScriptableObject CreateInstance(Type type)
		{
			return null;
		}

		public static T CreateInstance<T>() where T : ScriptableObject
		{
			return null;
		}

		[NativeMethod(IsThreadSafe = true)]
		private static void CreateScriptableObject([Writable] ScriptableObject self)
		{
		}

		[FreeFunction("Scripting::CreateScriptableObjectWithType")]
		internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset)
		{
			return null;
		}
	}
}
