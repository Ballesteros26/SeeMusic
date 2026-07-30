namespace UnityEngine.Purchasing
{
	internal class JavaBridge : AndroidJavaProxy, IUnityCallback
	{
		private readonly IUnityCallback forwardTo;

		public JavaBridge(IUnityCallback forwardTo)
			: base((string)null)
		{
		}
	}
}
