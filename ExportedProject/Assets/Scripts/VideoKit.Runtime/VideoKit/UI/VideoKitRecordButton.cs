using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace VideoKit.UI
{
	[AddComponentMenu(null)]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Image))]
	public sealed class VideoKitRecordButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[CompilerGenerated]
		private sealed class _003CCountdown_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public VideoKitRecordButton _003C_003E4__this;

			private float _003CstartTime_003E5__2;

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
			public _003CCountdown_003Ed__11(int _003C_003E1__state)
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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStartRecording_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public VideoKitRecordButton _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStopRecording_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public VideoKitRecordButton _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[Tooltip("Recorder to control.")]
		[Header("Settings")]
		public VideoKitRecorder recorder;

		[Range(5f, 60f)]
		[Tooltip("Maximum duration that button can be pressed.")]
		public float maxDuration;

		[Tooltip("Countdown image.")]
		[Header("UI")]
		public Image countdown;

		[Tooltip("Event invoked when recording is started.")]
		[Header("Events")]
		public UnityEvent OnStartRecording;

		[Tooltip("Event invoked when recording is stopped.")]
		public UnityEvent OnStopRecording;

		private Image button;

		private bool touch;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Zero()
		{
		}

		[IteratorStateMachine(typeof(_003CCountdown_003Ed__11))]
		private IEnumerator Countdown()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CStartRecording_003Ed__12))]
		private void StartRecording()
		{
		}

		[AsyncStateMachine(typeof(_003CStopRecording_003Ed__13))]
		private void StopRecording()
		{
		}

		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
		}

		void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
		{
		}
	}
}
