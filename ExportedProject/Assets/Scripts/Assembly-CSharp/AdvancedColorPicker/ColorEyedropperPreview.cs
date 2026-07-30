using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace AdvancedColorPicker
{
	[RequireComponent(typeof(CanvasRenderer))]
	public class ColorEyedropperPreview : MaskableGraphic
	{
		public enum KMJDFKFJCPM
		{
			PixelSize = 0,
			PixelAmountHorizontal = 1,
			PixelAmountVertical = 2
		}

		private sealed class CPAHPJCOBIM : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ColorEyedropperPreview _003C_003E4__this;

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
			public CPAHPJCOBIM(int _003C_003E1__state)
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

		[SerializeField]
		private KMJDFKFJCPM type;

		[SerializeField]
		private float pixelSize;

		[SerializeField]
		private float borderSize;

		[SerializeField]
		private float horizontalPixels;

		[SerializeField]
		private float verticalPixels;

		[SerializeField]
		private Color32 selectionBoxColor;

		[SerializeField]
		private bool activated;

		private Coroutine DNBDMMHDHJM;

		private Color32[] HAKGBOEBOLD;

		private Color32 LCJKNODHJPL => default(Color32);

		public KMJDFKFJCPM Type
		{
			get
			{
				return default(KMJDFKFJCPM);
			}
			set
			{
			}
		}

		public float PixelSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float BorderSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float HorizontalPixels
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float VerticalPixels
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int ExpectedVertices => 0;

		public Color32 SelectionBoxColor
		{
			get
			{
				return default(Color32);
			}
			set
			{
			}
		}

		public bool Activated
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[SpecialName]
		public KMJDFKFJCPM PBKEOIIAOND()
		{
			return default(KMJDFKFJCPM);
		}

		private bool GIMKFFNKFEF(UIVertex[] POFNMEKIGDK, Vector3 DMOJMBGJPLI, Rect FOFMPDDHPLJ, float JNIBMEKOAJK)
		{
			return false;
		}

		[SpecialName]
		public float LCIKCBDCIDK()
		{
			return 0f;
		}

		[SpecialName]
		public void NGDJDHKCDLH(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public Color32 BEHFLEMDHML()
		{
			return default(Color32);
		}

		private void LBPCHMCEBIJ(UIVertex[] POFNMEKIGDK, Color32 OLJIIPPOIHN)
		{
		}

		[SpecialName]
		private Color32 CGMOBIJDPCL()
		{
			return default(Color32);
		}

		[SpecialName]
		public void IAMFEOKKGHE(Color32 JEHONDDIMPC)
		{
		}

		[SpecialName]
		public KMJDFKFJCPM OHKJBMNLOCN()
		{
			return default(KMJDFKFJCPM);
		}

		protected override void OnDisable()
		{
		}

		[SpecialName]
		public float PJBCLOKPDLI()
		{
			return 0f;
		}

		private IEnumerator GADAOAABOGA()
		{
			return null;
		}

		private IEnumerator MCOMMGHEOIE()
		{
			return null;
		}

		private bool ANFPAPJMBFA(UIVertex[] POFNMEKIGDK, Vector3 DMOJMBGJPLI, Rect FOFMPDDHPLJ)
		{
			return false;
		}

		[SpecialName]
		public float LOAPIJEEJFL()
		{
			return 0f;
		}

		private bool BEIJMDBLACI(UIVertex[] POFNMEKIGDK, Vector3 DMOJMBGJPLI, Rect FOFMPDDHPLJ, float JNIBMEKOAJK)
		{
			return false;
		}

		[SpecialName]
		public Color32 OIIAMAGCLLA()
		{
			return default(Color32);
		}

		[SpecialName]
		public void FABCNGHJJJE(float JEHONDDIMPC)
		{
		}

		private bool EFIPDOPFNFC(UIVertex[] POFNMEKIGDK, Vector3 DMOJMBGJPLI, Rect FOFMPDDHPLJ, float JNIBMEKOAJK)
		{
			return false;
		}

		protected override void OnEnable()
		{
		}

		[SpecialName]
		public float IAHFCKBHEDK()
		{
			return 0f;
		}

		private bool LLLBGBNOCLM(UIVertex[] POFNMEKIGDK, Vector3 DMOJMBGJPLI, Rect FOFMPDDHPLJ, float JNIBMEKOAJK)
		{
			return false;
		}

		private void PCCANMANCON(UIVertex[] POFNMEKIGDK, Color32 OLJIIPPOIHN)
		{
		}

		private bool IHANJNIBIPM(UIVertex[] POFNMEKIGDK, Vector3 DMOJMBGJPLI, Rect FOFMPDDHPLJ, float JNIBMEKOAJK)
		{
			return false;
		}

		[SpecialName]
		public float MJGJDFOPHNA()
		{
			return 0f;
		}

		[SpecialName]
		private Color32 GEOHGLJOLOK()
		{
			return default(Color32);
		}

		private bool EDAODFFFIOJ(UIVertex[] POFNMEKIGDK, Vector3 DMOJMBGJPLI, Rect FOFMPDDHPLJ)
		{
			return false;
		}

		[SpecialName]
		public float MNGKCNBLMFD()
		{
			return 0f;
		}

		private bool BEIJMDBLACI(UIVertex[] POFNMEKIGDK, Vector3 DMOJMBGJPLI, Rect FOFMPDDHPLJ)
		{
			return false;
		}

		private void JHDLAPHMGBI()
		{
		}

		private void GLMMLOIHKKP()
		{
		}

		[SpecialName]
		public int POFEMJPMMNJ()
		{
			return 0;
		}

		[SpecialName]
		public Color32 PNBBBHJGFJB()
		{
			return default(Color32);
		}

		[SpecialName]
		public bool IBHAEJKJOKL()
		{
			return false;
		}

		[SpecialName]
		public float LCNOPIAKGJO()
		{
			return 0f;
		}

		[SpecialName]
		public float JHLCIHDNJOL()
		{
			return 0f;
		}

		private void NMBLDFNBCJL(UIVertex[] POFNMEKIGDK, Color32 OLJIIPPOIHN)
		{
		}

		[SpecialName]
		public bool BDOPHCCEAMH()
		{
			return false;
		}

		[SpecialName]
		public void HMHHNKGFCIN(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void BAAFIHPLPGP(float JEHONDDIMPC)
		{
		}

		private bool PIOIGMCFPBH(UIVertex[] POFNMEKIGDK, Vector3 DMOJMBGJPLI, Rect FOFMPDDHPLJ, float JNIBMEKOAJK)
		{
			return false;
		}

		private void HOEAJKFEEKM()
		{
		}

		[SpecialName]
		private Color32 ELOODABLJOI()
		{
			return default(Color32);
		}

		[SpecialName]
		public int EIPPGDOJJCD()
		{
			return 0;
		}

		[SpecialName]
		public void LLKNMFMAGHD(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float ODGMKBPFCIN()
		{
			return 0f;
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		[SpecialName]
		public void FBFOEDIGOPA(KMJDFKFJCPM JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void BCMMJDCMIDG(float JEHONDDIMPC)
		{
		}

		private void BNGJGFMODPJ(UIVertex[] POFNMEKIGDK, Color32 OLJIIPPOIHN)
		{
		}

		private void IJFCHMLKOIG()
		{
		}

		[SpecialName]
		public float FBKOCGKCPAG()
		{
			return 0f;
		}

		[SpecialName]
		public void FHGMAMAPNJN(KMJDFKFJCPM JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void NEJJOMODADL(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void BMDCCPCOKEJ(KMJDFKFJCPM JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float KKBPLNKLKAH()
		{
			return 0f;
		}

		[SpecialName]
		public void OLFCCIBAIDB(Color32 JEHONDDIMPC)
		{
		}

		private bool JIEDLJMMEGH(UIVertex[] POFNMEKIGDK, Vector3 DMOJMBGJPLI, Rect FOFMPDDHPLJ, float JNIBMEKOAJK)
		{
			return false;
		}

		[SpecialName]
		private Color32 KGEEDDBBEOH()
		{
			return default(Color32);
		}

		[SpecialName]
		public KMJDFKFJCPM OKKIJDCCKKD()
		{
			return default(KMJDFKFJCPM);
		}

		[SpecialName]
		public void LKEGONDEOMP(bool JEHONDDIMPC)
		{
		}

		private bool GDHOGBCCBOI(UIVertex[] POFNMEKIGDK, Vector3 DMOJMBGJPLI, Rect FOFMPDDHPLJ, float JNIBMEKOAJK)
		{
			return false;
		}

		private void FNKNNPFAHEJ()
		{
		}

		private void IOADELMICNH()
		{
		}

		[SpecialName]
		public float FFJNOIJCMKD()
		{
			return 0f;
		}

		private bool GFEKFDIMIFJ(UIVertex[] POFNMEKIGDK, Vector3 DMOJMBGJPLI, Rect FOFMPDDHPLJ)
		{
			return false;
		}

		private bool HPOEIAJJJNF(UIVertex[] POFNMEKIGDK, Vector3 DMOJMBGJPLI, Rect FOFMPDDHPLJ, float JNIBMEKOAJK)
		{
			return false;
		}

		[SpecialName]
		public int MLFJCHIOCMG()
		{
			return 0;
		}

		private void CGJGMLEJMCH()
		{
		}

		[SpecialName]
		public bool CAKFGGJHEII()
		{
			return false;
		}

		[SpecialName]
		public Color32 DEAJHJADJAG()
		{
			return default(Color32);
		}

		[SpecialName]
		public bool HAIHFMHODIM()
		{
			return false;
		}

		[SpecialName]
		public void MJHOGPANKNI(KMJDFKFJCPM JEHONDDIMPC)
		{
		}

		protected override void OnPopulateMesh(VertexHelper BIKKMNGAKBK)
		{
		}

		[SpecialName]
		public void PCGOBCFKLCO(float JEHONDDIMPC)
		{
		}

		private IEnumerator NFCDLGPHDAN()
		{
			return null;
		}

		private bool CLMAAGAOGJF(UIVertex[] POFNMEKIGDK, Vector3 DMOJMBGJPLI, Rect FOFMPDDHPLJ)
		{
			return false;
		}

		private IEnumerator NFDEEOLLJFK()
		{
			return null;
		}

		[SpecialName]
		public bool BKAHCMJLKJE()
		{
			return false;
		}

		[SpecialName]
		public float ODFACCADLMM()
		{
			return 0f;
		}

		[SpecialName]
		public void EIONLIJJFDO(KMJDFKFJCPM JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float MECEBMPDILH()
		{
			return 0f;
		}

		[SpecialName]
		private Color32 FGLPKMMNHIN()
		{
			return default(Color32);
		}

		[SpecialName]
		public void NLEJOCFAAAP(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public bool NDMFHKLDKMB()
		{
			return false;
		}

		private void DILDNDMAGPC()
		{
		}

		private bool CNJGMPFNBPC(UIVertex[] POFNMEKIGDK, Vector3 DMOJMBGJPLI, Rect FOFMPDDHPLJ)
		{
			return false;
		}

		[SpecialName]
		public float KGFHNDNOOEH()
		{
			return 0f;
		}

		[SpecialName]
		private Color32 JABCDGHGOIL()
		{
			return default(Color32);
		}

		[SpecialName]
		public void PDKGEOMPGGK(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public Color32 IGKLINENFKD()
		{
			return default(Color32);
		}

		[SpecialName]
		public KMJDFKFJCPM FEHFPAKEIFA()
		{
			return default(KMJDFKFJCPM);
		}

		[SpecialName]
		public void KPAABPMIEGA(float JEHONDDIMPC)
		{
		}

		[IteratorStateMachine(typeof(CPAHPJCOBIM))]
		private IEnumerator JDPCGOCAFIK()
		{
			return null;
		}

		[SpecialName]
		public float HMLEHBCANEG()
		{
			return 0f;
		}

		[SpecialName]
		public KMJDFKFJCPM AMKFLIBNDPM()
		{
			return default(KMJDFKFJCPM);
		}

		[SpecialName]
		public bool OHACABFEMLG()
		{
			return false;
		}

		[SpecialName]
		private Color32 EPOHFJFOGKG()
		{
			return default(Color32);
		}

		[SpecialName]
		public int OJECNIAMKEI()
		{
			return 0;
		}

		private void GDCBNLLPDOA(UIVertex[] POFNMEKIGDK, Color32 OLJIIPPOIHN)
		{
		}

		[SpecialName]
		public float IDFMJKMDFCJ()
		{
			return 0f;
		}

		private IEnumerator EHCMCMCAHMH()
		{
			return null;
		}

		[SpecialName]
		public Color32 MKOLKODHJNF()
		{
			return default(Color32);
		}

		private void HGMNLDBBHNN(UIVertex[] POFNMEKIGDK, Color32 OLJIIPPOIHN)
		{
		}

		private IEnumerator EIKEBLKOIHL()
		{
			return null;
		}

		private void GEHCLDJPJCN(UIVertex[] POFNMEKIGDK, Color32 OLJIIPPOIHN)
		{
		}

		[SpecialName]
		public void AJOLPDBHFAK(KMJDFKFJCPM JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void OGBJPHFGDBE(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void ONAHJCEAACP(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public KMJDFKFJCPM GNBNCFNOOBL()
		{
			return default(KMJDFKFJCPM);
		}

		[SpecialName]
		public void OHPDOGMLIBN(float JEHONDDIMPC)
		{
		}

		private void FMCNKJLIJFI(UIVertex[] POFNMEKIGDK, Color32 OLJIIPPOIHN)
		{
		}

		[SpecialName]
		public void PBOAJLFOLDO(float JEHONDDIMPC)
		{
		}

		private void BECDJFLLABH()
		{
		}

		[SpecialName]
		public void GOOGNAJEIFD(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public int AIOADEAGFAA()
		{
			return 0;
		}

		[SpecialName]
		public void NPDCAOEEDIC(KMJDFKFJCPM JEHONDDIMPC)
		{
		}

		[SpecialName]
		public KMJDFKFJCPM BCIDOOAAJEP()
		{
			return default(KMJDFKFJCPM);
		}

		[SpecialName]
		public void HGBJOLCJJNO(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void ABHBILPMJHD(float JEHONDDIMPC)
		{
		}

		private void MGGBBBPONPP(UIVertex[] POFNMEKIGDK, Color32 OLJIIPPOIHN)
		{
		}

		[SpecialName]
		private Color32 HFFDHLBFNEE()
		{
			return default(Color32);
		}

		private void HAPNHGHFOHC(UIVertex[] POFNMEKIGDK, Color32 OLJIIPPOIHN)
		{
		}

		[SpecialName]
		public void ACBNIEEEBJP(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		private Color32 GIFPCIDOGBM()
		{
			return default(Color32);
		}

		private IEnumerator FCIBDFBGLAK()
		{
			return null;
		}

		[SpecialName]
		public void GMFBABGLNBD(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void CJCNDCJELNA(KMJDFKFJCPM JEHONDDIMPC)
		{
		}

		private void DKKAPKKCDJD(UIVertex[] POFNMEKIGDK, Color32 OLJIIPPOIHN)
		{
		}

		private IEnumerator HGDJNLINAFD()
		{
			return null;
		}

		[SpecialName]
		public void HJHIGCACIGP(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float EALAMMBLPIE()
		{
			return 0f;
		}

		[SpecialName]
		public void AKEACOGHFDM(Color32 JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float LNGFOHIFKMP()
		{
			return 0f;
		}

		[SpecialName]
		public float DKOOGCFILJA()
		{
			return 0f;
		}

		private bool FMFAKJFLIJB(UIVertex[] POFNMEKIGDK, Vector3 DMOJMBGJPLI, Rect FOFMPDDHPLJ)
		{
			return false;
		}

		[SpecialName]
		public KMJDFKFJCPM AFNOADDCKGI()
		{
			return default(KMJDFKFJCPM);
		}

		[SpecialName]
		public void MIHIDDHKPEM(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void EICBELCOFEL(KMJDFKFJCPM JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float HGDOPAHMDPI()
		{
			return 0f;
		}

		[SpecialName]
		private Color32 OGDKMONDNEK()
		{
			return default(Color32);
		}

		[SpecialName]
		public void PMIKDNHKMJD(Color32 JEHONDDIMPC)
		{
		}

		[SpecialName]
		private Color32 NJHEFIMPMHH()
		{
			return default(Color32);
		}

		[SpecialName]
		public void GPLCBBHPMPO(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void CAPNJDKLKEB(float JEHONDDIMPC)
		{
		}

		private bool OCLHOFKICCJ(UIVertex[] POFNMEKIGDK, Vector3 DMOJMBGJPLI, Rect FOFMPDDHPLJ)
		{
			return false;
		}

		[SpecialName]
		private Color32 LHDDOAHBGOG()
		{
			return default(Color32);
		}

		[SpecialName]
		public float MHPEPHPIGKH()
		{
			return 0f;
		}

		private void OFILFOFCHNJ()
		{
		}

		[SpecialName]
		public bool IKLMKDCFECH()
		{
			return false;
		}

		public override void SetNativeSize()
		{
		}

		[SpecialName]
		public void JDNELMMBLFE(float JEHONDDIMPC)
		{
		}
	}
}
