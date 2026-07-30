using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MidiPlayerTK
{
	public class VoiceAudioSource : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CThreadPlayNote_003Ed__9 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public VoiceAudioSource _003C_003E4__this;

			float IEnumerator<float>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0f;
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
			public _003CThreadPlayNote_003Ed__9(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CRelease_003Ed__12 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public VoiceAudioSource _003C_003E4__this;

			float IEnumerator<float>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0f;
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
			public _003CRelease_003Ed__12(int _003C_003E1__state)
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

		public MidiSynth synth;

		public fluid_voice fluidvoice;

		public AudioSource Audiosource;

		public AudioLowPassFilter LowPassFilter;

		public AudioReverbFilter ReverbFilter;

		public AudioChorusFilter ChorusFilter;

		public void Awake()
		{
		}

		public void Start()
		{
		}

		public void RunUnityThread()
		{
		}

		[IteratorStateMachine(typeof(_003CThreadPlayNote_003Ed__9))]
		protected IEnumerator<float> ThreadPlayNote()
		{
			return null;
		}

		public void fluid_voice_audiosource_write(long ticks)
		{
		}

		public void fluid_weakvoice_write(long ticks)
		{
		}

		[IteratorStateMachine(typeof(_003CRelease_003Ed__12))]
		public IEnumerator<float> Release()
		{
			return null;
		}
	}
}
