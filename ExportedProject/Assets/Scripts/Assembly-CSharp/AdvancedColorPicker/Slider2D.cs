using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace AdvancedColorPicker
{
	[RequireComponent(typeof(RectTransform))]
	public class Slider2D : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
	{
		[Serializable]
		public class Slider2DEvent : UnityEvent<float, float>
		{
		}

		[SerializeField]
		private RectTransform m_HandleRect;

		[SerializeField]
		private Vector2 m_MinValue;

		[SerializeField]
		private Vector2 m_MaxValue;

		[SerializeField]
		private bool m_WholeNumbers;

		[SerializeField]
		protected float m_ValueX;

		[SerializeField]
		protected float m_ValueY;

		[SerializeField]
		protected bool inverseX;

		[SerializeField]
		protected bool inverseY;

		[SerializeField]
		private Slider2DEvent m_OnValueChanged;

		private Transform APCKKBGELEM;

		protected RectTransform FAKNMLAMKJI;

		private Vector2 NLFPGCGFPND;

		private DrivenRectTransformTracker GCPGNPCMGNP;

		public RectTransform handleRect
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2 minValue
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 maxValue
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public bool wholeNumbers
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual float valueX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float normalizedValueX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float valueY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float normalizedValueY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool InverseX
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool InverseY
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Slider2DEvent onValueChanged
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		Transform ICanvasElement.transform => null;

		private float PENPCGNBCAG(int CJKBJFLAHJN)
		{
			return 0f;
		}

		public override void OnPointerUp(PointerEventData KFOIKMGPCHF)
		{
		}

		public virtual void NNNKCMJNMLN(PointerEventData KFOIKMGPCHF)
		{
		}

		[SpecialName]
		public bool AELGAABPENF()
		{
			return false;
		}

		[SpecialName]
		public bool GINLMCFGPMB()
		{
			return false;
		}

		[SpecialName]
		public float NDIAIDHNKBP()
		{
			return 0f;
		}

		private void INNCPELCMNL(float CGOPKGNIBEO)
		{
		}

		[SpecialName]
		public Vector2 ILDKIAPGNKP()
		{
			return default(Vector2);
		}

		public virtual void JFOEJHOBAIE(CanvasUpdate DGBCAPLEGPB)
		{
		}

		private bool OEMCMAFPFBO(PointerEventData KFOIKMGPCHF)
		{
			return false;
		}

		private void IHIPJIEABPM()
		{
		}

		public override void OnMove(AxisEventData KFOIKMGPCHF)
		{
		}

		[SpecialName]
		public void ONGCHAGNGLJ(bool JEHONDDIMPC)
		{
		}

		protected virtual void MPJGLMFPAHA(float CGOPKGNIBEO, bool JNEMILHNJOP)
		{
		}

		[SpecialName]
		public void LCKAPANGCBM(bool JEHONDDIMPC)
		{
		}

		public virtual void LayoutComplete()
		{
		}

		protected Slider2D()
		{
		}

		[SpecialName]
		public bool JEIMPGJPEPG()
		{
			return false;
		}

		public virtual void KJMOAGPINCH(CanvasUpdate DGBCAPLEGPB)
		{
		}

		[SpecialName]
		public void IKLFOGOMBHB(Vector2 JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void GCGCGBOKAAD(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float JMFLNGBDIBK()
		{
			return 0f;
		}

		[SpecialName]
		private Transform DJCJKBBKNAE()
		{
			return null;
		}

		protected override void OnDisable()
		{
		}

		private void LEDEIAEICPA(float CGOPKGNIBEO)
		{
		}

		[SpecialName]
		public bool HDELEEPIDFC()
		{
			return false;
		}

		protected virtual void APBLBMDJNAA(PointerEventData KFOIKMGPCHF, Camera EGDMDNAPHPI)
		{
		}

		[SpecialName]
		public void BIPDLABACOK(float JEHONDDIMPC)
		{
		}

		public virtual void MAJOEMDGMJM(CanvasUpdate DGBCAPLEGPB)
		{
		}

		[SpecialName]
		public RectTransform NJDBLHMMGJM()
		{
			return null;
		}

		protected virtual void EOBOCJLCOBP(float CGOPKGNIBEO, bool JNEMILHNJOP)
		{
		}

		[SpecialName]
		public bool DBNCBBNBNIP()
		{
			return false;
		}

		[SpecialName]
		public void OKKOENLCIBI(bool JEHONDDIMPC)
		{
		}

		private float CDPJAABMABO(int CJKBJFLAHJN)
		{
			return 0f;
		}

		protected virtual void IBNEPLNBBPM(PointerEventData KFOIKMGPCHF, Camera EGDMDNAPHPI)
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		private void CAPOLODCANM(float CGOPKGNIBEO)
		{
		}

		[SpecialName]
		public float PFBJHBKPIKG()
		{
			return 0f;
		}

		public virtual void OnInitializePotentialDrag(PointerEventData KFOIKMGPCHF)
		{
		}

		[SpecialName]
		public void DIEOFENFBEF(bool JEHONDDIMPC)
		{
		}

		protected float PMCLOPEPNAO(float CGOPKGNIBEO, int CJKBJFLAHJN)
		{
			return 0f;
		}

		private float JCMECIEHJKK(int CJKBJFLAHJN)
		{
			return 0f;
		}

		private void AAEJBLOHFME()
		{
		}

		private bool IIINLFBLPEJ(PointerEventData KFOIKMGPCHF)
		{
			return false;
		}

		public virtual void GraphicUpdateComplete()
		{
		}

		[SpecialName]
		public float OPCNEMAAJKP()
		{
			return 0f;
		}

		[SpecialName]
		public Slider2DEvent KOJCCIOKEJK()
		{
			return null;
		}

		private void KHOCBFDJHDB(float CGOPKGNIBEO)
		{
		}

		[SpecialName]
		public void KDKNDONPHKO(bool JEHONDDIMPC)
		{
		}

		protected float NBCPPJNNAKF(float CGOPKGNIBEO, int CJKBJFLAHJN)
		{
			return 0f;
		}

		[SpecialName]
		public void KCHOEAMGMBK(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void ALMJGJEFFNP(float JEHONDDIMPC)
		{
		}

		public virtual void ONFENEAADCD(PointerEventData KFOIKMGPCHF)
		{
		}

		private void JPKLGOJMPCN()
		{
		}

		[SpecialName]
		public void PEBALLEMEBH(Vector2 JEHONDDIMPC)
		{
		}

		[SpecialName]
		private Transform IJAHFODGNFN()
		{
			return null;
		}

		private void BGMHABILEBO()
		{
		}

		[SpecialName]
		public bool GGNJHGJHFCG()
		{
			return false;
		}

		[SpecialName]
		public void GMPPMHMPCCN(bool JEHONDDIMPC)
		{
		}

		protected virtual void FHHGHNCFFCD(PointerEventData KFOIKMGPCHF, Camera EGDMDNAPHPI)
		{
		}

		public virtual void Rebuild(CanvasUpdate DGBCAPLEGPB)
		{
		}

		private bool BGLCGIMKFJJ(PointerEventData KFOIKMGPCHF)
		{
			return false;
		}

		[SpecialName]
		public void LGPADHLNOLP(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float KFDAGKLLHJC()
		{
			return 0f;
		}

		public virtual void PKBPHBPALLD()
		{
		}

		[SpecialName]
		public bool FCNGPGHCOCK()
		{
			return false;
		}

		protected float DENCPMDEDCM(float CGOPKGNIBEO, int CJKBJFLAHJN)
		{
			return 0f;
		}

		[SpecialName]
		public Vector2 AEJBJKGKAKJ()
		{
			return default(Vector2);
		}

		[SpecialName]
		public virtual float PKANAHJEOJO()
		{
			return 0f;
		}

		[SpecialName]
		public void CPJBIOEPCAJ(float JEHONDDIMPC)
		{
		}

		protected virtual void IDOPFJMEEOL(float CGOPKGNIBEO, bool JNEMILHNJOP)
		{
		}

		[SpecialName]
		public void MBILGANMLEO(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void EFMJNHOLOKL(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void CFLHKOHGENP(bool JEHONDDIMPC)
		{
		}

		private void ELEOGPGMNEF(float CGOPKGNIBEO)
		{
		}

		protected float FICMDPODMPH(float CGOPKGNIBEO, int CJKBJFLAHJN)
		{
			return 0f;
		}

		[SpecialName]
		public void EIDKAJFIHOK(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public Vector2 NMDALOHJJOJ()
		{
			return default(Vector2);
		}

		public virtual void EBFMCLOKGIJ(CanvasUpdate DGBCAPLEGPB)
		{
		}

		[SpecialName]
		public Vector2 ENAGBICGLNI()
		{
			return default(Vector2);
		}

		[SpecialName]
		public void DPCJFBKHIHL(Vector2 JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void BMGLLMBHCIN(float JEHONDDIMPC)
		{
		}

		public virtual void HDLHAOPCBDO()
		{
		}

		private bool IFBLLOFPBHC(PointerEventData KFOIKMGPCHF)
		{
			return false;
		}

		protected virtual void ALEMOJMOHKC(PointerEventData KFOIKMGPCHF, Camera EGDMDNAPHPI)
		{
		}

		[SpecialName]
		public void DEHKAGAHOAH(Vector2 JEHONDDIMPC)
		{
		}

		public virtual void GGNFELAABAB(CanvasUpdate DGBCAPLEGPB)
		{
		}

		protected virtual void ANLEAMBFBIG(PointerEventData KFOIKMGPCHF, Camera EGDMDNAPHPI)
		{
		}

		private void PMGNLLBFBCD()
		{
		}

		protected virtual void DOGKJEEGECM(float CGOPKGNIBEO, bool JNEMILHNJOP)
		{
		}

		[SpecialName]
		public Vector2 JJKCPHFHFEH()
		{
			return default(Vector2);
		}

		private void MOONEEJJPAO()
		{
		}

		protected virtual void CAPOLODCANM(float CGOPKGNIBEO, bool JNEMILHNJOP)
		{
		}

		[SpecialName]
		public void KEHGHLPOCDA(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void BKFEKAOKLEA(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public bool MLJLPOBHOHG()
		{
			return false;
		}

		[SpecialName]
		public void GJIDJPPCFIH(Slider2DEvent JEHONDDIMPC)
		{
		}

		private void AADGKKJOKAO(float CGOPKGNIBEO)
		{
		}

		[SpecialName]
		public Slider2DEvent KPDEBDACDDA()
		{
			return null;
		}

		[SpecialName]
		public float CFLHAKGMLKG()
		{
			return 0f;
		}

		[SpecialName]
		public void IPGCDJKFNEP(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public virtual void OLPJJFGLKDA(float JEHONDDIMPC)
		{
		}

		private bool KMGKIMKPFDF(PointerEventData KFOIKMGPCHF)
		{
			return false;
		}

		[SpecialName]
		public void JFPADNJCADP(bool JEHONDDIMPC)
		{
		}

		private void BFBCBECJPID()
		{
		}

		[SpecialName]
		public bool GMFLKGLADEF()
		{
			return false;
		}

		[SpecialName]
		public virtual void GEIENJKKMAL(float JEHONDDIMPC)
		{
		}

		private bool GPPJJIBFGBN(PointerEventData KFOIKMGPCHF)
		{
			return false;
		}

		protected override void OnEnable()
		{
		}

		[SpecialName]
		public void CMPGNAHNBOJ(Vector2 JEHONDDIMPC)
		{
		}

		public override void OnPointerDown(PointerEventData KFOIKMGPCHF)
		{
		}

		[SpecialName]
		private Transform KOCNDMIDKFH()
		{
			return null;
		}

		public virtual void MJGBNMLIDFN(PointerEventData KFOIKMGPCHF)
		{
		}

		protected virtual void HJCCADJBJEC(float CGOPKGNIBEO, bool JNEMILHNJOP)
		{
		}

		private void LLLOJNMNIJB(float CGOPKGNIBEO)
		{
		}

		private void GEJPIOMOMKL(float CGOPKGNIBEO)
		{
		}

		[SpecialName]
		public RectTransform APDNDEHPJNH()
		{
			return null;
		}

		[SpecialName]
		public bool NEDHLDJPGLF()
		{
			return false;
		}

		[SpecialName]
		public Slider2DEvent ALHEFEPJPOI()
		{
			return null;
		}

		public virtual void ENBJCDOEGDA()
		{
		}

		[SpecialName]
		public void GJDLOIANBLL(bool JEHONDDIMPC)
		{
		}

		protected virtual void MJHFKNBLAHN(float CGOPKGNIBEO, bool JNEMILHNJOP)
		{
		}

		public virtual void OnDrag(PointerEventData KFOIKMGPCHF)
		{
		}

		[SpecialName]
		public void GAPGBMHLBDD(float JEHONDDIMPC)
		{
		}

		private void DOGKJEEGECM(float CGOPKGNIBEO)
		{
		}

		[SpecialName]
		public void NFECDKJAPPJ(Vector2 JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float CIMPCCIJJCB()
		{
			return 0f;
		}

		public virtual void OKOGFIGABDJ(CanvasUpdate DGBCAPLEGPB)
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}

		[SpecialName]
		private Transform ILDNLECEFPB()
		{
			return null;
		}
	}
}
