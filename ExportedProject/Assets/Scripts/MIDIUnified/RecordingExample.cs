using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class RecordingExample : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CStart_003Ed__7(int _003C_003E1__state)
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
	private sealed class _003CLoadClip_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RecordingExample _003C_003E4__this;

		private UnityWebRequest _003Cwww_003E5__2;

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
		public _003CLoadClip_003Ed__19(int _003C_003E1__state)
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

	private AudioSource audioSource;

	public MidiSeqKaraokeScript seq;

	public AudioClip bgMusic;

	[Range(0f, 1f)]
	public float bgMusicVolume;

	public Text synthFileText;

	public Text midiFileText;

	public Text speedText;

	public Slider speedSlider;

	public Text semitoneText;

	public Slider semitoneSlider;

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__7))]
	private IEnumerator Start()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	public void OpenDirectory()
	{
	}

	public void StartMidiInputRecording()
	{
	}

	public void StopMidiInputRecording(bool playBack = true)
	{
	}

	public void StopMidiPlayback()
	{
	}

	public void StartSynthRecording()
	{
	}

	public void StopSynthRecording(bool playBack = true)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadClip_003Ed__19))]
	private IEnumerator LoadClip()
	{
		return null;
	}

	public void StopSynthPlayback()
	{
	}

	public void SpeedSynth()
	{
	}

	public void SemitoneSynth()
	{
	}
}
