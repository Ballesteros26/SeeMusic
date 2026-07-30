using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Michsky.UI.ModernUIPack
{
	public class RadialSlider : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Serializable]
		public class SliderEvent : UnityEvent<float>
		{
		}

		private const string NGHIFFFGNLP = "Radial";

		[Header("OBJECTS")]
		public Image sliderImage;

		public Transform indicatorPivot;

		public TextMeshProUGUI valueText;

		[Header("SETTINGS")]
		public string sliderTag;

		public float maxValue;

		public float currentValue;

		[Range(0f, 8f)]
		public int decimals;

		public bool isPercent;

		public bool rememberValue;

		public bool enableCurrentValue;

		[SerializeField]
		private SliderEvent onValueChanged;

		private GraphicRaycaster NNPKBFNJLCL;

		private RectTransform GHLGNGCMFHB;

		private bool OPCFMBADNJP;

		private float PFGFCOCMEBD;

		private float KLPPMKCOBAK;

		private float DFIHDBBJKOD;

		public float SliderAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SliderValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SliderValueRaw
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void OGHLBDDBPKK()
		{
		}

		[SpecialName]
		public void EJPAJNMHBMI(float JEHONDDIMPC)
		{
		}

		public void NIAOFBLBFOM()
		{
		}

		public void ICOKLPOHNML(PointerEventData KFOIKMGPCHF)
		{
		}

		private void IKIPLDKDIKH()
		{
		}

		public void JDEPKAIPFIC(PointerEventData KFOIKMGPCHF)
		{
		}

		private bool LEPOBCDELDJ()
		{
			return false;
		}

		[SpecialName]
		public void LFPCDLKPFMH(float JEHONDDIMPC)
		{
		}

		private bool KCHFLMABPAC()
		{
			return false;
		}

		[SpecialName]
		public void GJBHPLMGGJM(float JEHONDDIMPC)
		{
		}

		private void NHICHLIKCHJ(PointerEventData KFOIKMGPCHF, bool MAAGAJPDINN)
		{
		}

		public void PJIBNNNPBOE()
		{
		}

		[SpecialName]
		public void DNPKJGGJOKN(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float AJJIIFOFICH()
		{
			return 0f;
		}

		private void HKDAPKKHDOO()
		{
		}

		[SpecialName]
		public void HKEPNNJLGBD(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float AIEEMLJKLHD()
		{
			return 0f;
		}

		public void BPENNIKMDBD()
		{
		}

		public void DBHHLAPFAJI(PointerEventData KFOIKMGPCHF)
		{
		}

		public void KLJAOADGGML(PointerEventData KFOIKMGPCHF)
		{
		}

		[SpecialName]
		public void EKDJMIHAFIN(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void ALDHKKOJHKI(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void GPPODBFDLGP(float JEHONDDIMPC)
		{
		}

		public void HMGCPIMFOPP(PointerEventData KFOIKMGPCHF)
		{
		}

		private bool PIGMBCOPIPM()
		{
			return false;
		}

		[SpecialName]
		public void FDLINFKBFDA(float JEHONDDIMPC)
		{
		}

		public void NLCLNCFJDFI(PointerEventData KFOIKMGPCHF)
		{
		}

		private void PGLGDDAGBJB(PointerEventData KFOIKMGPCHF, bool MAAGAJPDINN)
		{
		}

		private bool INPFJDFFICP()
		{
			return false;
		}

		private void HKEBLKOGMGK()
		{
		}

		private void OLODDAMNFMN()
		{
		}

		[SpecialName]
		public float CKLONGNEGDM()
		{
			return 0f;
		}

		[SpecialName]
		public void FLBBIAKHOLN(float JEHONDDIMPC)
		{
		}

		public void BGPPGJGKPKJ(PointerEventData KFOIKMGPCHF)
		{
		}

		private void NNJEOGGNCAI()
		{
		}

		public void DCDKBCJFJEA(PointerEventData KFOIKMGPCHF)
		{
		}

		public void OnPointerDown(PointerEventData KFOIKMGPCHF)
		{
		}

		public void NNIJKALEMJF()
		{
		}

		private void HGDPMAGIIEK(PointerEventData KFOIKMGPCHF, bool MAAGAJPDINN)
		{
		}

		public void HGCJHMCNJLM(PointerEventData KFOIKMGPCHF)
		{
		}

		private bool BAINILNNAMG()
		{
			return false;
		}

		[SpecialName]
		public float DPPHFBPOLEM()
		{
			return 0f;
		}

		private void OBLFBCPHDOJ(PointerEventData KFOIKMGPCHF, bool MAAGAJPDINN)
		{
		}

		[SpecialName]
		public void BDDBIHPBNBJ(float JEHONDDIMPC)
		{
		}

		public void OGKHEAEHFFD()
		{
		}

		private void NPEJFDDJOHB(PointerEventData KFOIKMGPCHF, bool MAAGAJPDINN)
		{
		}

		[SpecialName]
		public float PMNHBKJBPEB()
		{
			return 0f;
		}

		[SpecialName]
		public void MCEHCHPMOOO(float JEHONDDIMPC)
		{
		}

		public void JCELMIPMEGN(PointerEventData KFOIKMGPCHF)
		{
		}

		public void KAJNNAKDCEH()
		{
		}

		private void MOGIEDONELO()
		{
		}

		[SpecialName]
		public void PMFDHKNILEM(float JEHONDDIMPC)
		{
		}

		public void FPKABHALKGH()
		{
		}

		public void JPAMIOFMKHO()
		{
		}

		public void CIMDAKMPJCO()
		{
		}

		[SpecialName]
		public float EIKAIOKOGBE()
		{
			return 0f;
		}

		[SpecialName]
		public void DNJDLFLPJLJ(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void BJFBIDCDIBB(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float KHAEPGMFCDH()
		{
			return 0f;
		}

		[SpecialName]
		public float HFKMPEPKGJG()
		{
			return 0f;
		}

		[SpecialName]
		public void BLBKMKPEKHK(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float PPFFLDGHECD()
		{
			return 0f;
		}

		public void JONAOPIAEIJ()
		{
		}

		[SpecialName]
		public void JGHPCOOPCBA(float JEHONDDIMPC)
		{
		}

		public void OnPointerUp(PointerEventData KFOIKMGPCHF)
		{
		}

		public void JEEHCKDLAED()
		{
		}

		private void JHCCLOLEOMK()
		{
		}

		[SpecialName]
		public float CAIGHDDLLBL()
		{
			return 0f;
		}

		[SpecialName]
		public void DKDMGJNNOLB(float JEHONDDIMPC)
		{
		}

		private void JDJIBFFIEDE(PointerEventData KFOIKMGPCHF, bool MAAGAJPDINN)
		{
		}

		public void PHHDFHGGBDK()
		{
		}

		public void LDOOCLGLADB(PointerEventData KFOIKMGPCHF)
		{
		}

		public void KHMGGJFAKDM()
		{
		}

		public void LNMHAKLKNAH()
		{
		}

		public void PCBEHOLPHON()
		{
		}

		public void UpdateUI()
		{
		}

		[SpecialName]
		public void LEPDCIIKNJM(float JEHONDDIMPC)
		{
		}

		private bool AOFNJNGDBGP()
		{
			return false;
		}

		private void Start()
		{
		}

		[SpecialName]
		public void OGCJJGLDLMJ(float JEHONDDIMPC)
		{
		}

		public void LoadState()
		{
		}

		public void PPHNFDOKFPN()
		{
		}

		[SpecialName]
		public float HCEAGKMDILM()
		{
			return 0f;
		}

		private void KEHHLCGNHLN(PointerEventData KFOIKMGPCHF, bool MAAGAJPDINN)
		{
		}

		[SpecialName]
		public float AKCCPMLJFIA()
		{
			return 0f;
		}

		private bool HCCAGADMDEA()
		{
			return false;
		}

		public void KDMKNINBIED(PointerEventData KFOIKMGPCHF)
		{
		}

		private void HMKEAPODGFL()
		{
		}

		[SpecialName]
		public float KLBDLPLEIKI()
		{
			return 0f;
		}

		public void OIACCJIECAP(PointerEventData KFOIKMGPCHF)
		{
		}

		private void IBLOABJPLEB()
		{
		}

		public void BHLMIEPNOEN(PointerEventData KFOIKMGPCHF)
		{
		}

		[SpecialName]
		public void OCIJNEACDDC(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float IHMOGDKDFFH()
		{
			return 0f;
		}

		public void OnDrag(PointerEventData KFOIKMGPCHF)
		{
		}

		public void BAKBBKIHIIA(PointerEventData KFOIKMGPCHF)
		{
		}

		[SpecialName]
		public float NMFBAMMDNMD()
		{
			return 0f;
		}

		[SpecialName]
		public float IPGFPDDOIBJ()
		{
			return 0f;
		}

		private bool ECOPFPDLOLJ()
		{
			return false;
		}

		private void ADLBOGNDDAJ()
		{
		}

		public void SaveState()
		{
		}

		private void Awake()
		{
		}

		[SpecialName]
		public void HFFJOEMIOGG(float JEHONDDIMPC)
		{
		}

		public void JFKNAKCBNHD(PointerEventData KFOIKMGPCHF)
		{
		}

		public void AKNJPHKCGFD()
		{
		}

		private bool JJOLFBIDBDJ()
		{
			return false;
		}

		public void FHKFCFJJDFM(PointerEventData KFOIKMGPCHF)
		{
		}

		[SpecialName]
		public float PDEDNJLMFAL()
		{
			return 0f;
		}

		public void ENOOOCIABME(PointerEventData KFOIKMGPCHF)
		{
		}

		private void JEDKMMEHKOF(PointerEventData KFOIKMGPCHF, bool MAAGAJPDINN)
		{
		}

		[SpecialName]
		public float LFMFGBMFDME()
		{
			return 0f;
		}

		[SpecialName]
		public void AEPFDCCCLMH(float JEHONDDIMPC)
		{
		}

		public void FKPIMNBAIDM(PointerEventData KFOIKMGPCHF)
		{
		}

		public void HBHGPHCHOLF()
		{
		}

		[SpecialName]
		public float JBLLGFLFOAE()
		{
			return 0f;
		}

		[SpecialName]
		public float EACFFPEANHK()
		{
			return 0f;
		}

		public void AIPPGHLEGEF()
		{
		}

		[SpecialName]
		public float KHKLLFHBEOM()
		{
			return 0f;
		}

		public void DCPEECFPDKJ()
		{
		}

		public void LIKHKNOAAAH()
		{
		}

		public void DEDIGOKBCOL(PointerEventData KFOIKMGPCHF)
		{
		}

		public void DFOKEIHBCMA()
		{
		}

		private void JCAOMFBDDOB()
		{
		}

		public void MMGIJJDKBIH(PointerEventData KFOIKMGPCHF)
		{
		}
	}
}
