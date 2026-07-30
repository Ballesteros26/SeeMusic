using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace FfmpegUnity
{
	public class FfmpegPlayerCommand : FfmpegCommand
	{
		[Serializable]
		public class FfmpegStream
		{
			public enum IDMDNDJIECG
			{
				OTHER = -1,
				VIDEO = 0,
				AUDIO = 1,
				DATA = 2
			}

			public IDMDNDJIECG CodecType;

			public int Width;

			public int Height;

			public int Channels;

			public int SampleRate;
		}

		private sealed class CDKLEKEECGN : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FfmpegPlayerCommand _003C_003E4__this;

			public float val;

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
			public CDKLEKEECGN(int _003C_003E1__state)
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

		private sealed class CAFBFJDLNDM : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FfmpegPlayerCommand _003C_003E4__this;

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
			public CAFBFJDLNDM(int _003C_003E1__state)
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

		private sealed class GLKBGFBHPMM
		{
			public TextReader reader;

			public FfmpegPlayerCommand _003C_003E4__this;

			public List<FfmpegStream> ffmpegStreams;

			internal void EOPINNMEGHM()
			{
			}
		}

		private sealed class JJAEAOALDJK : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FfmpegPlayerCommand _003C_003E4__this;

			public string inputPathAll;

			private GLKBGFBHPMM _003C_003E8__1;

			private Thread _003CffprobeThread_003E5__2;

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
			public JJAEAOALDJK(int _003C_003E1__state)
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

		private sealed class GHMMADEHLCO
		{
			public int streamId;

			public FfmpegPlayerCommand _003C_003E4__this;

			internal void DHHJENAOFHE()
			{
			}
		}

		private sealed class NMGLPGNDHPD
		{
			public int streamId;

			public FfmpegPlayerCommand _003C_003E4__this;

			internal void OCHBHIHMHHK()
			{
			}
		}

		private sealed class ACBJNGCCMJC : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FfmpegPlayerCommand _003C_003E4__this;

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
			public ACBJNGCCMJC(int _003C_003E1__state)
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

		private sealed class NCDJBPPDNKA : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FfmpegPlayerCommand _003C_003E4__this;

			private string _003CreadStr_003E5__2;

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
			public NCDJBPPDNKA(int _003C_003E1__state)
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

		public string InputOptions;

		public FMBCIJMBOHF.FLAKOAENHMK DefaultPath;

		public string InputPath;

		public bool AutoStreamSettings;

		public FfmpegStream[] Streams;

		public float FrameRate;

		public string PlayerOptions;

		public FfmpegPlayerVideoTexture[] VideoTextures;

		public AudioSource[] AudioSources;

		public bool SyncFrameRate;

		private float CJGJHBEAIFG;

		private bool JIMJDPKDJOO;

		private float BKKMAFIJILA;

		[CompilerGenerated]
		private int _003CKKCCNGPGGFH_003Ek__BackingField;

		[CompilerGenerated]
		private bool _003CKIEHKMNIOFF_003Ek__BackingField;

		private bool EMFIKHGAGAB;

		private List<Thread> FDBFODGHFLF;

		private Dictionary<int, byte[]> ENIHJOAAGHE;

		private Dictionary<int, int> FHJAGMBODIL;

		private Dictionary<int, int> JPALBBBODPK;

		private Dictionary<int, List<float>> ENEFBGJILKF;

		private Dictionary<int, int> OPANOGLKDGE;

		private Dictionary<int, int> KMLMBHALNMP;

		[CompilerGenerated]
		private double _003CDONMFEFCKDG_003Ek__BackingField;

		private bool GLONGHBELBP;

		private PBLLPKLFLGE IFDAFOKCKCI;

		private string MFBIBPEINAM;

		public float Time
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		public float Duration
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		public bool IsPlaying => false;

		public int Frames
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected bool IELMIHIEJGC
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public double TimeBase
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsEOF => false;

		protected bool DNLMDNIHLPH()
		{
			return false;
		}

		protected IEnumerator BBLFOGFKPAA()
		{
			return null;
		}

		private IEnumerator AJDDBGJMILD()
		{
			return null;
		}

		public void BPAHOALBAPG(int OHOGDKFDBNA, byte[] IAHBEEJKAKL)
		{
		}

		protected IEnumerator CKCCJBOIKPM()
		{
			return null;
		}

		[SpecialName]
		public int BICGDNJIIPI()
		{
			return 0;
		}

		private void ABGEFFFDCJE(int MIPLPPLCFBI)
		{
		}

		public void OnAudioFilterReadFromPlayerAudio(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		protected override void IMACCPAMNGN()
		{
		}

		public void KCMLIPHNAKO(float HEMGLOMCHBD)
		{
		}

		[SpecialName]
		public float CIKILJJPDGC()
		{
			return 0f;
		}

		[SpecialName]
		private void FJEBGFBAOCB(double JEHONDDIMPC)
		{
		}

		[SpecialName]
		public bool EICIMPJPLHC()
		{
			return false;
		}

		private void ACOMMDNKILH(int MIPLPPLCFBI)
		{
		}

		[SpecialName]
		protected void HPEKNMOMFNE(bool JEHONDDIMPC)
		{
		}

		protected IEnumerator NODLBAGAAKB()
		{
			return null;
		}

		protected IEnumerator PKIHKMEDKEO()
		{
			return null;
		}

		protected IEnumerator DBJFJHHAFNG()
		{
			return null;
		}

		private IEnumerator DECMJFGGGBO()
		{
			return null;
		}

		private void MNIBLPNOOJM(int MIPLPPLCFBI)
		{
		}

		private IEnumerator DCKIPFNKHND(float HEMGLOMCHBD)
		{
			return null;
		}

		[SpecialName]
		public bool MAHNHLCPDIF()
		{
			return false;
		}

		[SpecialName]
		protected bool PJCOLAENNPL()
		{
			return false;
		}

		private IEnumerator MEHKFKHMNCN()
		{
			return null;
		}

		public void EAHFGNOPPFB(int MIPLPPLCFBI)
		{
		}

		private IEnumerator PCPNFBEIMAA()
		{
			return null;
		}

		[SpecialName]
		private void PALFNDOEIOP(float JEHONDDIMPC)
		{
		}

		private IEnumerator PBNNALJHJAK(float HEMGLOMCHBD)
		{
			return null;
		}

		private IEnumerator HEGMIAMKPAE()
		{
			return null;
		}

		[SpecialName]
		protected void CBKHLCGIFPL(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public int GIHLFHIIGBP()
		{
			return 0;
		}

		[SpecialName]
		public double MKCCMLFFHBI()
		{
			return 0.0;
		}

		protected bool DNEJCCHODPB()
		{
			return false;
		}

		public void IIGIAIMALGH(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		private IEnumerator PLDCFIOBHMF()
		{
			return null;
		}

		[IteratorStateMachine(typeof(NCDJBPPDNKA))]
		private IEnumerator CFNLEPFMKIO()
		{
			return null;
		}

		[SpecialName]
		public float FGFGEMMALDI()
		{
			return 0f;
		}

		private IEnumerator KECDNFBBKPB(float HEMGLOMCHBD)
		{
			return null;
		}

		[SpecialName]
		public int PNBLONEAHKA()
		{
			return 0;
		}

		private void CBENNDCLALB(int MIPLPPLCFBI)
		{
		}

		[SpecialName]
		protected void LMLOONDOOCN(bool JEHONDDIMPC)
		{
		}

		protected IEnumerator OEEPANOKOCN()
		{
			return null;
		}

		private IEnumerator FAANEIHBGIM()
		{
			return null;
		}

		protected override void MGLKMGOMGGM()
		{
		}

		private IEnumerator KNJMANJEINP()
		{
			return null;
		}

		[SpecialName]
		protected bool IJJKGHDOCMO()
		{
			return false;
		}

		[IteratorStateMachine(typeof(ACBJNGCCMJC))]
		protected IEnumerator JKIDOMOGOPC()
		{
			return null;
		}

		[SpecialName]
		private void JLFKNFFPMHG(double JEHONDDIMPC)
		{
		}

		[SpecialName]
		public int PKLBNPGKHLC()
		{
			return 0;
		}

		[SpecialName]
		public float JLNJEDGFNGC()
		{
			return 0f;
		}

		[SpecialName]
		private void JPIDKBHFHPG(float JEHONDDIMPC)
		{
		}

		private IEnumerator DHLAONOFIEP()
		{
			return null;
		}

		protected bool MGFALDNOELB()
		{
			return false;
		}

		[SpecialName]
		public float PDCLBHHBDBN()
		{
			return 0f;
		}

		protected IEnumerator FGJPPBOEFKN(string OIBDLPHOPHK)
		{
			return null;
		}

		private IEnumerator FDIDNAFCBJG()
		{
			return null;
		}

		private IEnumerator FHMMAILJHGM()
		{
			return null;
		}

		[SpecialName]
		private void DOKBBIHCDGD(float JEHONDDIMPC)
		{
		}

		public void OFPHNDCCMCD(float HEMGLOMCHBD)
		{
		}

		private void GCBFJILANLL(int MIPLPPLCFBI)
		{
		}

		[SpecialName]
		private void EOADDOBFCAJ(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float PNLGFDNPLHF()
		{
			return 0f;
		}

		[SpecialName]
		protected bool AGOHICPFOFB()
		{
			return false;
		}

		[SpecialName]
		private void MDFMEGEAFPO(float JEHONDDIMPC)
		{
		}

		protected IEnumerator EDPJADMPGOD(string OIBDLPHOPHK)
		{
			return null;
		}

		[SpecialName]
		public bool AGBAENDDDEI()
		{
			return false;
		}

		public void StopPerFrameFunc(int MIPLPPLCFBI)
		{
		}

		public void CIDHHOLHFDI(int MIPLPPLCFBI)
		{
		}

		public void IPDOIJHGLEN(float HEMGLOMCHBD)
		{
		}

		[SpecialName]
		private void AJFGDCMPBCC(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		protected void CGCKJPBDGDH(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		protected bool GDPNOJLIKCJ()
		{
			return false;
		}

		[SpecialName]
		private void EGLPFCBABPF(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		private void APCPEMKFMLN(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		protected bool BEKIDEHBLFA()
		{
			return false;
		}

		public void JMOMBIEKOPP(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		[SpecialName]
		public bool MOFEHFLNPDM()
		{
			return false;
		}

		private IEnumerator MEEEGBFJFPL()
		{
			return null;
		}

		private void HMMLMLNKKDN(int MIPLPPLCFBI)
		{
		}

		[SpecialName]
		protected void HMIMPFLLHLF(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float EEMDPKKGHKJ()
		{
			return 0f;
		}

		private IEnumerator DBJNFIHEPOK()
		{
			return null;
		}

		protected override void FJJPNCANEKC()
		{
		}

		[SpecialName]
		public float MILFNEGJMIN()
		{
			return 0f;
		}

		protected bool INFJJDEEBLA()
		{
			return false;
		}

		protected IEnumerator NCOAOHNHCGP(string OIBDLPHOPHK)
		{
			return null;
		}

		protected IEnumerator AOHPHNIFIMO()
		{
			return null;
		}

		private IEnumerator AHDPGLFMPNG()
		{
			return null;
		}

		[SpecialName]
		public bool PADOGJGNHMA()
		{
			return false;
		}

		[IteratorStateMachine(typeof(JJAEAOALDJK))]
		protected IEnumerator EJCEJIFGJNB(string OIBDLPHOPHK)
		{
			return null;
		}

		public void FIHPCDOPCDO(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		[SpecialName]
		protected void NBOBBNACPKL(bool JEHONDDIMPC)
		{
		}

		private void EDCELAPBJBO(int MIPLPPLCFBI)
		{
		}

		public void NONHFOLCMAL(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		protected override void Update()
		{
		}

		public void LHIFOMGCKFO(int OHOGDKFDBNA, float[] PJFJCAHKFPO)
		{
		}

		[SpecialName]
		protected bool DPNEOOHNDLP()
		{
			return false;
		}

		[SpecialName]
		public double KEEPEODFMBF()
		{
			return 0.0;
		}

		public void OICFANNBLKJ(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		[SpecialName]
		public double NMOOHIFBOIB()
		{
			return 0.0;
		}

		[SpecialName]
		public float BGMFDGFKPJM()
		{
			return 0f;
		}

		[SpecialName]
		public int IPEJMDHHOCD()
		{
			return 0;
		}

		public void AddAudioBuffer(int OHOGDKFDBNA, float[] PJFJCAHKFPO)
		{
		}

		[IteratorStateMachine(typeof(CDKLEKEECGN))]
		private IEnumerator OLKDDKJOHON(float HEMGLOMCHBD)
		{
			return null;
		}

		[SpecialName]
		private void KGJACBOPJHA(double JEHONDDIMPC)
		{
		}

		[SpecialName]
		private void MBJPIPBODJI(float JEHONDDIMPC)
		{
		}

		private IEnumerator FLILOBAGHLL(float HEMGLOMCHBD)
		{
			return null;
		}

		private IEnumerator DCHPKIAHDHI(float HEMGLOMCHBD)
		{
			return null;
		}

		[SpecialName]
		protected bool BOPPFDHHJGB()
		{
			return false;
		}

		[SpecialName]
		private void LAJANMIGKFI(float JEHONDDIMPC)
		{
		}

		protected IEnumerator IKLPFJAEGGG(string OIBDLPHOPHK)
		{
			return null;
		}

		[SpecialName]
		private void FDMNKBNNEPN(int JEHONDDIMPC)
		{
		}

		private void MDAGOOOOPAM(int MIPLPPLCFBI)
		{
		}

		public void SetVideoBuffer(int OHOGDKFDBNA, byte[] IAHBEEJKAKL)
		{
		}

		private IEnumerator JJIJJDLAJDL(float HEMGLOMCHBD)
		{
			return null;
		}

		[IteratorStateMachine(typeof(CAFBFJDLNDM))]
		private IEnumerator HHKKCIJNOOE()
		{
			return null;
		}

		[SpecialName]
		private void JNBFECGADKK(float JEHONDDIMPC)
		{
		}

		public void PICJBCJNCMM(int OHOGDKFDBNA, float[] PJFJCAHKFPO)
		{
		}

		[SpecialName]
		private void CBACKBJGDAA(double JEHONDDIMPC)
		{
		}

		[SpecialName]
		public bool LAENEBOAAPK()
		{
			return false;
		}

		public void OPAHIFLGFMD(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		[SpecialName]
		private void AKDHKPEJPPK(double JEHONDDIMPC)
		{
		}

		private void MPJNGKBBMHP(int MIPLPPLCFBI)
		{
		}

		protected bool GHDEDCGFHDH()
		{
			return false;
		}

		[SpecialName]
		private void LJOINJAAOEL(double JEHONDDIMPC)
		{
		}

		private IEnumerator GKDGMIFFAKK(float HEMGLOMCHBD)
		{
			return null;
		}

		public void ALNNFEEEFDP(float HEMGLOMCHBD)
		{
		}

		public void NHKIHCGIEKB(int MIPLPPLCFBI)
		{
		}

		[SpecialName]
		public bool PBLKJPBLCBH()
		{
			return false;
		}

		private void PFGJOIIIKMH(int MIPLPPLCFBI)
		{
		}

		[SpecialName]
		private void PEPFKMBHLBD(int JEHONDDIMPC)
		{
		}

		[SpecialName]
		public bool FOBEGCGCHFI()
		{
			return false;
		}

		private IEnumerator INAIDEOCCHO()
		{
			return null;
		}

		[SpecialName]
		public float MDCCCJIEFLF()
		{
			return 0f;
		}

		[SpecialName]
		public int EIEJCLIILCA()
		{
			return 0;
		}

		[SpecialName]
		public double FFLMCFFAIGJ()
		{
			return 0.0;
		}

		protected IEnumerator JMCJADIJCJN()
		{
			return null;
		}

		public void FNIKGGPFMEC(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		public void SetTime(float HEMGLOMCHBD)
		{
		}

		[SpecialName]
		public float LNAPBNCFBEK()
		{
			return 0f;
		}

		private void DEIEJGDMBAP(int MIPLPPLCFBI)
		{
		}

		[SpecialName]
		private void HNDDIOALDMD(int JEHONDDIMPC)
		{
		}

		[SpecialName]
		private void HFOIDALJDHN(double JEHONDDIMPC)
		{
		}
	}
}
