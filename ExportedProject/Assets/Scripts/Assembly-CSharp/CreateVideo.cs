using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateVideo : MonoBehaviour
{
	private sealed class IICDNBOEHNE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CreateVideo _003C_003E4__this;

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
		public IICDNBOEHNE(int _003C_003E1__state)
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

	private sealed class GFILDJGOEFF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CreateVideo _003C_003E4__this;

		public bool cancelRecording;

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
		public GFILDJGOEFF(int _003C_003E1__state)
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

	private sealed class EPKHHOLDHOM
	{
		public float timeWaitStarted;

		public CreateVideo _003C_003E4__this;

		internal bool HCPLOCGKLFD()
		{
			return false;
		}

		internal bool MLLAGMLIKLF()
		{
			return false;
		}
	}

	private sealed class OENGAGOHFDP
	{
		public float timeWaitStarted;

		public CreateVideo _003C_003E4__this;

		internal bool IAJCMJMNDPG()
		{
			return false;
		}

		internal bool JNCINCNLMKJ()
		{
			return false;
		}
	}

	private sealed class FFHEHFMDMDJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CreateVideo _003C_003E4__this;

		private EPKHHOLDHOM _003C_003E8__1;

		private OENGAGOHFDP _003C_003E8__2;

		private int _003COriginalSampleRate_003E5__2;

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
		public FFHEHFMDMDJ(int _003C_003E1__state)
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

	private sealed class IAMPOHPNMMC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CreateVideo _003C_003E4__this;

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
		public IAMPOHPNMMC(int _003C_003E1__state)
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

	public GameObject CreateVideoPanel;

	public GameObject CreateVideoPieceLabel;

	public GameObject CreateVideoDurationLabel;

	public GameObject CreateVideoRangeSlider;

	public GameObject CreateVideoRangeLeftFieldSec;

	public GameObject CreateVideoRangeLeftFieldMin;

	public GameObject CreateVideoRangeRightFieldSec;

	public GameObject CreateVideoRangeRightFieldMin;

	public GameObject CreateVideoFramerateLabel;

	public GameObject CreateVideoFramerateLabelPanel;

	public GameObject CreateVideoResolutionLabel;

	public GameObject CreateVideoQualityLabel;

	public GameObject CreateVideoFrameworkLabel;

	public GameObject CreateVideoFrameworkLabelPanel;

	public GameObject CreateVideoVolumeBoostLabel;

	public GameObject RenderCompletePanel;

	public TextMeshProUGUI RenderCompleteTitle;

	public GameObject WatermarkPanel;

	public GameObject CreateVideoProgressPanel;

	public GameObject CreateVideoProgressBar;

	public GameObject CreateVideoProgressPieceLabel;

	public GameObject CreateVideoProgressActionText;

	public GameObject CreateVideoProgressTimeLeft;

	public GameObject CreateVideoProgressPreview;

	public GameObject CreateVideoProgressBackground;

	public Image CreateVideoProgressImageComponent;

	public GameObject CreateVideoSettings;

	public GameObject CaptureFramerateControl;

	public GameObject RenderVideoSoundButton;

	public GameObject RenderVideoSoundButtonMain;

	public GameObject VideoResolutionControl;

	public GameObject VideoQualityControl;

	public GameObject RenderFrameworkControl;

	public GameObject RenderAspectRatioControl;

	public GameObject CodecParentPanel;

	public GameObject RenderVideoCodecPanel;

	public GameObject RenderVideoCodecLabel;

	public GameObject RenderVideoCodecLabelPanel;

	public GameObject RenderVideoCodecControl;

	public GameObject RenderTransparentPanel;

	public GameObject RenderTransparentChildPanel;

	public GameObject RenderTransparentLabel;

	public GameObject RenderTransparentLabelPanel;

	public GameObject RenderTransparentControl;

	public GameObject FrameworkPanel;

	public GameObject ExtensionParentPanel;

	public GameObject ExtensionLayoutPanel;

	public GameObject RenderAudioCodecPanel;

	public GameObject RenderAudioCodecLabel;

	public GameObject RenderAudioCodecLabelPanel;

	public GameObject RenderAudioCodecControl;

	public GameObject ConfigureVideoCodecPanel;

	public GameObject RenderExtensionPanel;

	public GameObject RenderExtensionLabel;

	public GameObject RenderExtensionLabelPanel;

	public GameObject RenderExtensionControl;

	public GameObject FrameworkSoundParentPanel;

	public GameObject FrameworkSoundLayoutPanel;

	public GameObject VolumeBoostSlider;

	public GameObject VolumeBoostValueText;

	public Text createVideoSpeedText;

	public Text createVideoFramerateText;

	public GameObject FrameworkParentPanel;

	public GameObject RenderFrameworkPanel;

	public GameObject ShowRenderPreviewPanel;

	public GameObject ShowRenderPreviewCheckbox;

	public GameObject BottomSettingsPanel;

	public Sprite ConfigureLagarithImage;

	public Sprite ConfigureMagicYUVImage;

	[NonSerialized]
	public float renderStartTime;

	[NonSerialized]
	public float videoRenderTimeElapsed;

	[NonSerialized]
	public float videoRenderSpeed;

	public float audioRenderTimePassed;

	public bool audioRenderPlaybackStarted;

	[NonSerialized]
	private bool DLJOEADDBBC;

	[NonSerialized]
	public int FramerateBeforeRender;

	[NonSerialized]
	public string AspectBeforeRender;

	public void LJBAMOIPHCG()
	{
	}

	public void EPICJBCBBLD()
	{
	}

	public void RenderRangeChanged()
	{
	}

	[CompilerGenerated]
	private void ODNNBMFJMNJ()
	{
	}

	public void UpdateCreateVideoLabels()
	{
	}

	public void HAFKDFGEGLJ()
	{
	}

	public void JMNJDBDHKJP()
	{
	}

	private void JPNGMHNEILC()
	{
	}

	private void PEICHKCINIM()
	{
	}

	public void CFPLJBDHJIE()
	{
	}

	private void HDBLEGPKPIN()
	{
	}

	public void FONANIMAJDF()
	{
	}

	public void CheckAudioRenderTime()
	{
	}

	public void AFHMLIKNNBI()
	{
	}

	public void BMMBMFBGJHE()
	{
	}

	public void RenderButtonAction()
	{
	}

	public void AGNNOBDPJDN(int AOCGNPPGDCO)
	{
	}

	public void EAPABIEBGND()
	{
	}

	public bool LCDEHFBJFCH()
	{
		return false;
	}

	[CompilerGenerated]
	private void MKPKIGABGNC()
	{
	}

	public void PPNLCKMEAPK(int AOCGNPPGDCO)
	{
	}

	public void RenderHelpButtonAction()
	{
	}

	private void GICIFLHFIEB()
	{
	}

	public void AMDIMLILJGH(int AOCGNPPGDCO)
	{
	}

	public IEnumerator NOLLHOBCBLI(bool KEDMAJLGPMG = false)
	{
		return null;
	}

	public void GPLPBLICAOK()
	{
	}

	public void AssignRenderedAudioToClip(AudioClip PHHLFEIOHGG, string EDCDFNFGDDK)
	{
	}

	public void UpdateCreateVideoProgressBar()
	{
	}

	public void NPADMBOEAGF()
	{
	}

	public IEnumerator FLJCPGKFCFN()
	{
		return null;
	}

	private void NNPPMFBOODF()
	{
	}

	public void NLEILJCKEKJ(int AOCGNPPGDCO)
	{
	}

	private void GMNNENEOAEJ()
	{
	}

	public void NOGDNPEEMME()
	{
	}

	public void PCEMKNPOHBO()
	{
	}

	public void GIOGHGBAEFL()
	{
	}

	public void SelectFormatSegments()
	{
	}

	public void LHMDFFNLFKO(string BNJFBIPBDEF)
	{
	}

	public void FOANPLGIADE(int AOCGNPPGDCO)
	{
	}

	public void AudioCodecControlAction(int AOCGNPPGDCO)
	{
	}

	private void LNIIIMNLFHC()
	{
	}

	public void PIHMFEKLPMC()
	{
	}

	public void SetRangeFields()
	{
	}

	public void KOAKMDAJOMJ()
	{
	}

	[IteratorStateMachine(typeof(FFHEHFMDMDJ))]
	public IEnumerator CreateVideoAfterOpenCoroutine()
	{
		return null;
	}

	public void IHOGCCALEJE(int AOCGNPPGDCO)
	{
	}

	public void CALLNGAHBHI()
	{
	}

	private void KPHLCNPELAA()
	{
	}

	public void FNDDHMGEJNK(int AOCGNPPGDCO)
	{
	}

	public void KOEAFJICDHG(int AOCGNPPGDCO)
	{
	}

	public void SetControls()
	{
	}

	public void DCONFNGOKLC(int AOCGNPPGDCO)
	{
	}

	private void OIBLPHDAHDF()
	{
	}

	public bool LJFMLNOGOCE()
	{
		return false;
	}

	public void DOKNPIPMNJB()
	{
	}

	public void DONLHKCOMKF(int AOCGNPPGDCO)
	{
	}

	private void FFBBAOHCOOD()
	{
	}

	public void GOMHHKFFPKI()
	{
	}

	private void DPELLILFEJB()
	{
	}

	public void CloseCreateVideoPanel()
	{
	}

	private void Start()
	{
	}

	private bool FHIMMMCNGJB()
	{
		return false;
	}

	public void InstallLagarithAlert()
	{
	}

	public void HADIFKDONKE()
	{
	}

	public void IOCLLIJEPFI()
	{
	}

	public void PDIHKIJNAGN()
	{
	}

	public void VideoCodecControlAction(int AOCGNPPGDCO)
	{
	}

	public void VideoResolutionControlAction(int AOCGNPPGDCO)
	{
	}

	public void ShowRenderPreviewCheckboxAction()
	{
	}

	public void CreateVideoAfterOpenFile()
	{
	}

	public void DHLFABICOOL()
	{
	}

	public void AKFNCOPADEN()
	{
	}

	public void OKJLIGGLJEO(int AOCGNPPGDCO)
	{
	}

	public void CloseCreateVideoSettings()
	{
	}

	public void GDHMPHEIMDH()
	{
	}

	public void GECAJBPBOGB(int AOCGNPPGDCO)
	{
	}

	[CompilerGenerated]
	private void PBIPNFJOPBM()
	{
	}

	public void HPBDKLNHBOH()
	{
	}

	public void ToggleRenderSound()
	{
	}

	public void LFOHECKOAAA()
	{
	}

	private void MPMPGNJLDMD()
	{
	}

	[IteratorStateMachine(typeof(GFILDJGOEFF))]
	public IEnumerator CreateVideoAction(bool LLNACDHNKJD = false)
	{
		return null;
	}

	private void AMENEIOLOFA()
	{
	}

	public void VolumeBoostSliderChanged()
	{
	}

	public void APNEOLMIGBD(int AOCGNPPGDCO)
	{
	}

	public int GetCodecIndex(string PIGIPJFBACC)
	{
		return 0;
	}

	public bool VideoCodecSupportsTransparent()
	{
		return false;
	}

	public IEnumerator BKBCBHNJBDK(bool KEDMAJLGPMG = false)
	{
		return null;
	}

	public void FEAGBFJEDAK()
	{
	}

	public void NPMFDDKOLEL()
	{
	}

	private void GMHKEGDJIEO()
	{
	}

	public void InstallMagicYUVAlert()
	{
	}

	private void FGADKBFJCHL()
	{
	}

	public void BMAPCJEFMPJ()
	{
	}

	public void AKEPIBOKFHO()
	{
	}

	public void FFJDLMMCOJM()
	{
	}

	public void FHNKKOIMKGJ()
	{
	}

	public void NHFLPDNHEJP(int AOCGNPPGDCO)
	{
	}

	private void BBINOJNHDDN()
	{
	}

	public void NACCMGJHFGB(int AOCGNPPGDCO)
	{
	}

	public void PLHAMLEMAPK()
	{
	}

	public void CancelCreateVideo()
	{
	}

	public void VideoQualityControlAction(int AOCGNPPGDCO)
	{
	}

	private void KCEBELLKIBB()
	{
	}

	public void CBJKPJBDNDC()
	{
	}

	public void NJLKDKBIJPP()
	{
	}

	[CompilerGenerated]
	private bool OKMLEGCODEI()
	{
		return false;
	}

	public void AHFPDILHFGI()
	{
	}

	[CompilerGenerated]
	private void EFNIIBIIEMC()
	{
	}

	public void VideoRenderComplete()
	{
	}

	public void SetVideoBitrate()
	{
	}

	public void AudioRenderComplete()
	{
	}

	public void CreateVideoSettingsButtonAction()
	{
	}

	private void CPKOBHJAFJL()
	{
	}

	private void Awake()
	{
	}

	private bool CPHFFGMMDOD()
	{
		return false;
	}

	public void PLCOMDGHHGP(int AOCGNPPGDCO)
	{
	}

	public void VolumeBoostTextInputChanged()
	{
	}

	public void DFHJINBNCCE()
	{
	}

	public void KHGFNFIPGOK(int AOCGNPPGDCO)
	{
	}

	public void EPKEJHDLLBI()
	{
	}

	public void RenderAspectRatioControlAction(int AOCGNPPGDCO)
	{
	}

	private void FOGNJAJMOEG()
	{
	}

	[IteratorStateMachine(typeof(IICDNBOEHNE))]
	public IEnumerator PrepareAudioClipForVideoRender()
	{
		return null;
	}

	public void CHIEGPKHKIN()
	{
	}

	public void GIKKFLJFKFL()
	{
	}

	private void MDNELOCAOCP()
	{
	}

	public void UpdateFormatsOn()
	{
	}

	[CompilerGenerated]
	private bool BIKJAFPEKEG()
	{
		return false;
	}

	public void DNJODPFOHIK()
	{
	}

	public void OpenRenderCompletePanel()
	{
	}

	public void MBHOLAJFAFC()
	{
	}

	public void CEDPIDDPAHC(int AOCGNPPGDCO)
	{
	}

	public void SetFormatTransparentControls()
	{
	}

	private void EMOLNCEJBJN()
	{
	}

	private void Update()
	{
	}

	[CompilerGenerated]
	private void ABEDJLOEIFJ()
	{
	}

	public int LKFPCIGKKFC(string PIGIPJFBACC)
	{
		return 0;
	}

	public void UpdateCreateVideoResolutionLabel()
	{
	}

	public void RenderTransparentControlAction(int AOCGNPPGDCO)
	{
	}

	public void BLBPPMLLDKO(int AOCGNPPGDCO)
	{
	}

	private void GPFOCNOGIAK()
	{
	}

	public void RenderVideoSoundButtonAction()
	{
	}

	public void JHFBHJHMAGL(string BNJFBIPBDEF)
	{
	}

	private void CMEBAAODKCI()
	{
	}

	public void LGOLCIGCGDJ()
	{
	}

	private void NPFPBIMHGKC()
	{
	}

	public void RangeFieldRightEdited(string BNJFBIPBDEF)
	{
	}

	[CompilerGenerated]
	private void KJABGNNBLHD()
	{
	}

	public void RenderCompleteDoneAction()
	{
	}

	public void PFAFOICFGGE(int AOCGNPPGDCO)
	{
	}

	public void JIPIJDHMEAN()
	{
	}

	public void WatermarkUpgradeAction()
	{
	}

	private void PHMBLLDOGJE()
	{
	}

	public void INAKGPACIIF(int AOCGNPPGDCO)
	{
	}

	public IEnumerator ALDBGMKOPNF(bool KEDMAJLGPMG = false)
	{
		return null;
	}

	public void AADFFLPAOBA()
	{
	}

	[CompilerGenerated]
	private void JBMALEDPPNI()
	{
	}

	public void BCBKCHNIMMJ(int AOCGNPPGDCO)
	{
	}

	public void DCMNABMAGKB(int AOCGNPPGDCO)
	{
	}

	public void FFEKOPBEKGC()
	{
	}

	public void NFFGMIPKGNJ(int AOCGNPPGDCO)
	{
	}

	public void DPIHELOJLOJ()
	{
	}

	public void JLEFCGKCFBK(int AOCGNPPGDCO)
	{
	}

	public void KLGBOPKCIMP()
	{
	}

	public int BHJAFLPBPIL(string PIGIPJFBACC)
	{
		return 0;
	}

	public void HandleRangeFieldChange()
	{
	}

	[CompilerGenerated]
	private void JEOJJBFGHHH()
	{
	}

	public void UpdateFrameworkLabel()
	{
	}

	private void NNCLDNKGMOP()
	{
	}

	public void RenderFrameworkControlAction(int AOCGNPPGDCO)
	{
	}

	public void JMMKDKKJIGC()
	{
	}

	public bool CheckCodecAvailable(string PIGIPJFBACC)
	{
		return false;
	}

	public void ConfigureVideoCodecButtonAction()
	{
	}

	private void GCIDCJCLCBG()
	{
	}

	private void GBHMGMNOPFI()
	{
	}

	private void AKIAKIBPDNF()
	{
	}

	[CompilerGenerated]
	private void IKANHKKHBFK()
	{
	}

	private void INLKPMOHMOG()
	{
	}

	public void EIHOLCGPICP()
	{
	}

	public void BJEDKEIFBMN()
	{
	}

	public bool POCEGGNLOKN()
	{
		return false;
	}

	public void ResetToH264()
	{
	}

	public void RangeFieldLeftEdited(string BNJFBIPBDEF)
	{
	}

	public void KBJGGFDIDEK(int AOCGNPPGDCO)
	{
	}

	public void FJABBAONCOM()
	{
	}

	public IEnumerator GGGGHKOIOCD(bool LLNACDHNKJD = false)
	{
		return null;
	}

	[IteratorStateMachine(typeof(IAMPOHPNMMC))]
	public IEnumerator UpdateFormatControlValues(bool KEDMAJLGPMG = false)
	{
		return null;
	}

	public void WatermarkSkipAction()
	{
	}

	public void VideoFramerateControlAction(int AOCGNPPGDCO)
	{
	}

	public void RenderExtensionControlAction(int AOCGNPPGDCO)
	{
	}

	public void OpenWatermarkPanel()
	{
	}

	public void JDBKGPCINEB(int AOCGNPPGDCO)
	{
	}
}
