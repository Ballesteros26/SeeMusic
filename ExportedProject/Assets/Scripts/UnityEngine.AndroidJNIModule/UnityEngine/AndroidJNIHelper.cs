using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeConditional("PLATFORM_ANDROID")]
	[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
	[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType.DoubleColon)]
	[UsedByNativeCode]
	public static class AndroidJNIHelper
	{
		public static IntPtr GetConstructorID(IntPtr javaClass, [DefaultValue(null)] string signature)
		{
			return (IntPtr)0;
		}

		public static IntPtr GetMethodID(IntPtr javaClass, string methodName, [DefaultValue(null)] string signature, [DefaultValue("false")] bool isStatic)
		{
			return (IntPtr)0;
		}

		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, [DefaultValue(null)] string signature, [DefaultValue("false")] bool isStatic)
		{
			return (IntPtr)0;
		}

		public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable)
		{
			return (IntPtr)0;
		}

		public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy)
		{
			return (IntPtr)0;
		}

		public static IntPtr ConvertToJNIArray(Array array)
		{
			return (IntPtr)0;
		}

		public static jvalue[] CreateJNIArgArray(object[] args)
		{
			return null;
		}

		public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs)
		{
		}

		public static IntPtr GetConstructorID(IntPtr jclass, object[] args)
		{
			return (IntPtr)0;
		}

		public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			return (IntPtr)0;
		}

		public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array)
		{
			return default(ArrayType);
		}

		public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			return (IntPtr)0;
		}

		public static IntPtr GetFieldID<FieldType>(IntPtr jclass, string fieldName, bool isStatic)
		{
			return (IntPtr)0;
		}
	}
}
