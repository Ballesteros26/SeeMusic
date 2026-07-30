using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EnhancedUI.EnhancedScroller
{
	[RequireComponent(typeof(ScrollRect))]
	public class EnhancedScroller : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
	{
		public enum LOLKMNACBMP
		{
			Vertical = 0,
			Horizontal = 1
		}

		public enum IAPFIPILPIF
		{
			Before = 0,
			After = 1
		}

		public enum LOFHGFNLPHH
		{
			OnlyIfNeeded = 0,
			Always = 1,
			Never = 2
		}

		public enum LABGHCNAEPL
		{
			Closest = 0,
			Up = 1,
			Down = 2
		}

		private enum MOMDFOGOHPI
		{
			First = 0,
			Last = 1
		}

		public enum OFOCCNGBKLI
		{
			immediate = 0,
			linear = 1,
			spring = 2,
			easeInQuad = 3,
			easeOutQuad = 4,
			easeInOutQuad = 5,
			easeInCubic = 6,
			easeOutCubic = 7,
			easeInOutCubic = 8,
			easeInQuart = 9,
			easeOutQuart = 10,
			easeInOutQuart = 11,
			easeInQuint = 12,
			easeOutQuint = 13,
			easeInOutQuint = 14,
			easeInSine = 15,
			easeOutSine = 16,
			easeInOutSine = 17,
			easeInExpo = 18,
			easeOutExpo = 19,
			easeInOutExpo = 20,
			easeInCirc = 21,
			easeOutCirc = 22,
			easeInOutCirc = 23,
			easeInBounce = 24,
			easeOutBounce = 25,
			easeInOutBounce = 26,
			easeInBack = 27,
			easeOutBack = 28,
			easeInOutBack = 29,
			easeInElastic = 30,
			easeOutElastic = 31,
			easeInOutElastic = 32
		}

		private sealed class EADGINIAHND : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OFOCCNGBKLI tweenType;

			public float time;

			public EnhancedScroller _003C_003E4__this;

			public float start;

			public float end;

			public Action tweenComplete;

			private float _003CnewPosition_003E5__2;

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
			public EADGINIAHND(int _003C_003E1__state)
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

		public LOLKMNACBMP scrollDirection;

		public float spacing;

		public RectOffset padding;

		[SerializeField]
		private bool loop;

		public bool loopWhileDragging;

		public float maxVelocity;

		[SerializeField]
		private LOFHGFNLPHH scrollbarVisibility;

		public bool snapping;

		public float snapVelocityThreshold;

		public float snapWatchOffset;

		public float snapJumpToOffset;

		public float snapCellCenterOffset;

		public bool snapUseCellSpacing;

		public OFOCCNGBKLI snapTweenType;

		public float snapTweenTime;

		public bool snapWhileDragging;

		private float NNPNIKGFBCP;

		private float OKPHCDPMKDN;

		public NDMDHDLCJHE cellViewVisibilityChanged;

		public NJDEMHFGFEG cellViewWillRecycle;

		public MDANLJMPHEI scrollerScrolled;

		public DGFCOLPIPNO scrollerSnapped;

		public IGGOLNCDPPA scrollerScrollingChanged;

		public DGMLDJKIBNN scrollerTweeningChanged;

		public BGNBEHLJINB cellViewInstantiated;

		public FAMEAEDBIJA cellViewReused;

		[CompilerGenerated]
		private bool _003CCLEKMKJOFHD_003Ek__BackingField;

		[CompilerGenerated]
		private bool _003CKKADMEMKIGH_003Ek__BackingField;

		private bool OKLPILJKAPB;

		private bool BCJBDPMLBEA;

		private ScrollRect LCFAPOEKANP;

		private RectTransform KIJEPJGIDGI;

		private Scrollbar LLEEBGBFLOO;

		private RectTransform IGNAILDMFCL;

		private HorizontalOrVerticalLayoutGroup DICNGLLCDCH;

		private MAPFGPLJKLL LPMCGOJPDEI;

		private bool FDCPDBINCKI;

		private bool GPPJKCKDMKD;

		private global::DOJIFNMNAPH<EnhancedScrollerCellView> DMBBAAKBNDK;

		private LayoutElement MGENMNHDJLF;

		private LayoutElement KOGNGIAHHAK;

		private RectTransform OJHBOGBAMOO;

		private global::DOJIFNMNAPH<float> AKPFFPMLFEM;

		private global::DOJIFNMNAPH<float> CKOKCIHKCIC;

		public float _scrollPosition;

		private global::DOJIFNMNAPH<EnhancedScrollerCellView> EEFOHGCDFPP;

		private int DFFNIFGHJEP;

		private int KLKAHPDDDNE;

		private int CFMGKKHFNLH;

		private int MBLMEBAMBKN;

		private float BMAOGPHDAAD;

		private float JCPPDDCAGAC;

		private float FOKFDMEGALD;

		private float FKLDKEDMFAL;

		private float OJBFOCGHIIN;

		private bool BNDEKAEONNP;

		private int KBPHAAOCKLM;

		private int BMNPGPCEGEK;

		private bool IOFFHHCEAJA;

		private bool DBDJGIJAMJM;

		private LOFHGFNLPHH DDILFIGBMPA;

		private float CIFJOGFKMLO;

		private bool DBAOJEICPPN;

		private bool CDDDLIJMOKA;

		private bool OGKKODAGNGL;

		private int MCCELPPMBOG;

		private float KOCNOKDJIND;

		public float lookAheadBefore
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float lookAheadAfter
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public MAPFGPLJKLL Delegate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float ScrollPosition
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ScrollSize => 0f;

		public float NormalizedScrollPosition => 0f;

		public bool Loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public LOFHGFNLPHH ScrollbarVisibility
		{
			get
			{
				return default(LOFHGFNLPHH);
			}
			set
			{
			}
		}

		public Vector2 Velocity
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float LinearVelocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool IsScrolling
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsTweening
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int StartCellViewIndex => 0;

		public int EndCellViewIndex => 0;

		public int StartDataIndex => 0;

		public int EndDataIndex => 0;

		public int NumberOfCells => 0;

		public ScrollRect ScrollRect => null;

		public float ScrollRectSize => 0f;

		public LayoutElement FirstPadder => null;

		public LayoutElement LastPadder => null;

		public RectTransform Container => null;

		public int GetCellViewIndexAtPosition(float PFCFCJFDLEP)
		{
			return 0;
		}

		private void ONHKCMEIEON()
		{
		}

		[SpecialName]
		private void AGNNBDDCNNH(bool JEHONDDIMPC)
		{
		}

		public float GetScrollPositionForDataIndex(int ANOPGILBLFM, IAPFIPILPIF EOFKPNCCIEA)
		{
			return 0f;
		}

		public EnhancedScrollerCellView GetCellViewAtDataIndex(int ANOPGILBLFM)
		{
			return null;
		}

		private static float FMLKHKCKJCF(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		[SpecialName]
		public int DANMGAPMLKD()
		{
			return 0;
		}

		private static float GDAHOJLBBGB(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private IEnumerator IBOKGFGEHPG(OFOCCNGBKLI NDKKPPPCJGB, float CCKIOGLFDBF, float ECOIELMGGGP, float NKGMEFJMAOM, Action CIGMBGKABCG)
		{
			return null;
		}

		private void OnDisable()
		{
		}

		public void OnEndDrag(PointerEventData BIIANEPOGPP)
		{
		}

		private void EBMKKKIILPN(bool CGOGAGLFJMI)
		{
		}

		private static float MIPHPONPODJ(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float CONFDAPCGNG(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		[SpecialName]
		public void LBFHKHIGPMB(float JEHONDDIMPC)
		{
		}

		[IteratorStateMachine(typeof(EADGINIAHND))]
		private IEnumerator PIKLGCIEFBN(OFOCCNGBKLI NDKKPPPCJGB, float CCKIOGLFDBF, float ECOIELMGGGP, float NKGMEFJMAOM, Action CIGMBGKABCG)
		{
			return null;
		}

		private static float EGCCEILFLPH(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private void JLKHAPNKIHF()
		{
		}

		private static float CPOGPHAHIJA(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float DHMKPPNGAND(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		public void IgnoreLoopJump(bool OFPIMDKLPEL)
		{
		}

		private void KBIGPGMCJFO()
		{
		}

		private void AKOIDFDAFAD()
		{
		}

		private void NCGNCCDECDO(EnhancedScrollerCellView IKJLFPBCGIO)
		{
		}

		private static float IBCMCPOKINB(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float OKCOKDPOAIJ(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private int NIJHGIKIACM(float PFCFCJFDLEP, int CILNECBLFDO, int EFDKFECPIIC)
		{
			return 0;
		}

		private void ONPFCGIGHJM()
		{
		}

		private float MPCPKGCIFIC()
		{
			return 0f;
		}

		public void ClearRecycled()
		{
		}

		public void SetScrollPositionImmediately(float NCONAMNLJFC)
		{
		}

		private static float MPIJJBNALDO(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		[SpecialName]
		public RectTransform JDEDDPONBCP()
		{
			return null;
		}

		private static float NILBPPEAAPK(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private void LHNDBNAKFJN(int EPEOFFCKILI, int FCFLHOMCNGF)
		{
		}

		private static float BGACINAHJNH(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		public void PLPBEJHGILL()
		{
		}

		private void Awake()
		{
		}

		[SpecialName]
		public LayoutElement MNIDPLCHCGB()
		{
			return null;
		}

		private EnhancedScrollerCellView CMGMAMEAGLF(EnhancedScrollerCellView CKHJDEKJLKK)
		{
			return null;
		}

		private static float JJOAPKHJMNF(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private void ILOJFIEMGFE(Vector2 HEMGLOMCHBD)
		{
		}

		private static float BPLCKGGLLAB(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		public void OnBeginDrag(PointerEventData BIIANEPOGPP)
		{
		}

		private static float KBICJAACGBF(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float NFAKHIJFDMP(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		public void ClearActive()
		{
		}

		private static float IOJPNNHDGCI(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float KDEKNOOEOJE(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float DODEDCNLPIA(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float KKCCJAOPKPO(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		public EnhancedScrollerCellView GetCellView(EnhancedScrollerCellView CKHJDEKJLKK)
		{
			return null;
		}

		[SpecialName]
		public bool GCFNIMPBKJM()
		{
			return false;
		}

		private void HKHDKNIMIJH()
		{
		}

		public void JumpToDataIndex(int ANOPGILBLFM, float CEOFPINMEJC = 0f, float OJOJLFFFCMB = 0f, bool EMMBFIHPGME = true, OFOCCNGBKLI NDKKPPPCJGB = OFOCCNGBKLI.immediate, float FBKNJKOAPOL = 0f, Action LKKLIAFIIPE = null, LABGHCNAEPL BGCLHMIFIBF = LABGHCNAEPL.Closest)
		{
		}

		private void NFCKNLNGDJH(float DAFPEAOPOEH)
		{
		}

		private static float CDCKCGKBIJH(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float GMODOJBDMBK(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private void NJOKIOLHKPP()
		{
		}

		private void IAEONMLBFFN()
		{
		}

		private float KMHHDMMOGLO(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float NDNHIOEJMHE(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float LLDEFMDHBKN(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float FOKFBPPIMMF(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private void OnValidate()
		{
		}

		private static float BHPDOMFHDNB(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float EIGKDBLMHKL(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		public float GetScrollPositionForCellViewIndex(int FJBFCBBJKON, IAPFIPILPIF EOFKPNCCIEA)
		{
			return 0f;
		}

		private static float PIMDAGAJIFI(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private void HFIHLKGGGJH(int CAHBHMCIMBP, MOMDFOGOHPI CJPEEGLLHED)
		{
		}

		private void CCPLBEBBAKA(out int CILNECBLFDO, out int EFDKFECPIIC)
		{
			CILNECBLFDO = default(int);
			EFDKFECPIIC = default(int);
		}

		private static float IGLBLBCFCDJ(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private void OnEnable()
		{
		}

		private static float KAHLJMNKBIL(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private void MDKOKFBGIAN(int CAHBHMCIMBP, MOMDFOGOHPI CJPEEGLLHED)
		{
		}

		[SpecialName]
		public void KILLNDDGJHE(MAPFGPLJKLL JEHONDDIMPC)
		{
		}

		private static float MGIKPEIECGB(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		public void ClearAll()
		{
		}

		private float BBFBFELEIPM()
		{
			return 0f;
		}

		public void ToggleLoop()
		{
		}

		private static float NPHIJEAMKKC(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float PHLOKJMLJPJ(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float FOFBPKDDNKE(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float BOPNOBFJDPB(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		public void ReloadData(float BHBKPNIFJGB = 0f)
		{
		}

		private void Update()
		{
		}

		public void Snap()
		{
		}

		public void RefreshActiveCellViews()
		{
		}

		private void LateUpdate()
		{
		}

		private static float JDBJCLFBDCF(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private int KCJEPKGJHPI(float PFCFCJFDLEP, int CILNECBLFDO, int EFDKFECPIIC)
		{
			return 0;
		}

		private static float DNAMCICAMOB(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private void KBKENOEGBOC()
		{
		}

		private static float EKEBNIAMLOH(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		public EnhancedScrollerCellView JGBFAPCHCKO(int ANOPGILBLFM)
		{
			return null;
		}

		public void CDLAHHACKFL(PointerEventData BIIANEPOGPP)
		{
		}

		[SpecialName]
		public bool MKILKAMNBIP()
		{
			return false;
		}

		[SpecialName]
		public LOFHGFNLPHH FMAGLOHPCKE()
		{
			return default(LOFHGFNLPHH);
		}

		private static float LNPCKHINCIE(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float CGOEBDKFKJD(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float PPKDLJOOHDO(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float EMCBBLPONMK(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float IOMJCDHIKCN(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private static float BMNEJBPOMJF(float ECOIELMGGGP, float NKGMEFJMAOM, float HEMGLOMCHBD)
		{
			return 0f;
		}

		private void IHPBGJPMMEN()
		{
		}

		[SpecialName]
		public bool CNBPHAGLGCM()
		{
			return false;
		}
	}
}
