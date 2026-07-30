using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace AdvancedColorPicker
{
	[RequireComponent(typeof(CanvasRenderer))]
	public class GradientBackground : GraphicalColorComponent
	{
		public enum OGMEMBODKNE
		{
			Custom = 0,
			Color = 1,
			RGB_R = 2,
			RGB_G = 3,
			RGB_B = 4,
			HSV_H = 5,
			HSV_S = 6,
			HSV_V = 7,
			HSL_H = 8,
			HSL_S = 9,
			HSL_L = 10
		}

		public enum MEEPKGEOBJK
		{
			Custom = 0,
			Alpha = 1,
			RGB_R = 2,
			RGB_G = 3,
			RGB_B = 4,
			HSV_H = 5,
			HSV_S = 6,
			HSV_V = 7,
			HSL_H = 8,
			HSL_S = 9,
			HSL_L = 10
		}

		[Serializable]
		public class GradientPart
		{
			[SerializeField]
			private OGMEMBODKNE type;

			[SerializeField]
			private Color32 color;

			public UnityAction callback;

			[SerializeField]
			private bool v2Fixed;

			[SerializeField]
			private bool v3Fixed;

			[SerializeField]
			private bool alphaFixed;

			[SerializeField]
			[Range(0f, 1f)]
			private float fixedV2;

			[Range(0f, 1f)]
			[SerializeField]
			private float fixedV3;

			[SerializeField]
			[Range(0f, 255f)]
			private byte fixedAlpha;

			public OGMEMBODKNE Type
			{
				get
				{
					return default(OGMEMBODKNE);
				}
				set
				{
				}
			}

			public Color32 Color
			{
				get
				{
					return default(Color32);
				}
				set
				{
				}
			}

			public bool Value2IsFixed
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool Value3IsFixed
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool AlphaIsFixed
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public float FixedValue2
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float FixedValue3
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public byte FixedAlphaValue
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public float FixedAlphaNormalized => 0f;

			public GradientPart()
			{
			}

			[SpecialName]
			public void LONEEIOJNKJ(bool JEHONDDIMPC)
			{
			}

			[SpecialName]
			public bool JBPFJANLBLN()
			{
				return false;
			}

			[SpecialName]
			public Color32 JFAAGDCJEHL()
			{
				return default(Color32);
			}

			public float PAIHKEGOOIO(float OLICMIPNBMM)
			{
				return 0f;
			}

			public float KMAJMHBIJGE(float OLICMIPNBMM)
			{
				return 0f;
			}

			private void OCCAMBECHKP()
			{
			}

			public float LHCOCDOIOAP(float OLICMIPNBMM)
			{
				return 0f;
			}

			public GradientPart(GradientPart OPLAIPLICAO)
			{
			}

			public byte HKCGCNIEABC(byte OLICMIPNBMM)
			{
				return 0;
			}

			[SpecialName]
			public Color32 MNPDHKFFNIB()
			{
				return default(Color32);
			}

			public float JAIAPILGLHO(float OLICMIPNBMM)
			{
				return 0f;
			}

			[SpecialName]
			public bool LABJMDNDKPJ()
			{
				return false;
			}

			public float AFHKFFLPONI(float OLICMIPNBMM)
			{
				return 0f;
			}

			public byte LLJKFCDDKAK(byte OLICMIPNBMM)
			{
				return 0;
			}

			[SpecialName]
			public bool KCMPPIDCFPF()
			{
				return false;
			}

			public byte PAIHKEGOOIO(byte OLICMIPNBMM)
			{
				return 0;
			}

			[SpecialName]
			public void PIMMKFFBDIF(float JEHONDDIMPC)
			{
			}

			private void DEFAEBDEKNG()
			{
			}

			[SpecialName]
			public void ICGHKOMGACJ(float JEHONDDIMPC)
			{
			}

			[SpecialName]
			public OGMEMBODKNE BIDDAJLOLDJ()
			{
				return default(OGMEMBODKNE);
			}

			[SpecialName]
			public float ABMNCPMNLAC()
			{
				return 0f;
			}

			[SpecialName]
			public float GIBGKKHDEHI()
			{
				return 0f;
			}

			[SpecialName]
			public void MKFBELHKIEP(bool JEHONDDIMPC)
			{
			}

			[SpecialName]
			public byte GIIJJLBLNNL()
			{
				return 0;
			}

			[SpecialName]
			public void OAPMCHIIGME(float JEHONDDIMPC)
			{
			}

			[SpecialName]
			public Color32 CLOKFFOHFKE()
			{
				return default(Color32);
			}

			[SpecialName]
			public void LHIEDDCEJHK(byte JEHONDDIMPC)
			{
			}

			[SpecialName]
			public float DHBDCOGBBFF()
			{
				return 0f;
			}

			[SpecialName]
			public void GNCFEOAPDBF(byte JEHONDDIMPC)
			{
			}

			[SpecialName]
			public Color32 PENAKPNDJOP()
			{
				return default(Color32);
			}
		}

		private bool MKCOBOCNPAF;

		[SerializeField]
		private GradientPart[] colors;

		[SerializeField]
		private bool displayCheckboard;

		[SerializeField]
		private bool gradient;

		[SerializeField]
		private Slider.Direction direction;

		[SerializeField]
		[Range(0f, 1f)]
		private float centerPos;

		[SerializeField]
		private MEEPKGEOBJK centerType;

		[SerializeField]
		private float checkBoardSize;

		[SerializeField]
		private float borderSize;

		public bool DisplayCheckboard
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float CheckboardSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool Gradient
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MEEPKGEOBJK CenterType
		{
			get
			{
				return default(MEEPKGEOBJK);
			}
			set
			{
			}
		}

		public float CenterPosition
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

		public Slider.Direction Direction
		{
			get
			{
				return default(Slider.Direction);
			}
			set
			{
			}
		}

		public int Count
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public GradientPart this[int CJKBJFLAHJN] => null;

		public override Texture mainTexture => null;

		[SpecialName]
		public float KGINCNBEGBD()
		{
			return 0f;
		}

		[SpecialName]
		public void AGIKAPIIBOF(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float ELPJFBGFEJL()
		{
			return 0f;
		}

		[SpecialName]
		public void PGOEPFAPCKC(MEEPKGEOBJK JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void IJCLEEKNIDJ(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void PDMGIGEBNNO(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void DIKNGGCDKOF(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public bool BBIGEOHAMAN()
		{
			return false;
		}

		[SpecialName]
		public void AHGLKHIDCCL(int JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void AMOBNNHOPGD(float JEHONDDIMPC)
		{
		}

		public void DGKBNHHBAKI(JEFPJABADEA GFMIKEPFCLG)
		{
		}

		[SpecialName]
		public Slider.Direction LBMOGGFAJJL()
		{
			return default(Slider.Direction);
		}

		[SpecialName]
		public void EBCNNMEBFPK(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void PNDGFDPEPMO(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void AFLJLCNBCHB(MEEPKGEOBJK JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void NKENDJCPCOA(Slider.Direction JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void IFDFGDKEKFN(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public MEEPKGEOBJK OOKACLIJOKC()
		{
			return default(MEEPKGEOBJK);
		}

		[SpecialName]
		public void GMOHLNPGGNF(int JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void DMOBBDMGHGH(int JEHONDDIMPC)
		{
		}

		[SpecialName]
		public Slider.Direction ICJBDNIBMFI()
		{
			return default(Slider.Direction);
		}

		[SpecialName]
		public void MHDDLJIDHIH(int JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void JEOCNGAPNPA(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void COECAELEAOD(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float KPDKJHJGBBJ()
		{
			return 0f;
		}

		[SpecialName]
		public void CHMIPNBFDED(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float NJLJOAOANBB()
		{
			return 0f;
		}

		[SpecialName]
		public int COEPNLHOILG()
		{
			return 0;
		}

		public void SetToDefaultType(JEFPJABADEA GFMIKEPFCLG)
		{
		}

		[SpecialName]
		public MEEPKGEOBJK JNGJLGJLLJN()
		{
			return default(MEEPKGEOBJK);
		}

		public void FKABMFCINDB(JEFPJABADEA GFMIKEPFCLG)
		{
		}

		[SpecialName]
		public Slider.Direction KAJEANMEJOC()
		{
			return default(Slider.Direction);
		}

		[SpecialName]
		public bool DNBLHNEJAJA()
		{
			return false;
		}

		[SpecialName]
		public GradientPart DLEPHDHFFCK(int CJKBJFLAHJN)
		{
			return null;
		}

		[SpecialName]
		public float GBBJNBCPBNC()
		{
			return 0f;
		}

		[SpecialName]
		public void OLDPNEOGMFJ(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void ALBMNFMMBGI(Slider.Direction JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void ICNBFGINJIE(MEEPKGEOBJK JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void DDPFFBKMPCM(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void EMAHOOKKBPO(Slider.Direction JEHONDDIMPC)
		{
		}

		[SpecialName]
		public MEEPKGEOBJK LGNIEINKCPO()
		{
			return default(MEEPKGEOBJK);
		}

		[SpecialName]
		public void FDPHDMKKCIK(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void MBHJNCHCKJA(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float LJJCKHGCLPJ()
		{
			return 0f;
		}

		[SpecialName]
		public bool ENHAPHPIPHO()
		{
			return false;
		}

		[SpecialName]
		public void NODNEEBFHOA(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void BLNMJOEMKEJ(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void JAEAHDPOJFB(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public Slider.Direction EBIGAOPHDCO()
		{
			return default(Slider.Direction);
		}

		[SpecialName]
		public void NLEJOCFAAAP(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void HELONKOACCK(Slider.Direction JEHONDDIMPC)
		{
		}

		[SpecialName]
		public bool ADHMOAHKBOH()
		{
			return false;
		}

		[SpecialName]
		public float NHPCBDACNGD()
		{
			return 0f;
		}

		[SpecialName]
		public void PLIPJHLDHIL(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void MPKCMLLAHMM(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float CCPMMOCCGIE()
		{
			return 0f;
		}

		[SpecialName]
		public Slider.Direction JBNNGBGJEHC()
		{
			return default(Slider.Direction);
		}

		[SpecialName]
		public void FBAFIAGNEPG(MEEPKGEOBJK JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void PPKIEBJCNGH(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void IADEANNNODB(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public int KBJKMNBFAAG()
		{
			return 0;
		}

		[SpecialName]
		public int ALLMEOEAKGH()
		{
			return 0;
		}

		public override void SetNativeSize()
		{
		}

		[SpecialName]
		public void HPLHNHOAMJL(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float HOCNMHBGPGD()
		{
			return 0f;
		}

		[SpecialName]
		public int FPPBKFDDJMB()
		{
			return 0;
		}

		[SpecialName]
		public void CDFOKPCPDEB(Slider.Direction JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void ELKNKCACPGI(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float HGOMJJCDNFF()
		{
			return 0f;
		}

		[SpecialName]
		public bool DFMJDODJMNO()
		{
			return false;
		}

		[SpecialName]
		public void DFDNIMJJPPI(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public int NDKBDHOIODA()
		{
			return 0;
		}

		public void EKHGGAOCMFD(JEFPJABADEA GFMIKEPFCLG)
		{
		}

		[SpecialName]
		public bool MIBBKDFEBJM()
		{
			return false;
		}

		[SpecialName]
		public GradientPart FGEPOCFLDKC(int CJKBJFLAHJN)
		{
			return null;
		}

		[SpecialName]
		public int MCAINOBJDJK()
		{
			return 0;
		}

		[SpecialName]
		public float JIKLPFDKIEN()
		{
			return 0f;
		}

		[SpecialName]
		public void AMDBIMGNPDJ(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void MLJBNPGAHFM(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void IAKODJGIMMF(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public GradientPart PPLDPPNGCPD(int CJKBJFLAHJN)
		{
			return null;
		}

		[SpecialName]
		public void IIKNKGEGPIL(int JEHONDDIMPC)
		{
		}

		[SpecialName]
		public bool IABPJECNFOH()
		{
			return false;
		}

		[SpecialName]
		public void KDBDDDMOLGB(int JEHONDDIMPC)
		{
		}

		[SpecialName]
		public Slider.Direction HEKPIDPONKE()
		{
			return default(Slider.Direction);
		}

		public void FAKOMDHDOFC(JEFPJABADEA GFMIKEPFCLG)
		{
		}

		[SpecialName]
		public float BJPPCBHOCGM()
		{
			return 0f;
		}

		[SpecialName]
		public void KIEFBHPLDKP(Slider.Direction JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void JLGOHOGDFHA(Slider.Direction JEHONDDIMPC)
		{
		}

		[SpecialName]
		public MEEPKGEOBJK IEJNGMKBAKI()
		{
			return default(MEEPKGEOBJK);
		}

		[SpecialName]
		public void DFJNHPKCBHG(MEEPKGEOBJK JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void JMHMOGMLIGG(MEEPKGEOBJK JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void PJGEIKDACFD(int JEHONDDIMPC)
		{
		}

		[SpecialName]
		public GradientPart PGAECKPCMDN(int CJKBJFLAHJN)
		{
			return null;
		}

		[SpecialName]
		public int NDJCGNNOKKP()
		{
			return 0;
		}

		[SpecialName]
		public void FOLGMNKDPCP(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public MEEPKGEOBJK FPKEJEBBHKC()
		{
			return default(MEEPKGEOBJK);
		}

		[SpecialName]
		public void PHHMJHOAJKG(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public MEEPKGEOBJK GMGFNPEOGKG()
		{
			return default(MEEPKGEOBJK);
		}

		[SpecialName]
		public bool FNNLOIKEPJF()
		{
			return false;
		}

		[SpecialName]
		public void GKDCEBMFBGM(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float EDGGJGFHOHH()
		{
			return 0f;
		}

		[SpecialName]
		public float CAFOMHPACNH()
		{
			return 0f;
		}

		[SpecialName]
		public int HBCHBEHKPKC()
		{
			return 0;
		}

		[SpecialName]
		public void JMCHDPAOKKP(Slider.Direction JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void NNEJBHDFJPO(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public bool OCFMOCCNCOJ()
		{
			return false;
		}

		[SpecialName]
		public bool NNFACFAFNOM()
		{
			return false;
		}

		[SpecialName]
		public void FJKILEPGNMF(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void DDHOFFLMIKC(MEEPKGEOBJK JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void LBBFDNDEEBL(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public GradientPart LGJOHJAHEEC(int CJKBJFLAHJN)
		{
			return null;
		}

		public void JMDPJAJMFID(JEFPJABADEA GFMIKEPFCLG)
		{
		}

		[SpecialName]
		public float BJLECMMIKJL()
		{
			return 0f;
		}

		[SpecialName]
		public Slider.Direction GICBLPMPLKK()
		{
			return default(Slider.Direction);
		}

		protected override void OAOOLMGAMOK()
		{
		}

		[SpecialName]
		public void EFLKJJDPKCJ(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public bool GFNBFHJMLII()
		{
			return false;
		}

		[SpecialName]
		public float MDFJEKEDBKB()
		{
			return 0f;
		}

		[SpecialName]
		public void EFJPEIPJOGC(int JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float FGHJNCJOAHG()
		{
			return 0f;
		}

		[SpecialName]
		public float LBGNPKJFHND()
		{
			return 0f;
		}

		[SpecialName]
		public bool MALKFONNIOD()
		{
			return false;
		}

		[SpecialName]
		public void OBHAKHPMDLB(MEEPKGEOBJK JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void GMANBHADEDI(Slider.Direction JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void CCKIADFAHEJ(MEEPKGEOBJK JEHONDDIMPC)
		{
		}

		[SpecialName]
		public GradientPart HHCNMJLCJLP(int CJKBJFLAHJN)
		{
			return null;
		}

		[SpecialName]
		public void GJJAPJKFPBF(int JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void CPKLBJLDANI(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void BJDOBPMNKFF(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float BPGIOINIPIE()
		{
			return 0f;
		}

		[SpecialName]
		public void DHAPCENODIE(float JEHONDDIMPC)
		{
		}

		protected override void OnPopulateMesh(VertexHelper BIKKMNGAKBK)
		{
		}

		[SpecialName]
		public void KMJLBBHOGMF(Slider.Direction JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void DLDCJKCJNLF(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public MEEPKGEOBJK JOJEFMJLHHL()
		{
			return default(MEEPKGEOBJK);
		}

		[SpecialName]
		public int BIGIEHLKNLP()
		{
			return 0;
		}

		[SpecialName]
		public void PLLHNDKNHJI(MEEPKGEOBJK JEHONDDIMPC)
		{
		}

		[SpecialName]
		public bool HDFEDGFPBBD()
		{
			return false;
		}

		[SpecialName]
		public float CCCILGPCMNJ()
		{
			return 0f;
		}

		[SpecialName]
		public void HKIMOEEKPCH(float JEHONDDIMPC)
		{
		}

		public void KGLIHGCGMGM(JEFPJABADEA GFMIKEPFCLG)
		{
		}

		[SpecialName]
		public int KJCDNGFKHHK()
		{
			return 0;
		}

		[SpecialName]
		public void MFNJMEHBMDH(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void CGDEHJPJLMH(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void IDHGLACHAPC(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void MPKLBAKJFIL(float JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void DJHPKGBFMCC(MEEPKGEOBJK JEHONDDIMPC)
		{
		}

		[SpecialName]
		public float FKJDCHBJKPB()
		{
			return 0f;
		}

		[SpecialName]
		public void FCADJEOMCLE(Slider.Direction JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void PDKHIIOMNKH(bool JEHONDDIMPC)
		{
		}
	}
}
