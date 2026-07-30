using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VideoKit.Recorders.Clocks;

namespace VideoKit.Recorders.Inputs
{
	public class CameraInput : IDisposable
	{
		private sealed class CameraInputAttachment : MonoBehaviour
		{
		}

		[CompilerGenerated]
		private sealed class _003CCommitFrames_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CameraInput _003C_003E4__this;

			private WaitForEndOfFrame _003Cyielder_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCommitFrames_003Ed__12(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public readonly IReadOnlyList<Camera> cameras;

		public int frameSkip;

		private readonly TextureInput input;

		private readonly IClock clock;

		private readonly RenderTextureDescriptor descriptor;

		private readonly CameraInputAttachment attachment;

		private int frameCount;

		[Obsolete("Deprecated in NatCorder 1.9.3. This property is no longer necessary.")]
		public bool HDR;

		public CameraInput(MediaRecorder recorder, IClock clock, params Camera[] cameras)
		{
		}

		public CameraInput(MediaRecorder recorder, params Camera[] cameras)
		{
		}

		public CameraInput(TextureInput input, IClock clock, params Camera[] cameras)
		{
		}

		public CameraInput(TextureInput input, params Camera[] cameras)
		{
		}

		public void Dispose()
		{
		}

		[IteratorStateMachine(typeof(_003CCommitFrames_003Ed__12))]
		private IEnumerator CommitFrames()
		{
			return null;
		}

		protected virtual void ClearFrame(RenderTexture renderTexture)
		{
		}

		protected virtual void CommitFrame(Camera source, RenderTexture destination)
		{
		}
	}
}
