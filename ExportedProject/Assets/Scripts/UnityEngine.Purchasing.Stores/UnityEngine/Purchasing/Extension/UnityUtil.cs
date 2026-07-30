using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Uniject;

namespace UnityEngine.Purchasing.Extension
{
	[HideInInspector]
	[AddComponentMenu(null)]
	internal class UnityUtil : MonoBehaviour, IUtil
	{
		[CompilerGenerated]
		private sealed class _003CDelayedCoroutine_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int delay;

			public UnityUtil _003C_003E4__this;

			public IEnumerator coroutine;

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
			public _003CDelayedCoroutine_003Ed__48(int _003C_003E1__state)
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

		private static readonly List<Action> s_Callbacks;

		private static bool s_CallbacksPending;

		private static readonly List<RuntimePlatform> s_PcControlledPlatforms;

		private readonly List<Action<bool>> pauseListeners;

		public DateTime currentTime => default(DateTime);

		public string persistentDataPath => null;

		public string deviceUniqueIdentifier => null;

		public string unityVersion => null;

		public string cloudProjectId => null;

		public string userId => null;

		public string gameVersion => null;

		public ulong sessionId => 0uL;

		public RuntimePlatform platform => default(RuntimePlatform);

		public bool isEditor => false;

		public string deviceModel => null;

		public string deviceName => null;

		public DeviceType deviceType => default(DeviceType);

		public string operatingSystem => null;

		public int screenWidth => 0;

		public int screenHeight => 0;

		public float screenDpi => 0f;

		public string screenOrientation => null;

		public T[] GetAnyComponentsOfType<T>() where T : class
		{
			return null;
		}

		object IUtil.InitiateCoroutine(IEnumerator start)
		{
			return null;
		}

		void IUtil.InitiateCoroutine(IEnumerator start, int delay)
		{
		}

		public void RunOnMainThread(Action runnable)
		{
		}

		public object GetWaitForSeconds(int seconds)
		{
			return null;
		}

		private void Start()
		{
		}

		public static T FindInstanceOfType<T>() where T : MonoBehaviour
		{
			return null;
		}

		public static T LoadResourceInstanceOfType<T>() where T : MonoBehaviour
		{
			return null;
		}

		public static bool PcPlatform()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CDelayedCoroutine_003Ed__48))]
		private IEnumerator DelayedCoroutine(IEnumerator coroutine, int delay)
		{
			return null;
		}

		private void Update()
		{
		}

		public void AddPauseListener(Action<bool> runnable)
		{
		}

		public void OnApplicationPause(bool paused)
		{
		}

		public bool IsClassOrSubclass(Type potentialBase, Type potentialDescendant)
		{
			return false;
		}
	}
}
