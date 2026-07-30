using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class RARE : MonoBehaviour
{
	private sealed class OGIPCCOPCEI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string fileName;

		public string fileType;

		public Action<AudioClip, string> callBackFunction;

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

		[DebuggerHidden]
		public OGIPCCOPCEI(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		private void ICFDPOEDPCK()
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
	}

	private sealed class ALHAGNFCDOH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string urlPath;

		public Action<AudioClip, string> callBackFunction;

		private WWW _003Cwww_003E5__2;

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
		public ALHAGNFCDOH(int _003C_003E1__state)
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

	private int HOGKFBLFBGN;

	public bool recOutput;

	public Queue<float> dataQ;

	public float outputVol;

	private bool GAGMEPHKPHM;

	private bool LLEKFCGAOHH;

	private GameObject MNHEBIKJNBN;

	private float[] AAMKPDFHFAF;

	private AudioSource OBFDBKDOFHM;

	private bool ANNMFACCNHH;

	public static RARE _Instance;

	public static RARE Instance => null;

	public KeyValuePair<AudioClip, AudioClip> FEIMPJIEBFP(AudioClip BKDPGMMPAMD, int MMLKLLPCCOG)
	{
		return default(KeyValuePair<AudioClip, AudioClip>);
	}

	public AudioClip PJBDNDIOIBE(AudioClip BKDPGMMPAMD)
	{
		return null;
	}

	public AudioClip RemoveSilenceFromEndOfAudioClip(AudioClip BKDPGMMPAMD)
	{
		return null;
	}

	public void NIJLNACFGMC(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH, string HLGGHMOLEIK = "wav")
	{
	}

	public void CKBNDAPKOIJ(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}

	public void AOOAKDNNHMA()
	{
	}

	public void OLHIDNFELKH(int DGJINDBIOIH = 300)
	{
	}

	public void HIICJGKAANG(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}

	[IteratorStateMachine(typeof(OGIPCCOPCEI))]
	private IEnumerator MFKLCKGENGD(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH, string HLGGHMOLEIK = "wav")
	{
		return null;
	}

	private void AOACDHGKCJH(FileStream PNKBKBPAGOI, int GCBPPCOMPIK, int GAOEHHFMDGE)
	{
	}

	public KeyValuePair<AudioClip, AudioClip> SplitAudioClip(AudioClip BKDPGMMPAMD, int MMLKLLPCCOG)
	{
		return default(KeyValuePair<AudioClip, AudioClip>);
	}

	public void DLOHCODENJC(float CGOPKGNIBEO)
	{
	}

	public void BMKNDJGLFLO(string CAGFHGLBOEB, int ECNCJLIIJLB, int EFDKFECPIIC, AudioClip BKDPGMMPAMD, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}

	public void ALHAMBIMCFC(float[] BIIANEPOGPP, int GAOEHHFMDGE)
	{
	}

	public void JPPKPMKEFNC(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH, string HLGGHMOLEIK = "wav")
	{
	}

	public KeyValuePair<AudioClip, AudioClip> LMPDAMPKNJC(AudioClip BKDPGMMPAMD, int MMLKLLPCCOG)
	{
		return default(KeyValuePair<AudioClip, AudioClip>);
	}

	public float[] GetAudioLevels()
	{
		return null;
	}

	public AudioClip LPGPNBLCIJM(AudioClip BKDPGMMPAMD)
	{
		return null;
	}

	public AudioClip DEEHEFGMMIH(AudioClip BKDPGMMPAMD)
	{
		return null;
	}

	public AudioClip FONBIPJILAF(AudioClip BKDPGMMPAMD)
	{
		return null;
	}

	public AudioClip MakeAudioClipMono(AudioClip BKDPGMMPAMD)
	{
		return null;
	}

	public void OnAudioFilterRead(float[] BIIANEPOGPP, int GAOEHHFMDGE)
	{
	}

	public void DLPCFBABNIA(int DGJINDBIOIH = 300)
	{
	}

	public void DMGLOHHIPAC(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}

	public void GetAudioClipFromFile(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH, string HLGGHMOLEIK = "wav")
	{
	}

	public void OICKDOAJKBJ(string CAGFHGLBOEB, int ECNCJLIIJLB, int EFDKFECPIIC, AudioClip BKDPGMMPAMD, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}

	public AudioClip NPGHAOJIIFC(AudioClip BKDPGMMPAMD, int EFDKFECPIIC)
	{
		return null;
	}

	public float[] GKLOHCMMNMP()
	{
		return null;
	}

	public AudioClip GOHJDGAOALP(AudioClip BKDPGMMPAMD)
	{
		return null;
	}

	public AudioClip OOHKOLOMCMD(AudioClip BKDPGMMPAMD)
	{
		return null;
	}

	private IEnumerator CACJJIAHJFF(string ACCGILCCDGO, Action<AudioClip, string> CPKGIBPDMBH)
	{
		return null;
	}

	public void PBPFOMLOHAG(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}

	public void CBDCHEMPGAI(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH, string HLGGHMOLEIK = "wav")
	{
	}

	public float[] PMFGBDCIPLA()
	{
		return null;
	}

	public AudioClip HGIMDNAEGFK(AudioClip BKDPGMMPAMD, int ECNCJLIIJLB)
	{
		return null;
	}

	public void BOHHIIBECHI()
	{
	}

	private IEnumerator GJLFAJDMCHC(string ACCGILCCDGO, Action<AudioClip, string> CPKGIBPDMBH)
	{
		return null;
	}

	public void BOBGKEMBNAL(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}

	public AudioClip OINGKMAFCHF(AudioClip BKDPGMMPAMD)
	{
		return null;
	}

	public void SetMicPlayBack(bool GONLFJLNILD)
	{
	}

	[SpecialName]
	public static RARE JEJEIOPGBCI()
	{
		return null;
	}

	public void INKHPCCPAGH(float CGOPKGNIBEO)
	{
	}

	private IEnumerator CAFALDMOFNJ(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH, string HLGGHMOLEIK = "wav")
	{
		return null;
	}

	public void FBHBPKFNOAE()
	{
	}

	public void StartMicRecording(int DGJINDBIOIH = 300)
	{
	}

	public void LBHBMLHOOGJ(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH, string HLGGHMOLEIK = "wav")
	{
	}

	public void GetAudioClipFromURL(string ACCGILCCDGO, Action<AudioClip, string> CPKGIBPDMBH)
	{
	}

	public void IILHADIMPCG(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}

	public void PJPMGHIIIEH(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}

	public void OutputVolume(float CGOPKGNIBEO)
	{
	}

	private void Awake()
	{
	}

	public void CCBIIFMHFEM(bool GONLFJLNILD)
	{
	}

	public void BPAIAMEHCKK(string ACCGILCCDGO, Action<AudioClip, string> CPKGIBPDMBH)
	{
	}

	[IteratorStateMachine(typeof(ALHAGNFCDOH))]
	private IEnumerator KCBJECHPOKE(string ACCGILCCDGO, Action<AudioClip, string> CPKGIBPDMBH)
	{
		return null;
	}

	public AudioClip FIMLKDICEKP(AudioClip BKDPGMMPAMD, int ECNCJLIIJLB)
	{
		return null;
	}

	private IEnumerator ONDCKJOBAKC(string ACCGILCCDGO, Action<AudioClip, string> CPKGIBPDMBH)
	{
		return null;
	}

	public void PLECPLGICGJ(string CAGFHGLBOEB, AudioClip BKDPGMMPAMD, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}

	public AudioClip GIHPFKCPFHA(AudioClip BKDPGMMPAMD)
	{
		return null;
	}

	public AudioClip HBDIBANDPPG(AudioClip BKDPGMMPAMD)
	{
		return null;
	}

	public AudioClip LPMGPDCFINL(AudioClip BKDPGMMPAMD)
	{
		return null;
	}

	public AudioClip TrimEndOfAudioClip(AudioClip BKDPGMMPAMD, int EFDKFECPIIC)
	{
		return null;
	}

	public void KHNEOPMIEDO(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}

	public void JDLOAIHFFLJ(float[] BIIANEPOGPP, int GAOEHHFMDGE)
	{
	}

	public KeyValuePair<AudioClip, AudioClip> EFJGGIPIHCA(AudioClip BKDPGMMPAMD, int MMLKLLPCCOG)
	{
		return default(KeyValuePair<AudioClip, AudioClip>);
	}

	public void StartAudioListenerRecording()
	{
	}

	public void MAAEDHPIIIN(string CAGFHGLBOEB, AudioClip BKDPGMMPAMD, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}

	private void FECGNEDPNJJ()
	{
	}

	public void BEAGFIAGMHA(int DGJINDBIOIH = 300)
	{
	}

	public void EBABPBLEOIJ(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}

	public void EPFNNDCMJIC(string ACCGILCCDGO, Action<AudioClip, string> CPKGIBPDMBH)
	{
	}

	public AudioClip OMBGAPFOALK(AudioClip BKDPGMMPAMD, int ECNCJLIIJLB)
	{
		return null;
	}

	public void IKLLHGOACOL(float LKFDNNLOBAL)
	{
	}

	public void ADNNPFCLIHE()
	{
	}

	public void KBHJCILDFBL(string ACCGILCCDGO, Action<AudioClip, string> CPKGIBPDMBH)
	{
	}

	public void FDPICMNDCEJ(float LKFDNNLOBAL)
	{
	}

	public AudioClip CDDAPFAEHHI(AudioClip BKDPGMMPAMD)
	{
		return null;
	}

	public AudioClip EMOODPDPDHN(AudioClip BKDPGMMPAMD)
	{
		return null;
	}

	public AudioClip DFEMALCDINN(AudioClip BKDPGMMPAMD)
	{
		return null;
	}

	public float[] LNHALCKAENA()
	{
		return null;
	}

	private void BBAGMDJCPMH()
	{
	}

	[SpecialName]
	public static RARE DKJDFMAMMCB()
	{
		return null;
	}

	public void LIHKMJCAGEF(float LKFDNNLOBAL)
	{
	}

	public void ExportClip(string CAGFHGLBOEB, AudioClip BKDPGMMPAMD, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}

	public AudioClip DHNBBKDKDHJ(AudioClip BKDPGMMPAMD)
	{
		return null;
	}

	public void SetMicPlayBackVolume(float LKFDNNLOBAL)
	{
	}

	public KeyValuePair<AudioClip, AudioClip> NFHPKEGKNOK(AudioClip BKDPGMMPAMD, int MMLKLLPCCOG)
	{
		return default(KeyValuePair<AudioClip, AudioClip>);
	}

	[SpecialName]
	public static RARE JJEIJBCDMGC()
	{
		return null;
	}

	public void HCIPPLMCDAB(float[] BIIANEPOGPP, int GAOEHHFMDGE)
	{
	}

	private IEnumerator GGIGLDDGBNL(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH, string HLGGHMOLEIK = "wav")
	{
		return null;
	}

	[SpecialName]
	public static RARE PBIEEAGIODE()
	{
		return null;
	}

	public void StopMicRecording(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}

	private void NAHOHPAJLID()
	{
	}

	public void BOOJEGIPOKO(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}

	public void CDKIDOHKHEP(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}

	public void EPLEBLDHDFD(float CGOPKGNIBEO)
	{
	}

	public void CropAudioClip(string CAGFHGLBOEB, int ECNCJLIIJLB, int EFDKFECPIIC, AudioClip BKDPGMMPAMD, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}

	public AudioClip RemoveSilenceFromFrontOfAudioClip(AudioClip BKDPGMMPAMD)
	{
		return null;
	}

	[SpecialName]
	public static RARE AMOLJOPEJME()
	{
		return null;
	}

	public void GOBDINBEKOI(float LKFDNNLOBAL)
	{
	}

	public AudioClip TrimFrontOfAudioClip(AudioClip BKDPGMMPAMD, int ECNCJLIIJLB)
	{
		return null;
	}

	private void KCEBELLKIBB()
	{
	}

	public void BCGOCGGBLEL(int DGJINDBIOIH = 300)
	{
	}

	private IEnumerator EACMBIGMLFA(string ACCGILCCDGO, Action<AudioClip, string> CPKGIBPDMBH)
	{
		return null;
	}

	[SpecialName]
	public static RARE FAEHFLACLLK()
	{
		return null;
	}

	public void MBPHJAMIBIA(string ACCGILCCDGO, Action<AudioClip, string> CPKGIBPDMBH)
	{
	}

	public AudioClip NFNNMBCIDAE(AudioClip BKDPGMMPAMD, int ECNCJLIIJLB)
	{
		return null;
	}

	public AudioClip NIMHOOBALEO(AudioClip BKDPGMMPAMD)
	{
		return null;
	}

	public void LAHBPCBBKCP(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH, string HLGGHMOLEIK = "wav")
	{
	}

	public KeyValuePair<AudioClip, AudioClip> GMBCIOGCACM(AudioClip BKDPGMMPAMD, int MMLKLLPCCOG)
	{
		return default(KeyValuePair<AudioClip, AudioClip>);
	}

	public void StopAudioListenerRecording(string CAGFHGLBOEB, Action<AudioClip, string> CPKGIBPDMBH = null, GameObject FMMNKCGGHEF = null)
	{
	}
}
