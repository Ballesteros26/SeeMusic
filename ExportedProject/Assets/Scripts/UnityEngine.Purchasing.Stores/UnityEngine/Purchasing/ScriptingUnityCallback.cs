using Uniject;

namespace UnityEngine.Purchasing
{
	internal class ScriptingUnityCallback : IUnityCallback
	{
		private readonly IUnityCallback forwardTo;

		private readonly IUtil util;

		public ScriptingUnityCallback(IUnityCallback forwardTo, IUtil util)
		{
		}
	}
}
