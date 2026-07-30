using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class AppRaterModel
{
	public enum NHHCIMBOHJP
	{
		TwoButtons = 0,
		ThreeButtons = 1
	}

	public enum PCLABNDHOMD
	{
		Yes = 0,
		No = 1
	}

	public enum HBJKKCFIKLN
	{
		One = 0,
		Two = 1,
		Three = 2,
		Four = 3,
		Five = 4,
		Six = 5,
		Seven = 6,
		Eight = 7,
		Nine = 8,
		Ten = 9
	}

	[SerializeField]
	private string appid;

	[SerializeField]
	private string reviewTitle;

	[SerializeField]
	private string reviewMessage;

	[SerializeField]
	private string rateNowTitle;

	[SerializeField]
	private string rateLaterTitle;

	[SerializeField]
	private string neverRemindTitle;

	[SerializeField]
	private PCLABNDHOMD shouldAlwaysShow;

	[SerializeField]
	private bool isThirdButton;

	[SerializeField]
	private PCLABNDHOMD shouldAutoShow;

	[SerializeField]
	private HBJKKCFIKLN numberOfDays;

	[SerializeField]
	private HBJKKCFIKLN numberOfGamePlays;

	[SerializeField]
	private NHHCIMBOHJP numberOfButtons;

	public bool IsThirdButton
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public PCLABNDHOMD ShouldAlwaysShow
	{
		get
		{
			return default(PCLABNDHOMD);
		}
		set
		{
		}
	}

	public PCLABNDHOMD ShouldAutoShow
	{
		get
		{
			return default(PCLABNDHOMD);
		}
		set
		{
		}
	}

	public HBJKKCFIKLN NumberOfDays
	{
		get
		{
			return default(HBJKKCFIKLN);
		}
		set
		{
		}
	}

	public HBJKKCFIKLN NumberOfGamePlays
	{
		get
		{
			return default(HBJKKCFIKLN);
		}
		set
		{
		}
	}

	public NHHCIMBOHJP NumberOfButtons
	{
		get
		{
			return default(NHHCIMBOHJP);
		}
		set
		{
		}
	}

	public string Appid
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string ReviewTitle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string ReviewMessage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string RateNowTitle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string RateLaterTitle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string NeverRemindTitle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[SpecialName]
	public string GDDLOIGNMEO()
	{
		return null;
	}

	[SpecialName]
	public NHHCIMBOHJP NBHAEDBFELE()
	{
		return default(NHHCIMBOHJP);
	}

	[SpecialName]
	public void PDIJJDCILEO(bool JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void MBIGIENKJAJ(PCLABNDHOMD JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void GEHDLBFKJEB(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void FDJLDCCPDIN(PCLABNDHOMD JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void FNPEOIJJLLO(PCLABNDHOMD JEHONDDIMPC)
	{
	}

	[SpecialName]
	public string LIEFIPCKEHJ()
	{
		return null;
	}

	[SpecialName]
	public void EFGDNIEAHBH(HBJKKCFIKLN JEHONDDIMPC)
	{
	}

	[SpecialName]
	public string EGOBCEOCFGP()
	{
		return null;
	}

	[SpecialName]
	public NHHCIMBOHJP LOHPDGHHMPJ()
	{
		return default(NHHCIMBOHJP);
	}

	[SpecialName]
	public string JLKHMJNKIKL()
	{
		return null;
	}

	[SpecialName]
	public void AIJPLBFFCEF(PCLABNDHOMD JEHONDDIMPC)
	{
	}

	[SpecialName]
	public string MNNHNJONNPB()
	{
		return null;
	}

	[SpecialName]
	public void BAABCCBMLFB(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public PCLABNDHOMD FFHCMFEHFGL()
	{
		return default(PCLABNDHOMD);
	}

	[SpecialName]
	public NHHCIMBOHJP IEKNDPDOMGC()
	{
		return default(NHHCIMBOHJP);
	}

	[SpecialName]
	public HBJKKCFIKLN CCHJFJIPJDP()
	{
		return default(HBJKKCFIKLN);
	}

	[SpecialName]
	public void PPKELNHOPFK(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public string APDEALNOBGF()
	{
		return null;
	}

	[SpecialName]
	public void EGONCBIKEEL(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public PCLABNDHOMD NDAONFFLJCP()
	{
		return default(PCLABNDHOMD);
	}

	[SpecialName]
	public string KLMJAAJFAFC()
	{
		return null;
	}

	[SpecialName]
	public string KHGKAJFPEIF()
	{
		return null;
	}

	[SpecialName]
	public string BDNMOOAOLNH()
	{
		return null;
	}

	[SpecialName]
	public void EONKBGKKPOM(HBJKKCFIKLN JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void FKOABOIMJJG(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public HBJKKCFIKLN OGAHLKJHBOP()
	{
		return default(HBJKKCFIKLN);
	}

	[SpecialName]
	public NHHCIMBOHJP PMGFBNPDOOH()
	{
		return default(NHHCIMBOHJP);
	}

	[SpecialName]
	public void MIMHMBHLMII(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public string JPEPKFLLNBM()
	{
		return null;
	}

	[SpecialName]
	public NHHCIMBOHJP POBNHLJNPEO()
	{
		return default(NHHCIMBOHJP);
	}

	[SpecialName]
	public void OFKPMLLDHLF(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void IHKBDLFCGNJ(bool JEHONDDIMPC)
	{
	}

	[SpecialName]
	public HBJKKCFIKLN GEDOAHDBKKO()
	{
		return default(HBJKKCFIKLN);
	}

	[SpecialName]
	public void HKPMMHCHEPL(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public bool JCMBPDKCJNA()
	{
		return false;
	}

	[SpecialName]
	public string AGDFOHGONDO()
	{
		return null;
	}

	[SpecialName]
	public HBJKKCFIKLN BIHGNOEDEOE()
	{
		return default(HBJKKCFIKLN);
	}

	[SpecialName]
	public void PGHAFJGCHJE(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void CJNJAKJLJKG(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void NIADBBANDGO(HBJKKCFIKLN JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void FFKIELOMFDK(PCLABNDHOMD JEHONDDIMPC)
	{
	}

	[SpecialName]
	public HBJKKCFIKLN OLFJPDPCNMG()
	{
		return default(HBJKKCFIKLN);
	}

	[SpecialName]
	public string IOLIPMEAGNJ()
	{
		return null;
	}

	[SpecialName]
	public void ANMDEOBLAPG(NHHCIMBOHJP JEHONDDIMPC)
	{
	}

	[SpecialName]
	public string IOFGJGLJINJ()
	{
		return null;
	}

	[SpecialName]
	public void BJLBCJFIHDF(HBJKKCFIKLN JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void IANCINDDIHP(NHHCIMBOHJP JEHONDDIMPC)
	{
	}

	[SpecialName]
	public string ANJCKIJHOJG()
	{
		return null;
	}

	[SpecialName]
	public HBJKKCFIKLN NPANIOMJFHL()
	{
		return default(HBJKKCFIKLN);
	}

	[SpecialName]
	public void PCEBFPENPDE(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public string OPHKJPAPFCK()
	{
		return null;
	}

	[SpecialName]
	public NHHCIMBOHJP KMFFIJGFHMP()
	{
		return default(NHHCIMBOHJP);
	}

	[SpecialName]
	public void MEPDNEDNIIN(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public string CFFFPNGGPGD()
	{
		return null;
	}

	[SpecialName]
	public void MHHGPCMEKJI(HBJKKCFIKLN JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void GLJAHPHAAGJ(PCLABNDHOMD JEHONDDIMPC)
	{
	}

	[SpecialName]
	public PCLABNDHOMD GFPFKGCEHOB()
	{
		return default(PCLABNDHOMD);
	}

	[SpecialName]
	public string CDEALBGNMIN()
	{
		return null;
	}

	[SpecialName]
	public HBJKKCFIKLN ENIAAJAMAKP()
	{
		return default(HBJKKCFIKLN);
	}

	[SpecialName]
	public HBJKKCFIKLN OPHFDMILGAI()
	{
		return default(HBJKKCFIKLN);
	}

	[SpecialName]
	public void NLBJJHFKNFP(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void HILODDBPOMP(HBJKKCFIKLN JEHONDDIMPC)
	{
	}

	[SpecialName]
	public HBJKKCFIKLN JDBAFGMIENF()
	{
		return default(HBJKKCFIKLN);
	}

	[SpecialName]
	public NHHCIMBOHJP EHNAIFPKKIH()
	{
		return default(NHHCIMBOHJP);
	}

	[SpecialName]
	public string FMKNOBHCBIO()
	{
		return null;
	}

	[SpecialName]
	public void BICIPGPPGCF(bool JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void MHLMHAONNJB(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public PCLABNDHOMD LPJLAJDLADO()
	{
		return default(PCLABNDHOMD);
	}

	[SpecialName]
	public void PJJBOMHBPFI(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void PNAKPEHPCDJ(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public HBJKKCFIKLN PDAEIGHIILK()
	{
		return default(HBJKKCFIKLN);
	}

	[SpecialName]
	public void LGKILJMADIB(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void FOFILDNKPBJ(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public string OPLIMBHNMDF()
	{
		return null;
	}

	[SpecialName]
	public void LGEFDDCKPKM(HBJKKCFIKLN JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void LOCKAKPMBMD(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void OIDAIPHBCPJ(HBJKKCFIKLN JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void HCENKIHMOCJ(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public string FPAOOBJDCLE()
	{
		return null;
	}

	[SpecialName]
	public void IBGOLJNMEHD(bool JEHONDDIMPC)
	{
	}

	[SpecialName]
	public HBJKKCFIKLN EGAHIKCHNHF()
	{
		return default(HBJKKCFIKLN);
	}

	[SpecialName]
	public void DGDJKIFKPBL(PCLABNDHOMD JEHONDDIMPC)
	{
	}

	[SpecialName]
	public string MPCJOLMMOMC()
	{
		return null;
	}

	[SpecialName]
	public void BMJKEGJHKJC(PCLABNDHOMD JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void GKDJIFDCHJI(HBJKKCFIKLN JEHONDDIMPC)
	{
	}

	[SpecialName]
	public string GBIHFBKEDJD()
	{
		return null;
	}

	[SpecialName]
	public void AJCOEAOOJOK(NHHCIMBOHJP JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void PFBIMNINEEK(NHHCIMBOHJP JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void BCMOJMFHJKM(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void BIHBIBDDEMO(PCLABNDHOMD JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void GIFEGNCMGFJ(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void AAHBFIMLPAD(PCLABNDHOMD JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void BDEEANMEIHA(HBJKKCFIKLN JEHONDDIMPC)
	{
	}

	[SpecialName]
	public PCLABNDHOMD JHOJLGEELJI()
	{
		return default(PCLABNDHOMD);
	}

	[SpecialName]
	public HBJKKCFIKLN AJCHOACPBMJ()
	{
		return default(HBJKKCFIKLN);
	}

	[SpecialName]
	public void CGDOBFDADML(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public bool KACMHJMIHLB()
	{
		return false;
	}

	[SpecialName]
	public void CIBBHDAMFBG(bool JEHONDDIMPC)
	{
	}

	[SpecialName]
	public PCLABNDHOMD DAIMGLGFGHO()
	{
		return default(PCLABNDHOMD);
	}

	[SpecialName]
	public HBJKKCFIKLN GJLINADKBHC()
	{
		return default(HBJKKCFIKLN);
	}

	[SpecialName]
	public void JMFGCMLGEAB(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public void HOLEDBBOPAO(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public string PAKNDOGOGPK()
	{
		return null;
	}

	[SpecialName]
	public void LMCCGHDJFDP(bool JEHONDDIMPC)
	{
	}

	[SpecialName]
	public string OBPLGODOLJN()
	{
		return null;
	}

	[SpecialName]
	public string AHPBJKEPLLB()
	{
		return null;
	}

	[SpecialName]
	public string IIMIMBBMDNH()
	{
		return null;
	}

	[SpecialName]
	public void MKEFCFPGMMP(string JEHONDDIMPC)
	{
	}

	[SpecialName]
	public string OOFNDJOIFHF()
	{
		return null;
	}

	[SpecialName]
	public string DKGCOGDEGBE()
	{
		return null;
	}

	[SpecialName]
	public void LDICIMJNMJJ(NHHCIMBOHJP JEHONDDIMPC)
	{
	}

	[SpecialName]
	public string PJJBGLEDKOM()
	{
		return null;
	}

	[SpecialName]
	public string LCHGNKDHJCF()
	{
		return null;
	}

	[SpecialName]
	public void KBCGFFEGAOJ(PCLABNDHOMD JEHONDDIMPC)
	{
	}

	[SpecialName]
	public string IOILMKEPIOG()
	{
		return null;
	}
}
