using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	[RequiredByNativeCode]
	[NativeHeader("Modules/Director/PlayableDirector.h")]
	[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
	public class PlayableDirector : Behaviour
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<PlayableDirector> played;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<PlayableDirector> paused;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<PlayableDirector> stopped;

		public PlayState state => default(PlayState);

		public DirectorWrapMode extrapolationMode => default(DirectorWrapMode);

		public PlayableAsset playableAsset => null;

		public DirectorUpdateMode timeUpdateMode
		{
			get
			{
				return default(DirectorUpdateMode);
			}
			set
			{
			}
		}

		public void Pause()
		{
		}

		public void Resume()
		{
		}

		[NativeMethod("GetBindingFor")]
		public Object GetGenericBinding(Object key)
		{
			return null;
		}

		private PlayState GetPlayState()
		{
			return default(PlayState);
		}

		private DirectorWrapMode GetWrapMode()
		{
			return default(DirectorWrapMode);
		}

		private ScriptableObject Internal_GetPlayableAsset()
		{
			return null;
		}

		[RequiredByNativeCode]
		private void SendOnPlayableDirectorPlay()
		{
		}

		[RequiredByNativeCode]
		private void SendOnPlayableDirectorPause()
		{
		}

		[RequiredByNativeCode]
		private void SendOnPlayableDirectorStop()
		{
		}
	}
}
