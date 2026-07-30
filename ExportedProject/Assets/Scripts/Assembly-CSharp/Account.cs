using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CodeStage.AntiCheat.Detectors;
using Parse;
using UnityEngine;
using UnityEngine.Purchasing;

public class Account : MonoBehaviour
{
	private sealed class BNPJMIBBDGE
	{
		public Account _003C_003E4__this;

		public string emailInput;

		public string passwordInput;

		public bool transferSubscription;

		public Task signUpTask;

		internal void JLJCEHGJMFF(Task<object> t)
		{
		}

		internal bool MLLIMCDIOAG()
		{
			return false;
		}

		internal void BNEHACJNAPF()
		{
		}

		internal void LDIMEJIBDCL()
		{
		}
	}

	private sealed class CPJBFAKKMDI
	{
		public Task<object> t;

		public BNPJMIBBDGE CS_0024_003C_003E8__locals1;

		internal void MFLCOFBMEGB()
		{
		}
	}

	private sealed class LGEHCGIMDJN
	{
		public string result;

		public CPJBFAKKMDI CS_0024_003C_003E8__locals2;

		internal void ELEBLABPLCF()
		{
		}
	}

	private sealed class ODDBJCEBFGH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Account _003C_003E4__this;

		public string emailInput;

		public string passwordInput;

		private BNPJMIBBDGE _003C_003E8__1;

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
		public ODDBJCEBFGH(int _003C_003E1__state)
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

	private sealed class GCLHOLAAPAB
	{
		public Account _003C_003E4__this;

		public string emailInput;

		public bool automatedLogin;

		public string passwordInput;

		public Action _003C_003E9__3;

		public Action _003C_003E9__7;

		public Action _003C_003E9__4;

		internal void HMKLKGJPIJJ()
		{
		}

		internal bool DKGMCECPJME()
		{
			return false;
		}

		internal void JPHCOALKHAK()
		{
		}

		internal void HOLPPOOJAHH()
		{
		}

		internal void DGLGIDLJKNH()
		{
		}
	}

	private sealed class IBGLEMJLENL
	{
		public CancellationTokenSource cancelTokenSource;

		public GCLHOLAAPAB CS_0024_003C_003E8__locals1;

		internal void JECOJJNNMDC(Task<ParseUser> t)
		{
		}
	}

	private sealed class GAJKEBHGMIG
	{
		public Task<ParseUser> t;

		public IBGLEMJLENL CS_0024_003C_003E8__locals2;

		public Action _003C_003E9__6;

		internal void FLJKIEGCNBN()
		{
		}

		internal void MOCJEDKABNB(Task<bool> existsT)
		{
		}
	}

	private sealed class GDHLDAHBALD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Account _003C_003E4__this;

		public string emailInput;

		public bool automatedLogin;

		public string passwordInput;

		private GCLHOLAAPAB _003C_003E8__1;

		public bool initialLogin;

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
		public GDHLDAHBALD(int _003C_003E1__state)
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

	private sealed class AFKJPMCKHAP
	{
		public Task<object> t;

		public Account _003C_003E4__this;

		internal void LPKPGJFJEJC()
		{
		}
	}

	private sealed class KNFONICIEKF
	{
		public Account _003C_003E4__this;

		public string emailInput;

		public string passwordInput;

		public bool automatedLogin;

		internal void IHDKJODEKNH()
		{
		}
	}

	private sealed class BLHHKKCEHFH
	{
		public float timeServerTimeWaitStarted;

		public float timeWaitStarted;

		public Account _003C_003E4__this;

		internal bool MELDECABMDP()
		{
			return false;
		}

		internal bool FICMDGGCDHM()
		{
			return false;
		}
	}

	private sealed class LHPNEKFHCLF
	{
		public Task task;

		internal bool KFFBCPLNJFJ()
		{
			return false;
		}
	}

	private sealed class CGCDDLPADNF
	{
		public bool CancelingSubscription;

		public Action _003C_003E9__6;

		internal void JDBONBADLBO(Task<object> t)
		{
		}

		internal bool MFMGOBLDJGC()
		{
			return false;
		}

		internal void MNFPPODDOHM()
		{
		}
	}

	private sealed class FNCOIOEKIHI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Account _003C_003E4__this;

		public bool verifyInternet;

		private LHPNEKFHCLF _003C_003E8__1;

		private BLHHKKCEHFH _003C_003E8__2;

		public bool openUpgradeWindow;

		private bool _003CshouldCheckForExpiration_003E5__2;

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
		public FNCOIOEKIHI(int _003C_003E1__state)
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

	private sealed class KABAHLPCMEJ
	{
		public float timeWaitStarted;

		internal bool GHFMJDBAFCJ()
		{
			return false;
		}
	}

	private sealed class NKEEJAGKMOH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Account _003C_003E4__this;

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
		public NKEEJAGKMOH(int _003C_003E1__state)
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

	private sealed class OHKFCPMIPED : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Account _003C_003E4__this;

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
		public OHKFCPMIPED(int _003C_003E1__state)
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

	private sealed class MEGOFLMKDDE
	{
		public float timeWaitStarted;

		public Account _003C_003E4__this;

		internal bool LINBHCMCLGN()
		{
			return false;
		}
	}

	private sealed class BBIBOLIJLJJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Account _003C_003E4__this;

		private MEGOFLMKDDE _003C_003E8__1;

		private bool _003CwasActive_003E5__2;

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
		public BBIBOLIJLJJ(int _003C_003E1__state)
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

	private sealed class LPMODMPOFEL
	{
		public Account _003C_003E4__this;

		public string identifier;

		internal void OPAPAOFBLLD()
		{
		}

		internal void MOHAKEIOJBF()
		{
		}
	}

	private sealed class KHADGLCFPHE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Account _003C_003E4__this;

		public string identifier;

		public bool signOut;

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
		public KHADGLCFPHE(int _003C_003E1__state)
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

	private sealed class NNCKMNKJEHJ
	{
		public Task task;

		internal bool CFBCKEAFEMA()
		{
			return false;
		}
	}

	private sealed class KLCNAEPLIPI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Account _003C_003E4__this;

		private NNCKMNKJEHJ _003C_003E8__1;

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
		public KLCNAEPLIPI(int _003C_003E1__state)
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

	private sealed class NMGBOJDCFMH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Account _003C_003E4__this;

		public string productID;

		public string receipt;

		public Product product;

		public string transactionID;

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
		public NMGBOJDCFMH(int _003C_003E1__state)
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

	private sealed class FDJKIMKGBPC : IEnumerator<object>, IEnumerator, IDisposable
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
		public FDJKIMKGBPC(int _003C_003E1__state)
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

	private sealed class GFDKNBCAPNH
	{
		public Account _003C_003E4__this;

		public float timeWaitStarted2;

		internal bool EDAKLGEAIGL()
		{
			return false;
		}

		internal bool BNODBOGKJNM()
		{
			return false;
		}
	}

	private sealed class LHNNLMNBDAA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Account _003C_003E4__this;

		private GFDKNBCAPNH _003C_003E8__1;

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
		public LHNNLMNBDAA(int _003C_003E1__state)
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

	private static Account JOHCOGCAEAK;

	[CompilerGenerated]
	private static Account _003CHOLNFGBMPDC_003Ek__BackingField;

	public SceneSingleton SceneSingleton;

	public MIDIControl MIDIControl;

	public UIManager UIManager;

	public NoteAnimation NoteAnimation;

	public KeyboardAnimation KeyboardAnimation;

	public ParticleAnimation ParticleAnimation;

	public Preferences Preferences;

	[NonSerialized]
	public string email;

	[NonSerialized]
	public string password;

	[NonSerialized]
	public string userID;

	[NonSerialized]
	public ParseUser parseUser;

	[NonSerialized]
	public string AppleUserID;

	[NonSerialized]
	public string AppleUserEmail;

	[NonSerialized]
	public string AppleUserFullName;

	[NonSerialized]
	public ParseObject AppleUserObject;

	[NonSerialized]
	public bool LoggedInApple;

	[NonSerialized]
	public bool LoginAppleFailed;

	[NonSerialized]
	public bool LoggedInAccount;

	[NonSerialized]
	public bool loginFailed;

	[NonSerialized]
	public bool emailVerified;

	[NonSerialized]
	public bool subscriptionActive;

	[NonSerialized]
	public bool noRestorePurchasesAlert;

	[NonSerialized]
	public bool subscriptionNeedsRenewal;

	[NonSerialized]
	public string subscriptionType;

	[NonSerialized]
	public string subscriptionDevice;

	[NonSerialized]
	public DateTime subscriptionExpiration;

	[NonSerialized]
	public string subscriptionTransactionID;

	[NonSerialized]
	public DateTime subscriptionPurchaseDate;

	[NonSerialized]
	public int maxDevicesAllowed;

	[NonSerialized]
	public bool appUnlocked;

	[NonSerialized]
	public string PabblyURL;

	[NonSerialized]
	public DateTime PabblyURLExpiration;

	[NonSerialized]
	public string PabblyCustomerID;

	[NonSerialized]
	public string PabblyPlanID;

	[NonSerialized]
	public string PabblyProductID;

	[NonSerialized]
	public DateTime PurchaseDate;

	[NonSerialized]
	public bool UseSignInWithApple;

	[NonSerialized]
	public bool SignedInWithApple;

	[NonSerialized]
	public DateTime date;

	[NonSerialized]
	public DateTime expirationDate;

	[NonSerialized]
	public bool dateCheckWorked;

	[NonSerialized]
	public bool dateCheckOn;

	[NonSerialized]
	public DateTime InstallDate;

	private bool CGBGOJAMABJ;

	[NonSerialized]
	public int unsuccessfulLogins;

	[NonSerialized]
	public bool unsuccessfulLoginAlertShown;

	[NonSerialized]
	public bool automatedLoginFailed;

	[NonSerialized]
	public bool loggingInUser;

	[NonSerialized]
	public bool refreshingSubscription;

	[NonSerialized]
	public bool checkingSubscriptionExpiration;

	[NonSerialized]
	public float lastRefreshSubscriptionFromParse;

	[NonSerialized]
	public DateTime lastExpirationCheck;

	[NonSerialized]
	public DateTime lastEmailVerificationCheck;

	[NonSerialized]
	public DateTime lastWatermarkCheck;

	[NonSerialized]
	public DateTime lastLoginAttempt;

	[NonSerialized]
	public DateTime lastMonthlyRestoreAttempt;

	[NonSerialized]
	public bool ActivatingSubscription;

	[NonSerialized]
	public bool updatingServerTime;

	[NonSerialized]
	public DateTime serverTime;

	[NonSerialized]
	public bool hasServerTime;

	[NonSerialized]
	public bool openingUpgradeWindow;

	public TimeCheatingDetector timeCheatingDetector;

	private int DBPPPLKNJBD;

	[NonSerialized]
	private float BHGEFHMAGHL;

	[NonSerialized]
	public bool verifySubscriptionComplete;

	[NonSerialized]
	public bool parseInfoUpToDate;

	[NonSerialized]
	public List<MGFGDCEJHGB> activeDevicesList;

	[NonSerialized]
	public List<object> activeDevices;

	private bool MHFNMGFPHIL;

	[NonSerialized]
	private bool NKAFPBFLDOK;

	[NonSerialized]
	public bool purchaseCompleting;

	[NonSerialized]
	private bool MCLEINOAMFI;

	private int FOLMCEPMCPE;

	private bool EOJCJNDENHE;

	public static Account Instance
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

	[CompilerGenerated]
	private void DFNNPBDNOLD(Task<object> LJGFOHONDJL)
	{
	}

	public void CIOAEKGIJHH(string CLCMMOAPJAI)
	{
	}

	[CompilerGenerated]
	private bool EALCGLDFCNC()
	{
		return false;
	}

	[IteratorStateMachine(typeof(FNCOIOEKIHI))]
	public IEnumerator RefreshSubscriptionFromParse(bool GHMHCMDENLB = true, bool FLIBMEDFHCP = false)
	{
		return null;
	}

	public bool IsSubscriptionDevice()
	{
		return false;
	}

	public void UpdateActiveDevicesParse()
	{
	}

	[CompilerGenerated]
	private void LPBEHNBLLEA()
	{
	}

	public void ActivateNoUser(DateTime AFOLOKKIHBI, string AEBIJNEIDLN, string EBADAEHEHDN, bool JMIKOPNBEHE)
	{
	}

	[CompilerGenerated]
	private void ILKNFHBEDCO()
	{
	}

	[CompilerGenerated]
	private void BBABNOIFOED()
	{
	}

	public string GetNameForCurrentDevice()
	{
		return null;
	}

	private void LLJLHBDHPKJ()
	{
	}

	[CompilerGenerated]
	private void OIALHPDFGLI(Task<object> LJGFOHONDJL)
	{
	}

	private void MINIJIHDECE()
	{
	}

	[IteratorStateMachine(typeof(NKEEJAGKMOH))]
	public IEnumerator UpdateServerTime()
	{
		return null;
	}

	public void AddActiveDevice(List<string> ANLHFEHOGHL)
	{
	}

	public IEnumerator CIMHEINEIAD()
	{
		return null;
	}

	[IteratorStateMachine(typeof(LHNNLMNBDAA))]
	public IEnumerator ActivateSubscription()
	{
		return null;
	}

	public void ClearActivationPrefs()
	{
	}

	private void MEFLCIMIMBJ()
	{
	}

	public IEnumerator BDNCBKEEGCH(bool GHMHCMDENLB = true, bool FLIBMEDFHCP = false)
	{
		return null;
	}

	public void Apple(string CLCMMOAPJAI)
	{
	}

	public string AEDPPAPHKIH()
	{
		return null;
	}

	[CompilerGenerated]
	private void NKFKEEAIHGD()
	{
	}

	public void LHGLNJAEGLA()
	{
	}

	public void CheckSubscription(bool DBCIHALCDNG = false)
	{
	}

	[CompilerGenerated]
	private void MJFJKMFLPDH()
	{
	}

	public void JHKLKIKFJDB()
	{
	}

	public void Google(string LJGFOHONDJL, string GNKJBGGACDN, string BPJNHHPLABC)
	{
	}

	[IteratorStateMachine(typeof(GDHLDAHBALD))]
	public IEnumerator LogInUser(string MOOHCIDJPCH, string MFKGKKGOLEH, bool GOEIIOKGLOA = false, bool LNDEFOIACNE = false)
	{
		return null;
	}

	public void UpdateUnreachableTimeLeftText(bool ODGJIEIGCPH)
	{
	}

	public void IFBKGIEPKJH(List<string> ANLHFEHOGHL)
	{
	}

	[CompilerGenerated]
	private void KADIANAABLG()
	{
	}

	[CompilerGenerated]
	private void DCLEOLAPACG(Task<object> LJGFOHONDJL)
	{
	}

	[IteratorStateMachine(typeof(KHADGLCFPHE))]
	public IEnumerator DeactivateDevice(string FEJJGBPBCEP, bool GHGACFKEDCE = false)
	{
		return null;
	}

	public void SignOut(bool CIPKBDIDBEE = true, bool PMMPDDIGCAE = true)
	{
	}

	public void LoginSuccessful(string MOOHCIDJPCH, string MFKGKKGOLEH, bool GOEIIOKGLOA = false, Exception IBCHKEMLLBB = null)
	{
	}

	private void OBNCMHEOPEL()
	{
	}

	[CompilerGenerated]
	private void DMMAAKJAONH(Task<object> LJGFOHONDJL)
	{
	}

	[IteratorStateMachine(typeof(ODDBJCEBFGH))]
	public IEnumerator CreateAccount(string MOOHCIDJPCH, string MFKGKKGOLEH)
	{
		return null;
	}

	private void JMAPDKEHMID(Task<object> LJGFOHONDJL)
	{
	}

	[CompilerGenerated]
	private void BDDCCEGAOEL()
	{
	}

	public void FKGJJCCCDPM(bool ODGJIEIGCPH)
	{
	}

	[CompilerGenerated]
	private void OKJJAMAKOLC()
	{
	}

	public void DeleteAccount()
	{
	}

	[IteratorStateMachine(typeof(KLCNAEPLIPI))]
	public IEnumerator CheckForEmailVerification()
	{
		return null;
	}

	[CompilerGenerated]
	private void PMNKLMFLJMG()
	{
	}

	[IteratorStateMachine(typeof(FDJKIMKGBPC))]
	public IEnumerator CheckMacSubscription()
	{
		return null;
	}

	[IteratorStateMachine(typeof(BBIBOLIJLJJ))]
	public IEnumerator CheckSubscriptionExpiration()
	{
		return null;
	}

	private bool OCFBGGPADLA()
	{
		return false;
	}

	public void MPMPPFHPNCH(bool DBCIHALCDNG = false)
	{
	}

	public void TooManyDevicesAlert(bool NLBMEIGLHMC = true)
	{
	}

	public void PurchaseComplete(Product PNEINFKEEBD)
	{
	}

	private void ILANJPCBLBI(Task<object> LJGFOHONDJL)
	{
	}

	[IteratorStateMachine(typeof(NMGBOJDCFMH))]
	public IEnumerator PurchaseComplete(string BCGMAJBAPOL, string ELFJFHKMEBL = "", Product PNEINFKEEBD = null, string MECNHBGHKEI = "")
	{
		return null;
	}

	public void CheckDeviceCount()
	{
	}

	public string[] GetInfoForDevice(int KODCJPLIPKO)
	{
		return null;
	}

	public void SubscriptionActivatedAlert()
	{
	}

	public void UpdateUnreachableTime()
	{
	}

	[CompilerGenerated]
	private void AAKIHNEPOIC()
	{
	}

	public void DeactivateDeviceButtonAction()
	{
	}

	public void JDILBFKPNOK(bool NLBMEIGLHMC = true)
	{
	}

	public bool IsApplePlatform()
	{
		return false;
	}

	[CompilerGenerated]
	private void NEFAPCBMCJN()
	{
	}

	public void UpdateActiveDevices()
	{
	}

	public IEnumerator OIIJMOCNICF()
	{
		return null;
	}

	private void Start()
	{
	}

	[CompilerGenerated]
	private bool BMEPPKKIKCO()
	{
		return false;
	}

	public bool IPCLKGFAPCP()
	{
		return false;
	}

	[CompilerGenerated]
	private bool LMMCHPIEKEP()
	{
		return false;
	}

	private void Awake()
	{
	}

	public void DCHCMKAKBPI(Product PNEINFKEEBD)
	{
	}

	private void EPNIJEFDFGG()
	{
	}

	private void CAECOHIOIPE()
	{
	}

	private void JNKEOHNDCLM()
	{
	}

	public string GetDeviceIdentifierFromModalScroller()
	{
		return null;
	}

	[IteratorStateMachine(typeof(OHKFCPMIPED))]
	public IEnumerator UpdateServerTimeWithInternetCheck()
	{
		return null;
	}
}
