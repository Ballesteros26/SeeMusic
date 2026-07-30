using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SettingsInput : MonoBehaviour
{
	private sealed class LFFBMONAGAI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SettingsInput _003C_003E4__this;

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
		public LFFBMONAGAI(int _003C_003E1__state)
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

	public GameObject MIDIInputScroller;

	[NonSerialized]
	public SeeMusicScrollerController MIDIInputScrollerController;

	public GameObject AudioInputScroller;

	[NonSerialized]
	public SeeMusicScrollerController AudioInputScrollerController;

	public GameObject VideoInputScroller;

	[NonSerialized]
	public SeeMusicScrollerController VideoInputScrollerController;

	public GameObject MIDIInputScrollbar;

	public GameObject AudioInputScrollbar;

	public GameObject VideoInputScrollbar;

	public GameObject AudioInputNoMicPermissionOverlay;

	public GameObject CameraPermissionOverlay;

	public GameObject UseMIDIJackControl;

	public GameObject UseMIDIJackControlPanel;

	public GameObject MidiMonitorImage;

	public GameObject AudioMonitorPanel;

	public GameObject CameraViewButton;

	public GameObject CameraViewSwitch;

	public GameObject PitchDetectionButton;

	public GameObject PitchDetectionButtonText;

	public GameObject PlayExternalNotesButton;

	public SeeMusicCellView SeeMusicCellViewPreFab;

	public GameObject RecordMIDISwitch;

	public GameObject RecordAudioSwitch;

	public GameObject RecordVideoSwitch;

	private int JPPIDJDBJJO;

	private int EEPIFBCJNIO;

	public void MicPermissionsOverlayClicked()
	{
	}

	private void KGNADCGNDFF()
	{
	}

	public void KNMOPNBCNEK()
	{
	}

	public void NNFFGFJEADH()
	{
	}

	public void LCILHPEAGCL()
	{
	}

	public void EIHCLCAAOEA()
	{
	}

	public bool MCIPKKGMOPA(List<MGFGDCEJHGB> KGMHIPANFHM, List<MGFGDCEJHGB> GEHLNBOGOFI)
	{
		return false;
	}

	public void BCFKBMNAPPE()
	{
	}

	public void MIDIMonitorOff()
	{
	}

	public void GHDNKJHBFEE()
	{
	}

	private void ADNCOBKDKHF()
	{
	}

	public void LGBFLDMKDAM()
	{
	}

	public void KBMDCKEDGNP()
	{
	}

	public void FFFMKKFHLND()
	{
	}

	public void PlayExternalNotesButtonAction()
	{
	}

	public void DBOEEOBNCOP()
	{
	}

	public void CameraButtonAction()
	{
	}

	public void CreateScrollerControllers()
	{
	}

	private void HPGPBKKBAIF()
	{
	}

	public void TogglePlayExternalNotes()
	{
	}

	public void LEGDFLCPEPD()
	{
	}

	public void MIDISettingsButtonAction()
	{
	}

	public void POOGHEMBMGI()
	{
	}

	private void PCPDLMOICDH()
	{
	}

	public void RefreshInputScrollers()
	{
	}

	public void PBEBBIHFOKO()
	{
	}

	public void HPOPBEKBHPB()
	{
	}

	public void HBHHBECCDMB()
	{
	}

	public bool CompareScrollerData(List<MGFGDCEJHGB> KGMHIPANFHM, List<MGFGDCEJHGB> GEHLNBOGOFI)
	{
		return false;
	}

	public void CameraSettingsButtonAction()
	{
	}

	private void Awake()
	{
	}

	public void SetControls()
	{
	}

	public void BMMIKJHPEFC()
	{
	}

	public IEnumerator LKMLDGCNDGD()
	{
		return null;
	}

	private void DJIEHLBBJAC()
	{
	}

	public void CameraPermissionsOverlayClicked()
	{
	}

	private void DAGIBBICCPN()
	{
	}

	private void Start()
	{
	}

	public void BPIOPIAINHA()
	{
	}

	public void PINJJCCAIGG()
	{
	}

	public void PitchDetectionButtonTapped()
	{
	}

	public void JGEDPDDIDIK()
	{
	}

	public void JGDHEFIFBDD()
	{
	}

	public void MIDIMonitorOn()
	{
	}

	public void UpdateAudioMonitor()
	{
	}

	private void Update()
	{
	}

	private void CBGPAHOHMKE()
	{
	}

	[IteratorStateMachine(typeof(LFFBMONAGAI))]
	public IEnumerator ReloadScrollersAfterOneFrame()
	{
		return null;
	}

	public void FODHLAAPFLC()
	{
	}
}
