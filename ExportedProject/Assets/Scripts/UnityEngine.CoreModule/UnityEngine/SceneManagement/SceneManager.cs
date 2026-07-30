using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.SceneManagement
{
	[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
	[RequiredByNativeCode]
	public class SceneManager
	{
		internal static bool s_AllowLoadScene;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static UnityAction<Scene> sceneUnloaded;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static UnityAction<Scene, Scene> activeSceneChanged;

		public static int sceneCount
		{
			[StaticAccessor("GetSceneManager()", StaticAccessorType.Dot)]
			[NativeHeader("Runtime/SceneManager/SceneManager.h")]
			[NativeMethod("GetSceneCount")]
			get
			{
				return 0;
			}
		}

		public static event UnityAction<Scene, LoadSceneMode> sceneLoaded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		public static Scene GetActiveScene()
		{
			return default(Scene);
		}

		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		[NativeThrows]
		public static Scene GetSceneAt(int index)
		{
			return default(Scene);
		}

		private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			return null;
		}

		[RequiredByNativeCode]
		internal static AsyncOperation LoadFirstScene_Internal(bool async)
		{
			return null;
		}

		public static void LoadScene(string sceneName, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
		{
		}

		public static Scene LoadScene(string sceneName, LoadSceneParameters parameters)
		{
			return default(Scene);
		}

		[RequiredByNativeCode]
		private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[RequiredByNativeCode]
		private static void Internal_SceneUnloaded(Scene scene)
		{
		}

		[RequiredByNativeCode]
		private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene)
		{
		}

		private static void GetActiveScene_Injected(out Scene ret)
		{
			ret = default(Scene);
		}

		private static void GetSceneAt_Injected(int index, out Scene ret)
		{
			ret = default(Scene);
		}
	}
}
