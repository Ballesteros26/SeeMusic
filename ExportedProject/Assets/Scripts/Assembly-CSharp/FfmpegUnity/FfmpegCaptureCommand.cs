using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace FfmpegUnity
{
	public class FfmpegCaptureCommand : FfmpegCommand
	{
		[Serializable]
		public class CaptureSource
		{
			public enum GPPGMFNLGLP
			{
				Video_GameView = 0,
				Video_Camera = 1,
				Video_RenderTexture = 2,
				Audio_AudioListener = 3,
				Audio_AudioSource = 4
			}

			public GPPGMFNLGLP Type;

			public int Width;

			public int Height;

			public int FrameRate;

			public Camera SourceCamera;

			public RenderTexture SourceRenderTexture;

			public AudioSource SourceAudio;

			public bool Mute;
		}

		private sealed class PGKKIBKPHJE
		{
			public string fileName;

			public FfmpegCaptureCommand _003C_003E4__this;
		}

		private sealed class GILBKFDMLHB
		{
			public int captureId;

			public int width;

			public int height;

			public PGKKIBKPHJE CS_0024_003C_003E8__locals1;

			internal void EKOAIHLHCBM()
			{
			}
		}

		private sealed class HEEKDPDPEAK
		{
			public int captureId;

			public int width;

			public int height;

			public PGKKIBKPHJE CS_0024_003C_003E8__locals2;

			internal void OALKEKDIHKG()
			{
			}
		}

		private sealed class GMPJDGBFMKK
		{
			public int captureId;

			public int width;

			public int height;

			public PGKKIBKPHJE CS_0024_003C_003E8__locals3;

			internal void FJHNLCEJOMI()
			{
			}
		}

		private sealed class FCODADDGGOO
		{
			public int captureId;

			public int sampleRate;

			public int channels;

			public PGKKIBKPHJE CS_0024_003C_003E8__locals4;

			internal void DEPNPLLGFLJ()
			{
			}
		}

		private sealed class POKBPCIHOAM
		{
			public int captureId;

			public int sampleRate;

			public int audioThreadChannels;

			public PGKKIBKPHJE CS_0024_003C_003E8__locals5;

			internal void MNNPPLGCFLF()
			{
			}
		}

		private sealed class FDBENPKNNNN : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FfmpegCaptureCommand _003C_003E4__this;

			private POKBPCIHOAM _003C_003E8__1;

			private int _003CcaptureLoop_003E5__2;

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
			public FDBENPKNNNN(int _003C_003E1__state)
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

		public CaptureSource[] CaptureSources;

		public string CaptureOptions;

		private Dictionary<int, Texture2D> HGOONLNNGIC;

		private Dictionary<int, byte[]> ENIHJOAAGHE;

		private Dictionary<int, List<float>> ENEFBGJILKF;

		private Dictionary<int, int> GOHJOOIBDAG;

		private List<Thread> FDBFODGHFLF;

		private FfmpegCaptureAudioListener DLIJNEFPPCI;

		private Dictionary<int, RenderTexture> PODICIHGBFB;

		private Dictionary<int, bool> AKOIALFBNLE;

		private Shader ILKKJLHHIEI;

		private Material EPFKNHEOFIA;

		private HLLHOGCHMPE EPMOKLFIEEF;

		protected virtual void GEMEFKGHFCA()
		{
		}

		private IEnumerator PDLIJMCLLNJ()
		{
			return null;
		}

		protected virtual void NOOMAOHBFME()
		{
		}

		private void BMDGBDCLLFA(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		protected virtual void MDBFGHAIJAA()
		{
		}

		private void JDDPMPPKJCG(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		public void NEJPDFCOLKN(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		private void KNOFDHCGFDN(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		public void OnAudioFilterWriteToCaptureAudio(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		private void EPCKJCBDBJB(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		private void NKDGOCKIGMM(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		private void GPLKKCPJAKO(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		public void ABFFHJKEOJB(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		protected virtual void LAPIEDOHNKE()
		{
		}

		private void HMAEOFJMLOD(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		private void LOFONJAOJJJ(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		protected virtual void AFFLIJCINIF()
		{
		}

		private void KBMBDPLNIPI(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		protected override void IMACCPAMNGN()
		{
		}

		private void KCPLMLLJKIJ(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		private void PFEEEBNJHHJ(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		private void BEKHDAPCICE(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		private IEnumerator DEIKBEEPODA()
		{
			return null;
		}

		private IEnumerator BFBHPCGPDBM()
		{
			return null;
		}

		public void LKKDKIKEENH(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		protected virtual void MBHJFOMDMAG()
		{
		}

		private IEnumerator INDFECGBMLN()
		{
			return null;
		}

		private void CGKLOANMKEO(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		public void CFDHEPAKOBH(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		public void KALGBHGEJKP(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		protected virtual void NGNKKGNDIPE()
		{
		}

		private void BICLDJCECMH(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		private IEnumerator PJDANAHIPAP()
		{
			return null;
		}

		private void AMGIPNIHBFG(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		private IEnumerator NCFHLJOGMDP()
		{
			return null;
		}

		private void EGNOBJDHLFH(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		public void MLFICGIMGAI(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		public void AGMPANGPBNO(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		private void CDLOAEGFLKK(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		public void IEJPOELCLEB(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		protected override void Update()
		{
		}

		public void EIBMKFILBBP(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		public void NFLEFEOLCKG(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		public void BGCGLAELPGM(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		public void KANEJPKBNFI(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		private void MBJAPOEGJCM(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		protected virtual void AHIBGIFDJIJ()
		{
		}

		private void JBKCIHDFNCL(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		private IEnumerator GMOELEHHFED()
		{
			return null;
		}

		private IEnumerator CBIAOBIKGOH()
		{
			return null;
		}

		private IEnumerator LPIGCDHOAPK()
		{
			return null;
		}

		protected virtual void CNBDOGPOKMB()
		{
		}

		public void KGBJHOEKNOO(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		private void PBOLHDOPFLG(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		public void NBDPJEMJCCC(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		public void FMNPNGACAPK(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		protected virtual void MBBHOJMJNBL()
		{
		}

		protected virtual void FCEDHNINDPD()
		{
		}

		protected override void MGLKMGOMGGM()
		{
		}

		public void CDCCLNEHIFI(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		private IEnumerator MOPILDPKGOE()
		{
			return null;
		}

		private void PJFGGKNNIHJ(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		protected virtual void DGJMDBCIIFG()
		{
		}

		protected virtual void FEEPHFCPJPB()
		{
		}

		private void HFPPGLCEEGP(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		protected virtual void JGMBAOKPOIH()
		{
		}

		private void GKAKNDKEMAC(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		private void FHCDDCFBGPJ(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		public void IIHMPFMHPHM(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		protected virtual void BBDGDFODOKL()
		{
		}

		private void JHCFDLBMHJI(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		private void GFIOCNAONFO(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		private void BMLHEPOHFAH(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		private void JMGFBOANOAE(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		private IEnumerator INAEFEKOMFF()
		{
			return null;
		}

		private void MLKCKBCHEDC(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		private void LCDKKPINLAL(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		public void ICFAOLEIGEJ(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		private IEnumerator EENCBLAJDFJ()
		{
			return null;
		}

		private void FOKKHNPBJMB(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		protected virtual void OCMFLNMAKOJ()
		{
		}

		public void PKBHOEELDFA(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		public void NFCFNFNMGIH(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		private IEnumerator DLFPHCJAEOK()
		{
			return null;
		}

		protected virtual void KBOMGOONADP()
		{
		}

		protected virtual void ENKBGNPFDEA()
		{
		}

		private void ENKHKIJLAII(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		private IEnumerator CDMNNLFOFIA()
		{
			return null;
		}

		private void BKBGPKPDPAE(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		private void CFKECDKPEHA(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		private void HJNDFEDEKFI(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		private IEnumerator MMIHCFDOPLI()
		{
			return null;
		}

		private void BBBJLLCNIIM(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		protected virtual void DFGJDJPMCAM()
		{
		}

		protected virtual void OOLKGLCEFJG()
		{
		}

		private void MDDOLIMGJKH(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		protected virtual void BGPCPOJJPLP()
		{
		}

		private void KNOICFGKGPM(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		private void IHPLLANCAMH(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		protected virtual void CDKPHKBMEFC()
		{
		}

		private void JCPCLJPGONI(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		private void NHJCCBOKGBN(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		private void JPOMEGEIJIB(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		private IEnumerator MMKOLLOLMMP()
		{
			return null;
		}

		private void EJPCELMMEDG(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		[IteratorStateMachine(typeof(FDBENPKNNNN))]
		private IEnumerator OMIAICPPHPJ()
		{
			return null;
		}

		private void KKPOPNOGIKM(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		protected virtual void APNJGIMPKAB()
		{
		}

		public void HOFGGOFDBFE(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		private IEnumerator KCOMFICKGJF()
		{
			return null;
		}

		private void LMMCMGMLBAC(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		protected virtual void CEMHGCNEHCD()
		{
		}

		private void EPPJENJDAKM(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		private void PIFEMJJAJGO(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		private void ACFHGLNIPKB(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		protected virtual void EAPMLFMGFFL()
		{
		}

		protected virtual void DHFIKBGPKHM()
		{
		}

		public void KMNANNJHNDN(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		private void OBLGLIKFLDO(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		protected virtual void KNAEHIDAGPM()
		{
		}

		public void KILNKMKGFFM(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		protected virtual void BMBCDPPKPPN()
		{
		}

		private void LKOIDAJJDML(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		private void GBOLOFLLCGA(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		protected virtual void GPJDOKFFCKA()
		{
		}

		public void JHLEDLEOCFO(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		protected virtual void EBAJMDLDBJM()
		{
		}

		private IEnumerator KKFNHCPPEJP()
		{
			return null;
		}

		private void KIMJNKMGAHD(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		protected virtual void IBFLAIGKFAL()
		{
		}

		protected virtual void BACADFNAFOM()
		{
		}

		protected virtual void KAFJDHJOOAE()
		{
		}

		private void LEHLKLHMFHC(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		private IEnumerator CNDEJJJKGDD()
		{
			return null;
		}

		protected virtual void JNGPEIKOGNG()
		{
		}

		private void POCANGGIJNG(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		public void GLPIKGIIJBL(float[] BIIANEPOGPP, int GAOEHHFMDGE, int MIPLPPLCFBI)
		{
		}

		private void HAJMPILLPAK(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		private void OMONNFONCNG(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}

		private IEnumerator GODMPEDMCOC()
		{
			return null;
		}

		private void GFMPFJFJMIJ(int MIPLPPLCFBI, string EGDOGJFMBHJ, int NHCAHIMBLMD, int GAOEHHFMDGE)
		{
		}

		private void AJPDOALMGIE(int MIPLPPLCFBI, string EGDOGJFMBHJ, int MHOFONMFCJD, int AOEIBOIKGAL)
		{
		}
	}
}
