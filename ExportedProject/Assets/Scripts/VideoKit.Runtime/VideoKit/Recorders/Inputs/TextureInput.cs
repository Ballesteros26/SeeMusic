using System;
using UnityEngine;

namespace VideoKit.Recorders.Inputs
{
	public class TextureInput : IDisposable
	{
		public static bool UseGLESTextureInput;

		protected readonly MediaRecorder recorder;

		private Texture2D readbackBuffer;

		public virtual (int width, int height) frameSize => default((int, int));

		private static bool AllowGLESDefault => false;

		public TextureInput(MediaRecorder recorder)
		{
		}

		public virtual void CommitFrame(Texture texture, long timestamp)
		{
		}

		public virtual void Dispose()
		{
		}

		public static TextureInput CreateDefault(MediaRecorder recorder)
		{
			return null;
		}
	}
}
