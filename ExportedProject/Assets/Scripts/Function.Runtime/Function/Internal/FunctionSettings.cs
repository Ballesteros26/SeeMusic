using UnityEngine;

namespace Function.Internal
{
	[DefaultExecutionOrder(int.MinValue)]
	internal sealed class FunctionSettings : ScriptableObject
	{
		[SerializeField]
		[HideInInspector]
		internal string accessKey;

		internal static FunctionSettings Instance;

		private void Awake()
		{
		}
	}
}
