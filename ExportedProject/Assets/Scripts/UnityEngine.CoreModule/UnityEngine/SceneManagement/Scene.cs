using System;
using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement
{
	[Serializable]
	[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
	public struct Scene
	{
		[SerializeField]
		[HideInInspector]
		private int m_Handle;

		public int handle => 0;

		internal string guid => null;

		public string name => null;

		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		private static string GetNameInternal(int sceneHandle)
		{
			return null;
		}

		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		private static string GetGUIDInternal(int sceneHandle)
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object other)
		{
			return false;
		}
	}
}
