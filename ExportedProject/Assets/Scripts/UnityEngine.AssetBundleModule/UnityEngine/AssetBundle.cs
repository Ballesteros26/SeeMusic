using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("AssetBundleScriptingClasses.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromManagedStreamAsyncOperation.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromFileAsyncOperation.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetUtility.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleUtility.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleSaveAndLoadHelper.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromMemoryAsyncOperation.h")]
	[NativeHeader("Runtime/Scripting/ScriptingUtility.h")]
	[NativeHeader("Runtime/Scripting/ScriptingObjectWithIntPtrField.h")]
	[NativeHeader("Runtime/Scripting/ScriptingExportUtility.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
	[ExcludeFromPreset]
	public class AssetBundle : Object
	{
		private AssetBundle()
		{
		}

		[FreeFunction("LoadFromFileAsync")]
		internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset)
		{
			return null;
		}

		public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc, ulong offset)
		{
			return null;
		}

		[FreeFunction("LoadFromFile")]
		internal static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset)
		{
			return null;
		}

		public static AssetBundle LoadFromFile(string path, uint crc, ulong offset)
		{
			return null;
		}
	}
}
