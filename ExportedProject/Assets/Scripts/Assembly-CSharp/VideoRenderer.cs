using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RenderHeads.Media.AVProMovieCapture;
using UnityEngine;
using UnityEngine.Video;

public class VideoRenderer : MonoBehaviour
{
	private sealed class AAICJDODNAL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VideoRenderer _003C_003E4__this;

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
		public AAICJDODNAL(int _003C_003E1__state)
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

	private sealed class PGHGJILIOIO
	{
		public int SaberPreviousFrameCount;

		public IntPtr SaberPreviousTexture;

		public float timeWaitStarted;

		public VideoRenderer _003C_003E4__this;

		internal bool DHHALOFGBAK()
		{
			return false;
		}

		internal bool IBNFPCJNPML()
		{
			return false;
		}
	}

	private sealed class FBMFEADPEIG
	{
		public float timeWaitStarted;

		public VideoRenderer _003C_003E4__this;

		internal bool FCLNNLOJPAP()
		{
			return false;
		}
	}

	private sealed class DBFGDDJKFIF
	{
		public int AVProTextureFrameCount;

		public float timeWaitStarted;

		public IntPtr TexturePreviousTexture;

		public VideoRenderer _003C_003E4__this;

		internal bool BHNADKKFBLP()
		{
			return false;
		}

		internal bool JOGKCOBOGNO()
		{
			return false;
		}
	}

	private sealed class CHJPONMLNAP
	{
		public float timeWaitStarted;

		public VideoRenderer _003C_003E4__this;

		internal bool NFLCOMIDNFF()
		{
			return false;
		}
	}

	private sealed class LDCMCPCHLMO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VideoRenderer _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public LDCMCPCHLMO(int _003C_003E1__state)
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

	private sealed class GPIHIDOEDKP
	{
		public int RenderProbePass;

		public VideoRenderer _003C_003E4__this;

		internal bool AKIGDCHOBFO()
		{
			return false;
		}
	}

	private sealed class MIJPIIMPKJI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VideoRenderer _003C_003E4__this;

		private double _003Ctime_003E5__2;

		private bool _003CwaitForVideo_003E5__3;

		private double _003CvideoTime_003E5__4;

		private IntPtr _003CVideoPreviousTexture_003E5__5;

		private int _003CAVProVideoFrameCount_003E5__6;

		private bool _003CwaitForSaber_003E5__7;

		private IntPtr _003CSaberPreviousTexture_003E5__8;

		private int _003CAVProSaberFrameCount_003E5__9;

		private bool _003CwaitForTexture_003E5__10;

		private IntPtr _003CTexturePreviousTexture_003E5__11;

		private int _003CAVProTextureFrameCount_003E5__12;

		private double _003CAVProTextureVideoTime_003E5__13;

		private bool _003CwaitForBackgroundVideo_003E5__14;

		private IntPtr _003CBackgroundPreviousTexture_003E5__15;

		private int _003CAVProBackgroundFrameCount_003E5__16;

		private double _003CAVProBackgroundVideoTime_003E5__17;

		private float _003CtimeWaitStarted_003E5__18;

		private float _003CTimeToWait_003E5__19;

		private bool _003CreattemptedPerformanceSeek_003E5__20;

		private bool _003CreattemptedSecondPerformanceSeek_003E5__21;

		private bool _003CreattemptedSaberSeek_003E5__22;

		private bool _003CreattemptedSecondSaberSeek_003E5__23;

		private bool _003CreattemptedTextureSeek_003E5__24;

		private bool _003CreattemptedSecondTextureSeek_003E5__25;

		private bool _003CreattemptedBackgroundSeek_003E5__26;

		private bool _003CreattemptedSecondBackgroundSeek_003E5__27;

		private bool _003CvideosReady_003E5__28;

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
		public MIJPIIMPKJI(int _003C_003E1__state)
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

	private sealed class JCLGHGHGCBP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VideoRenderer _003C_003E4__this;

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
		public JCLGHGHGCBP(int _003C_003E1__state)
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

	private sealed class OOFNPNMGOCN
	{
		public VideoRenderer _003C_003E4__this;

		public float timeWaitStarted;

		internal bool BPGDODBHOMK()
		{
			return false;
		}

		internal bool CHFBBKODLKJ()
		{
			return false;
		}
	}

	private sealed class CNCGKIOODLC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VideoRenderer _003C_003E4__this;

		private OOFNPNMGOCN _003C_003E8__1;

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
		public CNCGKIOODLC(int _003C_003E1__state)
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

	private sealed class IIAHOLDCJJF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VideoRenderer _003C_003E4__this;

		public string path;

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
		public IIAHOLDCJJF(int _003C_003E1__state)
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

	public SceneSingleton SceneSingleton;

	public UIManager UIManager;

	public Account Account;

	public MIDIControl MIDIControl;

	public NoteAnimation NoteAnimation;

	public KeyboardAnimation KeyboardAnimation;

	public ParticleAnimation ParticleAnimation;

	public Background Background;

	[Header("Recording")]
	public int videoWidth;

	public int videoHeight;

	[Header("Microphone")]
	public bool recordMicrophone;

	public AudioSource microphoneSource;

	public CaptureFromCamera captureFromCamera;

	public CaptureAudioFromAudioClip captureAudioFromAudioClip;

	public AudioClip inGameAudioClip;

	public bool audioEnabled;

	public AudioSource renderAudioSource;

	public AudioClip DirectAudioClip;

	private Camera INLMNIPLLNH;

	[NonSerialized]
	public string videoRenderPath;

	[NonSerialized]
	public string videoSavePath;

	public GameObject DummyObject;

	public VideoPlayer DummyPlayer;

	[NonSerialized]
	private double HKLDMCLLNCC;

	[NonSerialized]
	private double ENAMEELJDCC;

	[NonSerialized]
	private double MBFDANGMPAO;

	[NonSerialized]
	private double HEDLODDCJHI;

	[NonSerialized]
	public bool DirectCopyAudioClip;

	[NonSerialized]
	public bool DirectCopyVideoClip;

	[NonSerialized]
	public bool frameRendered;

	[NonSerialized]
	public int committedFrames;

	[NonSerialized]
	public int outputSampleRate;

	[NonSerialized]
	private int IBLCMBNPEFH;

	[NonSerialized]
	private int ILOFLMMNOFL;

	[NonSerialized]
	private int JPDLGFKLDBN;

	[NonSerialized]
	private int DJAPPHPDEMA;

	[NonSerialized]
	private int AEIDLNJIPDH;

	[NonSerialized]
	private int IBPFOHAEPHO;

	[NonSerialized]
	private bool GDEFLLFEKEL;

	[NonSerialized]
	private int PDAFPPJHCCG;

	[NonSerialized]
	private double MHGABGLGCFB;

	[NonSerialized]
	public bool videoFramesCommitted;

	[NonSerialized]
	public int saberProFrame;

	[NonSerialized]
	public int lightProFrame;

	[NonSerialized]
	public int videoProFrame;

	[NonSerialized]
	private int MLBFFGMGLMM;

	[NonSerialized]
	private int GHNNJPGDFOC;

	[NonSerialized]
	private double KEMNJEPBKNG;

	public float SeekWaitMax;

	[NonSerialized]
	public List<float[]> frameRenderTimes;

	[NonSerialized]
	public float renderSpeed;

	[NonSerialized]
	public bool finishedCommittingAudioSamples;

	[NonSerialized]
	public int lastCommittedSample;

	[NonSerialized]
	public int committedSamples;

	[NonSerialized]
	private static bool EMNEGGHOIPM;

	[NonSerialized]
	public bool audioRenderStarted;

	[NonSerialized]
	public float audioRenderStartedAt;

	[NonSerialized]
	public double videoAudioRenderedOffset;

	private bool PPGKGGMFMGG;

	private Action JBNGNLPGLLG;

	public string videoRenderFilename;

	public bool SavePathSet;

	[NonSerialized]
	private string PPGGCCDENGP;

	[NonSerialized]
	public bool FileWritingCompleted;

	private string LGLAMEDDMJO;

	private string EDPFGMLFELL;

	private static float[] FGKHEBMBBKG;

	private IEnumerator MKHHOHEDNEN(string LNMDPMBMJBI)
	{
		return null;
	}

	[CompilerGenerated]
	private bool PCIAJDFOJFB()
	{
		return false;
	}

	public IEnumerator NEACCCJPNMG()
	{
		return null;
	}

	private bool LGHILCNICIE()
	{
		return false;
	}

	public void SetSaveFilenameAndPath()
	{
	}

	public void MJFGKNJKILH()
	{
	}

	private bool LDDNBMLGCKO()
	{
		return false;
	}

	[CompilerGenerated]
	private bool OPBHOOBGDJP()
	{
		return false;
	}

	private bool HPEPDOBKDKM()
	{
		return false;
	}

	public IEnumerator KLJAFCHONJG()
	{
		return null;
	}

	public float[] GetAudioSamplesForFrame()
	{
		return null;
	}

	private IEnumerator BJEIOEAHPDF(string LNMDPMBMJBI)
	{
		return null;
	}

	[CompilerGenerated]
	private bool NPJIFBEIJFL()
	{
		return false;
	}

	public void MACBAIPCIKG()
	{
	}

	private void JGKMMLENHKA()
	{
	}

	public IEnumerator LHFEMKNCFCM()
	{
		return null;
	}

	public void NJCEJEIDADN()
	{
	}

	private void PLHCGCJKGNJ()
	{
	}

	public string NKNJHGAODAE(string DJPDEGLFOGE)
	{
		return null;
	}

	public IEnumerator OOPHILMEGAE()
	{
		return null;
	}

	public void ENEOMFDPFNG()
	{
	}

	[CompilerGenerated]
	private bool GHDMIFMMBEL()
	{
		return false;
	}

	private void LFJJDIJNLFO()
	{
	}

	private bool FKDKEIHFAJP()
	{
		return false;
	}

	[CompilerGenerated]
	private bool IBJAHBBPMMF()
	{
		return false;
	}

	public IEnumerator JHPPNKNBDHD()
	{
		return null;
	}

	public string NIHEMAELCDM(string DJPDEGLFOGE)
	{
		return null;
	}

	[CompilerGenerated]
	private bool GHKICCPNBMO()
	{
		return false;
	}

	[IteratorStateMachine(typeof(MIJPIIMPKJI))]
	public IEnumerator RenderFrame()
	{
		return null;
	}

	public void JGGPDBBIGPI()
	{
	}

	[CompilerGenerated]
	private void JBBLDMGOBEL()
	{
	}

	public float[] PCFICAFMHDM()
	{
		return null;
	}

	public void OnCompleteFileWriting(FileWritingHandler BENAGPIAHLI)
	{
	}

	private bool LOAOOMLDEFA()
	{
		return false;
	}

	public IEnumerator KNJOIADGNJK()
	{
		return null;
	}

	[CompilerGenerated]
	private bool GKKOOOAJMIN()
	{
		return false;
	}

	private bool AGDCPKDJFFK()
	{
		return false;
	}

	private bool BDBCIGMCCOA()
	{
		return false;
	}

	private bool OICHBNJLDFH()
	{
		return false;
	}

	private bool AELIJOLMKBB()
	{
		return false;
	}

	public void KPGJFGGJICI()
	{
	}

	private bool PINOCHHBJIJ()
	{
		return false;
	}

	public void Start()
	{
	}

	private bool GHBCDPBOBOJ()
	{
		return false;
	}

	public float[] EHGAGMNLDCE()
	{
		return null;
	}

	private bool BJKPDGCPIOP()
	{
		return false;
	}

	private void ENLPDJKICMM()
	{
	}

	public void GHNFEHJOOKE()
	{
	}

	public void IKMAPEOKKBC(FileWritingHandler BENAGPIAHLI)
	{
	}

	private void OBIFMAFGGKE()
	{
	}

	public void MICOABCDMGN(float[] MMANPBLCGDP, int NHCAHIMBLMD, int IJIEDFBOJME, long DBNDEAEAGPD)
	{
	}

	[CompilerGenerated]
	private void BAHPCPENEBG()
	{
	}

	public void PNDMCACBLCK()
	{
	}

	private void IIAECBGFNKF()
	{
	}

	[IteratorStateMachine(typeof(JCLGHGHGCBP))]
	public IEnumerator CommitSamplesFromAudioSource()
	{
		return null;
	}

	[CompilerGenerated]
	private bool AIBCHLCAFPA()
	{
		return false;
	}

	public IEnumerator CLJAGHGFIEO()
	{
		return null;
	}

	public IEnumerator HOFPIDOKBEN()
	{
		return null;
	}

	[CompilerGenerated]
	private void DMPGMGPBDFB()
	{
	}

	public IEnumerator PHBKFCJNCBK()
	{
		return null;
	}

	public string JHCJDAMOJMH(string DJPDEGLFOGE)
	{
		return null;
	}

	public void PFFHJIJOFDG()
	{
	}

	public void StopRecording(bool LLNACDHNKJD = false)
	{
	}

	public void IELMFBMEJIF()
	{
	}

	private void GIDILDKIMNC()
	{
	}

	public void OnSampleBuffer(float[] MMANPBLCGDP, int NHCAHIMBLMD, int IJIEDFBOJME, long DBNDEAEAGPD)
	{
	}

	public void KPOFBIIJBFJ(string HNELMLGEBEM)
	{
	}

	[IteratorStateMachine(typeof(AAICJDODNAL))]
	public IEnumerator StartRecording()
	{
		return null;
	}

	public void UpdateRenderPreview()
	{
	}

	public void SetSaveFilenameAfterOpen(string HNELMLGEBEM)
	{
	}

	private bool GCNEMCLGGCG()
	{
		return false;
	}

	public IEnumerator NHAEJNKBAHJ()
	{
		return null;
	}

	public string LMEBFGNKJDM(string DJPDEGLFOGE)
	{
		return null;
	}

	public IEnumerator KNILCDHDILG()
	{
		return null;
	}

	[IteratorStateMachine(typeof(LDCMCPCHLMO))]
	public IEnumerator RenderVideo()
	{
		return null;
	}

	public void FreezeAnimation()
	{
	}

	private bool OFDOHKBDGLA()
	{
		return false;
	}

	private bool GHOIKGPFMHD()
	{
		return false;
	}

	[IteratorStateMachine(typeof(CNCGKIOODLC))]
	public IEnumerator RenderAudio()
	{
		return null;
	}

	public string ReplaceIllegalCharacters(string DJPDEGLFOGE)
	{
		return null;
	}

	public string NGFNBNHKFEC(string DJPDEGLFOGE)
	{
		return null;
	}

	public void ExportAudioWAV(AudioClip MNICELEFEBK, string OMKOADDLAMJ)
	{
	}

	public string FGIPDJFFPFH(string DJPDEGLFOGE)
	{
		return null;
	}

	private bool EKDIBFNMMGE()
	{
		return false;
	}

	[CompilerGenerated]
	private bool HEEONMELLBL()
	{
		return false;
	}

	public void DJGMBIEDHLM()
	{
	}

	public IEnumerator BDJNOPFOCPD()
	{
		return null;
	}

	public IEnumerator HEKJJFHBMJL()
	{
		return null;
	}

	private void LKHHCIPPFKD()
	{
	}

	public void IGBBIFKGIKB(FileWritingHandler BENAGPIAHLI)
	{
	}

	[IteratorStateMachine(typeof(IIAHOLDCJJF))]
	private IEnumerator HCKMOACGHGD(string LNMDPMBMJBI)
	{
		return null;
	}

	private bool KPLHHIMGEGN()
	{
		return false;
	}
}
