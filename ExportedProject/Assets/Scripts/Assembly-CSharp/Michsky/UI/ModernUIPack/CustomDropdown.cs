using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Michsky.UI.ModernUIPack
{
	public class CustomDropdown : MonoBehaviour, IPointerExitHandler, IEventSystemHandler
	{
		public enum KAAEFOCEMGH
		{
			FADING = 0,
			SLIDING = 1,
			STYLISH = 2
		}

		[Serializable]
		public class Item
		{
			public string itemName;

			public Sprite itemIcon;

			public UnityEvent OnItemSelection;
		}

		private sealed class DOJDNOBHMOD
		{
			public GameObject go;

			public CustomDropdown _003C_003E4__this;

			internal void NLCFGLKCKBO()
			{
			}
		}

		[Header("OBJECTS")]
		public GameObject triggerObject;

		public TextMeshProUGUI selectedText;

		public Image selectedImage;

		public Transform itemParent;

		public GameObject itemObject;

		public GameObject scrollbar;

		private VerticalLayoutGroup FMANIFJHFOE;

		private Transform KABIBFFBLKH;

		public Transform listParent;

		[Header("SETTINGS")]
		public bool enableIcon;

		public bool enableTrigger;

		public bool enableScrollbar;

		public bool setHighPriorty;

		public bool outOnPointerExit;

		public bool isListItem;

		public bool invokeAtStart;

		public KAAEFOCEMGH animationType;

		public int selectedItemIndex;

		[Header("SAVING")]
		public bool saveSelected;

		[Tooltip("Note that every Dropdown should has its own unique tag.")]
		public string dropdownTag;

		[SerializeField]
		[Header("CONTENT")]
		public List<Item> dropdownItems;

		private Animator PHFCGCOJBJJ;

		private TextMeshProUGUI NBMBCNDOOCL;

		private Image NJKGIMCDHAL;

		private Sprite IHOOLHLBJCF;

		private string IHLFPCODFOM;

		private string DJECGNAFIPK;

		private Sprite PMGNOMCNPNC;

		private bool MDDDIIFHGKK;

		[HideInInspector]
		public int index;

		[HideInInspector]
		public int siblingIndex;

		public void MOLLMNHFCAA()
		{
		}

		public void ChangeDropdownInfo(int EHOPKBPKNIC)
		{
		}

		public void FNIECBAEEAP(Sprite JKFBKNMOPEE)
		{
		}

		private void JNFMGLCKLON()
		{
		}

		public void HJICNAPMFBC()
		{
		}

		public void BMKEHONPHPE()
		{
		}

		public void ENCFJBAFPKB()
		{
		}

		public void ODKCJBJLNAB()
		{
		}

		public void MDNMPAKFEFD()
		{
		}

		public void DHOPHEOFOPL(Sprite JKFBKNMOPEE)
		{
		}

		public void SetItemIcon(Sprite JKFBKNMOPEE)
		{
		}

		public void KHBHOAEBHIC()
		{
		}

		public void OKDNNMJLADC()
		{
		}

		public void AJFGKONCNMO(Sprite JKFBKNMOPEE)
		{
		}

		public void HFGOAPPDCNO()
		{
		}

		public void IHJJCNCEEBN(string LOIHBMKNJLB)
		{
		}

		public void ELAGMLJCEBK(int EHOPKBPKNIC)
		{
		}

		public void OFDAAOPFGNN(Sprite JKFBKNMOPEE)
		{
		}

		public void FFAJGPGLEAP()
		{
		}

		public void CELBJMLMALH(int EHOPKBPKNIC)
		{
		}

		public void CreateNewItem()
		{
		}

		public void ENONPLOKGAC()
		{
		}

		public void GMANAKPNPOF()
		{
		}

		public void IILHDCJCACA()
		{
		}

		public void GCHLJODGPNJ()
		{
		}

		public void CMOGDALKNGP()
		{
		}

		private void KAKPGMIKLDE()
		{
		}

		public void IAKFOCDMEDA()
		{
		}

		public void AJJMCBJMGID(string LOIHBMKNJLB)
		{
		}

		public void AHMJOMLJMNE(Sprite JKFBKNMOPEE)
		{
		}

		public void BIOMKLLLPLL()
		{
		}

		private void Start()
		{
		}

		private void LBABNGFKFHO()
		{
		}

		public void CCBOJNOHCGM()
		{
		}

		public void OHMJCNKLEKF(Sprite JKFBKNMOPEE)
		{
		}

		public void PAGBHHKMPCG()
		{
		}

		public void MPHLFIAHKDG()
		{
		}

		public void UpdateValues()
		{
		}

		public void IBOEEEPCIMC(string LOIHBMKNJLB)
		{
		}

		public void HICGEHGKFCN(Sprite JKFBKNMOPEE)
		{
		}

		public void KCAGHIIBNCG(Sprite JKFBKNMOPEE)
		{
		}

		public void AMHJIEEMDDL(Sprite JKFBKNMOPEE)
		{
		}

		public void CMALHAMOJBI(Sprite JKFBKNMOPEE)
		{
		}

		public void MBPEIJCKMJB()
		{
		}

		public void PBFKMFICHDK(PointerEventData KFOIKMGPCHF)
		{
		}

		public void PJECDJGIDMJ()
		{
		}

		public void OPJFPGBNKDC()
		{
		}

		public void IOBOEEBELAO()
		{
		}

		public void SetItemTitle(string LOIHBMKNJLB)
		{
		}

		public void LNPAEKKEGEB()
		{
		}

		public void BAPPPAKIHDK(PointerEventData KFOIKMGPCHF)
		{
		}

		private void CICHLIGGMEF()
		{
		}

		public void NKADBLENLIL(string LOIHBMKNJLB)
		{
		}

		public void ICMGLKKNDPI(Sprite JKFBKNMOPEE)
		{
		}

		private void OEADEFEDEBN()
		{
		}

		public void GIEOBAJNJEB()
		{
		}

		private void LDBFILLOLPC()
		{
		}

		public void FMFAPPKJCBG()
		{
		}

		public void NHACHHFFFHL()
		{
		}

		public void GLENHDNOJGK(Sprite JKFBKNMOPEE)
		{
		}

		public void JGCGIMBNOHC(int EHOPKBPKNIC)
		{
		}

		public void FFKEFIHKCMN()
		{
		}

		public void MOGBDFDFLBD(PointerEventData KFOIKMGPCHF)
		{
		}

		public void SetupDropdown()
		{
		}

		public void EBDAOJHDELO(int EHOPKBPKNIC)
		{
		}

		public void LMIHOCCLIHM(int EHOPKBPKNIC)
		{
		}

		public void LJDHADMEFDC()
		{
		}

		public void JIMACMDPNNN()
		{
		}

		public void LPDMLLOALHO()
		{
		}

		public void ECKPIGJDCFP()
		{
		}

		public void BANNKHOIIBC(Sprite JKFBKNMOPEE)
		{
		}

		public void JHICOEANJAP(int EHOPKBPKNIC)
		{
		}

		public void LMHCJGFDNGE(int EHOPKBPKNIC)
		{
		}

		public void DAFKBKMPPAA(int EHOPKBPKNIC)
		{
		}

		public void PAGLFOLEOJG()
		{
		}

		public void JAEDOPEEALD(PointerEventData KFOIKMGPCHF)
		{
		}

		public void OOAHENJGGBJ()
		{
		}

		public void GFGGIDGCAJB(PointerEventData KFOIKMGPCHF)
		{
		}

		public void COMBDDHFBHM(string LOIHBMKNJLB)
		{
		}

		public void NDMHAMAEPEI()
		{
		}

		public void PIFGPBJPMGK()
		{
		}

		public void EOADOJCIHNM(Sprite JKFBKNMOPEE)
		{
		}

		public void GFDLLCJICMF(string LOIHBMKNJLB)
		{
		}

		public void MECENCJMIBB(string LOIHBMKNJLB)
		{
		}

		public void OnPointerExit(PointerEventData KFOIKMGPCHF)
		{
		}

		public void BPPMOALFEAG(Sprite JKFBKNMOPEE)
		{
		}

		public void GHMKGMOOEMG()
		{
		}

		public void PDILIIIPOEG(PointerEventData KFOIKMGPCHF)
		{
		}

		public void BBNIIEEMCNL(Sprite JKFBKNMOPEE)
		{
		}

		public void GMPOBLFAPFH()
		{
		}

		public void ENHJDOKJOKP()
		{
		}

		public void HDHACNGNBJK()
		{
		}

		public void PDKIIKNJGHD(Sprite JKFBKNMOPEE)
		{
		}

		public void BAKPABGKGFJ()
		{
		}

		public void IAAJCJOOKPL(int EHOPKBPKNIC)
		{
		}

		public void DAIENMBHJEB(string LOIHBMKNJLB)
		{
		}

		public void MDBBGNOMDHE(PointerEventData KFOIKMGPCHF)
		{
		}

		public void PFMHAIAANFL()
		{
		}

		public void EPCDEPKAONN(Sprite JKFBKNMOPEE)
		{
		}

		public void DBCLPGNIKDK()
		{
		}

		private void HBBDBPJMBLI()
		{
		}

		private void MEKHINDNILK()
		{
		}

		public void NAOKGNOEGDP(string LOIHBMKNJLB)
		{
		}

		public void OJPEEFEMJBC(int EHOPKBPKNIC)
		{
		}

		public void OHKMEGOECNI()
		{
		}

		public void KBHFIKDHBGK(PointerEventData KFOIKMGPCHF)
		{
		}

		public void EPJPIPPKMBG(Sprite JKFBKNMOPEE)
		{
		}

		public void MBKIFBENGLH()
		{
		}

		public void CMOAMEGGHAL()
		{
		}

		public void LJFFOFMLDMI()
		{
		}

		public void DFBDDJGHLDJ(Sprite JKFBKNMOPEE)
		{
		}

		public void CDMKCICJDDP(Sprite JKFBKNMOPEE)
		{
		}

		public void BCHIFMEHFBL()
		{
		}

		private void NNLOHMAAJFF()
		{
		}

		public void CCGFGLDELOG()
		{
		}

		public void OBINNKKFMMH(PointerEventData KFOIKMGPCHF)
		{
		}

		public void ECEGNCNHFNP()
		{
		}

		public void BMJBABAFGCC(Sprite JKFBKNMOPEE)
		{
		}

		public void PNNFEJLDCON(PointerEventData KFOIKMGPCHF)
		{
		}

		public void MFHOJABGOBF()
		{
		}

		public void OEAIAKPHEOM()
		{
		}

		public void ANNADFMLBLE(string LOIHBMKNJLB)
		{
		}

		public void IJLPGCFAGNK()
		{
		}

		public void KAIABBFGDKH()
		{
		}

		public void Animate()
		{
		}

		public void AFJNAMPHHAD()
		{
		}

		public void HKBFFEEFBAI()
		{
		}

		public void NBNOPCLPMAM()
		{
		}

		public void EICPJLIGBGL()
		{
		}
	}
}
