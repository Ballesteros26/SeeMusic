using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OnAudioFilterReadWavRecorder : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnAudioFilterReadWavRecorder _003C_003E4__this;

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
		public _003CStart_003Ed__10(int _003C_003E1__state)
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

	private int outputRate;

	private readonly string fileName;

	public bool recording;

	private bool canRecord;

	private FileStream fileStream;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void PrepareRecording(string filePath = "")
	{
	}

	public void StartRecording(string filePath = "")
	{
	}

	public void StopRecording()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__10))]
	private IEnumerator Start()
	{
		return null;
	}

	private void OnAudioFilterRead(float[] data, int channels)
	{
	}
}
