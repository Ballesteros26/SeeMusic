using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement
{
	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
	[NativeHeader("Runtime/SceneManager/SceneManager.h")]
	internal static class SceneManagerAPIInternal
	{
		[NativeThrows]
		public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			return null;
		}

		private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			return null;
		}
	}
}
