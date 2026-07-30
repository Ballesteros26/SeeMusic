using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[NativeHeader("Runtime/Export/Director/PlayableGraph.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[UsedByNativeCode]
	public struct PlayableGraph
	{
		internal IntPtr m_Handle;

		internal uint m_Version;

		public bool Connect<U, V>(U source, int sourceOutputPort, V destination, int destinationInputPort) where U : struct, IPlayable where V : struct, IPlayable
		{
			return false;
		}

		public bool IsValid()
		{
			return false;
		}

		[FreeFunction("PlayableGraphBindings::GetPlayableCount", HasExplicitThis = true, ThrowsException = true)]
		public int GetPlayableCount()
		{
			return 0;
		}

		[FreeFunction("PlayableGraphBindings::CreatePlayableHandle", HasExplicitThis = true, ThrowsException = true)]
		internal PlayableHandle CreatePlayableHandle()
		{
			return default(PlayableHandle);
		}

		[FreeFunction("PlayableGraphBindings::CreateScriptOutputInternal", HasExplicitThis = true, ThrowsException = true)]
		internal bool CreateScriptOutputInternal(string name, out PlayableOutputHandle handle)
		{
			handle = default(PlayableOutputHandle);
			return false;
		}

		[FreeFunction("PlayableGraphBindings::ConnectInternal", HasExplicitThis = true, ThrowsException = true)]
		private bool ConnectInternal(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort)
		{
			return false;
		}

		private static bool IsValid_Injected(ref PlayableGraph _unity_self)
		{
			return false;
		}

		private static int GetPlayableCount_Injected(ref PlayableGraph _unity_self)
		{
			return 0;
		}

		private static void CreatePlayableHandle_Injected(ref PlayableGraph _unity_self, out PlayableHandle ret)
		{
			ret = default(PlayableHandle);
		}

		private static bool CreateScriptOutputInternal_Injected(ref PlayableGraph _unity_self, string name, out PlayableOutputHandle handle)
		{
			handle = default(PlayableOutputHandle);
			return false;
		}

		private static bool ConnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle source, int sourceOutputPort, ref PlayableHandle destination, int destinationInputPort)
		{
			return false;
		}
	}
}
