using System;
using System.Runtime.InteropServices;
using AOT;
using UnityEngine;
using UnityEngine.Rendering;
using VideoKit.Internal;

namespace VideoKit.Recorders.Inputs
{
	public sealed class GLESTextureInput : TextureInput
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void UnityRenderingEventAndData(int _, IntPtr data);

		private readonly RenderTexture frameBuffer;

		private readonly IntPtr frameBufferID;

		private IntPtr input;

		private readonly object fence;

		private static readonly IntPtr RenderThreadCallback;

		public GLESTextureInput(MediaRecorder recorder)
			: base(null)
		{
		}

		public override void CommitFrame(Texture texture, long timestamp)
		{
		}

		public override void Dispose()
		{
		}

		static GLESTextureInput()
		{
		}

		private static void RunOnRenderThread(CommandBuffer commandBuffer, Action action)
		{
		}

		[MonoPInvokeCallback(typeof(UnityRenderingEventAndData))]
		private static void OnRenderThreadInvoke(int _, IntPtr context)
		{
		}

		[MonoPInvokeCallback(typeof(VideoKitExt.ReadbackHandler))]
		private static void OnReadbackCompleted(IntPtr context, IntPtr pixelBuffer)
		{
		}
	}
}
