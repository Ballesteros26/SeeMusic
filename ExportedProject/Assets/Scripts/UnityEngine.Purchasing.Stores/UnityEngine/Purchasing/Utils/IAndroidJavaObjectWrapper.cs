namespace UnityEngine.Purchasing.Utils
{
	internal interface IAndroidJavaObjectWrapper
	{
		ReturnType Call<ReturnType>(string methodName, params object[] args);
	}
}
