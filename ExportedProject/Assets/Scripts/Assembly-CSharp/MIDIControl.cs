using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using FfmpegUnity;
using ForieroEngine.MIDIUnified;
using ForieroEngine.MIDIUnified.Plugins;
using MakeIt.Random;
using MidiPlayerTK;
using RenderHeads.Media.AVProVideo;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.Video;
using VideoKit;
using VideoKit.Devices;
using VideoKit.Devices.Outputs;

public class MIDIControl : MonoBehaviour
{
	private sealed class GOLJJLGDONI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MIDIControl _003C_003E4__this;

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
		public GOLJJLGDONI(int _003C_003E1__state)
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

	private sealed class OFIOOJACKCN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MIDIControl _003C_003E4__this;

		public bool keepTrackTime;

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
		public OFIOOJACKCN(int _003C_003E1__state)
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

	private sealed class PCEHCLHIDLK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MIDIControl _003C_003E4__this;

		public bool ForceUnity;

		public bool OnlyPerformance;

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
		public PCEHCLHIDLK(int _003C_003E1__state)
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

	private sealed class IGKEKPPEECH
	{
		public MIDIControl _003C_003E4__this;

		public float LocalVideoLoadRequest;

		internal bool DFFEDLJJPON()
		{
			return false;
		}

		internal bool MDBKAGOJPHD()
		{
			return false;
		}
	}

	private sealed class OIOHJMNJKNJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MIDIControl _003C_003E4__this;

		private IGKEKPPEECH _003C_003E8__1;

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
		public OIOHJMNJKNJ(int _003C_003E1__state)
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

	private sealed class MCIJKHBBCDB
	{
		public MIDIControl _003C_003E4__this;

		public float timeWaitStarted;

		internal bool LCGAJGCOBEJ()
		{
			return false;
		}
	}

	private sealed class ANJJHPBLMOF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MIDIControl _003C_003E4__this;

		public float LocalVideoLoadRequest;

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
		public ANJJHPBLMOF(int _003C_003E1__state)
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

	private sealed class FIOFHBDMCNN
	{
		public MediaPlayer mediaPlayer;

		public MIDIControl _003C_003E4__this;

		internal bool JMDADIHPBKI()
		{
			return false;
		}

		internal bool NJCCBIEAMBN()
		{
			return false;
		}

		internal bool MKIFFCEKFLO()
		{
			return false;
		}

		internal bool FOABMEIBMCJ()
		{
			return false;
		}

		internal bool LHDKMIKKCOI()
		{
			return false;
		}

		internal bool PNHGCOPBJHN()
		{
			return false;
		}

		internal bool DDEMNFBBHDF()
		{
			return false;
		}

		internal bool HHCMMENKHDH()
		{
			return false;
		}

		internal bool PFNPCHBFJBO()
		{
			return false;
		}
	}

	private sealed class IBBGMEILGJN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MediaPlayer mediaPlayer;

		public MIDIControl _003C_003E4__this;

		public string filename;

		private FIOFHBDMCNN _003C_003E8__1;

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
		public IBBGMEILGJN(int _003C_003E1__state)
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

	private sealed class BJLABCJIHCL
	{
		public MIDIControl _003C_003E4__this;

		public float timeWaitStarted;

		internal bool IGAIOEDICKN()
		{
			return false;
		}
	}

	private sealed class NMABKNEKNAK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MIDIControl _003C_003E4__this;

		public string soundfontName;

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
		public NMABKNEKNAK(int _003C_003E1__state)
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

	private sealed class MNOIFEHDBEG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MIDIControl _003C_003E4__this;

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
		public MNOIFEHDBEG(int _003C_003E1__state)
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

	private sealed class FNKNIINJPKO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string path;

		public AudioType type;

		public MIDIControl _003C_003E4__this;

		private UnityWebRequest _003Cwww_003E5__2;

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
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private void ICFDPOEDPCK()
		{
		}

		[DebuggerHidden]
		public FNKNIINJPKO(int _003C_003E1__state)
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
	}

	private sealed class LGKNKBDJBGC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string path;

		public AudioType type;

		public MIDIControl _003C_003E4__this;

		private UnityWebRequest _003Cwww_003E5__2;

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

		[DebuggerHidden]
		public LGKNKBDJBGC(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private void ICFDPOEDPCK()
		{
		}
	}

	private sealed class LNAAMINDDJF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MIDIControl _003C_003E4__this;

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
		public LNAAMINDDJF(int _003C_003E1__state)
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

	private sealed class EPKDIJOBHGK
	{
		public MIDIControl _003C_003E4__this;

		public int localSeekRequest;

		internal bool POPMHBBIHAF()
		{
			return false;
		}

		internal bool GPOJIBIAOGL()
		{
			return false;
		}
	}

	private sealed class KACLANEJKHP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MIDIControl _003C_003E4__this;

		public bool disableLogging;

		public bool OptimizedRedraw;

		public bool ResetSynth;

		public bool SpeedRedraw;

		public bool RestoreSelection;

		public bool seekVideo;

		private EPKDIJOBHGK _003C_003E8__1;

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
		public KACLANEJKHP(int _003C_003E1__state)
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

	private sealed class OGKCOFDFBKL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MIDIControl _003C_003E4__this;

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
		public OGKCOFDFBKL(int _003C_003E1__state)
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

	private sealed class DBNHPFPPCNM
	{
		public MIDIControl _003C_003E4__this;

		public bool OverrideRequestCheck;

		public int localSeekRequest;

		internal bool GINBDBGJFOL()
		{
			return false;
		}

		internal bool AEBIFPBDFOB()
		{
			return false;
		}

		internal bool KELEIDAMGEJ()
		{
			return false;
		}

		internal bool IGHNOBOHHMB()
		{
			return false;
		}

		internal bool IIEJDBNFEDP()
		{
			return false;
		}
	}

	private sealed class PMNMPMJLMML
	{
		public float timeWaitStarted;

		public DBNHPFPPCNM CS_0024_003C_003E8__locals1;

		internal bool BPAKGHPCPNG()
		{
			return false;
		}
	}

	private sealed class HNEMABFPEIB
	{
		public double performanceVideoPlayerTimeSet;

		public DBNHPFPPCNM CS_0024_003C_003E8__locals2;
	}

	private sealed class FJLODOACIAK
	{
		public int frameOffset;

		public double frameLength;

		public HNEMABFPEIB CS_0024_003C_003E8__locals3;

		internal bool BIGDOGPLIMP()
		{
			return false;
		}
	}

	private sealed class AFDNPDNIEPI
	{
		public int AVProVideoFrameCount;

		public float timeWaitStarted;

		public FJLODOACIAK CS_0024_003C_003E8__locals4;

		internal bool AFIAFMDCEHL()
		{
			return false;
		}
	}

	private sealed class LOOIICCLCEJ
	{
		public float TimeSeekStarted;

		public HNEMABFPEIB CS_0024_003C_003E8__locals5;

		internal bool DOBGBGEIIMC()
		{
			return false;
		}

		internal bool HJDNCDFPPGA()
		{
			return false;
		}
	}

	private sealed class LPAEALGJLEJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MIDIControl _003C_003E4__this;

		public bool OverrideRequestCheck;

		private PMNMPMJLMML _003C_003E8__1;

		public int videoSeekFrameBuffer;

		private DBNHPFPPCNM _003C_003E8__2;

		private HNEMABFPEIB _003C_003E8__3;

		public bool forcePlay;

		private AFDNPDNIEPI _003C_003E8__4;

		private LOOIICCLCEJ _003C_003E8__5;

		private bool _003CSkipToEnd_003E5__2;

		private int _003Cframe_003E5__3;

		private bool _003CplayVideo_003E5__4;

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
		public LPAEALGJLEJ(int _003C_003E1__state)
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

	private sealed class AHGKKBHKBIF
	{
		[StructLayout((LayoutKind)3)]
		private struct _003C_003CUpdateInputs_003Eb__0_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public AHGKKBHKBIF _003C_003E4__this;

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
		private struct _003C_003CUpdateInputs_003Eb__1_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public AHGKKBHKBIF _003C_003E4__this;

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

		public MIDIControl _003C_003E4__this;

		public bool initialUpdate;

		[AsyncStateMachine(typeof(_003C_003CUpdateInputs_003Eb__0_003Ed))]
		internal Task KPAEGPKKLJM()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003C_003CUpdateInputs_003Eb__1_003Ed))]
		internal Task BKMJOAKIEGD()
		{
			return null;
		}

		internal void LCIFOBNCKPJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct HLHKBMBALPG : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MIDIControl _003C_003E4__this;

		public bool initialUpdate;

		private AHGKKBHKBIF _003C_003E8__1;

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

	private sealed class PPFANNEEBHB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MIDIControl _003C_003E4__this;

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
		public PPFANNEEBHB(int _003C_003E1__state)
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
	private struct HMDIJBBDMKE : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MIDIControl _003C_003E4__this;

		private TaskAwaiter<AudioDevice[]> _003C_003Eu__1;

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
	private struct HLCGJFOKEBK : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MIDIControl _003C_003E4__this;

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

	private sealed class IBEPDENCEBI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MIDIControl _003C_003E4__this;

		private bool _003CMIDIInputActive_003E5__2;

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
		public IBEPDENCEBI(int _003C_003E1__state)
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
	private struct OOJDFECJLOJ : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MIDIControl _003C_003E4__this;

		private TaskAwaiter<AudioDevice[]> _003C_003Eu__1;

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
	private struct BGFAEHBENMP : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MIDIControl _003C_003E4__this;

		private TaskAwaiter<MediaDevice.PermissionStatus> _003C_003Eu__1;

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
	private struct FHAGDNHBGOL : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MIDIControl _003C_003E4__this;

		private TaskAwaiter<MediaDevice.PermissionStatus> _003C_003Eu__1;

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
	private struct EIDMNALFADG : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MIDIControl _003C_003E4__this;

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
	private struct LBCPFPJMOCL : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MIDIControl _003C_003E4__this;

		private TaskAwaiter<AudioDevice[]> _003C_003Eu__1;

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
	private struct ECPBGKEEIMP : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MIDIControl _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CameraDevice[]> _003C_003Eu__2;

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

	private sealed class OLAPAKNCNPJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MIDIControl _003C_003E4__this;

		private int _003Ci_003E5__2;

		private uint _003CcolorInt_003E5__3;

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
		public OLAPAKNCNPJ(int _003C_003E1__state)
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

	private sealed class MKLIGHLMEBI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MIDIControl _003C_003E4__this;

		private int _003Ci_003E5__2;

		private uint _003CcolorInt_003E5__3;

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
		public MKLIGHLMEBI(int _003C_003E1__state)
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

	private sealed class NNGEKECLCJI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MIDIControl _003C_003E4__this;

		private int _003Ci_003E5__2;

		private uint _003CcolorInt_003E5__3;

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
		public NNGEKECLCJI(int _003C_003E1__state)
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

	private sealed class MEDEELGKCOC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public uint integer;

		public MIDIControl _003C_003E4__this;

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
		public MEDEELGKCOC(int _003C_003E1__state)
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

	private sealed class KJLLCKFCLPF
	{
		public FfmpegCommand FFMpegComponent;

		public float timeStarted;

		internal bool ALNLHCMBJCC()
		{
			return false;
		}

		internal bool PGBDEHHLNKJ()
		{
			return false;
		}
	}

	private sealed class LGLKIKLPNHH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MIDIControl _003C_003E4__this;

		public float StartTime;

		public float EndTime;

		public string VideoPath;

		private KJLLCKFCLPF _003C_003E8__1;

		private string _003COutputPath_003E5__2;

		private UnityWebRequest _003Cwww_003E5__3;

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

		private void ICFDPOEDPCK()
		{
		}

		[DebuggerHidden]
		public LGLKIKLPNHH(int _003C_003E1__state)
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
		void IDisposable.Dispose()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private sealed class EJNHNGHLBHE
	{
		public FfmpegCommand FFMpegComponent;

		public float timeStarted;

		internal bool POFEEIOICJP()
		{
			return false;
		}

		internal bool FKPMMAHAOKA()
		{
			return false;
		}
	}

	private sealed class HNPFMJNAIAJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MIDIControl _003C_003E4__this;

		public float StartTime;

		public float EndTime;

		public string AudioPath;

		private EJNHNGHLBHE _003C_003E8__1;

		private string _003COutputPath_003E5__2;

		private UnityWebRequest _003Cwww_003E5__3;

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
		void IDisposable.Dispose()
		{
		}

		[DebuggerHidden]
		public HNPFMJNAIAJ(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		private void ICFDPOEDPCK()
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
	}

	[StructLayout((LayoutKind)3)]
	private struct FAMENKBCJOG : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MIDIControl _003C_003E4__this;

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
	private struct DOOOAJMCLGC : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MIDIControl _003C_003E4__this;

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
	private struct BDLLDDAFLAO : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MIDIControl _003C_003E4__this;

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

	private static MIDIControl JOHCOGCAEAK;

	[CompilerGenerated]
	private static MIDIControl _003CHOLNFGBMPDC_003Ek__BackingField;

	public SceneSingleton SceneSingleton;

	public Account Account;

	public UIManager UIManager;

	public NoteAnimation NoteAnimation;

	public BarAnimation BarAnimation;

	public KeyboardAnimation KeyboardAnimation;

	public ParticleAnimation ParticleAnimation;

	public Background Background;

	public LiveCamera LiveCamera;

	public NoteOperations NoteOperations;

	[NonSerialized]
	public int startMidiIndex;

	public MidiSequencer sequencer;

	public MidiSequencer pianoRollNotesSequencer;

	public MidiSequencer createVideoAudioSequencer;

	[NonSerialized]
	public bool MIDILoaded;

	[NonSerialized]
	public bool audioLoaded;

	[NonSerialized]
	public bool videoLoaded;

	[NonSerialized]
	public bool ForceRotateVideo;

	[NonSerialized]
	public FFLDNBHEPGD midiEvents;

	[NonSerialized]
	public FFLDNBHEPGD sequencerMidiEvents;

	[NonSerialized]
	public MidiEvents externalMidiEvents;

	public AudioSource audioSource;

	public AudioSource videoAudioSource;

	public VideoPlayer performanceVideoPlayer;

	public MediaPlayer performanceMediaPlayer;

	public MediaPlayer saberMediaPlayer;

	public MediaPlayer textureMediaPlayer;

	public ApplyToMesh PerformanceApplyToMesh;

	public RenderHeads.Media.AVProVideo.AudioOutput PerformanceAudioOutput;

	[NonSerialized]
	public float trackTime;

	[NonSerialized]
	public float timeTrackStarted;

	[NonSerialized]
	public float trackStartPosition;

	[NonSerialized]
	public float timeSinceStartup;

	[NonSerialized]
	public float trackLength;

	[NonSerialized]
	public bool atEndOfTrack;

	[NonSerialized]
	public float savedTrackTime;

	[NonSerialized]
	public float trackRenderStartTime;

	[NonSerialized]
	public float trackRenderEndTime;

	[NonSerialized]
	public float trackRenderDuration;

	[NonSerialized]
	public float timeRecordingStarted;

	[NonSerialized]
	public int MIDISoundOn;

	[NonSerialized]
	public int AudioSoundOn;

	[NonSerialized]
	public List<MGFGDCEJHGB> MIDIFiles;

	[NonSerialized]
	public List<MGFGDCEJHGB> audioFiles;

	[NonSerialized]
	public List<MGFGDCEJHGB> videoFiles;

	[NonSerialized]
	public List<MGFGDCEJHGB> saberVideoFiles;

	[NonSerialized]
	public List<MGFGDCEJHGB> noteTextureFiles;

	[NonSerialized]
	public List<MGFGDCEJHGB> soundfontFiles;

	[NonSerialized]
	public List<MGFGDCEJHGB> backgroundFiles;

	[NonSerialized]
	public List<string> SampleMIDINames;

	[NonSerialized]
	public List<string> SampleAudioNames;

	[NonSerialized]
	public List<string> SampleVideoNames;

	[NonSerialized]
	public List<string> SampleSoundfontNames;

	[NonSerialized]
	public List<string> SampleSaberVideoNames;

	[NonSerialized]
	public List<string> SampleNoteTextureNames;

	[NonSerialized]
	public float volume;

	[NonSerialized]
	public IHNIEDPLGGC[] MIDIOnOffArray;

	[NonSerialized]
	public IHNIEDPLGGC[] NotesOnOffArray;

	[NonSerialized]
	public int[] KeyboardOnOffArray;

	[NonSerialized]
	public int[] KeyboardRandomChannelArray;

	[NonSerialized]
	public int RandomChannelSeed;

	[NonSerialized]
	public float[] AveragesArray;

	[NonSerialized]
	public List<float[]> AveragesHistoryList;

	[NonSerialized]
	public float[] ColorPercentIntensities;

	[NonSerialized]
	public List<Color> BackgroundColorHistoryList;

	[NonSerialized]
	public List<Color> DynamicColorHistoryList;

	[NonSerialized]
	public bool sustainPedalOn;

	[NonSerialized]
	public int numNotes;

	[NonSerialized]
	public float noteCountAge;

	[NonSerialized]
	public int numNotesLimit;

	[NonSerialized]
	public List<float[]> NoteCountList;

	[NonSerialized]
	public float[] lastSixFrames;

	[NonSerialized]
	public List<MGFGDCEJHGB> MIDIInputs;

	[NonSerialized]
	public List<MGFGDCEJHGB> AudioInputs;

	[NonSerialized]
	public List<MGFGDCEJHGB> VideoInputs;

	[NonSerialized]
	public int selectedMIDIInput;

	[NonSerialized]
	public int selectedAudioInput;

	[NonSerialized]
	public int selectedVideoInput;

	[NonSerialized]
	public string SelectedMIDIInputName;

	[NonSerialized]
	public string SelectedAudioInputName;

	[NonSerialized]
	public string SelectedVideoInputName;

	public MidiStreamPlayer midiStreamPlayer;

	[NonSerialized]
	public float TimePlayStarted;

	[NonSerialized]
	public float TimeAtStart;

	[NonSerialized]
	private bool KAJLHAKAEIB;

	[NonSerialized]
	public int VirtualPortIndex;

	[NonSerialized]
	public int OutPortIndex;

	[NonSerialized]
	public string ChannelOutDeviceName;

	[NonSerialized]
	public bool MIDIControlStarted;

	[NonSerialized]
	public bool MIDIEventsInitialized;

	public bool updating;

	public int DebugCounter;

	private AudioClip MNICELEFEBK;

	private VideoClip GFKNDFDDBBG;

	[NonSerialized]
	private byte[] FEAEFLBCDEK;

	[NonSerialized]
	public bool loading;

	[NonSerialized]
	public bool loadingAudio;

	[NonSerialized]
	public bool loadingVideo;

	[NonSerialized]
	public bool videoLoadFailed;

	[NonSerialized]
	public bool videoStarted;

	[NonSerialized]
	private DIHCMBAGGGN ANLAMHNBEPD;

	public MeshRenderer performanceVideoRenderer;

	public MeshRenderer saberVideoRenderer;

	public MeshRenderer textureVideoRenderer;

	public bool loadingSoundfont;

	private bool FHIOHEHIGLE;

	[NonSerialized]
	private bool BDHMBBFGCNN;

	[NonSerialized]
	public bool seeking;

	[NonSerialized]
	public bool videoSeekCompleted;

	[NonSerialized]
	public bool actualVideoSeekCompleted;

	[NonSerialized]
	public bool actualSaberSeekCompleted;

	[NonSerialized]
	public bool actualTextureSeekCompleted;

	[NonSerialized]
	public bool disableSeekLogging;

	[NonSerialized]
	public int seekRequest;

	[NonSerialized]
	public int performanceVideoSeekFrame;

	[NonSerialized]
	public int performanceVideoFrame;

	[NonSerialized]
	public bool videoPreparedForStart;

	[NonSerialized]
	public bool SeekingUnityVideo;

	[NonSerialized]
	public bool videoFrameReady;

	[NonSerialized]
	public MLOEJPEOEDH MIDIRecordingEventCollection;

	[NonSerialized]
	public float recordingStartTime;

	[NonSerialized]
	public AudioDevice audioRecordingDevice;

	[NonSerialized]
	public string audioRecordingPath;

	[NonSerialized]
	public bool audioRecordingBufferReceived;

	[NonSerialized]
	public bool hasMicrophonePermissionInfo;

	[NonSerialized]
	public bool microphonePermissionGranted;

	[NonSerialized]
	public bool hasCameraPermissionInfo;

	[NonSerialized]
	public bool cameraPermissionGranted;

	[NonSerialized]
	public bool AudioRecordingStartComplete;

	[NonSerialized]
	public bool VideoRecordingStartComplete;

	[NonSerialized]
	private AudioClipOutput MNDAHEFHKFE;

	public VideoKitRecorder VideoRecorder;

	[NonSerialized]
	private bool MCPKICKIIGF;

	[NonSerialized]
	private bool FIMEJIMPDOP;

	[NonSerialized]
	private bool CNCFKAJGIAD;

	[NonSerialized]
	private bool KABIKIEBEFO;

	[NonSerialized]
	public bool UpdatingAudioInputs;

	[NonSerialized]
	public bool UpdatingVideoInputs;

	[NonSerialized]
	public bool GettingAudioInputs;

	[NonSerialized]
	private IRandom FDMJDAHFKBD;

	[NonSerialized]
	private int FDJOOHMFDOA;

	[NonSerialized]
	private float BNJFIHENCIE;

	[NonSerialized]
	public List<EJPLHFGGPBL> DelayedNoteEvents;

	public List<EJPLHFGGPBL> DelayedSustainEvents;

	[NonSerialized]
	private IRandom CNDHEJLPIPA;

	[NonSerialized]
	private IRandom AHCPKBINFME;

	private int OFNCFIECKMN;

	private float[] PHPDACDPIDJ;

	private float FPIAHFCMLOA;

	private float CGDJKAAFLCO;

	private float KCOAJONEPHB;

	private SerialPort KJGLPBNEOJF;

	public bool ArduinoStarted;

	private bool HDLCEJJFOOH;

	private float PHENMMCHKGD;

	private float LJIFHKFDMHL;

	[NonSerialized]
	public AudioClip ConvertedVideoAudioClip;

	[NonSerialized]
	public List<GameObject> FFMpegObjects;

	[NonSerialized]
	public bool FFMpegCompleted;

	[NonSerialized]
	public bool FFMpegSuccessful;

	[NonSerialized]
	public AudioClip ConvertedAudioClip;

	public static MIDIControl Instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	[CompilerGenerated]
	private void CEHGMGPMHGF()
	{
	}

	public void ClearDynamicColorHistory()
	{
	}

	private void MJEPBEHAAME(VideoPlayer KIKPMNCJDFF, string EDCDFNFGDDK)
	{
	}

	public float GetPianoRollSequencerTime()
	{
		return 0f;
	}

	public void ReceiveNoteOff(int EIIMHMFAEBB, int IIBKBKAKFBA, int MDFFKJEOFMC)
	{
	}

	[IteratorStateMachine(typeof(IBBGMEILGJN))]
	public IEnumerator LoadAVProVideo(string OMKOADDLAMJ, MediaPlayer PCHJGNKHLOE)
	{
		return null;
	}

	[AsyncStateMachine(typeof(BDLLDDAFLAO))]
	[CompilerGenerated]
	private Task DGPJOOMHNPN()
	{
		return null;
	}

	public void ReadMIDIDirectory()
	{
	}

	[IteratorStateMachine(typeof(OGKCOFDFBKL))]
	public IEnumerator NextVideoFrame()
	{
		return null;
	}

	public void ReadSampleSoundfontDirectory()
	{
	}

	[IteratorStateMachine(typeof(FNKNIINJPKO))]
	private IEnumerator GFHFOEDMFCL(string LNMDPMBMJBI, AudioType GFMIKEPFCLG)
	{
		return null;
	}

	[IteratorStateMachine(typeof(OIOHJMNJKNJ))]
	public IEnumerator LoadVideo()
	{
		return null;
	}

	public void SelectAudioInput()
	{
	}

	public string GetMIDIPath()
	{
		return null;
	}

	public void DDMGHNGFMFE()
	{
	}

	public void ACOOLFOINEP(int BAPFCKDMEMA, int GMAOPOKAOJO)
	{
	}

	public IEnumerator NKCEJBAEBAA()
	{
		return null;
	}

	public void KBPCCHCKCIM()
	{
	}

	public void SeekToFrameRelativeAVPro(MediaPlayer PCHJGNKHLOE, float JFLDFIDDJLF)
	{
	}

	public void CheckColorSaveTime()
	{
	}

	public void KeyboardPedalOffHandler(PedalEnum EGNCIMCBNGJ, int BAPFCKDMEMA, int GMAOPOKAOJO)
	{
	}

	public float GetRecordingSeconds()
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(MKLIGHLMEBI))]
	public IEnumerator UpdateArduinoChannelColors()
	{
		return null;
	}

	public void ColorizeBackground()
	{
	}

	[AsyncStateMachine(typeof(ECPBGKEEIMP))]
	public Task UpdateVideoInputAsync()
	{
		return null;
	}

	public IEnumerator DEMLMKLKKFC()
	{
		return null;
	}

	public void EFPIBPECGDM(ControllerEnum LEHHLJGBGPK, int BAPFCKDMEMA, int GMAOPOKAOJO)
	{
	}

	public void UseMIDIJackUpdate()
	{
	}

	public void PNIJBFCCNFJ()
	{
	}

	public void LogDelayedSustainEvent(float JNIEKBDGFHN)
	{
	}

	public float BDDDAONILPK()
	{
		return 0f;
	}

	public void MODAMPIGCNG(int KHDFEOMPNOJ)
	{
	}

	public IEnumerator MFKFEMAIMHP(bool OAOFLJIFDHB = true, bool IKHHHEGMNEI = true, bool PDKBJJEFBCG = false, bool IDHCHNJOPFF = true, bool MADDBMIDGBJ = false, bool NCHAKAKGAFA = true)
	{
		return null;
	}

	public void DFJNFCAOCMM()
	{
	}

	private void Awake()
	{
	}

	public void ForwardRandomChannelNote(BPLHJJGKANA GGGJGHMNCIE, int MDFFKJEOFMC)
	{
	}

	public void KABIENKALDF(float INOCNHBFJAC)
	{
	}

	public void StartVideosAfterSeek()
	{
	}

	public void processDynamicColor()
	{
	}

	[CompilerGenerated]
	private void MHCKLKPFLGI()
	{
	}

	public double GetAudioStartTime()
	{
		return 0.0;
	}

	public float GetTimeDiff(float CCKIOGLFDBF)
	{
		return 0f;
	}

	public double DDFHGDLIFIA()
	{
		return 0.0;
	}

	public float GetCurrentVideoTime()
	{
		return 0f;
	}

	public void POOBGCMGLGE(int BAPFCKDMEMA, int GMAOPOKAOJO)
	{
	}

	private bool DHOKADJKINO()
	{
		return false;
	}

	[IteratorStateMachine(typeof(GOLJJLGDONI))]
	public IEnumerator StartMIDIControl()
	{
		return null;
	}

	public void JODDHNFLGAP()
	{
	}

	public string GetSaberVideoPath()
	{
		return null;
	}

	public void SelectVideoInput()
	{
	}

	public void CountNotes()
	{
	}

	public void OGONEKGIDEC(float EBNEKOBBMPI)
	{
	}

	public void ReadSampleVideoDirectory()
	{
	}

	public void KeyboardPedalOff(int BAPFCKDMEMA, int GMAOPOKAOJO)
	{
	}

	public void FLEDBKCPAGL()
	{
	}

	[CompilerGenerated]
	private void FOLMMJHJNOC()
	{
	}

	[IteratorStateMachine(typeof(ANJJHPBLMOF))]
	public IEnumerator ExtraPreparePerformanceVideo(float CMBMINCHBIC)
	{
		return null;
	}

	public void TrackFinished(bool IKGNLCMDLFL = false)
	{
	}

	[CompilerGenerated]
	private bool FJNKHDGMKCH()
	{
		return false;
	}

	public void EDPFBJPNCDN()
	{
	}

	private Task IFDMMBGOJLJ()
	{
		return null;
	}

	public void UpdateMIDIInputs()
	{
	}

	public bool PALHGPBJADC()
	{
		return false;
	}

	public IEnumerator LLHDDIIEICE(string HIBCHKNFOHK, float NLMGJCPLOJA, float LDMPIPICHCL)
	{
		return null;
	}

	public void UpdateTime()
	{
	}

	public double GetVideoLength()
	{
		return 0.0;
	}

	public void SetVolume(bool AKCKIOBFJGA = false)
	{
	}

	public IEnumerator FMDBBCKELHI()
	{
		return null;
	}

	public float[] GetSamplesFromClip(AudioClip MNICELEFEBK, float NLMGJCPLOJA, float LDMPIPICHCL)
	{
		return null;
	}

	public void StopTrack()
	{
	}

	public void SetSustainFromTrack()
	{
	}

	private Task CPKMFBDEAGF()
	{
		return null;
	}

	public void KMNNMEMPIPJ()
	{
	}

	public void NIJPMEBLMHD()
	{
	}

	public void CBALOJJAKKE()
	{
	}

	[AsyncStateMachine(typeof(FHAGDNHBGOL))]
	private Task EPPMFFBLNLH()
	{
		return null;
	}

	public void OnPerformanceMediaPlayerEvent(MediaPlayer PCHJGNKHLOE, MediaPlayerEvent.EventType PDBNDPAAECJ, ErrorCode NAMIMDONICF)
	{
	}

	public int RandomChannelFromValue(float OJBEMNFOIKL)
	{
		return 0;
	}

	public float[] ALDHDFBCECL(AudioClip MNICELEFEBK, float NLMGJCPLOJA, float LDMPIPICHCL)
	{
		return null;
	}

	public double GetVideoFramerate()
	{
		return 0.0;
	}

	public void CHELOPLODCJ()
	{
	}

	public bool VideoStreamingAssetExists()
	{
		return false;
	}

	public void TurnOnVideo()
	{
	}

	[CompilerGenerated]
	private bool EFDOBIGHDMJ()
	{
		return false;
	}

	public double GetVideoStartTime()
	{
		return 0.0;
	}

	public void DeviceDisconnected(MidiDevice PMJDHPFJNHN)
	{
	}

	public void AOABKMJENAF()
	{
	}

	public void CheckSliderNAN(Slider HINADDIAGOI)
	{
	}

	[CompilerGenerated]
	private void ECCBEODBLNJ()
	{
	}

	private void FPMHJAGFAJB()
	{
	}

	public void LogDelayedNoteEvent(float KHDFEOMPNOJ, float JNIEKBDGFHN)
	{
	}

	public void LCLIKDCFKOP()
	{
	}

	public void PDFPEAMNCMB()
	{
	}

	public void SetTrackLength()
	{
	}

	public bool FlipVideo()
	{
		return false;
	}

	public IEnumerator BIKLOAKMGEC(string OMKOADDLAMJ, MediaPlayer PCHJGNKHLOE)
	{
		return null;
	}

	public void ReadSampleAudioDirectory()
	{
	}

	public void CustomNoteOnHandler(OIIOKADEOMG GIBBPAFCIDF, string HHHMHDLGBGC, int BELKMNKKAMM, bool NIFLPDOJPHK = false, int EFJHPCNDHIF = 0)
	{
	}

	public void SetSynthSustain(bool OJDFGGFLOBH, int JNIEKBDGFHN = 127)
	{
	}

	[CompilerGenerated]
	private bool KNDMFMICEKB()
	{
		return false;
	}

	[CompilerGenerated]
	private void CGEIOFGHBKA()
	{
	}

	public void LIKEAJEIBBO(float KHDFEOMPNOJ, float JNIEKBDGFHN)
	{
	}

	public void PauseVideosBeforeSeek()
	{
	}

	public void MOMACKPCEJC(float JNIEKBDGFHN)
	{
	}

	public void SendVirtualDynamicColorOut()
	{
	}

	public string KDHAFAJGABE()
	{
		return null;
	}

	public void AKIFHCENDIE()
	{
	}

	public float GetMainSequencerPRTime()
	{
		return 0f;
	}

	public void KeyboardNoteOffHandler(int EIIMHMFAEBB, int IIBKBKAKFBA, int MDFFKJEOFMC)
	{
	}

	[AsyncStateMachine(typeof(OOJDFECJLOJ))]
	private void DIEHFKHAFHN()
	{
	}

	public AudioClip SetSampleRate(AudioClip JJFBBNNEFLA, int HAPGCKHFAGD)
	{
		return null;
	}

	public void EGPPNCHDCFF()
	{
	}

	public void StartMIDIRecording()
	{
	}

	public float DEKDNBPGBFA()
	{
		return 0f;
	}

	public void EOPKNBHGOFN()
	{
	}

	public void ReadSampleMIDIDirectory()
	{
	}

	[CompilerGenerated]
	private void FAINFHKKEGL()
	{
	}

	public void StopAudioRecording()
	{
	}

	public void EFJCMOHENHG(MediaPlayer PCHJGNKHLOE, float JFLDFIDDJLF)
	{
	}

	private void LMNFPCNDHDJ()
	{
	}

	public IEnumerator IECDHKLOHDB(uint FLPEKHBCEEI)
	{
		return null;
	}

	public void UpdateTimeLabels()
	{
	}

	public bool CBAMGPOGMPP(IntPtr OMDIEPPFLJK, MediaPlayer PCHJGNKHLOE)
	{
		return false;
	}

	public bool GGDDKBKILKF()
	{
		return false;
	}

	public void KeyboardPedalOn(int BAPFCKDMEMA, int GMAOPOKAOJO)
	{
	}

	public IEnumerator OHPBBEKENDM(string HMOEINJAFBG)
	{
		return null;
	}

	public bool BCNCGINEKNP()
	{
		return false;
	}

	public void UpdateArduinoColors()
	{
	}

	public bool NoAudioEnabled()
	{
		return false;
	}

	[IteratorStateMachine(typeof(MNOIFEHDBEG))]
	public IEnumerator UpdateTempo()
	{
		return null;
	}

	[IteratorStateMachine(typeof(PCEHCLHIDLK))]
	public IEnumerator SwitchVideoFrameworks(bool LFHGGKGEOBL = false, bool LMENGNFOPMB = false)
	{
		return null;
	}

	public void ReadAudioDirectory()
	{
	}

	[CompilerGenerated]
	private void ECKIAGEKIOF()
	{
	}

	private void IDNLHODOLJL()
	{
	}

	public void GNLOOCKFNBH(AudioClip MNICELEFEBK, string OMKOADDLAMJ)
	{
	}

	public void VideoSeekCompleted(VideoPlayer KIKPMNCJDFF)
	{
	}

	public void CheckPlaybackSliders()
	{
	}

	[CompilerGenerated]
	private bool DIPKIJGGKLH()
	{
		return false;
	}

	public void BBALLADNFFK(MediaPlayer PCHJGNKHLOE, float JFLDFIDDJLF)
	{
	}

	public void SendDynamicColorToArduino()
	{
	}

	public IEnumerator DALADPBODCO()
	{
		return null;
	}

	[CompilerGenerated]
	private bool PJBGHCCOIBH()
	{
		return false;
	}

	public void PFNNGAKIAMJ()
	{
	}

	public float JCLMLAFPMHN()
	{
		return 0f;
	}

	[AsyncStateMachine(typeof(HLHKBMBALPG))]
	public void UpdateInputs(bool HOJMBCACNML = false)
	{
	}

	public double GetAudioCurrentTime()
	{
		return 0.0;
	}

	public void RedrawVisuals(bool PDKBJJEFBCG = false, bool IDHCHNJOPFF = true, bool MADDBMIDGBJ = false, bool NCHAKAKGAFA = true)
	{
	}

	[IteratorStateMachine(typeof(LPAEALGJLEJ))]
	public IEnumerator SeekPerformanceVideoTime(int MPCELEFJCIO = 0, bool OAJGPJBKAHH = false, bool BHPNPDBFGBP = false)
	{
		return null;
	}

	public bool DGEONKAFCHD()
	{
		return false;
	}

	public void OOGPEKHHNOI()
	{
	}

	public void AudioInputScrollerAction(int AOCGNPPGDCO)
	{
	}

	public void ReadSaberVideoDirectory()
	{
	}

	public void LoadVideos()
	{
	}

	public void EPPHKOIKIFB()
	{
	}

	public void MIDINoteReceived(float HEAGGEPEIME, float KHDFEOMPNOJ, float JNIEKBDGFHN, int BELKMNKKAMM, bool NIFLPDOJPHK, float DLHLFANAOPO = 0f, float CBGDKAKOEOD = -1f, float HIGEFPMJMAO = -1f, bool GCPAENGMCPD = false, bool FELNLNCIABN = false, OIIOKADEOMG GIBBPAFCIDF = null, bool FKCDPGGPNEG = false)
	{
	}

	public void VideoInputScrollerAction(int AOCGNPPGDCO)
	{
	}

	public IEnumerator MFAACCHJOBH()
	{
		return null;
	}

	public void UpdateArduinoColorMode()
	{
	}

	public void FixedUpdate()
	{
	}

	[AsyncStateMachine(typeof(BGFAEHBENMP))]
	private Task BKEGKIIMHCI()
	{
		return null;
	}

	public void SoftPedalHandler(ControllerEnum LEHHLJGBGPK, int BAPFCKDMEMA, int GMAOPOKAOJO)
	{
	}

	public void AJPCHBHDFDG()
	{
	}

	public IEnumerator NPLBJMCBFPJ()
	{
		return null;
	}

	public IEnumerator MAFPBECGIPM()
	{
		return null;
	}

	[IteratorStateMachine(typeof(HNPFMJNAIAJ))]
	public IEnumerator ConvertAudioToWav(string HIBCHKNFOHK, float NLMGJCPLOJA, float LDMPIPICHCL)
	{
		return null;
	}

	public IEnumerator NBJLLDCCENK()
	{
		return null;
	}

	public bool SaberStreamingAssetExists()
	{
		return false;
	}

	public void StartArduino()
	{
	}

	public void ACIHEJCCLAH()
	{
	}

	public void ReadVideoDirectory()
	{
	}

	public void PointIntPtr(IntPtr HMCCIFLDKNP, MediaPlayer PCHJGNKHLOE)
	{
	}

	public float GetVideoTime()
	{
		return 0f;
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(FAMENKBCJOG))]
	private Task BHDAOMDDLNN()
	{
		return null;
	}

	public void OOMHCBEAGBJ(AudioClip MNICELEFEBK, string OMKOADDLAMJ)
	{
	}

	private void HDLJOFMJEEM()
	{
	}

	public void KeyboardNoteOnHandler(int EIIMHMFAEBB, int IIBKBKAKFBA, int MDFFKJEOFMC)
	{
	}

	public IEnumerator BNIKLNKINKL(string HIBCHKNFOHK, float NLMGJCPLOJA, float LDMPIPICHCL)
	{
		return null;
	}

	public void LoadMIDI(bool OAOFLJIFDHB = false, bool CLNGAJHMKDM = false, bool NCHAKAKGAFA = true)
	{
	}

	public int POBALCGHIEG(double JKDIJJBDDID)
	{
		return 0;
	}

	public void LMNNGKMNLJB()
	{
	}

	private bool IAAOIPADMFP()
	{
		return false;
	}

	public void ReadSampleNoteTextureDirectory()
	{
	}

	public void BMCIAALDNIP()
	{
	}

	public void UpdateTrackTime()
	{
	}

	[AsyncStateMachine(typeof(LBCPFPJMOCL))]
	private Task MIPLADDFBHI()
	{
		return null;
	}

	public double FNLFONEJBPG()
	{
		return 0.0;
	}

	public void OEIOACGGANM()
	{
	}

	[CompilerGenerated]
	private void ECNKHHDPEOK()
	{
	}

	public void ClearSynth()
	{
	}

	public void KeyboardControllerEventMPTK(MPTKController LEHHLJGBGPK, int BAPFCKDMEMA, int GMAOPOKAOJO)
	{
	}

	public void UpdateNumberOfTracks()
	{
	}

	public void StopMIDIRecording()
	{
	}

	public IEnumerator NNOGCBOLOMI(bool OAOFLJIFDHB = true, bool IKHHHEGMNEI = true, bool PDKBJJEFBCG = false, bool IDHCHNJOPFF = true, bool MADDBMIDGBJ = false, bool NCHAKAKGAFA = true)
	{
		return null;
	}

	public void SetPerformanceVideoOpacity(float EBNEKOBBMPI)
	{
	}

	public string GetPerformanceVideoPath()
	{
		return null;
	}

	public void VideoFrameReady(VideoPlayer KIKPMNCJDFF, long PBPICCABKEL)
	{
	}

	[AsyncStateMachine(typeof(HLCGJFOKEBK))]
	public void StartVideoRecording()
	{
	}

	public void CustomControlChangeEventHandler(KJFHBOAEEMO LGDCCAOFJBE, string HHHMHDLGBGC, int BELKMNKKAMM, bool NIFLPDOJPHK = false)
	{
	}

	public float GetSliderTimeValue()
	{
		return 0f;
	}

	public double GetVideoFrameLength()
	{
		return 0.0;
	}

	public bool OverrideToUnityVideo()
	{
		return false;
	}

	[IteratorStateMachine(typeof(NNGEKECLCJI))]
	public IEnumerator UpdateArduinoGradientColors()
	{
		return null;
	}

	public void MIDIInputScrollerAction(int AOCGNPPGDCO)
	{
	}

	[CompilerGenerated]
	private bool NACGMNIFDMK()
	{
		return false;
	}

	public IEnumerator EJLDNBLBFOL(uint FLPEKHBCEEI)
	{
		return null;
	}

	public void SetRandomChannelForPitch(int KHDFEOMPNOJ)
	{
	}

	public void ReloadFiles()
	{
	}

	[IteratorStateMachine(typeof(IBEPDENCEBI))]
	public IEnumerator CheckInputConnectionsForRecording()
	{
		return null;
	}

	[IteratorStateMachine(typeof(LGKNKBDJBGC))]
	private IEnumerator BELGGFCNEFI(string LNMDPMBMJBI, AudioType GFMIKEPFCLG)
	{
		return null;
	}

	private bool JGCGLPPKAMM()
	{
		return false;
	}

	public void UpdateVideoSound()
	{
	}

	private void FCKPEACKNKD()
	{
	}

	public void PDFGHNLODIG()
	{
	}

	[IteratorStateMachine(typeof(OFIOOJACKCN))]
	public IEnumerator LoadTrack(bool JAHGDNMBPDF = false)
	{
		return null;
	}

	public IEnumerator HMPOAJFEODM(uint FLPEKHBCEEI)
	{
		return null;
	}

	[CompilerGenerated]
	private void IAGEBPHEAPG()
	{
	}

	public void ReadDelayedEvents()
	{
	}

	public float TrackTimeFromSequencerTime(float PKECNBPACFO)
	{
		return 0f;
	}

	public Task KGIMPLMAPBK()
	{
		return null;
	}

	[CompilerGenerated]
	private void GEOFFHJIKIN()
	{
	}

	public void KeyboardControllerEvent(ControllerEnum LEHHLJGBGPK, int BAPFCKDMEMA, int GMAOPOKAOJO)
	{
	}

	public void SelectMIDIInput()
	{
	}

	private void OBCCDIPMCMN()
	{
	}

	public void UpdateAnimation()
	{
	}

	public void UpdateSynthReverb()
	{
	}

	public void ReadSampleSaberVideoDirectory()
	{
	}

	public IEnumerator MFHLNNCPNHM(string HMOEINJAFBG)
	{
		return null;
	}

	[IteratorStateMachine(typeof(PPFANNEEBHB))]
	public IEnumerator StartAudioRecording()
	{
		return null;
	}

	public void CheckStartAudio()
	{
	}

	public void ODJOCMAKBLL()
	{
	}

	private void OKPNAAMNMMJ()
	{
	}

	[IteratorStateMachine(typeof(MEDEELGKCOC))]
	public IEnumerator WriteIntToArduino(uint FLPEKHBCEEI)
	{
		return null;
	}

	private void DINOEILKLMN()
	{
	}

	[IteratorStateMachine(typeof(NMABKNEKNAK))]
	public IEnumerator SetSoundfont(string HMOEINJAFBG)
	{
		return null;
	}

	public void ReadBackgroundDirectory()
	{
	}

	[AsyncStateMachine(typeof(EIDMNALFADG))]
	public Task UpdateAudioInputs()
	{
		return null;
	}

	public void SetRendererColor(MeshRenderer NJKEJBCOKOB, Color OLJIIPPOIHN)
	{
	}

	public float GNIJJNNGGFK(float PKECNBPACFO)
	{
		return 0f;
	}

	public string GetTextureVideoPath()
	{
		return null;
	}

	public void NLAPBJFHIGD()
	{
	}

	public void LEKDPBGFDKM()
	{
	}

	public void KeyboardPedalOnHandler(ControllerEnum LEHHLJGBGPK, int BAPFCKDMEMA, int GMAOPOKAOJO)
	{
	}

	[AsyncStateMachine(typeof(DOOOAJMCLGC))]
	[CompilerGenerated]
	private Task BKBGJOGOOFA()
	{
		return null;
	}

	[IteratorStateMachine(typeof(LGLKIKLPNHH))]
	public IEnumerator ConvertVideoToWav(string CHLJJOGMOHI, float NLMGJCPLOJA, float LDMPIPICHCL)
	{
		return null;
	}

	public void OLIAOPEKOJF()
	{
	}

	public void DNCMFMDEMPE(ControllerEnum LEHHLJGBGPK, int BAPFCKDMEMA, int GMAOPOKAOJO)
	{
	}

	[IteratorStateMachine(typeof(LNAAMINDDJF))]
	public IEnumerator StartTrack()
	{
		return null;
	}

	public void InitializeArrays()
	{
	}

	public void ClearMIDIArrays()
	{
	}

	[IteratorStateMachine(typeof(OLAPAKNCNPJ))]
	public IEnumerator UpdateArduinoTwelveColors()
	{
		return null;
	}

	public void ReadSoundfontDirectory()
	{
	}

	public void Update()
	{
	}

	public IEnumerator DPICAOFAGEK(string HIBCHKNFOHK, float NLMGJCPLOJA, float LDMPIPICHCL)
	{
		return null;
	}

	public void OnTempoChange(float INOCNHBFJAC)
	{
	}

	[IteratorStateMachine(typeof(KACLANEJKHP))]
	public IEnumerator SeekToTrackTime(bool OAOFLJIFDHB = true, bool IKHHHEGMNEI = true, bool PDKBJJEFBCG = false, bool IDHCHNJOPFF = true, bool MADDBMIDGBJ = false, bool NCHAKAKGAFA = true)
	{
		return null;
	}

	public void ExportAudioWAV(AudioClip MNICELEFEBK, string OMKOADDLAMJ)
	{
	}

	public float IEDDADBPJDC()
	{
		return 0f;
	}

	[CompilerGenerated]
	private bool DLEIABJCNDP()
	{
		return false;
	}

	public bool TextureStreamingAssetExists()
	{
		return false;
	}

	public string GetAudioPath()
	{
		return null;
	}

	public void ReadNoteTextureDirectory()
	{
	}

	public void VideoStarted(VideoPlayer KIKPMNCJDFF)
	{
	}

	public int GetSustainAtTicks(double JKDIJJBDDID)
	{
		return 0;
	}

	public uint ColorToPackedColor(Color OLJIIPPOIHN)
	{
		return 0u;
	}

	public void CustomPitchWheelEventHandler(HGDPHKOEDPB DLAJFNOEPHO, string HHHMHDLGBGC, int BELKMNKKAMM, bool NIFLPDOJPHK = false)
	{
	}

	public float SequencerTimeFromTrackTime(float KEKPNOKBGEN)
	{
		return 0f;
	}

	public void InitializeMIDIEvents()
	{
	}

	[CompilerGenerated]
	private void CMPHFBJBDNE()
	{
	}

	[CompilerGenerated]
	private bool DKBGLOMBBAI()
	{
		return false;
	}

	[AsyncStateMachine(typeof(HMDIJBBDMKE))]
	public void StartAudioRecordingAsync()
	{
	}

	public void SetSoundfontPath()
	{
	}

	public bool HasNewFrame(IntPtr OMDIEPPFLJK, MediaPlayer PCHJGNKHLOE)
	{
		return false;
	}

	public void CheckAndPlaySynthNote(int KHDFEOMPNOJ, float IIBKBKAKFBA, float DLHLFANAOPO, int MDFFKJEOFMC, bool FKCDPGGPNEG = false)
	{
	}
}
