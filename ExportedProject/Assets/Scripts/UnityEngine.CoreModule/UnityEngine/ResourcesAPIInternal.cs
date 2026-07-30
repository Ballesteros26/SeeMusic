using System;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine
{
	[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
	[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
	internal static class ResourcesAPIInternal
	{
		[TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
		[FreeFunction("Resources_Bindings::FindObjectsOfTypeAll")]
		public static Object[] FindObjectsOfTypeAll(Type type)
		{
			return null;
		}

		[FreeFunction("GetShaderNameRegistry().FindShader")]
		public static Shader FindShaderByName(string name)
		{
			return null;
		}

		[FreeFunction("Resources_Bindings::Load")]
		[NativeThrows]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		public static Object Load(string path, [NotNull("ArgumentNullException")] Type systemTypeInstance)
		{
			return null;
		}

		[NativeThrows]
		[FreeFunction("Resources_Bindings::LoadAll")]
		public static Object[] LoadAll([NotNull("ArgumentNullException")] string path, [NotNull("ArgumentNullException")] Type systemTypeInstance)
		{
			return null;
		}

		[FreeFunction("Resources_Bindings::LoadAsyncInternal")]
		internal static ResourceRequest LoadAsyncInternal(string path, Type type)
		{
			return null;
		}

		[FreeFunction("Scripting::UnloadAssetFromScripting")]
		public static void UnloadAsset(Object assetToUnload)
		{
		}
	}
}
