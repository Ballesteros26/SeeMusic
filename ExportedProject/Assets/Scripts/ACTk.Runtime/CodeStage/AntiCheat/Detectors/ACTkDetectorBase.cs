using System;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.Events;

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu(null)]
	public abstract class ACTkDetectorBase<T> : KeepAliveBehaviour<T> where T : ACTkDetectorBase<T>
	{
		protected const string MenuPath = "Code Stage/Anti-Cheat Toolkit/";

		[Tooltip("Automatically start detector. Detection Event will be called on detection.")]
		public bool autoStart;

		[Tooltip("Automatically dispose Detector after firing callback.")]
		public bool autoDispose;

		[SerializeField]
		protected UnityEvent detectionEvent;

		[SerializeField]
		protected bool detectionEventHasListener;

		protected bool started;

		protected bool isRunning;

		public bool IsCheatDetected { get; protected set; }

		public bool IsStarted => false;

		public bool IsRunning => false;

		public event Action CheatDetected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnApplicationQuit()
		{
		}

		protected override void OnDestroy()
		{
		}

		internal virtual void OnCheatingDetected()
		{
		}

		protected virtual bool DetectorHasCallbacks()
		{
			return false;
		}

		protected virtual void StopDetectionInternal()
		{
		}

		protected virtual void PauseDetector()
		{
		}

		protected virtual bool ResumeDetector()
		{
			return false;
		}

		protected abstract void StartDetectionAutomatically();
	}
}
