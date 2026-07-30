using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using RenderHeads.Media.AVProLiveCamera;
using UnityEngine;
using UnityEngine.UI;
using VideoKit;
using VideoKit.Devices;
using VideoKit.UI;

[RequireComponent(typeof(RawImage), typeof(AspectRatioFitter))]
public class LiveCamera : MonoBehaviour
{
	private sealed class HIMKDLPCCMK
	{
		public float timeWaitStarted;

		internal bool OEBHIMADPBB()
		{
			return false;
		}
	}

	private sealed class KBNICFDMBDF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LiveCamera _003C_003E4__this;

		public bool WithDelay;

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
		public KBNICFDMBDF(int _003C_003E1__state)
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

	[StructLayout((LayoutKind)3)]
	private struct EKCLIIGDLIL : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public LiveCamera _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CameraDevice[]> _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct CPIAANOODBL : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public LiveCamera _003C_003E4__this;

		private bool _003CNoInput_003E5__2;

		private TaskAwaiter<CameraDevice[]> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private float _003CtimeWaitStarted2_003E5__3;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private static LiveCamera JOHCOGCAEAK;

	[CompilerGenerated]
	private static LiveCamera _003CHOLNFGBMPDC_003Ek__BackingField;

	[CompilerGenerated]
	private WebCamTexture _003CILCKACLEPPD_003Ek__BackingField;

	public VideoKitCameraManager CameraManager;

	public VideoKitCameraView CameraView;

	public RawImage rawImage;

	private AspectRatioFitter FAEOBMLIIDL;

	public AVProLiveCameraManager AVProCameraManagerComponent;

	public AVProLiveCamera AVProLiveCameraComponent;

	public AVProLiveCameraMaterialApply AVProCameraMaterialComponent;

	public Material AVProLiveCameraMaterial;

	public GameObject CameraViewCanvas;

	[NonSerialized]
	public float CameraAspect;

	public static LiveCamera Instance
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

	public WebCamTexture webCamTexture
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

	[SpecialName]
	private static void PKMJPHJBNGO(LiveCamera JEHONDDIMPC)
	{
	}

	[SpecialName]
	private void HADNEGJNNGG(WebCamTexture JEHONDDIMPC)
	{
	}

	[SpecialName]
	public static LiveCamera FEEICNBGIGJ()
	{
		return null;
	}

	[SpecialName]
	private void JGPDNBGDPIL(WebCamTexture JEHONDDIMPC)
	{
	}

	[SpecialName]
	public static LiveCamera NIFABAMAGNL()
	{
		return null;
	}

	public void FPKAPJPJBBM()
	{
	}

	public void BNMHHMANABM()
	{
	}

	private void FHEOKAGIBPH()
	{
	}

	[SpecialName]
	private static void OGOJFGFDBLL(LiveCamera JEHONDDIMPC)
	{
	}

	[SpecialName]
	private void HHGLKDMJDCN(WebCamTexture JEHONDDIMPC)
	{
	}

	[SpecialName]
	private void CMNDEOABAHA(WebCamTexture JEHONDDIMPC)
	{
	}

	public void FFDFNBGEMNB()
	{
	}

	[SpecialName]
	public WebCamTexture JPOEMPCBIGJ()
	{
		return null;
	}

	[SpecialName]
	private static void JGGOEOHJJKA(LiveCamera JEHONDDIMPC)
	{
	}

	public void HBKJBDDMDMA()
	{
	}

	[SpecialName]
	private void AFEMKHEMGGN(WebCamTexture JEHONDDIMPC)
	{
	}

	[SpecialName]
	private void EEGNFNEGAHJ(WebCamTexture JEHONDDIMPC)
	{
	}

	[SpecialName]
	public static LiveCamera OEMIFMAJCCN()
	{
		return null;
	}

	private void LOHAIHNCPHL()
	{
	}

	[SpecialName]
	public WebCamTexture HLOPLDIDFPP()
	{
		return null;
	}

	[SpecialName]
	public static LiveCamera PCOKPBODLGI()
	{
		return null;
	}

	[SpecialName]
	public static LiveCamera BLIHHGCJDJI()
	{
		return null;
	}

	public void INIJPDMPJLI()
	{
	}

	public IEnumerator IPGMBEMEGMD(bool KFFAKGHKLGJ = false)
	{
		return null;
	}

	[SpecialName]
	public WebCamTexture DHPHFJNHLGO()
	{
		return null;
	}

	[SpecialName]
	public static LiveCamera MBBMKIIDBBB()
	{
		return null;
	}

	[SpecialName]
	private static void MCDMNDOBKLN(LiveCamera JEHONDDIMPC)
	{
	}

	private void OLEGMBOIKIK()
	{
	}

	public void LPMIOLHNDLM()
	{
	}

	[SpecialName]
	public WebCamTexture CHMKIIOPFBO()
	{
		return null;
	}

	[SpecialName]
	private void MOONKLNAGNM(WebCamTexture JEHONDDIMPC)
	{
	}

	[SpecialName]
	public WebCamTexture IEAIKBGHBPM()
	{
		return null;
	}

	public IEnumerator EPBFOPPNDBD(bool KFFAKGHKLGJ = false)
	{
		return null;
	}

	[AsyncStateMachine(typeof(EKCLIIGDLIL))]
	public void FindInputAndStartCamera()
	{
	}

	[SpecialName]
	private void BJADCDHGIMH(WebCamTexture JEHONDDIMPC)
	{
	}

	[SpecialName]
	public static LiveCamera EAFNOFAHCIP()
	{
		return null;
	}

	[SpecialName]
	private void MHGKGBIOEFP(WebCamTexture JEHONDDIMPC)
	{
	}

	public void DGDFPGGHCEN()
	{
	}

	public void HJFJKPIPNII()
	{
	}

	[SpecialName]
	private static void LAPIHDEEHFF(LiveCamera JEHONDDIMPC)
	{
	}

	public void PCMALMJIJMC()
	{
	}

	[SpecialName]
	public static LiveCamera GOOPLFNFDPH()
	{
		return null;
	}

	public void StopCamera()
	{
	}

	private void GBOPFKEINJA()
	{
	}

	public void NKNBECAFAPL()
	{
	}

	public void OINJMKNGEOL()
	{
	}

	private void CEANALJLNNJ()
	{
	}

	public void MHHBMIBJKAK()
	{
	}

	public void LBLMBDOFMDB()
	{
	}

	public void BPKNICMLIPE()
	{
	}

	public void EFPJIPMBFGE()
	{
	}

	public IEnumerator PHJKIPEDHBG(bool KFFAKGHKLGJ = false)
	{
		return null;
	}

	[SpecialName]
	private void FLOCODJCNED(WebCamTexture JEHONDDIMPC)
	{
	}

	private void HMDCFHMKDAD()
	{
	}

	public IEnumerator OFCBCHNFAFE(bool KFFAKGHKLGJ = false)
	{
		return null;
	}

	[SpecialName]
	public static LiveCamera AJNCFKIENAI()
	{
		return null;
	}

	private void GIJFFDLLCOF()
	{
	}

	public IEnumerator HMINBCHBJEM(bool KFFAKGHKLGJ = false)
	{
		return null;
	}

	private void KFLDHOFJFBE()
	{
	}

	public IEnumerator JPNGGCKFDBM(bool KFFAKGHKLGJ = false)
	{
		return null;
	}

	private void BLKDBGIMIJC()
	{
	}

	[SpecialName]
	private static void DFDLOAFNBOG(LiveCamera JEHONDDIMPC)
	{
	}

	public void GLDIHMNPCFE()
	{
	}

	public void DMKFMNBBAAN()
	{
	}

	public IEnumerator DOGCKPGFJKI(bool KFFAKGHKLGJ = false)
	{
		return null;
	}

	[SpecialName]
	public static LiveCamera FIJJMAMKLHJ()
	{
		return null;
	}

	public void PAFPGEAFAHM()
	{
	}

	[SpecialName]
	public WebCamTexture LLMCFPPGBNE()
	{
		return null;
	}

	public void DNMFPKBPMJE()
	{
	}

	private void Awake()
	{
	}

	private void NOIEOJJEENK()
	{
	}

	public IEnumerator AFLLFOAEKLA(bool KFFAKGHKLGJ = false)
	{
		return null;
	}

	public void FIJOBCCKGPG()
	{
	}

	public IEnumerator AHCBMLGMNEC(bool KFFAKGHKLGJ = false)
	{
		return null;
	}

	[SpecialName]
	private void BPOFNBAJBKE(WebCamTexture JEHONDDIMPC)
	{
	}

	public IEnumerator KIKGAGGBNDJ(bool KFFAKGHKLGJ = false)
	{
		return null;
	}

	public void CAONHNHMPLP()
	{
	}

	public void DIIAEECPMFI()
	{
	}

	public void LNLGFGJDAOM()
	{
	}

	public IEnumerator NOGFMPHDLFA(bool KFFAKGHKLGJ = false)
	{
		return null;
	}

	public void BFEAJFDMJFJ()
	{
	}

	[SpecialName]
	public WebCamTexture OBEJOMLGCGE()
	{
		return null;
	}

	public void JPCNCPFOOPH()
	{
	}

	[SpecialName]
	private void AGJNCFAOLIL(WebCamTexture JEHONDDIMPC)
	{
	}

	private void IBPJAHCLKBP()
	{
	}

	public void MFIMDDMPEDB()
	{
	}

	private void FBAPDGFEIOL()
	{
	}

	private void JPPAOKDGLKH()
	{
	}

	[SpecialName]
	private void DLEPPOCKNIN(WebCamTexture JEHONDDIMPC)
	{
	}

	public void DDPNOIMPGKC()
	{
	}

	private void AJOKACOLICB()
	{
	}

	[SpecialName]
	public static LiveCamera FDANNLJELAI()
	{
		return null;
	}

	private void HKDAPKKHDOO()
	{
	}

	[SpecialName]
	private static void OOJGEIAEOOC(LiveCamera JEHONDDIMPC)
	{
	}

	[IteratorStateMachine(typeof(KBNICFDMBDF))]
	public IEnumerator StartCamera(bool KFFAKGHKLGJ = false)
	{
		return null;
	}

	[SpecialName]
	public WebCamTexture MBLAJBAACDH()
	{
		return null;
	}

	[SpecialName]
	private static void JKPDDEGAOHD(LiveCamera JEHONDDIMPC)
	{
	}

	private void HICGGJIHPCE()
	{
	}

	[SpecialName]
	public static LiveCamera BCCIPMKJJBJ()
	{
		return null;
	}

	public void JJKJJPPPKFN()
	{
	}

	public void DCEMPFKIOKH()
	{
	}

	public void JEPOGAALOPE()
	{
	}

	public IEnumerator GMGCJLPLOKB(bool KFFAKGHKLGJ = false)
	{
		return null;
	}

	public IEnumerator MILCGLOBDAP(bool KFFAKGHKLGJ = false)
	{
		return null;
	}

	public IEnumerator CBLFIJKHFIH(bool KFFAKGHKLGJ = false)
	{
		return null;
	}

	[SpecialName]
	private static void KCHPGDPIANN(LiveCamera JEHONDDIMPC)
	{
	}

	[SpecialName]
	private void PEDCFJGADJK(WebCamTexture JEHONDDIMPC)
	{
	}

	public void COMMEGOLCNM()
	{
	}

	[AsyncStateMachine(typeof(CPIAANOODBL))]
	public void StartCameraAsync()
	{
	}

	[SpecialName]
	public WebCamTexture ODOMKHDOHNI()
	{
		return null;
	}

	private void NPKAHGHLHIK()
	{
	}

	[SpecialName]
	public WebCamTexture MOBEBJJGPMI()
	{
		return null;
	}

	public void OIJNDKDDJMF()
	{
	}

	[SpecialName]
	private void ODDCONJNAID(WebCamTexture JEHONDDIMPC)
	{
	}

	public void EEKPIPGHBKP()
	{
	}

	[SpecialName]
	private static void KLACAOODLKB(LiveCamera JEHONDDIMPC)
	{
	}
}
