using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Better.StreamingAssets
{
	public class BSA_TestSceneGUI : MonoBehaviour
	{
		private class CoroutineHost : MonoBehaviour
		{
		}

		private class TestInfo
		{
			public ReadMode readMode;

			public TestType testType;

			public string path;

			public int attempts;

			public Exception error;

			public TimeSpan duration;

			public long bytesRead;

			public long memoryPeak;

			public long maxMemoryPeak;
		}

		private delegate void TestResultDelegate(TimeSpan avgDuration, long avgBytesRead, long avgMemoryPeak, long maxMemoryPeak, string[] assetNames);

		[Flags]
		private enum ReadMode
		{
			BSA = 1,
			WWW = 2,
			Direct = 0x20,
			UnityWebRequest = 0x40
		}

		[Flags]
		private enum TestType
		{
			CheckIfExists = 1,
			LoadBytes = 2
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass26_0
		{
			public TestInfo testInfo;

			internal void _003CTestAllCoroutine_003Eb__0(TimeSpan duration, long bytes, long memory, long maxMemory, string[] names)
			{
			}

			internal void _003CTestAllCoroutine_003Eb__1(Exception ex)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CTestAllCoroutine_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BSA_TestSceneGUI _003C_003E4__this;

			public List<TestInfo> results;

			public IEnumerable<string> paths;

			public ReadMode readModes;

			public TestType testTypes;

			public int attempts;

			private _003C_003Ec__DisplayClass26_0 _003C_003E8__1;

			private string _003ClogPath_003E5__2;

			private IEnumerator<string> _003C_003E7__wrap2;

			private string _003Cpath_003E5__4;

			private IEnumerator _003C_003E7__wrap4;

			private ReadMode _003CreadMode_003E5__6;

			private IEnumerator _003C_003E7__wrap6;

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
			public _003CTestAllCoroutine_003Ed__26(int _003C_003E1__state)
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

			private void _003C_003Em__Finally2()
			{
			}

			private void _003C_003Em__Finally3()
			{
			}

			private void _003C_003Em__Finally4()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CErrorCatchingCoroutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BSA_TestSceneGUI _003C_003E4__this;

			public IEnumerator inner;

			public Action<Exception> onError;

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
			public _003CErrorCatchingCoroutine_003Ed__28(int _003C_003E1__state)
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
		private sealed class _003CTestHarness_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BSA_TestSceneGUI _003C_003E4__this;

			public string path;

			public ReadMode readMode;

			public TestType testType;

			public int attempts;

			public TestResultDelegate callback;

			private Stopwatch _003Cstopwatch_003E5__2;

			private string[] _003CassetNames_003E5__3;

			private string _003CstreamingAssetsUrl_003E5__4;

			private long _003CbytesRead_003E5__5;

			private long _003CmaxMemoryPeak_003E5__6;

			private long _003CtotalMemoryPeaks_003E5__7;

			private int _003Ci_003E5__8;

			private IDisposable _003CtoDispose_003E5__9;

			private long _003CmemoryUnityBefore_003E5__10;

			private WWW _003Cwww_003E5__11;

			private UnityWebRequest _003Cwww_003E5__12;

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
			public _003CTestHarness_003Ed__29(int _003C_003E1__state)
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

		public Text InProgressText;

		public string EditorApkPath;

		public int RepetitionCount;

		public bool LogToFile;

		private string m_status;

		private TestType m_testModes;

		private ReadMode m_readModes;

		private CoroutineHost coroutineHost;

		private Vector2 m_assetsScroll;

		private Vector2 m_resultsScroll;

		private string[] m_allStreamingAssets;

		private List<TestInfo> m_results;

		private HashSet<string> m_selectedPaths;

		private string StreamingAssetsPath => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnGUI()
		{
		}

		private void Initialize()
		{
		}

		private void DoTestTypeToggle(TestType testMode)
		{
		}

		private void DoReadModeToggle(ReadMode readMode)
		{
		}

		[IteratorStateMachine(typeof(_003CTestAllCoroutine_003Ed__26))]
		private IEnumerator TestAllCoroutine(IEnumerable<string> paths, int attempts, ReadMode readModes, TestType testTypes, List<TestInfo> results)
		{
			return null;
		}

		private void LogWorkProgress(string status)
		{
		}

		[IteratorStateMachine(typeof(_003CErrorCatchingCoroutine_003Ed__28))]
		private IEnumerator ErrorCatchingCoroutine(IEnumerator inner, Action<Exception> onError)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CTestHarness_003Ed__29))]
		private IEnumerator TestHarness(ReadMode readMode, string path, TestType testType, int attempts, TestResultDelegate callback)
		{
			return null;
		}
	}
}
