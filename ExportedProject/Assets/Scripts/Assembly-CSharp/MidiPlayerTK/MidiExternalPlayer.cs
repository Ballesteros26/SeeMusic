using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

namespace MidiPlayerTK
{
	[HelpURL("https://paxstellar.fr/midi-external-player-v2/")]
	public class MidiExternalPlayer : MidiFilePlayer
	{
		[CompilerGenerated]
		private sealed class _003CTheadLoadDataAndPlay_003Ed__7 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public MidiExternalPlayer _003C_003E4__this;

			private UnityWebRequest _003Creq_003E5__2;

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
			public _003CTheadLoadDataAndPlay_003Ed__7(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[HideInInspector]
		[SerializeField]
		private string pathmidiNameToPlay;

		public new string MPTK_MidiName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public new int MPTK_MidiIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected new void Awake()
		{
		}

		protected new void Start()
		{
		}

		public override void MPTK_Play(bool alreadyLoaded = false)
		{
		}

		[IteratorStateMachine(typeof(_003CTheadLoadDataAndPlay_003Ed__7))]
		private IEnumerator<float> TheadLoadDataAndPlay(bool alreadyLoaded = false)
		{
			return null;
		}

		public new MidiLoad MPTK_Load()
		{
			return null;
		}

		public new void MPTK_Next()
		{
		}

		public new void MPTK_Previous()
		{
		}
	}
}
