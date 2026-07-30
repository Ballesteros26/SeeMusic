using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UserReportingScript : MonoBehaviour
{
	private sealed class BPBJJDKNAKK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UserReportingScript _003C_003E4__this;

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
		public BPBJJDKNAKK(int _003C_003E1__state)
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

	[Tooltip("The category dropdown.")]
	public Dropdown CategoryDropdown;

	[Tooltip("The description input on the user report form.")]
	public InputField DescriptionInput;

	[Tooltip("The UI shown when there's an error.")]
	public Canvas ErrorPopup;

	private bool EAGNDPOPEMB;

	[Tooltip("A value indicating whether the hotkey is enabled (Left Alt + Left Shift + B).")]
	public bool IsHotkeyEnabled;

	[Tooltip("A value indicating whether the prefab is in silent mode. Silent mode does not show the user report form.")]
	public bool IsInSilentMode;

	[Tooltip("A value indicating whether the user report client reports metrics about itself.")]
	public bool IsSelfReporting;

	private bool ACGJDBHDEOF;

	private bool OHNPEIECCOO;

	[Tooltip("The display text for the progress text.")]
	public Text ProgressText;

	[Tooltip("A value indicating whether the user report client send events to analytics.")]
	public bool SendEventsToAnalytics;

	[Tooltip("The UI shown while submitting.")]
	public Canvas SubmittingPopup;

	[Tooltip("The summary input on the user report form.")]
	public InputField SummaryInput;

	[Tooltip("The thumbnail viewer on the user report form.")]
	public Image ThumbnailViewer;

	private GNCCCIONGEP KKGKOCNBCLM;

	[Tooltip("The user report button used to create a user report.")]
	public Button UserReportButton;

	[Tooltip("The UI for the user report form. Shown after a user report is created.")]
	public Canvas UserReportForm;

	[Tooltip("The User Reporting platform. Different platforms have different features but may require certain Unity versions or target platforms. The Async platform adds async screenshotting and report creation, but requires Unity 2018.3 and above, the package manager version of Unity User Reporting, and a target platform that supports asynchronous GPU readback such as DirectX.")]
	public UserReportingPlatformType UserReportingPlatform;

	[Tooltip("The event raised when a user report is submitting.")]
	public UnityEvent UserReportSubmitting;

	[CompilerGenerated]
	private IOEPKIMHJKA _003CDCLGDMOMMNJ_003Ek__BackingField;

	public IOEPKIMHJKA CurrentUserReport
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

	public IPLLLLJACGF State => default(IPLLLLJACGF);

	private void Start()
	{
	}

	private void GNINBLMMEIC(bool GBEOLMNEGBA, IOEPKIMHJKA KFGDHOJBLNI)
	{
	}

	public void OHFHKEFFALB()
	{
	}

	[SpecialName]
	public IOEPKIMHJKA AKJILCBMMOA()
	{
		return null;
	}

	private void AKNGPNDIJMC(IOEPKIMHJKA FICDFKIIIOB)
	{
	}

	[CompilerGenerated]
	private void GADAHCBBMNM(bool GBEOLMNEGBA, IOEPKIMHJKA KFGDHOJBLNI)
	{
	}

	private void IBFLAKGDPJJ(bool GBEOLMNEGBA, IOEPKIMHJKA KFGDHOJBLNI)
	{
	}

	public void KEOBHINAMFC()
	{
	}

	private void PPEOMNPJJFL()
	{
	}

	protected virtual void BPBHBLCDLBP()
	{
	}

	private KCPFHLAIJBE PAOKKBGDLBE()
	{
		return null;
	}

	public void SubmitUserReport()
	{
	}

	[SpecialName]
	public IPLLLLJACGF GLCLHJGLJPM()
	{
		return default(IPLLLLJACGF);
	}

	[CompilerGenerated]
	private void AHBGIPLAFHL(IOEPKIMHJKA MJOPBPLAALK)
	{
	}

	private void ICEIILINFHP()
	{
	}

	[CompilerGenerated]
	private void LINBPMBFLEC(float DMDPDMEGHDD, float OFHCFJDLIMD)
	{
	}

	private void NLMEPFIBMHM()
	{
	}

	[SpecialName]
	private void PAFPAGAPOPJ(IOEPKIMHJKA JEHONDDIMPC)
	{
	}

	public void CreateUserReport()
	{
	}

	[IteratorStateMachine(typeof(BPBJJDKNAKK))]
	private IEnumerator AJKBAEPELPJ()
	{
		return null;
	}

	private KCPFHLAIJBE NMDACIFJLCC()
	{
		return null;
	}

	private void DJMMOGFKMAO()
	{
	}

	private KCPFHLAIJBE OKFMFHOLIOG()
	{
		return null;
	}

	private KCPFHLAIJBE OOBDJOABFLN()
	{
		return null;
	}

	public bool IsSubmitting()
	{
		return false;
	}

	[SpecialName]
	public IOEPKIMHJKA NMPDHNENPEH()
	{
		return null;
	}

	private KCPFHLAIJBE DABPGOIKEKO()
	{
		return null;
	}

	public void HMGHNGKJEFP()
	{
	}

	public void CancelUserReport()
	{
	}

	private IEnumerator KCHPINGHBFL()
	{
		return null;
	}

	protected virtual void PACKOLGMCGG()
	{
	}

	private void Update()
	{
	}

	private void CNNHDCPLBJP(bool GBEOLMNEGBA, IOEPKIMHJKA KFGDHOJBLNI)
	{
	}
}
