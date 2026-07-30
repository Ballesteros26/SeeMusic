using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Purchasing;

public class Subscription : MonoBehaviour
{
	private sealed class AJMILLLNPKM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Subscription _003C_003E4__this;

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
		public AJMILLLNPKM(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		private void ICFDPOEDPCK()
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}
	}

	private sealed class BJGCFEBPPHC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public BJGCFEBPPHC(int _003C_003E1__state)
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

	private sealed class MLAHKJGDLKA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Subscription _003C_003E4__this;

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
		public MLAHKJGDLKA(int _003C_003E1__state)
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

	private sealed class GBFGHGJDDKL
	{
		public Subscription _003C_003E4__this;

		public string usernameInput;

		public string passwordInput;

		public Action _003C_003E9__3;

		internal void PAAGPONPBOE()
		{
		}

		internal void OAPAGHBMDCF()
		{
		}
	}

	private sealed class AACENNLGDCI
	{
		public Subscription _003C_003E4__this;

		public float timeStarted;

		internal bool DHCMIIMJBLL()
		{
			return false;
		}

		internal bool GACGGHJGOED()
		{
			return false;
		}
	}

	private sealed class BHEGGCFNBNK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Subscription _003C_003E4__this;

		private AACENNLGDCI _003C_003E8__1;

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
		public BHEGGCFNBNK(int _003C_003E1__state)
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

	private sealed class FLENJMPIHOF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public FLENJMPIHOF(int _003C_003E1__state)
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

	public Account Account;

	public GameObject SubscriptionPanel;

	public GameObject usernameButton;

	public GameObject usernameButtonText;

	public GameObject subscriptionStatusText;

	public GameObject subscriptionDeviceStoreText;

	public GameObject subscriptionPanelUpgradeButton;

	public GameObject subscriptionPanelUpgradeButtonPanel;

	public GameObject subscriptionPanelLoginButton;

	public GameObject subscriptionPanelLoginButtonPanel;

	public GameObject subscriptionPanelLoggedInLight;

	public GameObject subscriptionPanelSubscriptionActiveLight;

	public GameObject subscriptionUsernameLoggedInLight;

	public GameObject subscriptionPanelTimeLeftText;

	public GameObject OneMonthPurchaseButton;

	public GameObject ThreeMonthsPurchaseButton;

	public GameObject SixMonthsPurchaseButton;

	public GameObject TwelveMonthsPurchaseButton;

	public GameObject SubscriptionPurchaseButton;

	public GameObject SubscriptionPurchaseTopSpacerPanel;

	public GameObject SubscriptionPurchaseTitlePanel;

	public GameObject SubscriptionPurchaseButtonPanel;

	public GameObject SubscriptionPurchaseTermsPanel;

	public GameObject SubscriptionPurchaseSpacerPanel;

	public GameObject SixMonthsPurchaseButtonPanel;

	public GameObject SixTwelveMonthsButtonSpacer;

	public GameObject TwelveMonthsPurchaseButtonPanel;

	public GameObject NoPayPalPanel;

	public GameObject ManagePabblyPanel;

	public GameObject ExtraSpacerPanel;

	public GameObject SubscriptionUsernamePanel;

	public GameObject usernameInputField;

	public GameObject passwordInputField;

	public GameObject loginStatusText;

	public GameObject CreateAccountButtonPanel;

	public GameObject SignOutButtonPanel;

	public GameObject SignedInWithApplePanel;

	public GameObject SignInWithAppleImage;

	public GameObject SignInWithAppleButton;

	public GameObject SignInWithAppleButtonText;

	public GameObject AppleLoggedInLight;

	public GameObject ServerProgressPanel;

	public GameObject ServerProgressTitle;

	public GameObject SubscriptionUpgradePanel;

	public GameObject ManageDevicesPanel;

	public GameObject DevicesLeftText;

	public GameObject RestorePurchasesParentPanel;

	public GameObject SeeMusicAccountText;

	public GameObject DeleteAccountButton;

	public Color greenColor;

	public Color blueColor;

	public Color SubscriptionActiveUntilColor;

	public Font lightFont;

	public Font regularFont;

	private float KLPJODNEJAJ;

	private float EAGLCJKLIDP;

	private string JDODLPLPGGD;

	public void JEOCKOKFIFF(string BCGMAJBAPOL)
	{
	}

	private void KNOJPECBHEP()
	{
	}

	public void LoginButtonAction()
	{
	}

	public void ILPFOBNCMAP()
	{
	}

	public void OCIEANGBGPC()
	{
	}

	private void BKOHIIIGCGK()
	{
	}

	private void DJMMOGFKMAO()
	{
	}

	private void ELHKDIOLJAJ()
	{
	}

	private void JCODHHEENGM()
	{
	}

	[CompilerGenerated]
	private void FPOFHPCNJAH()
	{
	}

	public void IEAMECIENFC()
	{
	}

	public void GJOKDHJBBFL(string LOIHBMKNJLB)
	{
	}

	public void MAPHJLAIJAA()
	{
	}

	public void OGOMGHHPEPF(Product PNEINFKEEBD, PurchaseFailureReason GOKCEILLFGN)
	{
	}

	private void LOMKKBDMPCA()
	{
	}

	public void CGEMEAHMDJM()
	{
	}

	public void ManagePabblyButtonAction()
	{
	}

	private void PFNHPINNHAE()
	{
	}

	public void UpdateUpgradeButtonText(string OACJPDIIKAG, bool FHAEDJPCJIO = false)
	{
	}

	[IteratorStateMachine(typeof(BJGCFEBPPHC))]
	public IEnumerator ShowOkButtonAfterWait()
	{
		return null;
	}

	public void PabblyPurchaseProductAction(string BCGMAJBAPOL)
	{
	}

	private void Update()
	{
	}

	public void OLBCNPBIJCM()
	{
	}

	public void BHKOJICDPJA()
	{
	}

	private void BGPDPNPNNFM()
	{
	}

	public void UpdateSubscriptionStatusUI()
	{
	}

	private void KBFJBDLOEHC()
	{
	}

	private void DABFHFPJMHL()
	{
	}

	public void HGPMPKEABEA()
	{
	}

	private void PBJJOGKIHAF()
	{
	}

	[CompilerGenerated]
	private void CCBJDKLOOBL()
	{
	}

	private void MIBFBMNNEHM()
	{
	}

	public IEnumerator COBOPJPGKCL()
	{
		return null;
	}

	public void GCOPBEBNEIG()
	{
	}

	public void JEPGOHHDHDO(string OACJPDIIKAG, bool FHAEDJPCJIO = false)
	{
	}

	public void UpdateUsernameButtonText(string GAEPOPLNEEG)
	{
	}

	private string PGGBMEKDDLB()
	{
		return null;
	}

	public void FNKMGEJCDHB(string BCGMAJBAPOL)
	{
	}

	public void PrivacyPolicyButtonAction()
	{
	}

	private void KPCPBIMILJE()
	{
	}

	public IEnumerator LLACIFPMECO()
	{
		return null;
	}

	private void JEIMMBNLIEP()
	{
	}

	public void WindowsPurchaseComplete(string BCGMAJBAPOL)
	{
	}

	public void FBOKKGKDBAO(Product PNEINFKEEBD, PurchaseFailureReason GOKCEILLFGN)
	{
	}

	private void MHMOAFIPHHA()
	{
	}

	public void NMKGFMKEFBD(string BCGMAJBAPOL)
	{
	}

	public void GNCMCPPCEAP()
	{
	}

	private void HKEGMKOMAPP()
	{
	}

	public void MNGLCKFNAEC()
	{
	}

	[CompilerGenerated]
	private void NGCHICCLNPL()
	{
	}

	public void NoPayPalButtonAction()
	{
	}

	public void PMMNFGKEBNB()
	{
	}

	public IEnumerator GDAABAOFBAL()
	{
		return null;
	}

	public void OJKFDMLOEND()
	{
	}

	public void BBLMMCEKGML(string OACJPDIIKAG, bool FHAEDJPCJIO = false)
	{
	}

	private void NCJJOEKAGNL()
	{
	}

	public void ResetPasswordButtonAction()
	{
	}

	public void HMGHGNELDHM()
	{
	}

	public void ODAGMMPGMLG(Product PNEINFKEEBD)
	{
	}

	[CompilerGenerated]
	private void MJLDHCBLKCG()
	{
	}

	public void KPEHFIMCKPD()
	{
	}

	public void OLAFDMEHPGO()
	{
	}

	public IEnumerator HMLJABHBIPI()
	{
		return null;
	}

	private void LKLDKCICPLI()
	{
	}

	private void EBCACNLBOFF()
	{
	}

	private void CFOCFBAGAMF()
	{
	}

	private void GMFEACFJFHC()
	{
	}

	[CompilerGenerated]
	private void DIDNEONIBLP()
	{
	}

	private void ODPBBKIOHAE()
	{
	}

	private void OHKHFBEEHEJ()
	{
	}

	private string ECCGKPCHAJB()
	{
		return null;
	}

	public void CLMDIONCGGC()
	{
	}

	private void PGAFCBDJFOI()
	{
	}

	private void DEOJOJAMMKH()
	{
	}

	public void ShowServerProgressPanel(string LOIHBMKNJLB)
	{
	}

	private void OBHADIJIELJ()
	{
	}

	public void HFGCCPDLMHA()
	{
	}

	private void EDGMGPFNAKE()
	{
	}

	private void KBEIGMCMNDM()
	{
	}

	public IEnumerator EELPDGDLNNL()
	{
		return null;
	}

	public void CloseSubscriptionUsernamePanel()
	{
	}

	public void EINKKBBEDPA()
	{
	}

	private void Awake()
	{
	}

	public IEnumerator FFHNHCAPLDN()
	{
		return null;
	}

	public void NIMAHCLELHD()
	{
	}

	public void RestorePurchasesButtonAction()
	{
	}

	public void HPAEOONAPGE()
	{
	}

	public void CloseSubscriptionUpgradePanel()
	{
	}

	public void HMPHIIAMACF()
	{
	}

	public void FKJMNGKHLEP()
	{
	}

	private void HNJJBJCMJBA()
	{
	}

	public void MLFHCMBGDLE()
	{
	}

	[CompilerGenerated]
	private void HHHJHLOFEHG()
	{
	}

	public void DHHMMOBKALM(string OACJPDIIKAG, bool FHAEDJPCJIO = false)
	{
	}

	public void HideServerProgressPanel()
	{
	}

	[CompilerGenerated]
	private void EDAOGNCAHPL()
	{
	}

	public void MIAEPJFHEBI()
	{
	}

	public void OBNBBCCEPEI()
	{
	}

	[CompilerGenerated]
	private void JGFDLJCMPCC()
	{
	}

	public void OpenSubscriptionUpgradePanel()
	{
	}

	public void CloseSubscriptionPanel()
	{
	}

	private string HKDOCOHBPNI()
	{
		return null;
	}

	public void LPEFIJKAFLP()
	{
	}

	public void SubscriptionTermsButtonAction()
	{
	}

	public void CIJLLDIGAGH()
	{
	}

	private void NAKLNHOFKKL()
	{
	}

	private void JIABMCNEJPH()
	{
	}

	public void PurchaseFailed(Product PNEINFKEEBD, PurchaseFailureReason GOKCEILLFGN)
	{
	}

	[CompilerGenerated]
	private void LDGHCNNAABP()
	{
	}

	public IEnumerator DGAPBEIELBK()
	{
		return null;
	}

	public IEnumerator LDJIIAOOPBP()
	{
		return null;
	}

	private void OIMHJFDGHPE()
	{
	}

	public void CKKFAMPBEFM(string LOIHBMKNJLB)
	{
	}

	private void BGPOGEOHMFH()
	{
	}

	private void NNIOIOKJGMN()
	{
	}

	[IteratorStateMachine(typeof(FLENJMPIHOF))]
	public IEnumerator CloseSubscriptionUpgradePanelAfterOneFrame()
	{
		return null;
	}

	public void OAPCDBPDPJN()
	{
	}

	private void FPLDFBADJDH()
	{
	}

	public void CMJIAEKFJIP()
	{
	}

	public void NJCFMMENLOE()
	{
	}

	public void MDFPHHCFMGH()
	{
	}

	private void BHLAGJBEEJF()
	{
	}

	private void NNLOHMAAJFF()
	{
	}

	public void BCPHKDHFBKD(string BCGMAJBAPOL)
	{
	}

	public IEnumerator CDDOPONMHFO()
	{
		return null;
	}

	private void HDIBNKONABG()
	{
	}

	public void LDEMIHMBAHK()
	{
	}

	public void LLOGGHABOKF()
	{
	}

	public void LDOPMDAFIFA()
	{
	}

	private void JAGGLNPOGJH()
	{
	}

	private string FFFKAACHGII()
	{
		return null;
	}

	[IteratorStateMachine(typeof(MLAHKJGDLKA))]
	public IEnumerator RestorePurchases()
	{
		return null;
	}

	[CompilerGenerated]
	private void ADBOOHDJHCM()
	{
	}

	public void UpdateSubscriptionUpgradeButtonListener()
	{
	}

	public void AEDJGPLDPDB()
	{
	}

	public void BNFAECEJEKG()
	{
	}

	private void JMLBKAKPMMC()
	{
	}

	public IEnumerator HINAJJFNJIE()
	{
		return null;
	}

	public void DeleteAccountButtonAction()
	{
	}

	private void EDEONFDMAGM()
	{
	}

	private void EHGMJNGCMIG()
	{
	}

	public void PurchaseComplete(Product PNEINFKEEBD)
	{
	}

	private void OCGICFKDPGP()
	{
	}

	private void EOMDPAHMCKC()
	{
	}

	public void JJLHFIOPONF()
	{
	}

	private void BBKEEAOFLBC()
	{
	}

	private void FGAABDDAHKN()
	{
	}

	public void OpenSubscriptionUsernamePanel()
	{
	}

	public void AOCDALHNNCE()
	{
	}

	private void MBEEJDNDFOO()
	{
	}

	public void PLEKPBCGGFC()
	{
	}

	public IEnumerator KKHMCFKCKGB()
	{
		return null;
	}

	private void LNPFIKBFFBB()
	{
	}

	[CompilerGenerated]
	private void FHCAMBFLJMA()
	{
	}

	public void SignOutButtonAction()
	{
	}

	public void JOMEKDIPDKO()
	{
	}

	[CompilerGenerated]
	private void LIMDDKNLFAC()
	{
	}

	public void IGKBMJMECEL()
	{
	}

	public void AMDBMJIMFHJ()
	{
	}

	public void SignedInWithAppleButtonAction()
	{
	}

	private void PHEMBNGHECA()
	{
	}

	private void NOIBBDMHBDD()
	{
	}

	private void HLFINLIICMN()
	{
	}

	public void OpenManageDevices()
	{
	}

	private void Start()
	{
	}

	[CompilerGenerated]
	private void HPAACCMOJAN()
	{
	}

	public void NDDHOGBBNCD()
	{
	}

	private void IMHGLJPEFCA()
	{
	}

	[IteratorStateMachine(typeof(AJMILLLNPKM))]
	public IEnumerator GetPabblyURL()
	{
		return null;
	}

	private void AKOPENHLKLH()
	{
	}

	public void PPNGHMCNNBM()
	{
	}

	private void PNNMNNPLJNE()
	{
	}

	public void FINJIOCDLAJ()
	{
	}

	public void WindowsPurchaseFailed(string BCGMAJBAPOL)
	{
	}

	public void UpdateLoginStatusUI()
	{
	}

	[CompilerGenerated]
	private void IDILAKAOHNO()
	{
	}

	public void CreateAccountButtonAction()
	{
	}

	[IteratorStateMachine(typeof(BHEGGCFNBNK))]
	public IEnumerator OpenSubscriptionUpgradePanelAfterGettingServerTime()
	{
		return null;
	}
}
