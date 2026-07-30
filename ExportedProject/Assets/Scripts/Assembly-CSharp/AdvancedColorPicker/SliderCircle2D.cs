using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace AdvancedColorPicker
{
	[RequireComponent(typeof(RectTransform))]
	public class SliderCircle2D : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
	{
		[Serializable]
		public class SliderCircleEvent : UnityEvent<float, float>
		{
		}

		[SerializeField]
		private RectTransform m_HandleRect;

		[Range(0f, 360f)]
		[SerializeField]
		protected float m_Angle;

		[Range(0f, 1f)]
		[SerializeField]
		protected float m_Distance;

		[SerializeField]
		private int m_Corners;

		[SerializeField]
		private bool m_InverseAngle;

		[SerializeField]
		private SliderCircleEvent m_OnValueChanged;

		private Transform APCKKBGELEM;

		private RectTransform FAKNMLAMKJI;

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

		public virtual float angle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float normalizedAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual float distance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int Corners
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool InverseAngle
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public SliderCircleEvent onValueChanged
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

		public virtual void CMELKJBDPGA()
		{
		}

		private void AEEJEBLEKPD(float CGOPKGNIBEO)
		{
		}

		private void EDHMAOAABJM(float CGOPKGNIBEO)
		{
		}

		private void OBBIHEANKAF(float CGOPKGNIBEO)
		{
		}

		protected virtual void HAIADDNJABO(float CGOPKGNIBEO, bool JNEMILHNJOP)
		{
		}

		private Vector2 KMOKBBCEPBN()
		{
			return default(Vector2);
		}

		private void FPHFKJELOEB()
		{
		}

		[SpecialName]
		public void BEKKOHOMBLL(RectTransform JEHONDDIMPC)
		{
		}

		public virtual void OOLNIJAEDBP(PointerEventData KFOIKMGPCHF)
		{
		}

		[SpecialName]
		public float CBJDAOPAOAL()
		{
			return 0f;
		}

		[SpecialName]
		public virtual void EACCNCKHAKG(float JEHONDDIMPC)
		{
		}

		private void IHIPJIEABPM()
		{
		}

		private void GOOBNGFODHP(float CGOPKGNIBEO)
		{
		}

		[SpecialName]
		public void JCCCKJCACMA(SliderCircleEvent JEHONDDIMPC)
		{
		}

		[SpecialName]
		public virtual float KJOIPICOPML()
		{
			return 0f;
		}

		protected virtual void JFLHIMBGHCG(float CGOPKGNIBEO, bool JNEMILHNJOP)
		{
		}

		[SpecialName]
		public virtual float FODCIIMBPAP()
		{
			return 0f;
		}

		[SpecialName]
		public int IMOLBLKDLLF()
		{
			return 0;
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}

		public virtual void GIOMOJLOKGB()
		{
		}

		private bool NJBPDDGEBKF(PointerEventData KFOIKMGPCHF)
		{
			return false;
		}

		[SpecialName]
		public virtual float OJEINBFLCNC()
		{
			return 0f;
		}

		private Vector2 EHGOFGDCHDK()
		{
			return default(Vector2);
		}

		[SpecialName]
		private Transform OFAKGMOOPDD()
		{
			return null;
		}

		public virtual void POIANDKNBLA()
		{
		}

		[SpecialName]
		private Transform HMPJFCIJLAP()
		{
			return null;
		}

		[SpecialName]
		public virtual void PDEPKPGEEHM(float JEHONDDIMPC)
		{
		}

		private float FDOKOLIAFHH(float GHJDPOPELNL)
		{
			return 0f;
		}

		[SpecialName]
		public virtual void HJBBNLIDHJM(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void MOCLCCECEGC(SliderCircleEvent JEHONDDIMPC)
		{
		}

		[SpecialName]
		public int CPMALGDMNPC()
		{
			return 0;
		}

		[SpecialName]
		public float ICJOGPBAGFK()
		{
			return 0f;
		}

		[SpecialName]
		public virtual float HNEHGOMJLBG()
		{
			return 0f;
		}

		[SpecialName]
		public SliderCircleEvent LCLACILMLKA()
		{
			return null;
		}

		public virtual void KJMOAGPINCH(CanvasUpdate DGBCAPLEGPB)
		{
		}

		protected virtual void NGCGDAFFLMA(float CGOPKGNIBEO, bool JNEMILHNJOP)
		{
		}

		private void DAKPEPLDLCL(float CGOPKGNIBEO)
		{
		}

		[SpecialName]
		public virtual float PACOJBLFJGJ()
		{
			return 0f;
		}

		[SpecialName]
		public virtual void ADPKKAIFPCA(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void OHBOPCDPPDL(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public virtual void OMDHHPCIIFK(float JEHONDDIMPC)
		{
		}

		private void HDLHOFEMEHN()
		{
		}

		public virtual void IIPKMBHAJLI(CanvasUpdate DGBCAPLEGPB)
		{
		}

		[SpecialName]
		public virtual float ONIGKBEGFGO()
		{
			return 0f;
		}

		[SpecialName]
		public void KGFANCPEHNB(int JEHONDDIMPC)
		{
		}

		protected virtual void EOICAHGNBJM(float CGOPKGNIBEO, bool JNEMILHNJOP)
		{
		}

		private void PHDGOBDFOPO(float CGOPKGNIBEO)
		{
		}

		public virtual void FOLDAMHJION(PointerEventData KFOIKMGPCHF)
		{
		}

		protected virtual void EHGAKLFOKAJ(PointerEventData KFOIKMGPCHF, Camera EGDMDNAPHPI)
		{
		}

		private Vector2 OLIPHKAJBDL()
		{
			return default(Vector2);
		}

		protected override void OnEnable()
		{
		}

		[SpecialName]
		public virtual float AFJMBIICIHJ()
		{
			return 0f;
		}

		private void GHNGEMPEJOD(float CGOPKGNIBEO)
		{
		}

		private bool CHGMAEDBMOI(PointerEventData KFOIKMGPCHF)
		{
			return false;
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		private void HNKBGNEFDII(float CGOPKGNIBEO)
		{
		}

		private void HBDHAMIGFFG()
		{
		}

		[SpecialName]
		public SliderCircleEvent HHDPGDIKOGG()
		{
			return null;
		}

		[SpecialName]
		public SliderCircleEvent IMMOHJNLJAP()
		{
			return null;
		}

		private bool GNEAIJNPGIM(PointerEventData KFOIKMGPCHF)
		{
			return false;
		}

		public virtual void HDIAJDKCKOK(CanvasUpdate DGBCAPLEGPB)
		{
		}

		private void CDKNJFHCLIL(float CGOPKGNIBEO)
		{
		}

		private float EEDDLCAENNG(float GHJDPOPELNL)
		{
			return 0f;
		}

		[SpecialName]
		public void COGOJNDBINI(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void FCNPPIHDKMM(bool JEHONDDIMPC)
		{
		}

		private bool GPPJJIBFGBN(PointerEventData KFOIKMGPCHF)
		{
			return false;
		}

		private Vector2 KBLPEAEMHLC()
		{
			return default(Vector2);
		}

		[SpecialName]
		public bool JPBCKFIBIMI()
		{
			return false;
		}

		private void BHEBIBANOCF(float CGOPKGNIBEO)
		{
		}

		[SpecialName]
		public virtual float PJPFGBADLHA()
		{
			return 0f;
		}

		protected SliderCircle2D()
		{
		}

		public virtual void FAGJCCIADNM(PointerEventData KFOIKMGPCHF)
		{
		}

		public virtual void Rebuild(CanvasUpdate DGBCAPLEGPB)
		{
		}

		[SpecialName]
		public RectTransform EEIBEHLPFNA()
		{
			return null;
		}

		[SpecialName]
		public SliderCircleEvent DJIFPCMDCBJ()
		{
			return null;
		}

		protected virtual void FIDGEDGBGMF(float CGOPKGNIBEO, bool JNEMILHNJOP)
		{
		}

		public virtual void OnDrag(PointerEventData KFOIKMGPCHF)
		{
		}

		public virtual void NIPNHNBFILO()
		{
		}

		private bool IJOFDCFIJNP(PointerEventData KFOIKMGPCHF)
		{
			return false;
		}

		public virtual void FJAMAAIBMPF(PointerEventData KFOIKMGPCHF)
		{
		}

		private void DIHONOHBOKO(float CGOPKGNIBEO)
		{
		}

		public virtual void LOGKMPFGGBB()
		{
		}

		[SpecialName]
		public bool LHLCBLMJDAA()
		{
			return false;
		}

		[SpecialName]
		public RectTransform PNAGNKIHPBL()
		{
			return null;
		}

		private float FFDFFOIKPGG(float GHJDPOPELNL)
		{
			return 0f;
		}

		private Vector2 HBDCGMBBHLO()
		{
			return default(Vector2);
		}

		[SpecialName]
		public SliderCircleEvent AMDOPGGJOKF()
		{
			return null;
		}

		[SpecialName]
		public int HPFNDHBHNHI()
		{
			return 0;
		}

		[SpecialName]
		public void CIIEGNFBLCM(int JEHONDDIMPC)
		{
		}

		protected virtual void CPILFOJJPPG(float CGOPKGNIBEO, bool JNEMILHNJOP)
		{
		}

		public virtual void OnInitializePotentialDrag(PointerEventData KFOIKMGPCHF)
		{
		}

		private Vector2 OGIFFBICMBM()
		{
			return default(Vector2);
		}

		protected override void OnDisable()
		{
		}

		[SpecialName]
		public virtual float JJPIJJABIAA()
		{
			return 0f;
		}

		private void CENIJJFCBLE()
		{
		}

		private void LLMDDGMHJIE(float CGOPKGNIBEO)
		{
		}

		private Vector2 FDNGDHEPAPP()
		{
			return default(Vector2);
		}

		public override void OnPointerDown(PointerEventData KFOIKMGPCHF)
		{
		}

		private void NGCGDAFFLMA(float CGOPKGNIBEO)
		{
		}

		protected virtual void MCLEAAEINBG(PointerEventData KFOIKMGPCHF, Camera EGDMDNAPHPI)
		{
		}

		public virtual void OCJGKKNDFOP(CanvasUpdate DGBCAPLEGPB)
		{
		}

		private void HOLKNNLHCAM(float CGOPKGNIBEO)
		{
		}

		public virtual void GraphicUpdateComplete()
		{
		}

		private Vector2 MENALNGJKFE()
		{
			return default(Vector2);
		}

		[SpecialName]
		public float GPIMKGLBBJL()
		{
			return 0f;
		}

		private void CPILFOJJPPG(float CGOPKGNIBEO)
		{
		}

		[SpecialName]
		public float LECKIOLDDAF()
		{
			return 0f;
		}

		[SpecialName]
		public virtual void AFLJNAOPKDI(float JEHONDDIMPC)
		{
		}

		public virtual void BFKDLGFNHIN(PointerEventData KFOIKMGPCHF)
		{
		}

		[SpecialName]
		public virtual float DAMKODFCIKO()
		{
			return 0f;
		}

		[SpecialName]
		public bool CJAKMNGNFMP()
		{
			return false;
		}

		[SpecialName]
		public void ODPINLEELOC(int JEHONDDIMPC)
		{
		}

		protected virtual void HCOKDLNLOCH(PointerEventData KFOIKMGPCHF, Camera EGDMDNAPHPI)
		{
		}

		private Vector2 JDJLLKIGOCJ()
		{
			return default(Vector2);
		}

		protected virtual void PNPHEFDIJEF(float CGOPKGNIBEO, bool JNEMILHNJOP)
		{
		}

		private void DOKIAJHGJIM()
		{
		}

		public virtual void OPPEEFNHMHF()
		{
		}

		[SpecialName]
		public void CAPBDAPIDDB(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public virtual float MFFJKDLJDEK()
		{
			return 0f;
		}

		[SpecialName]
		public float FMHEOGNAKID()
		{
			return 0f;
		}

		public override void OnPointerUp(PointerEventData KFOIKMGPCHF)
		{
		}

		public virtual void LayoutComplete()
		{
		}

		[SpecialName]
		public void ILIIDEMLOLB(RectTransform JEHONDDIMPC)
		{
		}

		private Vector2 GIBMKACCNKP()
		{
			return default(Vector2);
		}

		[SpecialName]
		public bool ONNANKIAFNF()
		{
			return false;
		}

		[SpecialName]
		public void PEGMMBNPIMJ(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public virtual void JAIHFDCJJFA(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void OLKBLFIDIOC(int JEHONDDIMPC)
		{
		}

		public virtual void MEEJHJIANDC()
		{
		}

		[SpecialName]
		public virtual void JKDLECPLAOK(float JEHONDDIMPC)
		{
		}

		private void NPCGBFANNCH()
		{
		}

		private Vector2 MNBIKAKHCKJ()
		{
			return default(Vector2);
		}

		private Vector2 DEJBGDCCBPH()
		{
			return default(Vector2);
		}

		private void BFBCBECJPID()
		{
		}

		public virtual void CKIANIBOFOL()
		{
		}

		private void DDBNPALCNEO()
		{
		}

		protected virtual void APBLBMDJNAA(PointerEventData KFOIKMGPCHF, Camera EGDMDNAPHPI)
		{
		}

		public override void OnMove(AxisEventData KFOIKMGPCHF)
		{
		}

		private Vector2 FDOCDCLAOFN()
		{
			return default(Vector2);
		}

		[SpecialName]
		public void MGDJAIDAMIE(int JEHONDDIMPC)
		{
		}

		[SpecialName]
		public bool MMFDGFBEGNF()
		{
			return false;
		}

		private Vector2 IBFGAMMEBNO()
		{
			return default(Vector2);
		}

		[SpecialName]
		public virtual float HFLJFNLLLLP()
		{
			return 0f;
		}

		private void DDCEEJGMECG(float CGOPKGNIBEO)
		{
		}

		public virtual void NCBBLDPNONC(CanvasUpdate DGBCAPLEGPB)
		{
		}

		[SpecialName]
		public bool OLNEPHPENFL()
		{
			return false;
		}

		[SpecialName]
		public void IAHAMALMMND(int JEHONDDIMPC)
		{
		}

		public virtual void IFJFGCENCEH()
		{
		}

		private Vector2 POKAIKLFMCP()
		{
			return default(Vector2);
		}

		private Vector2 EOJLCBFNDJB()
		{
			return default(Vector2);
		}

		private Vector2 GBDFFBDMPFD()
		{
			return default(Vector2);
		}

		protected virtual void ALGJEILPKNG(float CGOPKGNIBEO, bool JNEMILHNJOP)
		{
		}

		[SpecialName]
		public int LIDBPDMKEGB()
		{
			return 0;
		}

		[SpecialName]
		public float MGFGINCMNGK()
		{
			return 0f;
		}

		public virtual void IJJDIPAMPJF(CanvasUpdate DGBCAPLEGPB)
		{
		}

		public virtual void BILNPHJHEEM()
		{
		}

		[SpecialName]
		public void HKJMOCHHPBL(RectTransform JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void BMNFAIBBEMK(RectTransform JEHONDDIMPC)
		{
		}

		[SpecialName]
		public virtual void HKKCCJANFOM(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public virtual void MEALIIHKJOA(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void HGOFJBNAIBD(float JEHONDDIMPC)
		{
		}

		private void IEOBLDCHHEK(float CGOPKGNIBEO)
		{
		}

		[SpecialName]
		public void DDPLDOKFJHK(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void GFOIFOIBLCD(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void AKCLOMFDLNI(bool JEHONDDIMPC)
		{
		}

		protected virtual void LNLCKCGGBOI(float CGOPKGNIBEO, bool JNEMILHNJOP)
		{
		}

		[SpecialName]
		public void ODCGCCKKAHI(int JEHONDDIMPC)
		{
		}

		public virtual void LCNIJNDNJEL()
		{
		}

		[SpecialName]
		public float EHHFFKAONLF()
		{
			return 0f;
		}
	}
}
