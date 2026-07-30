using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/UnityWebRequestTexture/Public/DownloadHandlerTexture.h")]
	public sealed class DownloadHandlerTexture : DownloadHandler
	{
		private NativeArray<byte> m_NativeData;

		private Texture2D mTexture;

		private bool mHasTexture;

		private bool mNonReadable;

		public Texture2D texture => null;

		private static IntPtr Create(DownloadHandlerTexture obj, bool readable)
		{
			return (IntPtr)0;
		}

		private void InternalCreateTexture(bool readable)
		{
		}

		public DownloadHandlerTexture(bool readable)
		{
		}

		protected override NativeArray<byte> GetNativeData()
		{
			return default(NativeArray<byte>);
		}

		public override void Dispose()
		{
		}

		private Texture2D InternalGetTexture()
		{
			return null;
		}

		[NativeThrows]
		private Texture2D InternalGetTextureNative()
		{
			return null;
		}

		private void ClearNativeTexture()
		{
		}

		public static Texture2D GetContent(UnityWebRequest www)
		{
			return null;
		}
	}
}
