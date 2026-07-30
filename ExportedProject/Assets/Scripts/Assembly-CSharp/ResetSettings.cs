using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ResetSettings : MonoBehaviour
{
	private sealed class NFLJEDDMIPC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ResetSettings _003C_003E4__this;

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
		public NFLJEDDMIPC(int _003C_003E1__state)
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

	public Preferences Preferences;

	[NonSerialized]
	public List<MGFGDCEJHGB> settingsScrollerList;

	public GameObject SettingsScroller;

	public GameObject SettingsScrollbar;

	[NonSerialized]
	public SeeMusicScrollerController SettingsScrollerController;

	[NonSerialized]
	public int selectedSettingsSaveIndex;

	[NonSerialized]
	public SeeMusicSettingsSave CurrentSave;

	public SeeMusicCellView SeeMusicCellViewPreFab;

	public SeeMusicCellView SeeMusicCellViewSaveSettingsPreFab;

	public SceneSingleton SceneSingleton;

	public UIManager UIManager;

	public MIDIControl MIDIControl;

	public SaveSettingsCheckboxPanel SaveSettingsCheckboxPanel;

	private string OFKKMOIHAPP;

	private SeeMusicSettingsSave OGDPPNIKHCK;

	private List<string> KHHOFGHDNHM;

	public List<string> SelectedSettingsToApply;

	[NonSerialized]
	public bool ToggleCallbacksOn;

	public void PLHAMLEMAPK()
	{
	}

	public void PNICBLAFCNG()
	{
	}

	public void BMLBOOALMNF()
	{
	}

	public void UpdateSettingsScrollerList(bool LONIELAOHFN = false)
	{
	}

	public void GMJLGPDMIDN(bool LONIELAOHFN = false)
	{
	}

	public void AACCEKFGELK(bool LONIELAOHFN = false)
	{
	}

	public void HHHGGGPEAMB()
	{
	}

	public void APMJABBADDL(string HIBNDDLLHAG, bool EDACFBJIFAG)
	{
	}

	public void CFNJPPFOAKI()
	{
	}

	private void OBHADIJIELJ()
	{
	}

	public void OEHCODOJBIO(bool LONIELAOHFN = false)
	{
	}

	public void LLIMLPMEGHA(int JCLFGKNOCFE)
	{
	}

	private void GIJFFDLLCOF()
	{
	}

	public void EAOBBFJCNOA(int JCLFGKNOCFE)
	{
	}

	public void FNEEBCKBMAM()
	{
	}

	public void KGFFABBMKLP()
	{
	}

	public void BHMJEBFIGAC()
	{
	}

	public void CreateScrollerControllers()
	{
	}

	private void KJCGDHMCFOC()
	{
	}

	public void LALOMINHKIL()
	{
	}

	public void FLKODJJNLFL(bool LONIELAOHFN = false)
	{
	}

	[IteratorStateMachine(typeof(NFLJEDDMIPC))]
	public IEnumerator ReloadScrollersAfterOneFrame()
	{
		return null;
	}

	public void LOLCEEHFLAB()
	{
	}

	public void BHHCAKIBEBE()
	{
	}

	public void LPNFBMFGHDO()
	{
	}

	private void DFDFCPNGFNG()
	{
	}

	public void OOHNANMPLGP()
	{
	}

	public void PNHHGMMDMFJ()
	{
	}

	public void FLCCPHDBHDK(string HIBNDDLLHAG, bool EDACFBJIFAG)
	{
	}

	public void MJNGNCGECOI(MGFGDCEJHGB OODHIAIJBNP)
	{
	}

	public void DDJMPBPOIHH()
	{
	}

	public void DGHCBMEFAJN()
	{
	}

	public void GFLJIKLBOOA()
	{
	}

	public void MMMBFAHLNEC()
	{
	}

	public void NJEIMLDKBDD(int JCLFGKNOCFE)
	{
	}

	public void PKKLPFONNJL(MGFGDCEJHGB OODHIAIJBNP)
	{
	}

	public IEnumerator DAJCGAEODCC()
	{
		return null;
	}

	public void JEMGNOKFGAC(int JCLFGKNOCFE)
	{
	}

	public void BIMFFPDEHOA()
	{
	}

	public void BMMAMNPEHFF()
	{
	}

	public void CloseResetSettingsPanel()
	{
	}

	public void KNMMKAELLHJ(MGFGDCEJHGB OODHIAIJBNP)
	{
	}

	public void NAMHNFDPKBC()
	{
	}

	public void APOCMGBNIJF()
	{
	}

	public void BMPLGAINOMD()
	{
	}

	public void FBPCFFJFJGC()
	{
	}

	public void SelectNoneSettingsAction()
	{
	}

	public void SetScrollerDataValues()
	{
	}

	public void OOKAIIGEAAA()
	{
	}

	public void GGEHKKPLMFA()
	{
	}

	public void LoadSettingsSave()
	{
	}

	public void FMBDHOBBHIM()
	{
	}

	public void LADPGPBJGMK()
	{
	}

	public void PDOJHMGAEJJ(int JCLFGKNOCFE)
	{
	}

	public void BBLBNIDHJGC()
	{
	}

	public void LNHLFFHLAPG()
	{
	}

	public void IKAMIGEBKFI(int JCLFGKNOCFE)
	{
	}

	public void JAPDFLPCONO()
	{
	}

	private void Start()
	{
	}

	public void EOEEAICKGLI()
	{
	}

	public void DAEGPKBCOLE(MGFGDCEJHGB OODHIAIJBNP)
	{
	}

	public void OCIAEDGKAPP()
	{
	}

	public void SelectVariablesForOpenPanel()
	{
	}

	public void GPODNKOOBGL()
	{
	}

	public void MEFFELBGODP()
	{
	}

	public void EKBGDJCCEBC(MGFGDCEJHGB OODHIAIJBNP)
	{
	}

	private void GEIDLENPEOH()
	{
	}

	private void MLDMFGBLIFN()
	{
	}

	public void SettingsCheckboxTapped(string HIBNDDLLHAG, bool EDACFBJIFAG)
	{
	}

	private void OIMHJFDGHPE()
	{
	}

	private void KBKENOEGBOC()
	{
	}

	public void FBNHEDHKEOH(MGFGDCEJHGB OODHIAIJBNP)
	{
	}

	public void GGPDBJOHOMJ()
	{
	}

	public void EEGDADLAPLB(MGFGDCEJHGB OODHIAIJBNP)
	{
	}

	public void FIPDJHIFNKC()
	{
	}

	public void FJAGHBNPJDO()
	{
	}

	private void LCACMOJCGDJ()
	{
	}

	public IEnumerator MMMMNNKNHNF()
	{
		return null;
	}

	public void ReloadScrollers()
	{
	}

	public void SetControls()
	{
	}

	public void UpdateSelectedSettingsToApply()
	{
	}

	public void DMMKEELAGGH()
	{
	}

	public void CPEPDMOMCPL()
	{
	}

	public void SelectAllSettingsAction()
	{
	}

	public void LFGJJNNJPMA()
	{
	}

	public void IEBLPEEDMAA()
	{
	}

	private void ICJDDHBLHAL()
	{
	}

	public void EIPPJIFMHIK()
	{
	}

	public void CategoryCheckboxTapped(List<string> KINCANOBGGL, bool EDACFBJIFAG)
	{
	}

	public void PLGOOAPHDDC()
	{
	}

	private void MAEKFJIAHFP()
	{
	}

	public void FHPEALCFDBE()
	{
	}

	public void LCDJEMIDPLE(string HIBNDDLLHAG, bool EDACFBJIFAG)
	{
	}

	public void BELHJNMIEPG()
	{
	}

	public void SettingsScrollerRowSelected(int JCLFGKNOCFE)
	{
	}

	private void Update()
	{
	}

	public void LBIDKBGMHAA()
	{
	}

	private void LLNKAMEMFLF()
	{
	}

	private void LMNFPCNDHDJ()
	{
	}

	private void LDBFILLOLPC()
	{
	}

	public void CCOOBJJJCPO(MGFGDCEJHGB OODHIAIJBNP)
	{
	}

	public void CHINOLPAEKN(bool LONIELAOHFN = false)
	{
	}

	public void IDHOBNGELFA()
	{
	}

	public void OHJFLABIHCC()
	{
	}

	public void SetScrollerDataValue(MGFGDCEJHGB OODHIAIJBNP)
	{
	}

	public void AFNHMMIEAMN()
	{
	}

	public void PFADAHIGFBA()
	{
	}

	public void SettingsSaveScrollerRowSelected(int JCLFGKNOCFE)
	{
	}

	private void CFIFNAGMLNE()
	{
	}

	public void GFDELPMIFLO()
	{
	}

	public void ILAIFKIKJFA(int JCLFGKNOCFE)
	{
	}

	public void FOGIJGMFEMP()
	{
	}

	public void CAPMLPLFEKC()
	{
	}

	public void ResetButtonAction()
	{
	}

	private void DJMMOGFKMAO()
	{
	}

	private void IBLOABJPLEB()
	{
	}

	public IEnumerator DIAOEIPKFLL()
	{
		return null;
	}

	private void Awake()
	{
	}
}
