using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using FfmpegUnity;

public class OKLBLDBDCMD : PBLLPKLFLGE
{
	private sealed class NDOEGKAOJCG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OKLBLDBDCMD _003C_003E4__this;

		public string inputPathAll;

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
		public NDOEGKAOJCG(int _003C_003E1__state)
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

	private AMEOEDIMFKJ GODKDFLJPLO;

	private TextReader PJAPKNPPNJA;

	private Dictionary<int, string> ANFJMEEDLOI;

	public override string JDGOGLPFGAE(int MIPLPPLCFBI, int MHOFONMFCJD, int AOEIBOIKGAL)
	{
		return null;
	}

	public OKLBLDBDCMD(FfmpegPlayerCommand JCNGOPKOPPE)
		: base(null)
	{
	}

	public override TextReader FLNNBCBLAEO(string OIBDLPHOPHK)
	{
		return null;
	}

	public override string NHPKHLEBGIM(int MIPLPPLCFBI, int NHCAHIMBLMD, int GAOEHHFMDGE)
	{
		return null;
	}

	public override void GMEGGFHJIIM(int MIPLPPLCFBI, int NHCAHIMBLMD, int GAOEHHFMDGE)
	{
	}

	public override void PPFPONEEBMO(int MIPLPPLCFBI, int MHOFONMFCJD, int AOEIBOIKGAL)
	{
	}

	public override void DLKIHMMEDOE()
	{
	}

	[IteratorStateMachine(typeof(NDOEGKAOJCG))]
	public override IEnumerator FFMGBLAIOLE(string OIBDLPHOPHK)
	{
		return null;
	}
}
