using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/UnityWebRequestAudio/Public/DownloadHandlerAudioClip.h")]
	public sealed class DownloadHandlerAudioClip : DownloadHandler
	{
		private NativeArray<byte> m_NativeData;

		[NativeThrows]
		public AudioClip audioClip => null;

		private static IntPtr Create(DownloadHandlerAudioClip obj, string url, AudioType audioType)
		{
			return (IntPtr)0;
		}

		private void InternalCreateAudioClip(string url, AudioType audioType)
		{
		}

		public DownloadHandlerAudioClip(string url, AudioType audioType)
		{
		}

		protected override NativeArray<byte> GetNativeData()
		{
			return default(NativeArray<byte>);
		}

		public override void Dispose()
		{
		}

		protected override string GetText()
		{
			return null;
		}

		public static AudioClip GetContent(UnityWebRequest www)
		{
			return null;
		}
	}
}
