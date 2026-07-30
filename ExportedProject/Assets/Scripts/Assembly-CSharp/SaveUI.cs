using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class SaveUI : MonoBehaviour
{
	private sealed class BGANKLALCNA
	{
		public bool overwrite;

		public SaveUI _003C_003E4__this;

		internal void MCAMLOGMGCO()
		{
		}
	}

	private sealed class LJBGGMJDLJM
	{
		public SaveUI _003C_003E4__this;

		public SeeMusicSettingsSave settingsSave;

		public List<string> SettingsToApply;

		internal void IIJMPHNNFCK()
		{
		}
	}

	private sealed class KGHMNCMDLIH
	{
		public string s;

		internal string BAPPLFOEKOF(char x, int i)
		{
			return null;
		}
	}

	private sealed class EOOPJMHFANM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SaveUI _003C_003E4__this;

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
		public EOOPJMHFANM(int _003C_003E1__state)
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
	public List<MGFGDCEJHGB> settingsSaveList;

	[NonSerialized]
	public List<string> settingsSaveFiles;

	public GameObject SaveScrollerPanel;

	[NonSerialized]
	public List<LPKBLPOAADM> settingsOnList;

	[NonSerialized]
	public List<string> settingsInSave;

	public GameObject SettingsSaveScroller;

	public GameObject SettingsSaveScrollbar;

	[NonSerialized]
	public SeeMusicScrollerController SettingsSaveScrollerController;

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

	public GameObject MainButtons;

	public GameObject NewSaveButtons;

	public List<string> SelectedSettingsToApply;

	public TextMeshProUGUI TitleComponent;

	public GameObject InSaveText;

	public GameObject CurrentText;

	[NonSerialized]
	public bool CreatingNewSave;

	[NonSerialized]
	public bool ToggleCallbacksOn;

	[NonSerialized]
	private string FGNPOCDBMFA;

	public void ExportSettingsSaveFile()
	{
	}

	[CompilerGenerated]
	private void HEBDBBBIBHK()
	{
	}

	public void ApplyButtonAction()
	{
	}

	[CompilerGenerated]
	private void AFAMJAEFPPF()
	{
	}

	public string[] ODAEJOLCEGF()
	{
		return null;
	}

	public void KLNKAAPKFOA(bool JOGJBPPHMMO = false, bool AJPOPLJEJNH = false, string GAMPPLCNNPM = "")
	{
	}

	private void KEPBMBBAJLF()
	{
	}

	public void DECNOBGALBN()
	{
	}

	public void HandleImportedSave(string GAMPPLCNNPM)
	{
	}

	private void Update()
	{
	}

	public void UpdateSelectedSettingsToApply()
	{
	}

	public void ImportButtonAction()
	{
	}

	[IteratorStateMachine(typeof(EOOPJMHFANM))]
	public IEnumerator ReloadScrollersAfterOneFrame()
	{
		return null;
	}

	public IEnumerator CLHOECNMAKG()
	{
		return null;
	}

	public void MOKBPDGCAAD(bool LONIELAOHFN = false)
	{
	}

	public void CloseSaveUIPanel()
	{
	}

	public void ApplySaveSettings(SeeMusicSettingsSave OKEGNCLMENA, List<string> BAPLHPIIKEM, bool DAIBHNFKFBG = false)
	{
	}

	public void MGABKNPCDGH(List<string> KINCANOBGGL, bool EDACFBJIFAG)
	{
	}

	public void DMOAHHBMFAA()
	{
	}

	public void SettingsCheckboxTapped(string HIBNDDLLHAG, bool EDACFBJIFAG)
	{
	}

	private void HICHELJJHCA()
	{
	}

	public string[] GetSavedVariables()
	{
		return null;
	}

	public void OverwriteButtonAction()
	{
	}

	public void EHHPCJCFHDH()
	{
	}

	public void OFJOEJIBHFE()
	{
	}

	public void NHCDMAOGJJI(bool JOGJBPPHMMO = false, bool AJPOPLJEJNH = false, string GAMPPLCNNPM = "")
	{
	}

	public void HODEBOHLGFJ()
	{
	}

	private void DAGNFBAHLGK()
	{
	}

	public void LoadSettingsSaveFiles()
	{
	}

	public void ELLPPIEOAON(string HIBNDDLLHAG, bool EDACFBJIFAG)
	{
	}

	private void HJPKCDHJAEH()
	{
	}

	public IEnumerator FFLIFICBMLF()
	{
		return null;
	}

	private void NFCCAHMDKCD()
	{
	}

	private void LPMCDILFDME()
	{
	}

	private void DJIEHLBBJAC()
	{
	}

	public void LoadSettingsSave()
	{
	}

	public void DeleteButtonAction()
	{
	}

	public void SaveSettings(bool JOGJBPPHMMO = false, bool AJPOPLJEJNH = false, string GAMPPLCNNPM = "")
	{
	}

	public void SettingsSaveScrollerRowSelected(int JCLFGKNOCFE)
	{
	}

	public void ExportSettingsSaveFileAfterSave(string HNELMLGEBEM)
	{
	}

	public void SetSaveInterface()
	{
	}

	private void JMFFMDBFNOK()
	{
	}

	public void NewSaveButtonAction()
	{
	}

	private void GIGODAMNKGG()
	{
	}

	public void CategoryCheckboxTapped(List<string> KINCANOBGGL, bool EDACFBJIFAG)
	{
	}

	[CompilerGenerated]
	private void MAGGIBPINMB()
	{
	}

	public void CreateScrollerControllers()
	{
	}

	public void EditSaveFileAction()
	{
	}

	public void CCCCFBKKAGE()
	{
	}

	public void ReloadScrollers()
	{
	}

	public void MGKAKIPPMCD()
	{
	}

	public void UpdateSettingsOnList(bool LONIELAOHFN = false)
	{
	}

	public void OGGEHIBIJPD()
	{
	}

	public void SelectNoneSettingsAction()
	{
	}

	public void BKNKDIDGEHI(string GAMPPLCNNPM, bool JOGJBPPHMMO, bool AJPOPLJEJNH)
	{
	}

	public void DeleteSettingsSaveFile()
	{
	}

	public void UpdateSettingsInSave()
	{
	}

	public int GetSaveIndex(string GAMPPLCNNPM)
	{
		return 0;
	}

	private void LLNKAMEMFLF()
	{
	}

	public void CancelNewSaveAction()
	{
	}

	public void LCDJEMIDPLE(string HIBNDDLLHAG, bool EDACFBJIFAG)
	{
	}

	public void EGOIDJHMGLL()
	{
	}

	public void ExportButtonAction()
	{
	}

	[CompilerGenerated]
	private void AFLMMHDECHN()
	{
	}

	private void Start()
	{
	}

	private void OOILAOLJAAE()
	{
	}

	private void Awake()
	{
	}

	public void SelectAllSettingsAction()
	{
	}

	public void SaveButtonAction()
	{
	}

	[CompilerGenerated]
	private void CMELMDDCDAG()
	{
	}

	public void MCJCFFKIPKI()
	{
	}

	public IEnumerator FOIPOAPCDHP()
	{
		return null;
	}

	public int OIMNJEKIDBM(string GAMPPLCNNPM)
	{
		return 0;
	}

	public void NewSaveDialog(string GAMPPLCNNPM, bool JOGJBPPHMMO, bool AJPOPLJEJNH)
	{
	}

	public void FOKBHKFELEO(SeeMusicSettingsSave OKEGNCLMENA, List<string> BAPLHPIIKEM, bool DAIBHNFKFBG = false)
	{
	}

	public IEnumerator PEKDIPMDJON()
	{
		return null;
	}

	private void IMHGLJPEFCA()
	{
	}

	public void HEMCOPFODMB(int JCLFGKNOCFE)
	{
	}
}
