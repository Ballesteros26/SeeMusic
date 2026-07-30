using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VideoKit.Recorders.Clocks;

namespace VideoKit.Recorders.Inputs
{
	internal sealed class CustomTextureInput : IDisposable
	{
		private sealed class CustomTextureInputAttachment : MonoBehaviour
		{
		}

		[CompilerGenerated]
		private sealed class _003CCommitFrames_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CustomTextureInput _003C_003E4__this;

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
			public _003CCommitFrames_003Ed__11(int _003C_003E1__state)
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

		public int frameSkip;

		private readonly TextureInput input;

		private readonly IClock clock;

		private readonly Texture texture;

		private readonly CustomTextureInputAttachment attachment;

		private int frameIdx;

		public CustomTextureInput(MediaRecorder recorder, IClock clock, Texture texture)
		{
		}

		public CustomTextureInput(MediaRecorder recorder, Texture texture)
		{
		}

		public CustomTextureInput(TextureInput input, IClock clock, Texture texture)
		{
		}

		public CustomTextureInput(TextureInput input, Texture texture)
		{
		}

		public void Dispose()
		{
		}

		[IteratorStateMachine(typeof(_003CCommitFrames_003Ed__11))]
		private IEnumerator CommitFrames()
		{
			return null;
		}
	}
}
