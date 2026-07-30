using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class InternetReachabilityVerifier : MonoBehaviour
{
	public enum GIHMMPOPODN
	{
		DefaultByPlatform = 0,
		Google204 = 1,
		GoogleBlank = 2,
		MicrosoftNCSI = 3,
		Apple = 4,
		Ubuntu = 5,
		Custom = 6,
		Apple2 = 7,
		AppleHTTPS = 8,
		Google204HTTPS = 9,
		UbuntuHTTPS = 10,
		MicrosoftConnectTest = 11,
		MicrosoftNCSI_IPV6 = 12,
		MicrosoftConnectTest_IPV6 = 13
	}

	public enum BIHDCDFOHBK
	{
		Offline = 0,
		PendingVerification = 1,
		Error = 2,
		Mismatch = 3,
		NetVerified = 4
	}

	public delegate void DNCHOIAADGG(BIHDCDFOHBK AADLDOKAKMB);

	public delegate bool PJELBIFGBPI(UnityWebRequest NKBNLABMICM, string DPGBADHDOAD);

	private sealed class HFDOAJFDKNO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InternetReachabilityVerifier _003C_003E4__this;

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
		public HFDOAJFDKNO(int _003C_003E1__state)
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

	private sealed class FACEOBHAODB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InternetReachabilityVerifier _003C_003E4__this;

		private NetworkReachability _003CprevUnityReachability_003E5__2;

		private GIHMMPOPODN _003Ccpdm_003E5__3;

		private UnityWebRequest _003Ciwr_003E5__4;

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
		public FACEOBHAODB(int _003C_003E1__state)
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

	private const int PCLMMGDEMCH = 1200;

	public GIHMMPOPODN captivePortalDetectionMethod;

	[Tooltip("Self-hosted URL for using CaptivePortalDetectionMethod.Custom. For example: https://example.com/IRV.txt")]
	public string customMethodURL;

	[Tooltip("Data expected from the custom self-hosted URL. By default the data returned by the custom url is expected to start with contents of this string. Alternatively you can set the customMethodVerifierDelegate (see example code), in which case this string will be passed to the delegate.")]
	public string customMethodExpectedData;

	[Tooltip("Makes the IRV object not be destroyed automatically when loading a new scene.")]
	public bool dontDestroyOnLoad;

	[Tooltip("When enabled, custom method URL is appended with a query string containing a random number.\nExample of what such a query string may look like: ?z=13371337")]
	public bool customMethodWithCacheBuster;

	[NonSerialized]
	[Tooltip("Default time in seconds to wait until trying to verify network connectivity again.\nSuggested minimum: 1 second.")]
	public float defaultCheckPeriod;

	[NonSerialized]
	[Tooltip("Time in seconds to wait before retrying, after last verification attempt resulted in an error.\nSuggested minimum: 3 seconds.")]
	public float errorRetryDelay;

	[Tooltip("Time in seconds to wait after detecting a captive portal (WiFi login screen).\nSuggested minimum: 2 seconds.")]
	public float mismatchRetryDelay;

	[HideInInspector]
	public bool alwaysUseCacheBuster;

	[CompilerGenerated]
	private DNCHOIAADGG CGOBDKCLBEI;

	public PJELBIFGBPI customMethodVerifierDelegate;

	private float NBLDMNKKGGC;

	private BIHDCDFOHBK POGDFLHPCFF;

	private string MHEMDDPKOAN;

	private static InternetReachabilityVerifier JOHCOGCAEAK;

	private static RuntimePlatform[] AHIIMKDMFPL;

	private const GIHMMPOPODN PGFGHAJANBJ = GIHMMPOPODN.MicrosoftNCSI;

	private bool OBOIIGIACPK;

	private string AMEMBLOJCNL;

	private float KNLOIPOCDGD;

	public BIHDCDFOHBK status
	{
		get
		{
			return default(BIHDCDFOHBK);
		}
		set
		{
		}
	}

	public string lastError
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static InternetReachabilityVerifier Instance => null;

	public event DNCHOIAADGG statusChangedDelegate
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private IEnumerator OEJPDGEAIAM()
	{
		return null;
	}

	[SpecialName]
	public BIHDCDFOHBK MFCBGKOHOIK()
	{
		return default(BIHDCDFOHBK);
	}

	public IEnumerator KABOCGOLLMH()
	{
		return null;
	}

	private bool CLFAFMIPDKH(float JOGOFOLLMBF)
	{
		return false;
	}

	private void NLFOGADCIKF()
	{
	}

	private void FJKPIIMOCGA()
	{
	}

	private bool PBMHKINHPBO(GIHMMPOPODN MBKCHGAMHCG, UnityWebRequest DHBFGGKMEID)
	{
		return false;
	}

	private long NBFIJKEEGBG(UnityWebRequest DHBFGGKMEID)
	{
		return 0L;
	}

	private string EHFMCAHHKFI(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	private string ELLJPOAFJKK(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	[SpecialName]
	public BIHDCDFOHBK NPILGAJBENL()
	{
		return default(BIHDCDFOHBK);
	}

	private bool PCNCMEOCAPE(UnityWebRequest DHBFGGKMEID)
	{
		return false;
	}

	public void forceReverification()
	{
	}

	private void FNCAJNIGBGP()
	{
	}

	private void JBEOLKFJAGL()
	{
	}

	[SpecialName]
	public void FANBIGOGHOO(BIHDCDFOHBK JEHONDDIMPC)
	{
	}

	[SpecialName]
	public static InternetReachabilityVerifier JEJEIOPGBCI()
	{
		return null;
	}

	private byte[] BLONMINBOLF(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	public void OOOMDFOMKKK()
	{
	}

	private string MLLBBJEMLED(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	private bool DMPJFIHAEPF(GIHMMPOPODN MBKCHGAMHCG, UnityWebRequest DHBFGGKMEID)
	{
		return false;
	}

	[IteratorStateMachine(typeof(HFDOAJFDKNO))]
	public IEnumerator waitForNetVerifiedStatus()
	{
		return null;
	}

	private void ABIJAOAPBBP()
	{
	}

	private string OHFFFAGELFC(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	private void ELNFDMDFMJL()
	{
	}

	public void LBNIEJLHLJL()
	{
	}

	private string FNFCFFFPIBC(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	public void AEKPOHKMOPG()
	{
	}

	public void IMELCPNKNED(float FGHMOABNNLJ, float LGMNIHKMNGN, float HOMKIFHAHID)
	{
	}

	private void OnEnable()
	{
	}

	private IEnumerator CNJCDDFADPK()
	{
		return null;
	}

	public void OKLLHNLKICM()
	{
	}

	private void JHACFDGHOKF()
	{
	}

	public void KPGIGCAHBHO()
	{
	}

	private void LHKMODNAFAK()
	{
	}

	public void NJPCAFPILDM()
	{
	}

	private Dictionary<string, string> JKJPBMFINLJ(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	public void KGAKIMNFKHI(float FGHMOABNNLJ, float LGMNIHKMNGN, float HOMKIFHAHID)
	{
	}

	private long CKGBBMLKOHP(UnityWebRequest DHBFGGKMEID)
	{
		return 0L;
	}

	private Dictionary<string, string> MEBJKDBDOGL(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	private string KBDFGPCGHOH(GIHMMPOPODN MBKCHGAMHCG)
	{
		return null;
	}

	private byte[] HDFMLNMAIAG(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	private byte[] BCGLALPPJOK(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	[IteratorStateMachine(typeof(FACEOBHAODB))]
	private IEnumerator CPEINBCFBCK()
	{
		return null;
	}

	private string IPGKJDKLEEB(GIHMMPOPODN MBKCHGAMHCG)
	{
		return null;
	}

	private bool GBIMBHEIPJH(float JOGOFOLLMBF)
	{
		return false;
	}

	private string DFCEBHPJPND(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	public float AKLFOINCNLG()
	{
		return 0f;
	}

	public float MDGCBHKGAKI()
	{
		return 0f;
	}

	public void setNetActivityTimes(float FGHMOABNNLJ, float LGMNIHKMNGN, float HOMKIFHAHID)
	{
	}

	[SpecialName]
	public BIHDCDFOHBK BNNDPPBFLGI()
	{
		return default(BIHDCDFOHBK);
	}

	private string PHOGGCANABJ(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	private bool KKHNGEBFAGI(UnityWebRequest DHBFGGKMEID)
	{
		return false;
	}

	private long EDKOEIJKMLI(UnityWebRequest DHBFGGKMEID)
	{
		return 0L;
	}

	private string KFICHFFBBBF(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	public void Stop()
	{
	}

	private string AEJNNKOKIKG(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	private string KFCPGPNNMOJ(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	[SpecialName]
	public void OFALKNKOFOC(DNCHOIAADGG JEHONDDIMPC)
	{
	}

	private IEnumerator BCHKAAJGIEM()
	{
		return null;
	}

	[SpecialName]
	public void OAKHAIIAKAD(DNCHOIAADGG JEHONDDIMPC)
	{
	}

	private byte[] OFICKGKLEPI(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	private string INCLHDCNJOG(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	private long EBFAHIAKMNG(UnityWebRequest DHBFGGKMEID)
	{
		return 0L;
	}

	private string JBALODMILKF(GIHMMPOPODN MBKCHGAMHCG)
	{
		return null;
	}

	public IEnumerator OGCPOHMLHPM()
	{
		return null;
	}

	[SpecialName]
	public string OPCAPBLFNLO()
	{
		return null;
	}

	private byte[] LIGPNPHBMGL(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	private string EOKAMGLDHGH(UnityWebRequest DHBFGGKMEID, string LAALMOBHGOB)
	{
		return null;
	}

	private Dictionary<string, string> CAONNDPAGMH(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	[SpecialName]
	public BIHDCDFOHBK JHBBKPIOCIC()
	{
		return default(BIHDCDFOHBK);
	}

	private void DGLILKBGNAL()
	{
	}

	private void ENANAHOBJGA()
	{
	}

	private IEnumerator DGOMHCCIHEF()
	{
		return null;
	}

	private string DCNFPHJKKPG(GIHMMPOPODN MBKCHGAMHCG)
	{
		return null;
	}

	private bool NMLCKKCJOGC(float JOGOFOLLMBF)
	{
		return false;
	}

	[SpecialName]
	public void MGGKIGIKAKO(BIHDCDFOHBK JEHONDDIMPC)
	{
	}

	private void DOCPBIJMDDH()
	{
	}

	[SpecialName]
	public void POLLHJPCIKK(BIHDCDFOHBK JEHONDDIMPC)
	{
	}

	private void BGNDJPAAMJB()
	{
	}

	private void EOLKJBMJOAM()
	{
	}

	private bool EICHENKDCJE(float JOGOFOLLMBF)
	{
		return false;
	}

	private void PFNKDIMADGK()
	{
	}

	private bool FJMEOKJKCIH(float JOGOFOLLMBF)
	{
		return false;
	}

	private void BEMOEPIGCML()
	{
	}

	private long AJPOKJOPCPJ(UnityWebRequest DHBFGGKMEID)
	{
		return 0L;
	}

	private Dictionary<string, string> MODEJACIEIN(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	private void HKMJKCECPLO()
	{
	}

	private byte[] AANJIKMKDAB(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	private bool BJKJNGADIGG(GIHMMPOPODN MBKCHGAMHCG, UnityWebRequest DHBFGGKMEID)
	{
		return false;
	}

	private string GBAHAGEBDDC(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	private string KHJPPCJDFOH(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	private bool DJBEIONKPMN(GIHMMPOPODN MBKCHGAMHCG, UnityWebRequest DHBFGGKMEID)
	{
		return false;
	}

	public float MHHHAPMNKEO()
	{
		return 0f;
	}

	private string EJJCGOHMFHN(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	private void NDDEACPIAHL()
	{
	}

	[SpecialName]
	public string HPDCLCLNCCE()
	{
		return null;
	}

	private bool FAFPJKLMPOO(GIHMMPOPODN MBKCHGAMHCG, UnityWebRequest DHBFGGKMEID)
	{
		return false;
	}

	private string LKKANODFALP(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	[SpecialName]
	public void CGEHCGJEFPG(string JEHONDDIMPC)
	{
	}

	private void JMHGOJGAHND()
	{
	}

	[SpecialName]
	public void EPHDDKGIECD(DNCHOIAADGG JEHONDDIMPC)
	{
	}

	private void JHHGMMGHEOE()
	{
	}

	private bool ONBNBONBIKP(GIHMMPOPODN MBKCHGAMHCG, UnityWebRequest DHBFGGKMEID)
	{
		return false;
	}

	private bool EJFBPBIJFIA(GIHMMPOPODN MBKCHGAMHCG, UnityWebRequest DHBFGGKMEID)
	{
		return false;
	}

	private Dictionary<string, string> GLLPKIMOAGK(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	private string AKMBLHJMFLA(UnityWebRequest DHBFGGKMEID, string LAALMOBHGOB)
	{
		return null;
	}

	private Dictionary<string, string> NCJMIOGLKGG(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	private bool PJDJHKMJDDK(float JOGOFOLLMBF)
	{
		return false;
	}

	[SpecialName]
	public string DACEAOCPCHN()
	{
		return null;
	}

	[SpecialName]
	public void NMKANMPAFIJ(BIHDCDFOHBK JEHONDDIMPC)
	{
	}

	private void Awake()
	{
	}

	private IEnumerator OIHDCJBDAOE()
	{
		return null;
	}

	private void Start()
	{
	}

	private byte[] ACCALMLGJNK(UnityWebRequest DHBFGGKMEID)
	{
		return null;
	}

	private void ELFLBDLLHAC()
	{
	}

	[SpecialName]
	public void GCKFLDIADHO(BIHDCDFOHBK JEHONDDIMPC)
	{
	}

	private void INODINGJFGO()
	{
	}

	private IEnumerator JLJLJNIKOLD()
	{
		return null;
	}

	public float getTimeWithoutInternetConnection()
	{
		return 0f;
	}

	public float DNKODEKJBAN()
	{
		return 0f;
	}

	private string AJAPHHLGADB(GIHMMPOPODN MBKCHGAMHCG)
	{
		return null;
	}

	private long MBEKFHIIAME(UnityWebRequest DHBFGGKMEID)
	{
		return 0L;
	}

	private void CHBMONCDKFI()
	{
	}

	private bool BHDALJLMFOC(float JOGOFOLLMBF)
	{
		return false;
	}

	public void FAJCMICDGDP(float FGHMOABNNLJ, float LGMNIHKMNGN, float HOMKIFHAHID)
	{
	}

	private void OnDisable()
	{
	}

	private string FAEOCINBGCP(UnityWebRequest DHBFGGKMEID, string LAALMOBHGOB)
	{
		return null;
	}

	private string LPAMOGMBEIJ(UnityWebRequest DHBFGGKMEID, string LAALMOBHGOB)
	{
		return null;
	}

	[SpecialName]
	public void AOJILNPBGNA(DNCHOIAADGG JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void HDAIIOBLLNH(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void JDHPIEEGFCI(DNCHOIAADGG JEHONDDIMPC)
	{
	}

	[SpecialName]
	public static InternetReachabilityVerifier FOCFOENJHBE()
	{
		return null;
	}
}
