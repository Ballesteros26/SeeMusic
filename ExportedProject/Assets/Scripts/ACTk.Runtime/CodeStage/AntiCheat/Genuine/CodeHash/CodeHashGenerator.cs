using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	[AddComponentMenu(null)]
	[DisallowMultipleComponent]
	public class CodeHashGenerator : KeepAliveBehaviour<CodeHashGenerator>, ICodeHashGenerator
	{
		[CompilerGenerated]
		private sealed class _003CCalculationAwaiter_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CodeHashGenerator _003C_003E4__this;

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
			public _003CCalculationAwaiter_003Ed__20(int _003C_003E1__state)
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

		private readonly WaitForSeconds cachedWaitForSeconds;

		private BaseWorker currentWorker;

		public HashGeneratorResult LastResult { get; private set; }

		public bool IsBusy => false;

		public static event HashGeneratorResultHandler HashGenerated
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

		public static bool IsTargetPlatformCompatible()
		{
			return false;
		}

		public static CodeHashGenerator AddToSceneOrGetExisting()
		{
			return null;
		}

		public static ICodeHashGenerator Generate()
		{
			return null;
		}

		internal static FileFilter[] GetFileFiltersAndroid(bool il2Cpp)
		{
			return null;
		}

		internal static FileFilter[] GetFileFiltersStandaloneWindows(bool il2Cpp)
		{
			return null;
		}

		ICodeHashGenerator ICodeHashGenerator.Generate()
		{
			return null;
		}

		protected override void OnDestroy()
		{
		}

		protected override string GetComponentName()
		{
			return null;
		}

		private ICodeHashGenerator GenerateInternal()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCalculationAwaiter_003Ed__20))]
		private IEnumerator CalculationAwaiter()
		{
			return null;
		}
	}
}
