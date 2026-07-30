using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace FfmpegUnity.Sample
{
	public class ShowProgress : MonoBehaviour
	{
		private sealed class BANCLGDEDMA : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShowProgress _003C_003E4__this;

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
			public BANCLGDEDMA(int _003C_003E1__state)
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

		public Text TextUI;

		public FfmpegCommand TargetCommand;

		private IEnumerator GCNBKAGMPEB()
		{
			return null;
		}

		private IEnumerator ICEIILINFHP()
		{
			return null;
		}

		private IEnumerator HDFKKPCNANE()
		{
			return null;
		}

		private IEnumerator NONDGLOAPHH()
		{
			return null;
		}

		private IEnumerator MMMONGBJMCE()
		{
			return null;
		}

		private IEnumerator KKBGMFBFGAA()
		{
			return null;
		}

		private IEnumerator NHCPDAOHBOH()
		{
			return null;
		}

		private IEnumerator IMHGLJPEFCA()
		{
			return null;
		}

		private IEnumerator HOIEMFALFGF()
		{
			return null;
		}

		private IEnumerator MGAGAKHMKGA()
		{
			return null;
		}

		private IEnumerator FDINBCPKJEH()
		{
			return null;
		}

		private IEnumerator CIFBNIIEEPF()
		{
			return null;
		}

		private IEnumerator PNCDECPPAKK()
		{
			return null;
		}

		private IEnumerator ADNCOBKDKHF()
		{
			return null;
		}

		[IteratorStateMachine(typeof(BANCLGDEDMA))]
		private IEnumerator Start()
		{
			return null;
		}
	}
}
