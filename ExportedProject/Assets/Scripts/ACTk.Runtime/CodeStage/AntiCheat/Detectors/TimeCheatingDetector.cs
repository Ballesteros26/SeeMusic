using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.Detectors
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Time Cheating Detector")]
	[HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_time_cheating_detector.html")]
	public class TimeCheatingDetector : ACTkDetectorBase<TimeCheatingDetector>
	{
		public delegate void OnlineTimeCallback(OnlineTimeResult result);

		public delegate void TimeCheatingDetectorEventHandler(CheckResult result, ErrorKind error);

		public struct OnlineTimeResult
		{
			[Obsolete("Please use Success property instead")]
			public bool success;

			[Obsolete("Please use Error property instead")]
			public string error;

			[Obsolete("Please use ErrorResponseCode property instead")]
			public long errorResponseCode;

			[Obsolete("Please use OnlineSecondsUtc property instead")]
			public double onlineSecondsUtc;

			[Obsolete("Please use OnlineDateTimeUtc property instead")]
			public DateTime onlineDateTimeUtc;

			public bool Success => false;

			public string Error => null;

			public long ErrorResponseCode => 0L;

			public double OnlineSecondsUtc => 0.0;

			public DateTime OnlineDateTimeUtc => default(DateTime);

			internal void SetTime(double secondsUtc, DateTime dateTimeUtc)
			{
			}

			internal void SetError(string errorText, long responseCode = -1L)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		public enum CheckResult
		{
			Unknown = 0,
			CheckPassed = 5,
			WrongTimeDetected = 10,
			CheatDetected = 15,
			Error = 100
		}

		public enum ErrorKind
		{
			NoError = 0,
			IncorrectUri = 3,
			OnlineTimeError = 5,
			NotStarted = 10,
			AlreadyCheckingForCheat = 15,
			Unknown = 100
		}

		public enum RequestMethod
		{
			Head = 0,
			Get = 1
		}

		[CompilerGenerated]
		private sealed class _003CGetOnlineTimeCoroutine_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string url;

			public OnlineTimeCallback callback;

			public RequestMethod method;

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
			public _003CGetOnlineTimeCoroutine_003Ed__50(int _003C_003E1__state)
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
		private sealed class _003CGetOnlineTimeCoroutine_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Uri uri;

			public RequestMethod method;

			public OnlineTimeCallback callback;

			private OnlineTimeResult _003Cresult_003E5__2;

			private UnityWebRequest _003Cwr_003E5__3;

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
			public _003CGetOnlineTimeCoroutine_003Ed__51(int _003C_003E1__state)
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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetOnlineTimeTask_003Ed__52 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<OnlineTimeResult> _003C_003Et__builder;

			public string url;

			public RequestMethod method;

			private TaskAwaiter<OnlineTimeResult> _003C_003Eu__1;

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
		private struct _003CGetOnlineTimeTask_003Ed__53 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<OnlineTimeResult> _003C_003Et__builder;

			public Uri uri;

			public RequestMethod method;

			private OnlineTimeResult _003Cresult_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

			private UnityWebRequest _003Cwr_003E5__3;

			private UnityWebRequestAsyncOperation _003CasyncOperation_003E5__4;

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

		[CompilerGenerated]
		private sealed class _003CForceCheckEnumerator_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeCheatingDetector _003C_003E4__this;

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
			public _003CForceCheckEnumerator_003Ed__59(int _003C_003E1__state)
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
		private struct _003CForceCheckTask_003Ed__60 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<CheckResult> _003C_003Et__builder;

			public TimeCheatingDetector _003C_003E4__this;

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

		[CompilerGenerated]
		private sealed class _003CCheckForCheat_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeCheatingDetector _003C_003E4__this;

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
			public _003CCheckForCheat_003Ed__67(int _003C_003E1__state)
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

		public const string ComponentName = "Time Cheating Detector";

		private const string FinalLogPrefix = "[ACTk] Time Cheating Detector: ";

		private const int DefaultTimeoutSeconds = 10;

		private static readonly WaitForEndOfFrame CachedEndOfFrame;

		public static bool gettingOnlineTime;

		[Tooltip("Absolute URL which will return correct datetime in response headers (you may use popular web servers like google.com, microsoft.com etc.).")]
		[Header("Request settings")]
		[SerializeField]
		private string requestUrl;

		[Tooltip("Method to use for url request. Use Head method if possible and fall back to get if server does not reply or block head requests.")]
		public RequestMethod requestMethod;

		[Tooltip("Online time request timeout in seconds.")]
		public int timeoutSeconds;

		[Tooltip("Time (in minutes) between detector checks.")]
		[Range(0f, 60f)]
		[Header("Settings in minutes")]
		public float interval;

		[Range(10f, 180f)]
		[FormerlySerializedAs("threshold")]
		[Tooltip("Maximum allowed difference between subsequent measurements, in minutes.")]
		public int realCheatThreshold;

		[Tooltip("Maximum allowed difference between local and online time, in minutes.")]
		[Range(1f, 180f)]
		public int wrongTimeThreshold;

		[Tooltip("Ignore case when time changes to be in sync with online correct time. Wrong time threshold is taken into account.")]
		public bool ignoreSetCorrectTime;

		private readonly string onlineOfflineDifferencePrefsKey;

		public Uri cachedUri;

		private TimeCheatingDetectorEventHandler cheatChecked;

		private float timeElapsed;

		private bool updateAfterPause;

		public double lastOnlineSecondsUtc;

		[NonSerialized]
		public DateTime serverTime;

		[NonSerialized]
		[Obsolete("Use wrongTimeThreshold instead.", true)]
		public int threshold;

		[NonSerialized]
		[Obsolete("Use requestUrl instead", true)]
		public string timeServer;

		public string RequestUrl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ErrorKind LastError { get; private set; }

		public CheckResult LastResult { get; private set; }

		public bool IsCheckingForCheat { get; private set; }

		public event TimeCheatingDetectorEventHandler CheatChecked
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

		[Obsolete("Please use CheatChecked event instead", true)]
		public event Action<ErrorKind> Error
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

		[Obsolete("Please use CheatChecked event instead", true)]
		public event Action CheckPassed
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

		protected override string GetComponentName()
		{
			return null;
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		private void Update()
		{
		}

		public static TimeCheatingDetector AddToSceneOrGetExisting()
		{
			return null;
		}

		public static TimeCheatingDetector StartDetection(TimeCheatingDetectorEventHandler cheatCheckedEventHandler = null)
		{
			return null;
		}

		public static TimeCheatingDetector StartDetection(float intervalMinutes, TimeCheatingDetectorEventHandler cheatCheckedEventHandler = null)
		{
			return null;
		}

		public static void StopDetection()
		{
		}

		public static void Dispose()
		{
		}

		[IteratorStateMachine(typeof(_003CGetOnlineTimeCoroutine_003Ed__50))]
		public static IEnumerator GetOnlineTimeCoroutine(string url, OnlineTimeCallback callback, RequestMethod method = RequestMethod.Head)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetOnlineTimeCoroutine_003Ed__51))]
		public static IEnumerator GetOnlineTimeCoroutine(Uri uri, OnlineTimeCallback callback, RequestMethod method = RequestMethod.Head)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetOnlineTimeTask_003Ed__52))]
		public static Task<OnlineTimeResult> GetOnlineTimeTask(string url, RequestMethod method = RequestMethod.Head)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetOnlineTimeTask_003Ed__53))]
		public static Task<OnlineTimeResult> GetOnlineTimeTask(Uri uri, RequestMethod method = RequestMethod.Head)
		{
			return null;
		}

		private static UnityWebRequest GetWebRequest(Uri uri, RequestMethod method)
		{
			return null;
		}

		private static void FillRequestResult(UnityWebRequest request, ref OnlineTimeResult result)
		{
		}

		private static Uri UrlToUri(string url)
		{
			return null;
		}

		private static bool TryGetDate(string source, out DateTime date)
		{
			date = default(DateTime);
			return false;
		}

		public bool ForceCheck()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CForceCheckEnumerator_003Ed__59))]
		public IEnumerator ForceCheckEnumerator()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CForceCheckTask_003Ed__60))]
		public Task<CheckResult> ForceCheckTask()
		{
			return null;
		}

		private TimeCheatingDetector StartDetectionInternal(float checkInterval, TimeCheatingDetectorEventHandler cheatCheckedEventHandler = null)
		{
			return null;
		}

		protected override bool Init(TimeCheatingDetector instance, string detectorName)
		{
			return false;
		}

		protected override void StartDetectionAutomatically()
		{
		}

		protected override bool DetectorHasCallbacks()
		{
			return false;
		}

		protected override void PauseDetector()
		{
		}

		protected override void StopDetectionInternal()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckForCheat_003Ed__67))]
		private IEnumerator CheckForCheat()
		{
			return null;
		}

		private void ReportCheckResult()
		{
		}

		public void OnOnlineTimeReceived(OnlineTimeResult result)
		{
		}

		private double GetLocalSecondsUtc()
		{
			return 0.0;
		}

		[Obsolete("Please use GetOnlineTimeCoroutine or GetOnlineTimeTask instead", true)]
		public static double GetOnlineTime(string server)
		{
			return 0.0;
		}

		[Obsolete("Please use Instance.Error event instead.", true)]
		public static void SetErrorCallback(Action<ErrorKind> errorCallback)
		{
		}

		[Obsolete("Please use StartDetection(int, ...) instead.", true)]
		public static void StartDetection(Action detectionCallback, int interval)
		{
		}

		[Obsolete("Please use StartDetection(int, ...) instead.", true)]
		public static void StartDetection(Action detectionCallback, Action<ErrorKind> errorCallback, int interval)
		{
		}

		[Obsolete("Please use other overloads of this method instead", true)]
		public static void StartDetection(float interval, Action detectionCallback, Action<ErrorKind> errorCallback, Action checkPassedCallback)
		{
		}
	}
}
