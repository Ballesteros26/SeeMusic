using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.U2D
{
	[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlasManager.h")]
	[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
	[StaticAccessor("GetSpriteAtlasManager()", StaticAccessorType.Dot)]
	public class SpriteAtlasManager
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<string, Action<SpriteAtlas>> atlasRequested;

		public static event Action<SpriteAtlas> atlasRegistered
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

		[RequiredByNativeCode]
		private static bool RequestAtlas(string tag)
		{
			return false;
		}

		[RequiredByNativeCode]
		private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas)
		{
		}

		internal static void Register(SpriteAtlas spriteAtlas)
		{
		}
	}
}
