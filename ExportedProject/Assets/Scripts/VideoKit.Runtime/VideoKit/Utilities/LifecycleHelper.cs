using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VideoKit.Utilities
{
	[DefaultExecutionOrder(-1000)]
	internal sealed class LifecycleHelper : MonoBehaviour, IDisposable
	{
		public event Action onUpdate
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

		public event Action<bool> onPause
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

		public event Action onQuit
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

		public static LifecycleHelper Create()
		{
			return null;
		}

		public void Dispose()
		{
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		private void OnApplicationQuit()
		{
		}
	}
}
