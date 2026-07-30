using System;

namespace UnityEngine
{
	public class AndroidJavaObject : IDisposable
	{
		private static bool enableDebugPrints;

		internal GlobalJavaObjectRef m_jobject;

		internal GlobalJavaObjectRef m_jclass;

		public AndroidJavaObject(string className, string[] args)
		{
		}

		public AndroidJavaObject(string className, AndroidJavaObject[] args)
		{
		}

		public AndroidJavaObject(string className, AndroidJavaClass[] args)
		{
		}

		public AndroidJavaObject(string className, AndroidJavaProxy[] args)
		{
		}

		public AndroidJavaObject(string className, AndroidJavaRunnable[] args)
		{
		}

		public AndroidJavaObject(string className, params object[] args)
		{
		}

		public void Dispose()
		{
		}

		public void Call<T>(string methodName, T[] args)
		{
		}

		public void Call(string methodName, params object[] args)
		{
		}

		public void CallStatic<T>(string methodName, T[] args)
		{
		}

		public void CallStatic(string methodName, params object[] args)
		{
		}

		public FieldType Get<FieldType>(string fieldName)
		{
			return default(FieldType);
		}

		public void Set<FieldType>(string fieldName, FieldType val)
		{
		}

		public FieldType GetStatic<FieldType>(string fieldName)
		{
			return default(FieldType);
		}

		public void SetStatic<FieldType>(string fieldName, FieldType val)
		{
		}

		public IntPtr GetRawObject()
		{
			return (IntPtr)0;
		}

		public IntPtr GetRawClass()
		{
			return (IntPtr)0;
		}

		public AndroidJavaObject CloneReference()
		{
			return null;
		}

		public ReturnType Call<ReturnType, T>(string methodName, T[] args)
		{
			return default(ReturnType);
		}

		public ReturnType Call<ReturnType>(string methodName, params object[] args)
		{
			return default(ReturnType);
		}

		public ReturnType CallStatic<ReturnType, T>(string methodName, T[] args)
		{
			return default(ReturnType);
		}

		public ReturnType CallStatic<ReturnType>(string methodName, params object[] args)
		{
			return default(ReturnType);
		}

		protected void DebugPrint(string msg)
		{
		}

		protected void DebugPrint(string call, string methodName, string signature, object[] args)
		{
		}

		private void _AndroidJavaObject(string className, params object[] args)
		{
		}

		internal AndroidJavaObject(IntPtr jobject)
		{
		}

		internal AndroidJavaObject()
		{
		}

		~AndroidJavaObject()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		protected void _Call(string methodName, params object[] args)
		{
		}

		protected ReturnType _Call<ReturnType>(string methodName, params object[] args)
		{
			return default(ReturnType);
		}

		protected FieldType _Get<FieldType>(string fieldName)
		{
			return default(FieldType);
		}

		protected void _Set<FieldType>(string fieldName, FieldType val)
		{
		}

		protected void _CallStatic(string methodName, params object[] args)
		{
		}

		protected ReturnType _CallStatic<ReturnType>(string methodName, params object[] args)
		{
			return default(ReturnType);
		}

		protected FieldType _GetStatic<FieldType>(string fieldName)
		{
			return default(FieldType);
		}

		protected void _SetStatic<FieldType>(string fieldName, FieldType val)
		{
		}

		internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject)
		{
			return null;
		}

		internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass)
		{
			return null;
		}

		internal static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(IntPtr jobject)
		{
			return default(ReturnType);
		}

		protected IntPtr _GetRawObject()
		{
			return (IntPtr)0;
		}

		protected IntPtr _GetRawClass()
		{
			return (IntPtr)0;
		}
	}
}
