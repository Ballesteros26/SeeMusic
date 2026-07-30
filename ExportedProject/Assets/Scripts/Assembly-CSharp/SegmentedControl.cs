using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SegmentedControl : MonoBehaviour
{
	private sealed class OPNKGIDLILH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SegmentedControl _003C_003E4__this;

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
		public OPNKGIDLILH(int _003C_003E1__state)
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

	private sealed class BPCIGNEKNLG
	{
		public Button segment;

		public SegmentedControl _003C_003E4__this;

		internal void HBJKIOPKMHO()
		{
		}
	}

	public int numberOfSegments;

	public int selectedSegment;

	[NonSerialized]
	public bool isEnabled;

	[NonSerialized]
	public Button[] segments;

	[NonSerialized]
	public GameObject[] dividers;

	public string segment1Title;

	public string segment2Title;

	public string segment3Title;

	public string segment4Title;

	public string segment5Title;

	public string segment6Title;

	[NonSerialized]
	public string[] segmentTitles;

	public Sprite segment1Image;

	public Sprite segment2Image;

	public Sprite segment3Image;

	public Sprite segment4Image;

	public Sprite segment5Image;

	public Sprite segment6Image;

	[NonSerialized]
	public Sprite[] segmentImages;

	[NonSerialized]
	public Image BackgroundImage;

	public Button segmentedControlSegment;

	[NonSerialized]
	public float highlightAlpha;

	[NonSerialized]
	public Color textColor;

	[NonSerialized]
	public Color highlightColor;

	public GameObject segmentHighlight;

	[NonSerialized]
	private float FOHCADBBODC;

	[NonSerialized]
	private float GMNMADBIPNG;

	[NonSerialized]
	private float JEEBECKGGNO;

	[NonSerialized]
	private float KMNCBDJEOHH;

	public int fontSize;

	public Action CustomClickAction;

	public DynamicSegmentedControl dynamicSegmentedControl;

	private GameObject MCHLHGIODJM;

	public List<GameObject> Segments;

	[NonSerialized]
	public Material DividerMaterial;

	private Image DIIPNLONOOE;

	[NonSerialized]
	private float KKMMBJNAFLF;

	[NonSerialized]
	private bool HBADCCDADHH;

	[NonSerialized]
	private float OHCLODOOMBA;

	[NonSerialized]
	private float HKHHBEMEMCJ;

	[NonSerialized]
	private bool KAJLHAKAEIB;

	public void LEPIPCCMIGP(bool AEGHMJIJPDN)
	{
	}

	public void AIJMIGMMMAP(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	public void GMACJFMEHDP()
	{
	}

	public void FEPKPCPCEHJ(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	public void CGJLHLGJMEG()
	{
	}

	public void JNOHCMPPHPL()
	{
	}

	public void IOEHPBKJBOJ(bool AEGHMJIJPDN)
	{
	}

	public void GNGIHNJKLMH(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	public void UpdateLayout()
	{
	}

	private void DOOIIGIIADA()
	{
	}

	public void GBJDLLFHBCF()
	{
	}

	public IEnumerator KCJPLKNIBLP()
	{
		return null;
	}

	private void PGCCHJEIBGL()
	{
	}

	public void IIGCLFPDMKJ(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	private void JDDIPBLLHGA()
	{
	}

	private void LFLNMOELKLC()
	{
	}

	public void OPPIMHCKDMN(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	public void IJDANCGNCMF()
	{
	}

	public IEnumerator OGEGNMPPDMD()
	{
		return null;
	}

	private void NFPPODEMOGD()
	{
	}

	private void IKHLFENBLDP()
	{
	}

	public IEnumerator DFIOLLAKLKO()
	{
		return null;
	}

	private void KPDHPECMDMH()
	{
	}

	private void PGOMLLJJKLM()
	{
	}

	public void OCLPDHLOHJP()
	{
	}

	private void OKAEIDPJBNO()
	{
	}

	public void AKMDBHBKDDE()
	{
	}

	private void EHFIFGMJCCG()
	{
	}

	public void NHBJDBPCDHJ()
	{
	}

	public void OKGPNLECFIF()
	{
	}

	public void DIPCHDFFMHL()
	{
	}

	private void Update()
	{
	}

	public void GMOAOPELDKE(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	public void KBEHHPFOECE()
	{
	}

	public IEnumerator KIHCODOKCCE()
	{
		return null;
	}

	private void IGOFIFLAAPL()
	{
	}

	public void initialize()
	{
	}

	public void IANCNPFCFKH(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	public void LJBKHICNAKN()
	{
	}

	private void KDJJBHFOFFM()
	{
	}

	public void BHNAOCHHFFK()
	{
	}

	public void IJFFIHBJMKI(bool AEGHMJIJPDN)
	{
	}

	public void BFKINHJJKAA(bool AEGHMJIJPDN)
	{
	}

	private void JPJPKFMAJEP()
	{
	}

	public void HCACHFCDJLM(bool AEGHMJIJPDN)
	{
	}

	public IEnumerator KEPPJANHBID()
	{
		return null;
	}

	public void SegmentClicked(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	public void INIFHPAPDMK(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	private void APJCDFAOPPF()
	{
	}

	public void IODCNCHBLLO(bool AEGHMJIJPDN)
	{
	}

	private void COMBKINJGFJ()
	{
	}

	public void KFKBDMMIPAE()
	{
	}

	private void HBMFFNJNEBD()
	{
	}

	private void DBCEKEGPBOB()
	{
	}

	public void DLHPGEEFMGI(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	private void AFIFGKEPLOG()
	{
	}

	public void EHBODMHOODC(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	public void BPOPINOHKDN(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	public void CPIGMGPJALB(bool AEGHMJIJPDN)
	{
	}

	private void HDBLEGPKPIN()
	{
	}

	public void NHNMOKFKEGE()
	{
	}

	public IEnumerator OMBPIGJAECE()
	{
		return null;
	}

	public void SetHighlightPosition(bool AEGHMJIJPDN)
	{
	}

	public IEnumerator LBFOCLOKDDK()
	{
		return null;
	}

	private void FEDJAAOCEIB()
	{
	}

	public void PDKCOGPEMKF(bool AEGHMJIJPDN)
	{
	}

	private void BDIENPFKEGA()
	{
	}

	public void CPEHNLDPOPA(bool AEGHMJIJPDN)
	{
	}

	private void AOJJEAAMEJI()
	{
	}

	public void LPNLEOJEFNJ()
	{
	}

	public IEnumerator ALAFCKNDFME()
	{
		return null;
	}

	private void JNFMGLCKLON()
	{
	}

	private void KCDKELNDCNL()
	{
	}

	private void NEHIBPAACGB()
	{
	}

	public IEnumerator LLMLDHJEOAE()
	{
		return null;
	}

	public void HJHMNKPOEOK()
	{
	}

	public void IOPPDFCMJLG()
	{
	}

	public void JIEJEODAMPD()
	{
	}

	private void MFHNOABBDOC()
	{
	}

	private void OBGLJMGGNNI()
	{
	}

	public IEnumerator PBOBLLGPGBO()
	{
		return null;
	}

	public void EEMNKPDPCEM(bool AEGHMJIJPDN)
	{
	}

	public void JKDBJIOKGGB(bool AEGHMJIJPDN)
	{
	}

	public void GPBBAMOFBFP()
	{
	}

	public void AKEKECMEEJD(bool AEGHMJIJPDN)
	{
	}

	public void GMDLIGJNGNL()
	{
	}

	private void DDGPCKALOCD()
	{
	}

	private void Start()
	{
	}

	private void KNPIFPLDNBK()
	{
	}

	public void AMOIHFHCIJB(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	public void JOHDCBIEPKB(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	public void IAFFBENLACO()
	{
	}

	public void KIOBAGFDABL(bool AEGHMJIJPDN)
	{
	}

	public void BFPLMLBPOOJ(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	[IteratorStateMachine(typeof(OPNKGIDLILH))]
	public IEnumerator Redraw()
	{
		return null;
	}

	public void DBEMFHOKNGH(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	private void PLLLEPOEGHH()
	{
	}

	private void FDINBCPKJEH()
	{
	}

	public void JHHJBBJHNOE(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	private void EDBBPKKIBCO()
	{
	}

	public void MAMEMLKOBCB()
	{
	}

	private void PMCEJKDPAJP()
	{
	}

	public void MPAEHAEPDDO(bool AEGHMJIJPDN)
	{
	}

	private void GPFOCNOGIAK()
	{
	}

	private void NPADANBLIOF()
	{
	}

	private void KOBAMMFJPMF()
	{
	}

	public void KEAJLNIDONP(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	private void HJPPALBAJGF()
	{
	}

	private void KALCJNFAMIC()
	{
	}

	public void PCOHMLDHNJE(bool AEGHMJIJPDN)
	{
	}

	private void KGMPHMOBEOL()
	{
	}

	public void FCPAPNHFINE()
	{
	}

	public void KGLDLMPMDGD()
	{
	}

	private void OAFDDLNFPMP()
	{
	}

	public void BFIAINMEJPM(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	public void MIJDPGEGGHO(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	private void DMENIFAPIPN()
	{
	}

	public void IBLBDOKLJNO(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	private void FCEPGJKPNLI()
	{
	}

	private void PCKGAKGDINA()
	{
	}

	public void EDPOLOBEHMJ(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	public IEnumerator FAALGLNOEEG()
	{
		return null;
	}

	public IEnumerator MANEBIMKDAN()
	{
		return null;
	}

	public void MPAJONJCGJL()
	{
	}

	private void GBIFNECJBLM()
	{
	}

	public IEnumerator IMIBHNFGICN()
	{
		return null;
	}

	public void GBMGFLIDLLI()
	{
	}

	private void ICJDDHBLHAL()
	{
	}

	public void LCGCIGACHMD()
	{
	}

	public void DNDOBNCEJMC()
	{
	}

	public void FCPKFMGMMMH()
	{
	}

	private void NAKPIFMLFBA()
	{
	}

	public void FDJOAOPIIMK(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	public void KOGCNJDLOJE()
	{
	}

	private void OBDEFBMCMBN()
	{
	}

	private void LCFBMNNHGMD()
	{
	}

	public void FMKPPGONIIH(int NPCNEBDEJOI, bool OPDHNGCBPEB, bool AEGHMJIJPDN = true)
	{
	}

	public void EEODBMIFBBF(bool AEGHMJIJPDN)
	{
	}

	public void NCNIBPFPKPK(bool AEGHMJIJPDN)
	{
	}

	private void ACMLHJNEAKD()
	{
	}

	public IEnumerator ABIGKDDFKPO()
	{
		return null;
	}

	private void HKEBLKOGMGK()
	{
	}

	private void DLOHBJJBNMK()
	{
	}

	public IEnumerator DDMKDPCJOBC()
	{
		return null;
	}

	public void GGGCHELMFPN()
	{
	}

	private void IAOLAEFFLOD()
	{
	}

	private void GDIPJMJOOJE()
	{
	}

	public void EGENMCBJJDF(bool AEGHMJIJPDN)
	{
	}
}
