using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MidiPlayerTK
{
	[RequireComponent(typeof(AudioSource))]
	[HelpURL("https://paxstellar.fr/midi-file-player-detailed-view-2-2/")]
	public class MidiStreamPlayer : MidiSynth
	{
		[CompilerGenerated]
		private sealed class _003CTheadPlay_003Ed__5 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public MPTKEvent evnt;

			public MidiStreamPlayer _003C_003E4__this;

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
			public _003CTheadPlay_003Ed__5(int _003C_003E1__state)
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
		private sealed class _003CTheadPlay_003Ed__6 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public List<MPTKEvent> events;

			public MidiStreamPlayer _003C_003E4__this;

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
			public _003CTheadPlay_003Ed__6(int _003C_003E1__state)
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

		private float localMaxDistance;

		public bool MPTK_LogChord;

		private int currentGammeIndex;

		private MPTKRangeLib range;

		public string MPTK_RangeName => null;

		public int MPTK_RangeSelected
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private new void Awake()
		{
		}

		private new void Start()
		{
		}

		public void MPTK_StartMidiStream()
		{
		}

		public void MPTK_PlayEvent(MPTKEvent mptkEvent)
		{
		}

		public void MPTK_PlayEvent(List<MPTKEvent> mptkEvents)
		{
		}

		[IteratorStateMachine(typeof(_003CTheadPlay_003Ed__5))]
		private IEnumerator<float> TheadPlay(MPTKEvent evnt)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CTheadPlay_003Ed__6))]
		private IEnumerator<float> TheadPlay(List<MPTKEvent> events)
		{
			return null;
		}

		public void MPTK_StopEvent(MPTKEvent mptkEvent)
		{
		}

		public void Update()
		{
		}

		public void MPTK_PlayPitchWheelChange(int channel, float pitchWheel)
		{
		}

		public void MPTK_PlayPitchWheelSensitivity(int channel, int sensitivity)
		{
		}

		public MPTKChordBuilder MPTK_PlayChordFromRange(MPTKChordBuilder chord)
		{
			return null;
		}

		public MPTKChordBuilder MPTK_PlayChordFromLib(MPTKChordBuilder chord)
		{
			return null;
		}

		public void MPTK_StopChord(MPTKChordBuilder chord)
		{
		}
	}
}
