using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Syncer : MonoBehaviour
{
	private sealed class MKCDILEHBIE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Syncer _003C_003E4__this;

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
		public MKCDILEHBIE(int _003C_003E1__state)
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

	private sealed class EBMDFNFGNGC
	{
		public Syncer _003C_003E4__this;

		public float timeWaitStarted;

		internal bool MOKMHLFDOGJ()
		{
			return false;
		}
	}

	private sealed class CHMKCBFOPBI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Syncer _003C_003E4__this;

		private EBMDFNFGNGC _003C_003E8__1;

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
		public CHMKCBFOPBI(int _003C_003E1__state)
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

	private sealed class EBCJMNGEBBG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Syncer _003C_003E4__this;

		public float diff;

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
		public EBCJMNGEBBG(int _003C_003E1__state)
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

	[NonSerialized]
	public float[] VideoAudioBuffer;

	public SceneSingleton SceneSingleton;

	public MIDIControl MIDIControl;

	public NoteAnimation NoteAnimation;

	public KeyboardAnimation KeyboardAnimation;

	public ParticleAnimation ParticleAnimation;

	public UIManager UIManager;

	public Background Background;

	public GameObject TracksPanel;

	public GameObject TracksScrollPanel;

	public RectTransform TracksScrollPanelRT;

	public GameObject MIDIPanel;

	public GameObject AudioPanel;

	public GameObject VideoPanel;

	public GameObject MIDITrack;

	public GameObject AudioTrack;

	public GameObject VideoTrack;

	public RectTransform AudioTrackRT;

	public RectTransform VideoTrackRT;

	public GameObject AudioTrackOutline;

	public GameObject VideoTrackOutline;

	public RectTransform AudioTrackOutlineRT;

	public RectTransform VideoTrackOutlineRT;

	public GameObject MIDITrackParent;

	public GameObject AudioTrackParent;

	public GameObject VideoTrackParent;

	public GameObject MIDILabelParent;

	public GameObject AudioLabelParent;

	public GameObject VideoLabelParent;

	public Image AudioImage;

	public Image VideoImage;

	private Texture2D HJPNJABGEKL;

	private Texture2D CKMPJPNNJBK;

	public GameObject WizardButtons;

	public GameObject SettingsBackButton;

	public Image TimelineTicksImage;

	public GameObject TimelineLabels;

	public GameObject TimelineLabelPrefab;

	public DynamicSegmentedControl LengthSegmentedControl;

	public SliderControl AutoThresholdSlider;

	public SliderControl ZoomSlider;

	public TMP_InputField ZoomInputField;

	public TMP_InputField AudioOffsetInputField;

	public TMP_InputField VideoOffsetInputField;

	[NonSerialized]
	private int PDJJPKLOBCH;

	[NonSerialized]
	private int DFJIBLBMIFO;

	[NonSerialized]
	private int HDIEOOPICCB;

	[NonSerialized]
	private int POFOOLPBKLE;

	[NonSerialized]
	private float MDIGIIJHOCH;

	[NonSerialized]
	private float LMBKJIDOGPJ;

	[NonSerialized]
	private float PAMCCNDBEPN;

	[NonSerialized]
	private float FFGFNKHBCCH;

	[NonSerialized]
	private float IJCPPKFNAOI;

	[NonSerialized]
	private float KOBDHLEGJDM;

	[NonSerialized]
	private float KDOHFPPBOPB;

	public GameObject GenerateVideoWaveformButtonPanel;

	public Scrollbar TrackScrollbar;

	public ScrollRectNoDrag TrackScrollRect;

	public GameObject PlayheadObject;

	public RectTransform PlayheadRT;

	public RectTransform TracksHorizontalLayoutPanelRT;

	public GameObject TimeLeftLabel;

	public GameObject TimePlayedLabel;

	public GameObject PlayButton;

	public GameObject UndoButton;

	public GameObject RedoButton;

	public GameObject WaveformProgressPanel;

	public GameObject WaveformProgressBar;

	public GameObject WaveformProgressTimeLeft;

	public RectTransform SyncerPanelRT;

	[NonSerialized]
	private int LLDIHNKJLIE;

	[NonSerialized]
	private int BHFGLNJOOIJ;

	private bool KFAKFGMBHBK;

	[NonSerialized]
	private bool ODALNIFMDNK;

	[NonSerialized]
	private float PKKBNLMPECA;

	[NonSerialized]
	private float LADOAAJPIHC;

	[NonSerialized]
	private bool FPIGFBMMOOO;

	private int LHGINKCGGMI;

	private Texture2D CIEOALFMFLA;

	public float[] BOGIEOJLMEI(AudioClip MNICELEFEBK, float NLMGJCPLOJA, float LDMPIPICHCL, float COPDDFINNHO = 0f)
	{
		return null;
	}

	public float[] FPOGDKOEEPG(float[] CEEANOFIEKP, float NLMGJCPLOJA, float LDMPIPICHCL)
	{
		return null;
	}

	public IEnumerator LPAHIGGANIE()
	{
		return null;
	}

	public void CreateTimelineLabels()
	{
	}

	public void GFJFEBGCHJB(int BLPOGJFABJE)
	{
	}

	public void WizardBackButtonAction()
	{
	}

	public void CBMEDBGJEDO()
	{
	}

	public void GenerateAudioWaveform(int BLPOGJFABJE)
	{
	}

	public void FHEKHGAIBEE()
	{
	}

	public void UpdateTimelineUI()
	{
	}

	public void MODFBLJHFFG()
	{
	}

	public void MNJHFCEJALO()
	{
	}

	private bool HAGPKJMKLHH()
	{
		return false;
	}

	public void WizardNextButtonAction()
	{
	}

	public void SyncWindowLengthControlAction(int AOCGNPPGDCO)
	{
	}

	public float[] MKLBHCMBOAB(AudioClip MNICELEFEBK, float NLMGJCPLOJA, float LDMPIPICHCL, float COPDDFINNHO = 0f)
	{
		return null;
	}

	public void OnResize()
	{
	}

	private void KBKENOEGBOC()
	{
	}

	public void PFHOLKHPBOK()
	{
	}

	public Texture2D GenerateTimelineTicks(int MHOFONMFCJD, int AOEIBOIKGAL)
	{
		return null;
	}

	public void BKOMHPLACAJ()
	{
	}

	public float GetFirstNoteTimeFromSamples(float[] CEEANOFIEKP)
	{
		return 0f;
	}

	public float GetFirstNoteTimeFromAudio(AudioClip MNICELEFEBK)
	{
		return 0f;
	}

	public void JMDEMJFFEKC()
	{
	}

	public void SetWaveformSize()
	{
	}

	public void HDKGAMFFFLE(bool KEFFCGEKLFE = true, bool JEMIMJMCJAF = false)
	{
	}

	public float PFDEOFMPJFP(AudioClip MNICELEFEBK)
	{
		return 0f;
	}

	public void IGPLDNLCPLF()
	{
	}

	public void EFJIPLCOGON()
	{
	}

	public IEnumerator EGMBDCBHFII()
	{
		return null;
	}

	[IteratorStateMachine(typeof(MKCDILEHBIE))]
	public IEnumerator AfterOneFrame()
	{
		return null;
	}

	public void CreateMIDITrack()
	{
	}

	public float IMIKFDKACCK(float GHAPIBJKBOH)
	{
		return 0f;
	}

	public void CAINEJBCNLL(int AOCGNPPGDCO)
	{
	}

	public float[] GetWaveformSamplesForClip(AudioClip MNICELEFEBK, float NLMGJCPLOJA, float LDMPIPICHCL, float COPDDFINNHO = 0f)
	{
		return null;
	}

	[IteratorStateMachine(typeof(EBCJMNGEBBG))]
	public IEnumerator SetTrackZoom(float IHFFKKOJLHD)
	{
		return null;
	}

	public IEnumerator MBHIELLMDFM()
	{
		return null;
	}

	[IteratorStateMachine(typeof(CHMKCBFOPBI))]
	public IEnumerator GetVideoSamples()
	{
		return null;
	}

	public void AHGDINOHDIP()
	{
	}

	public void DJIAELGCLPI()
	{
	}

	public void AMJMKPOHNGM()
	{
	}

	private bool KHMBCGOIEAN()
	{
		return false;
	}

	public float FGONCOKCNKL(Vector2 PLKMHLAAFPF)
	{
		return 0f;
	}

	public void ECOBBPNNKCA()
	{
	}

	public void PlayButtonAction()
	{
	}

	public void IIECNCODAIG(int BLPOGJFABJE)
	{
	}

	public void EEJOCPABLKK()
	{
	}

	private void NAEIAKHDMOH()
	{
	}

	public void IHNDHOHLFPL()
	{
	}

	public void RedoAction()
	{
	}

	public void KAPJOMJJLIP(bool KEFFCGEKLFE = true, bool JEMIMJMCJAF = false)
	{
	}

	public void FIFFGPDAIPM(PointerEventData KFOIKMGPCHF)
	{
	}

	public float GetPositionFromTimeOffset(float GHAPIBJKBOH)
	{
		return 0f;
	}

	public void GBFOMNAKOAI(PointerEventData KFOIKMGPCHF)
	{
	}

	public void CEBBHFIMJFC()
	{
	}

	public void ZoomInputFieldAction()
	{
	}

	public float GetTrackTimeFromScreenPosition(Vector2 PLKMHLAAFPF)
	{
		return 0f;
	}

	public void JEDGAOINFDC()
	{
	}

	public void EBPBMADCMMH()
	{
	}

	public void MIDITrackClicked(PointerEventData KFOIKMGPCHF)
	{
	}

	public void GetAudioSamples()
	{
	}

	public void DestroyTextures()
	{
	}

	public void TrackScrollbarAction()
	{
	}

	public void KLJBPBMBLNE()
	{
	}

	public void HCLNFNHECJI()
	{
	}

	public void NJPIMICJOLL()
	{
	}

	public float BBGIHAKNFBE(float GHAPIBJKBOH)
	{
		return 0f;
	}

	public void NLADEJALJND()
	{
	}

	public float BMLJDCGNKOP(Vector2 PLKMHLAAFPF)
	{
		return 0f;
	}

	public float EBEELJHOKPL()
	{
		return 0f;
	}

	public void SetPlayheadPosition()
	{
	}

	public void UpdateWaveformProgressBar()
	{
	}

	public void IDHGHAMPBCD()
	{
	}

	private bool BOPHKIECHMJ()
	{
		return false;
	}

	public void OAGONEEOLMM()
	{
	}

	public void OffsetInputFieldAction(string LBELHIHEFED)
	{
	}

	public void NFHLGOGNDFI()
	{
	}

	public float[] LBGHMLOJFPH(float[] CEEANOFIEKP, float NLMGJCPLOJA, float LDMPIPICHCL)
	{
		return null;
	}

	public float[] AMMBOIDDPKJ(AudioClip MNICELEFEBK, float NLMGJCPLOJA, float LDMPIPICHCL, float COPDDFINNHO = 0f)
	{
		return null;
	}

	public void SetOffsetInputFields()
	{
	}

	public void OFLANDAFCOI()
	{
	}

	public float[] IOKGACLNKCI(float[] CEEANOFIEKP, float NLMGJCPLOJA, float LDMPIPICHCL)
	{
		return null;
	}

	public void OILLMPMPIMF()
	{
	}

	public float[] MLJGEFJNKDJ(AudioClip MNICELEFEBK, float NLMGJCPLOJA, float LDMPIPICHCL, float COPDDFINNHO = 0f)
	{
		return null;
	}

	public void OBBOOOOHIGM(int BLPOGJFABJE)
	{
	}

	public void CCBKILMPCPE()
	{
	}

	public void OECLIPHJFCG()
	{
	}

	public void BAKGGMCOANL()
	{
	}

	public void EHGKEJPCCAC()
	{
	}

	public void NJBADBDPNPJ()
	{
	}

	public void JDMLGGMPMHN(bool KEFFCGEKLFE = true, bool JEMIMJMCJAF = false)
	{
	}

	public void BBLIKPBOKIO()
	{
	}

	public float NLLNJAMHDAL()
	{
		return 0f;
	}

	public void CLLACIGGIHP(int AOCGNPPGDCO)
	{
	}

	public void SetTrackPositions()
	{
	}

	public void BJOACOCODMK()
	{
	}

	public void NIABBHHOOFN(PointerEventData KFOIKMGPCHF)
	{
	}

	public void AGLJEHAPOME()
	{
	}

	public void EMKLMNPAJDD()
	{
	}

	public void NextFrameButtonAction()
	{
	}

	public void CloseAction()
	{
	}

	public void GPMNMKCCBHF(int BLPOGJFABJE)
	{
	}

	public void ODGICEJDFPD()
	{
	}

	public void ONLOKKKKLHP()
	{
	}

	public void JLIKGHMHEMC()
	{
	}

	public void KACAKLPIOBK(int BLPOGJFABJE)
	{
	}

	public void KEOPMJGBGCC(int BLPOGJFABJE)
	{
	}

	public float[] AMNNAHAIOKF(AudioClip MNICELEFEBK, float NLMGJCPLOJA, float LDMPIPICHCL, float COPDDFINNHO = 0f)
	{
		return null;
	}

	public void GenerateVideoWaveformFromSamples(int BLPOGJFABJE)
	{
	}

	public float[] GOIOCIDMFCA(float[] CEEANOFIEKP, float NLMGJCPLOJA, float LDMPIPICHCL)
	{
		return null;
	}

	public Texture2D GenerateWaveformFromSamples(float[] CEEANOFIEKP, int MHOFONMFCJD, int AOEIBOIKGAL, Color FLKMFEMHOII, int BLPOGJFABJE)
	{
		return null;
	}

	public float CDIPOLCHAIF(float[] CEEANOFIEKP)
	{
		return 0f;
	}

	public void UndoAction()
	{
	}

	public void LFKJJGLGKON()
	{
	}

	public void RedrawTracks(bool KEFFCGEKLFE = true, bool JEMIMJMCJAF = false)
	{
	}

	[CompilerGenerated]
	private bool FEEMHDLMHBJ()
	{
		return false;
	}

	public void JLHIJJOFHOJ()
	{
	}

	public float HECOLPLOPOK(float GHAPIBJKBOH)
	{
		return 0f;
	}

	public void ABEGPECJACP()
	{
	}

	public void AFJDEBPJKBJ(int BLPOGJFABJE)
	{
	}

	public void ZoomSliderAction()
	{
	}

	public void MKJIHHNLKNM(int AOCGNPPGDCO)
	{
	}

	public void EEJPHDDDGKE(string LBELHIHEFED)
	{
	}

	public float[] GGBHOOEEJNA(float[] CEEANOFIEKP, float NLMGJCPLOJA, float LDMPIPICHCL)
	{
		return null;
	}

	public float[] GetSamplesSubset(float[] CEEANOFIEKP, float NLMGJCPLOJA, float LDMPIPICHCL)
	{
		return null;
	}

	public IEnumerator FACLFNNCGMC()
	{
		return null;
	}

	private bool IICIKCPPKGA()
	{
		return false;
	}

	public void DIIIKLAFFCI()
	{
	}

	public void AutoSyncAction()
	{
	}

	public void FPDJMMOPJMC(int BLPOGJFABJE)
	{
	}

	public void BLJPBJGFPLO()
	{
	}

	private void Start()
	{
	}

	public void BFFFFMIOHDP()
	{
	}

	public void IAPHHLHJNNO(int BLPOGJFABJE)
	{
	}

	public float GFJNGMDBDHK(float GHAPIBJKBOH)
	{
		return 0f;
	}

	public IEnumerator EOEKFBEFBDO(float IHFFKKOJLHD)
	{
		return null;
	}

	public void GPOIPIDHBAE()
	{
	}

	public float IIOGMBANALJ(Vector2 PLKMHLAAFPF)
	{
		return 0f;
	}

	public float GetMIDIFirstNote()
	{
		return 0f;
	}

	public float[] CJJDBGHIABL(float[] CEEANOFIEKP, float NLMGJCPLOJA, float LDMPIPICHCL)
	{
		return null;
	}

	public void KKOKGCIKJFK(int BLPOGJFABJE)
	{
	}

	private void PJNFNHEPGFB()
	{
	}

	public IEnumerator NNDOCFBOEFO()
	{
		return null;
	}

	public IEnumerator EKAPJGDKADM()
	{
		return null;
	}

	public void FKHHACAEIBL()
	{
	}

	public void PAKMEFJKJGD()
	{
	}

	public void ILKLFIHLJFI()
	{
	}

	public void AOKJGOBMLEL()
	{
	}

	public void EHAGEALNEBL()
	{
	}

	public void LMLICONDBFE()
	{
	}

	public void FEGIDNBCGHE()
	{
	}

	public Texture2D LCPELBHCKJG(float[] CEEANOFIEKP, int MHOFONMFCJD, int AOEIBOIKGAL, Color FLKMFEMHOII, int BLPOGJFABJE)
	{
		return null;
	}

	private bool DEFLOAHCIGF()
	{
		return false;
	}

	public void GenerateWaveforms(int BLPOGJFABJE)
	{
	}

	public void PPNIDPPJBEL()
	{
	}

	public void AMKEPMAAACN(bool KEFFCGEKLFE = true, bool JEMIMJMCJAF = false)
	{
	}

	public void SetControls()
	{
	}

	public void DLAEMLKLCPN()
	{
	}

	public void NIJBMBLAKLN(string LBELHIHEFED)
	{
	}

	private void Update()
	{
	}

	public void GMEHPPCFGMD(int BLPOGJFABJE)
	{
	}

	public void KFJLOHBDMAO()
	{
	}

	public void DAJHOKPKAIE(string LBELHIHEFED)
	{
	}

	public Texture2D EKLBJEDKKCH(float[] CEEANOFIEKP, int MHOFONMFCJD, int AOEIBOIKGAL, Color FLKMFEMHOII, int BLPOGJFABJE)
	{
		return null;
	}
}
