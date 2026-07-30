using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Michsky.UI.ModernUIPack
{
	public class DropdownMultiSelect : MonoBehaviour
	{
		[Serializable]
		public class ToggleEvent : UnityEvent<bool>
		{
		}

		public enum EDFEPPHKKGF
		{
			FADING = 0,
			SLIDING = 1,
			STYLISH = 2
		}

		[Serializable]
		public class Item
		{
			public string itemName;

			public bool isOn;

			[SerializeField]
			public ToggleEvent toggleEvents;
		}

		[Header("OBJECTS")]
		public GameObject triggerObject;

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

		public EDFEPPHKKGF animationType;

		[Header("WIP - NOT FUNCTIONAL")]
		public bool saveSelected;

		public bool invokeAtStart;

		public string toggleTag;

		[Header("CONTENT")]
		[SerializeField]
		public List<Item> dropdownItems;

		private Animator PHFCGCOJBJJ;

		private TextMeshProUGUI NBMBCNDOOCL;

		private string IHLFPCODFOM;

		private string DJECGNAFIPK;

		private Sprite PMGNOMCNPNC;

		private bool MDDDIIFHGKK;

		[HideInInspector]
		public int iHelper;

		[HideInInspector]
		public int siblingIndex;

		private void CFIFNAGMLNE()
		{
		}

		public void NIKCBKBFJEF()
		{
		}

		public void MFFJEHOIHLI(bool MDDDIIFHGKK)
		{
		}

		public void BMIDHGAIPEO(PointerEventData KFOIKMGPCHF)
		{
		}

		private void CIFBNIIEEPF()
		{
		}

		public void SetupDropdown()
		{
		}

		public void OMFFFLOBNHO()
		{
		}

		public void DEKBDHJBCJI()
		{
		}

		public void ABHJGABHHKK(string LOIHBMKNJLB)
		{
		}

		public void DKKBAJMHBFB(bool MDDDIIFHGKK)
		{
		}

		public void MFHOJABGOBF()
		{
		}

		public void KHAKJLGEMKC()
		{
		}

		public void BECMGDALFOB()
		{
		}

		public void GEJIBLGFOCJ()
		{
		}

		public void LNFBIPKDJEL(string LOIHBMKNJLB)
		{
		}

		public void MOGBDFDFLBD(PointerEventData KFOIKMGPCHF)
		{
		}

		public void SetItemTitle(string LOIHBMKNJLB)
		{
		}

		public void FLPMMAAEJKC(bool MDDDIIFHGKK)
		{
		}

		public void ABOMKKMCGED(PointerEventData KFOIKMGPCHF)
		{
		}

		public void NBOHNBOIFHN()
		{
		}

		public void AHDCLGBAOII(bool MDDDIIFHGKK)
		{
		}

		public void EJNOGDCAEHM()
		{
		}

		public void PECBBJLJKOA(PointerEventData KFOIKMGPCHF)
		{
		}

		private void Start()
		{
		}

		public void UpdateValues()
		{
		}

		public void KCOKIGGEIEA()
		{
		}

		private void MPDLDFOEJOE()
		{
		}

		private void GBBEKNPEJNH()
		{
		}

		public void GPIFGIMOLLM(string LOIHBMKNJLB)
		{
		}

		public void COMBDDHFBHM(string LOIHBMKNJLB)
		{
		}

		private void NHCPDAOHBOH()
		{
		}

		public void GCENNGBBEMI(bool MDDDIIFHGKK)
		{
		}

		public void INCPNOEDLJA(string LOIHBMKNJLB)
		{
		}

		private void DDGPCKALOCD()
		{
		}

		public void Animate()
		{
		}

		public void MPHLFIAHKDG()
		{
		}

		public void FLMDFGDMICO(bool MDDDIIFHGKK)
		{
		}

		public void OFGBJFPALAH()
		{
		}

		public void CJAMDIOPLCP()
		{
		}

		public void CHEHDHLPEFF()
		{
		}

		public void JNPLMNPDLHH(string LOIHBMKNJLB)
		{
		}

		public void HAFNPNJKOPM()
		{
		}

		public void OnPointerExit(PointerEventData KFOIKMGPCHF)
		{
		}

		public void UpdateToggle(bool MDDDIIFHGKK)
		{
		}

		public void IMBFKGAIMLH(bool MDDDIIFHGKK)
		{
		}

		public void BLOLEHPDDKF(string LOIHBMKNJLB)
		{
		}

		public void LOGAGHDKAEM(bool MDDDIIFHGKK)
		{
		}

		public void FIHJKJMAHPL(PointerEventData KFOIKMGPCHF)
		{
		}

		public void CIPMKMMHCNH()
		{
		}

		public void BAPPPAKIHDK(PointerEventData KFOIKMGPCHF)
		{
		}

		public void CreateNewItem()
		{
		}

		public void DJPBFJPADBJ(bool MDDDIIFHGKK)
		{
		}

		public void BOAOMHALOJM(bool MDDDIIFHGKK)
		{
		}

		public void SaveToggle(bool MDDDIIFHGKK)
		{
		}

		public void ADGFCKKPNID()
		{
		}

		public void CNJAFAAADID(string LOIHBMKNJLB)
		{
		}

		public void CAOHDFJDJJM(string LOIHBMKNJLB)
		{
		}

		public void ENHDOLOAJEO(PointerEventData KFOIKMGPCHF)
		{
		}

		public void MIIMPAEDPMB()
		{
		}
	}
}
