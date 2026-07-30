using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sanford.Multimedia.Midi
{
	public sealed class Track
	{
		[CompilerGenerated]
		private sealed class _003CIterator_003Ed__22 : IEnumerable<MidiEvent>, IEnumerable, IEnumerator<MidiEvent>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private MidiEvent _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Track _003C_003E4__this;

			private MidiEvent _003Ccurrent_003E5__1;

			MidiEvent IEnumerator<MidiEvent>.Current
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
			public _003CIterator_003Ed__22(int _003C_003E1__state)
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

			[DebuggerHidden]
			IEnumerator<MidiEvent> IEnumerable<MidiEvent>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private int count;

		private int endOfTrackOffset;

		private MidiEvent head;

		private MidiEvent tail;

		private MidiEvent endOfTrackMidiEvent;

		public int Length => 0;

		public int EndOfTrackOffset => 0;

		public void Insert(int position, IMidiMessage message)
		{
		}

		[IteratorStateMachine(typeof(_003CIterator_003Ed__22))]
		public IEnumerable<MidiEvent> Iterator()
		{
			return null;
		}
	}
}
