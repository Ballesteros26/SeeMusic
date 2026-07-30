using System;

namespace UnityEngine.Purchasing.Utils
{
	internal class AndroidJavaObjectWrapper : IAndroidJavaObjectWrapper
	{
		private IDisposable androidJavaObject { get; }

		public AndroidJavaObjectWrapper(AndroidJavaObject obj)
		{
		}

		public ReturnType Call<ReturnType>(string methodName, params object[] args)
		{
			return default(ReturnType);
		}
	}
}
