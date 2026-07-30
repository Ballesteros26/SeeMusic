using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AdvancedColorPicker;
using UnityEngine;
using UnityEngine.UI;

public class SettingsColor : MonoBehaviour
{
	private sealed class JNAHDNDJLDP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SettingsColor _003C_003E4__this;

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
		public JNAHDNDJLDP(int _003C_003E1__state)
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

	private sealed class FMGOHEPIDEC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SettingsColor _003C_003E4__this;

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
		public FMGOHEPIDEC(int _003C_003E1__state)
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

	public GameObject PieceLabelColor;

	public GameObject ComposerLabelColor;

	public GameObject PiecePanelContainer;

	public GameObject SingleColorPanel;

	public GameObject TwelveColorPanel;

	public GameObject GradientColorPanel;

	public GameObject TrackColorPanel;

	public GameObject ColorModeControl;

	public GameObject ColorPanels;

	[NonSerialized]
	public int colorPanelSelectedPitch;

	public GameObject TwelveColorPickers;

	public GameObject KeyButtonSingleColor;

	public GameObject QualityButtonSingleColor;

	public GameObject AccidentalsButtonSingleColor;

	public GameObject KeyButtonTextSingleColor;

	public GameObject QualityButtonTextSingleColor;

	public GameObject AccidentalsButtonTextSingleColor;

	public GameObject KeyButtonTwelveColor;

	public GameObject QualityButtonTwelveColor;

	public GameObject AccidentalsButtonTwelveColor;

	public GameObject KeyButtonTextTwelveColor;

	public GameObject QualityButtonTextTwelveColor;

	public GameObject AccidentalsButtonTextTwelveColor;

	public GameObject KeyButtonTrackColor;

	public GameObject QualityButtonTrackColor;

	public GameObject AccidentalsButtonTrackColor;

	public GameObject KeyButtonTextTrackColor;

	public GameObject QualityButtonTextTrackColor;

	public GameObject AccidentalsButtonTextTrackColor;

	public GameObject KeyButtonGradientColor;

	public GameObject QualityButtonGradientColor;

	public GameObject AccidentalsButtonGradientColor;

	public GameObject KeyButtonTextGradientColor;

	public GameObject QualityButtonTextGradientColor;

	public GameObject AccidentalsButtonTextGradientColor;

	public GameObject ColorPreviewOutline1;

	public GameObject ColorPreviewOutline2;

	public GameObject ColorPreviewOutline3;

	public GameObject ColorPreviewOutline4;

	public GameObject ColorPreviewOutline5;

	public GameObject ColorPreviewOutline6;

	public GameObject ColorPreviewOutline7;

	public GameObject ColorPreviewOutline8;

	public GameObject ColorPreviewOutline9;

	public GameObject ColorPreviewOutline10;

	public GameObject ColorPreviewOutline11;

	public GameObject ColorPreviewOutline12;

	public GameObject ColorPreviewOutlineBG;

	public GameObject ColorPreviewOutlineSingleColorKey;

	public GameObject ColorPreviewOutlineTwelveColorKey;

	public GameObject ColorPreviewOutlineTrackColorKey;

	public GameObject ColorPreviewOutlineGradientColorKey;

	public GameObject ColorPreviewOutlineGradient1;

	public GameObject ColorPreviewOutlineGradient2;

	public GameObject ColorPreviewOutlineGradient3;

	public GameObject ColorPreviewOutlineGradient4;

	public GameObject ColorPreviewOutlineGradient5;

	public GameObject ColorPreviewOutlineGradient6;

	public GameObject ColorPreviewOutlineGradient7;

	public GameObject ColorPreviewOutlineGradient8;

	public GameObject ColorPreviewOutlineTrack1;

	public GameObject ColorPreviewOutlineTrack2;

	public GameObject ColorPreviewOutlineTrack3;

	public GameObject ColorPreviewOutlineTrack4;

	public GameObject ColorPreviewOutlineTrack5;

	public GameObject ColorPreviewOutlineTrack6;

	public GameObject ColorPreviewOutlineTrack7;

	public GameObject ColorPreviewOutlineTrack8;

	public GameObject ColorPreview1Panel;

	public GameObject ColorPreview2Panel;

	public GameObject ColorPreview3Panel;

	public GameObject ColorPreview4Panel;

	public GameObject ColorPreview5Panel;

	public GameObject ColorPreview6Panel;

	public GameObject ColorPreview7Panel;

	public GameObject ColorPreview8Panel;

	public GameObject ColorPreview9Panel;

	public GameObject ColorPreview10Panel;

	public GameObject ColorPreview11Panel;

	public GameObject ColorPreview12Panel;

	public GameObject ColorRow1Panel;

	public GameObject ColorRow2Panel;

	public GameObject ColorRow3Panel;

	public GameObject ColorRow4Panel;

	public GameObject ColorPreview1;

	public GameObject ColorPreview2;

	public GameObject ColorPreview3;

	public GameObject ColorPreview4;

	public GameObject ColorPreview5;

	public GameObject ColorPreview6;

	public GameObject ColorPreview7;

	public GameObject ColorPreview8;

	public GameObject ColorPreview9;

	public GameObject ColorPreview10;

	public GameObject ColorPreview11;

	public GameObject ColorPreview12;

	public GameObject ColorPreviewBG;

	public GameObject ColorPreviewSingleColorKey;

	public GameObject ColorPreviewTwelveColorKey;

	public GameObject ColorPreviewTrackColorKey;

	public GameObject ColorPreviewGradientColorKey;

	public GameObject ColorPreviewGradient1;

	public GameObject ColorPreviewGradient2;

	public GameObject ColorPreviewGradient3;

	public GameObject ColorPreviewGradient4;

	public GameObject ColorPreviewGradient5;

	public GameObject ColorPreviewGradient6;

	public GameObject ColorPreviewGradient7;

	public GameObject ColorPreviewGradient8;

	public GameObject ColorPreviewTrack1;

	public GameObject ColorPreviewTrack2;

	public GameObject ColorPreviewTrack3;

	public GameObject ColorPreviewTrack4;

	public GameObject ColorPreviewTrack5;

	public GameObject ColorPreviewTrack6;

	public GameObject ColorPreviewTrack7;

	public GameObject ColorPreviewTrack8;

	public GameObject ColorPreviewLabel1;

	public GameObject ColorPreviewLabel2;

	public GameObject ColorPreviewLabel3;

	public GameObject ColorPreviewLabel4;

	public GameObject ColorPreviewLabel5;

	public GameObject ColorPreviewLabel6;

	public GameObject ColorPreviewLabel7;

	public GameObject ColorPreviewLabel8;

	public GameObject ColorPreviewLabel9;

	public GameObject ColorPreviewLabel10;

	public GameObject ColorPreviewLabel11;

	public GameObject ColorPreviewLabel12;

	public GameObject ColorPreviewLabelBG;

	public GameObject ColorPreviewLabelTwelveColorKey;

	public GameObject ColorPreviewLabelTrackColorKey;

	public GameObject ColorPreviewLabelGradientColorKey;

	public GameObject ColorPreviewLabelGradient1;

	public GameObject ColorPreviewLabelGradient2;

	public GameObject ColorPreviewLabelGradient3;

	public GameObject ColorPreviewLabelGradient4;

	public GameObject ColorPreviewLabelGradient5;

	public GameObject ColorPreviewLabelGradient6;

	public GameObject ColorPreviewLabelGradient7;

	public GameObject ColorPreviewLabelGradient8;

	public GameObject ColorPreviewLabelTrack1;

	public GameObject ColorPreviewLabelTrack2;

	public GameObject ColorPreviewLabelTrack3;

	public GameObject ColorPreviewLabelTrack4;

	public GameObject ColorPreviewLabelTrack5;

	public GameObject ColorPreviewLabelTrack6;

	public GameObject ColorPreviewLabelTrack7;

	public GameObject ColorPreviewLabelTrack8;

	public GameObject ColorPreviewHueLabel1;

	public GameObject ColorPreviewHueLabel2;

	public GameObject ColorPreviewHueLabel3;

	public GameObject ColorPreviewHueLabel4;

	public GameObject ColorPreviewHueLabel5;

	public GameObject ColorPreviewHueLabel6;

	public GameObject ColorPreviewHueLabel7;

	public GameObject ColorPreviewHueLabel8;

	public GameObject ColorPreviewHueLabel9;

	public GameObject ColorPreviewHueLabel10;

	public GameObject ColorPreviewHueLabel11;

	public GameObject ColorPreviewHueLabel12;

	public GameObject ColorPreviewHueLabelBG;

	public GameObject ColorPreviewHueLabelSingleColorKey;

	public GameObject ColorPreviewHueLabelTwelveColorKey;

	public GameObject ColorPreviewHueLabelTrackColorKey;

	public GameObject ColorPreviewHueLabelGradientColorKey;

	public GameObject ColorPreviewHueLabelGradient1;

	public GameObject ColorPreviewHueLabelGradient2;

	public GameObject ColorPreviewHueLabelGradient3;

	public GameObject ColorPreviewHueLabelGradient4;

	public GameObject ColorPreviewHueLabelGradient5;

	public GameObject ColorPreviewHueLabelGradient6;

	public GameObject ColorPreviewHueLabelGradient7;

	public GameObject ColorPreviewHueLabelGradient8;

	public GameObject ColorPreviewHueLabelTrack1;

	public GameObject ColorPreviewHueLabelTrack2;

	public GameObject ColorPreviewHueLabelTrack3;

	public GameObject ColorPreviewHueLabelTrack4;

	public GameObject ColorPreviewHueLabelTrack5;

	public GameObject ColorPreviewHueLabelTrack6;

	public GameObject ColorPreviewHueLabelTrack7;

	public GameObject ColorPreviewHueLabelTrack8;

	public GameObject ColorPicker1;

	public GameObject ColorPicker2;

	public GameObject ColorPicker3;

	public GameObject ColorPicker4;

	public GameObject ColorPicker5;

	public GameObject ColorPicker6;

	public GameObject ColorPicker7;

	public GameObject ColorPicker8;

	public GameObject ColorPicker9;

	public GameObject ColorPicker10;

	public GameObject ColorPicker11;

	public GameObject ColorPicker12;

	public GameObject ColorPickerBG;

	public GameObject ColorPickerTwelveColorKey;

	public GameObject ColorPickerTrackColorKey;

	public GameObject ColorPickerGradientColorKey;

	public GameObject ColorPickerGradient1;

	public GameObject ColorPickerGradient2;

	public GameObject ColorPickerGradient3;

	public GameObject ColorPickerGradient4;

	public GameObject ColorPickerGradient5;

	public GameObject ColorPickerGradient6;

	public GameObject ColorPickerGradient7;

	public GameObject ColorPickerGradient8;

	public GameObject ColorPickerTrack1;

	public GameObject ColorPickerTrack2;

	public GameObject ColorPickerTrack3;

	public GameObject ColorPickerTrack4;

	public GameObject ColorPickerTrack5;

	public GameObject ColorPickerTrack6;

	public GameObject ColorPickerTrack7;

	public GameObject ColorPickerTrack8;

	public GameObject TrackColor1;

	public GameObject TrackColor2;

	public GameObject TrackColor3;

	public GameObject TrackColor4;

	public GameObject TrackColor5;

	public GameObject TrackColor6;

	public GameObject TrackColor7;

	public GameObject TrackColor8;

	public GameObject GradientColor1;

	public GameObject GradientColor2;

	public GameObject GradientColor3;

	public GameObject GradientColor4;

	public GameObject GradientColor5;

	public GameObject GradientColor6;

	public GameObject GradientColor7;

	public GameObject GradientColor8;

	public GradientPicker gradientPickerComponent;

	public GameObject TrackColorSpacer1;

	public GameObject TrackColorSpacerLeft;

	public GameObject TrackColorSpacerRight;

	public GameObject TrackColorSecondHalfPanel;

	public GameObject DividePointSliderPanel;

	public GameObject DividePointSlider;

	public GameObject TrackColorModeControl;

	public GameObject UseChannelForTrackColorSwitch;

	public GameObject UseChannelForTrackColorSwitchPanel;

	public GameObject GradientColorSecondHalfPanel;

	public GameObject GradientColorSpacer1;

	public GameObject GradientColorSpacerLeft;

	public GameObject GradientColorSpacerRight;

	public GameObject ColorHueCircle;

	public Slider ColorSaturationSlider;

	public ColorSlider SaturationSlider;

	public GradientBackground SaturationSliderGradientBackground;

	public GameObject GradientAngleSlider;

	public GameObject GradientAngleValueText;

	public GameObject RandomNumberOfChannelsSlider;

	public GameObject RandomNumberOfChannelsPanel;

	public GameObject NumberOfTracksSlider;

	public GameObject NumberOfGradientColorsSlider;

	public GameObject NumberOfGradientColorsValueText;

	public GameObject HueValueText;

	public GameObject SatValueText;

	public GameObject LumValueText;

	public GameObject ColorTimeSettings;

	public GameObject TimeSettingsScroller;

	[NonSerialized]
	public SeeMusicScrollerController TimeSettingsScrollerController;

	public GameObject TimeSettingsScrollbar;

	[NonSerialized]
	public List<MGFGDCEJHGB> ColorSaveScrollerList;

	public SeeMusicCellView SeeMusicCellViewPrefab;

	public GameObject ColorPanelsLeft;

	public GameObject ColorPanelRightContainer;

	[NonSerialized]
	private float LMAOJDLAAEG;

	public void ColorHueValueTextChanged()
	{
	}

	public void KMHNGDFBNOH()
	{
	}

	public void HHGCHIDPKOO()
	{
	}

	public void HueCircleAction(bool OBGABFOBEGE = false)
	{
	}

	public void PIPAOFMPEBA()
	{
	}

	public void ColorPreview1Tapped()
	{
	}

	public void PreviousTrackButtonAction()
	{
	}

	public void ColorModeControlAction(int AOCGNPPGDCO)
	{
	}

	public void ColorPreviewGradient2Tapped()
	{
	}

	public void LNNCNJFIFEF()
	{
	}

	public void CreateScrollerControllers()
	{
	}

	public void NNPMEABJGLG()
	{
	}

	public void RandomNumberOfChannelsSliderChanged()
	{
	}

	public void EPECOAABHAF()
	{
	}

	public void NumberOfGradientColorsSliderChanged()
	{
	}

	public void ColorPreviewBGTapped()
	{
	}

	public void AddColorSave()
	{
	}

	public void AJMALLNHPGB()
	{
	}

	public void KJJBBEOGFMD()
	{
	}

	public void GGGONPAKDFK()
	{
	}

	public void HJMEJOOIEFN()
	{
	}

	public void HJMPJOEIGDL(bool MGGIGCBLNHK = false)
	{
	}

	public void ColorPreviewTrack5Tapped()
	{
	}

	public void ColorPreviewTwelveKeyColorTapped()
	{
	}

	public void GCIMMGPMGMI()
	{
	}

	public void FLGFPMEOLKB()
	{
	}

	[IteratorStateMachine(typeof(JNAHDNDJLDP))]
	public IEnumerator ReloadScrollersAfterOneFrame()
	{
		return null;
	}

	public void ColorPreviewGradient4Tapped()
	{
	}

	public void EDAKNIIBIBA(int KIJBMNOJLPK, Color OLJIIPPOIHN, bool GFCPDLPBEKN = true)
	{
	}

	public void INALODBOPGE()
	{
	}

	public void JLKABJNMFFP()
	{
	}

	public void ColorPreview11Tapped()
	{
	}

	public void UpdateEntireColorUI()
	{
	}

	public void BPIFLNMHFMP()
	{
	}

	public void ColorPreview12Tapped()
	{
	}

	public void EHBHGPGNLHF()
	{
	}

	private int EDBPJDCMCJH(KCDPMOLPJNI LIBFLDPPPEH, KCDPMOLPJNI KNFBMKLLPAG)
	{
		return 0;
	}

	public void ColorPreviewGradient1Tapped()
	{
	}

	public void ColorPreviewGradient8Tapped()
	{
	}

	public void ColorPreview4Tapped()
	{
	}

	public void JJPLMAEBPDM()
	{
	}

	public void AOCHAFCLAMP()
	{
	}

	public void ColorPreviewGradient7Tapped()
	{
	}

	public void UpdateColorValueText()
	{
	}

	public void ColorPreviewTapAction(int GFGELBPJBOF)
	{
	}

	public void ColorPreviewTrack2Tapped()
	{
	}

	public void RemoveGradientAlphaKey()
	{
	}

	public void SelectColorSave(float DHIOKOLGBPH)
	{
	}

	public void BJGGCGDJOOP(int KIJBMNOJLPK, Color OLJIIPPOIHN, bool GFCPDLPBEKN = true)
	{
	}

	public void ColorPreviewTrack7Tapped()
	{
	}

	public void RemoveColorSave()
	{
	}

	private int AKAOCAGHIMN(KCDPMOLPJNI LIBFLDPPPEH, KCDPMOLPJNI KNFBMKLLPAG)
	{
		return 0;
	}

	private int BEECCHKLBHE(KCDPMOLPJNI LIBFLDPPPEH, KCDPMOLPJNI KNFBMKLLPAG)
	{
		return 0;
	}

	public IEnumerator NDOPCFEBMAM()
	{
		return null;
	}

	public void SetControls()
	{
	}

	public void FGCOHICOELC()
	{
	}

	public void UseChannelForTrackColorAction()
	{
	}

	private void Update()
	{
	}

	public void UpdateSelectedOutlineColor()
	{
	}

	public void IGHAAIOLMHD()
	{
	}

	public void BIGCEDJMBFJ()
	{
	}

	public void AccidentalsButtonAction()
	{
	}

	public void TimeSwitchControlAction(int AOCGNPPGDCO)
	{
	}

	public void Start()
	{
	}

	public void EBOHCJIKJDO(int GFGELBPJBOF)
	{
	}

	public void ICHANPOGMJE(bool DGOOHIPIDFP = false, bool NKGOHLCABMI = false)
	{
	}

	public void ColorPreview10Tapped()
	{
	}

	public void ColorPreview8Tapped()
	{
	}

	public void ColorPreviewGradient5Tapped()
	{
	}

	public void ColorPreviewGradient3Tapped()
	{
	}

	public void RemoveGradientColorKey()
	{
	}

	public void ColorLumValueTextChanged()
	{
	}

	public void EBJDLOHOOKE(int AOCGNPPGDCO)
	{
	}

	public void KCBEDJLDPBL()
	{
	}

	private int FKGNBOFKHBM(KCDPMOLPJNI LIBFLDPPPEH, KCDPMOLPJNI KNFBMKLLPAG)
	{
		return 0;
	}

	public void LNNMGAJIELM()
	{
	}

	public void ReloadScrollers()
	{
	}

	public void UpdateColorModeUI()
	{
	}

	public void ColorSaveSelected(int JCLFGKNOCFE)
	{
	}

	public void ColorPreview2Tapped()
	{
	}

	public void DJBENOBHIAC(int KIJBMNOJLPK, Color OLJIIPPOIHN, bool GFCPDLPBEKN = true)
	{
	}

	public void ColorPreviewTrack4Tapped()
	{
	}

	public void UpdateGradientPointsUI()
	{
	}

	public void ColorSatValueTextChanged()
	{
	}

	public void JPFAMHHKPEC()
	{
	}

	public void GMKBLOJPFBK()
	{
	}

	public void ColorPreviewGradient6Tapped()
	{
	}

	public void HighlightSelection(bool DGOOHIPIDFP = false, bool NKGOHLCABMI = false)
	{
	}

	public void ColorPreview7Tapped()
	{
	}

	public void NumberOfTracksSliderChanged()
	{
	}

	private void FHENLCGHKAI()
	{
	}

	public void NJPPCIMOOBL()
	{
	}

	public void ColorPreviewTrack8Tapped()
	{
	}

	public void ColorPreviewTrack1Tapped()
	{
	}

	public void UpdateColorRow(int KIJBMNOJLPK, Color OLJIIPPOIHN, bool GFCPDLPBEKN = true)
	{
	}

	public void KeyButtonAction()
	{
	}

	public void ColorPreviewTrack6Tapped()
	{
	}

	public void SortColorTime()
	{
	}

	private int NGPLOMLEJDP(KCDPMOLPJNI LIBFLDPPPEH, KCDPMOLPJNI KNFBMKLLPAG)
	{
		return 0;
	}

	public void DividePointSliderChanged()
	{
	}

	[IteratorStateMachine(typeof(FMGOHEPIDEC))]
	public IEnumerator AddLayoutGroupAfterOneFrame()
	{
		return null;
	}

	public void ColorSliderChanged()
	{
	}

	public void ColorPreview6Tapped()
	{
	}

	public void MEOALOOGMBE()
	{
	}

	public void UpdateNumberOfTracksUI(bool MGGIGCBLNHK = false)
	{
	}

	public void NextTrackButtonAction()
	{
	}

	public void ColorPreview5Tapped()
	{
	}

	public void ColorPreview9Tapped()
	{
	}

	public void DNMGKNBKIOF(int AOCGNPPGDCO)
	{
	}

	public void ColorPreviewTrack3Tapped()
	{
	}

	public void TrackColorModeControlAction(int AOCGNPPGDCO)
	{
	}

	public void ColorTimeInputFieldEdited(int ANOPGILBLFM)
	{
	}

	public void ILKFNIIEMEL()
	{
	}

	private void Awake()
	{
	}

	public void QualityButtonAction()
	{
	}

	private int JHKFIJPJFLF(KCDPMOLPJNI LIBFLDPPPEH, KCDPMOLPJNI KNFBMKLLPAG)
	{
		return 0;
	}

	public void LAJGNJGNILJ(bool MGGIGCBLNHK = false)
	{
	}

	public void ColorPreview3Tapped()
	{
	}

	public void PCIEONBLEGJ(bool OBGABFOBEGE = false)
	{
	}

	public void UpdateNumberOfGradientColorsUI(bool MGGIGCBLNHK = false)
	{
	}
}
