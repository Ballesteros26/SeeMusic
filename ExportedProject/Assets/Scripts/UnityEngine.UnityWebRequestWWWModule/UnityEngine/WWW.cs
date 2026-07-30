using System;
using UnityEngine.Networking;

namespace UnityEngine
{
	[Obsolete("Use UnityWebRequest, a fully featured replacement which is more efficient and has additional features")]
	public class WWW : CustomYieldInstruction, IDisposable
	{
		private UnityWebRequest _uwr;

		public byte[] bytes => null;

		public string error => null;

		public string text => null;

		public string url => null;

		public override bool keepWaiting => false;

		public WWW(string url)
		{
		}

		public void Dispose()
		{
		}

		internal Object GetAudioClipInternal(bool threeD, bool stream, bool compressed, AudioType audioType)
		{
			return null;
		}

		public AudioClip GetAudioClip(bool threeD, bool stream)
		{
			return null;
		}

		public AudioClip GetAudioClip(bool threeD, bool stream, AudioType audioType)
		{
			return null;
		}

		private bool WaitUntilDoneIfPossible()
		{
			return false;
		}
	}
}
