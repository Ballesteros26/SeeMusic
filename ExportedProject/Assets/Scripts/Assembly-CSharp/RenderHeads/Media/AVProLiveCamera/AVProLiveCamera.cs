using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RenderHeads.Media.AVProLiveCamera
{
	[AddComponentMenu("AVPro Live Camera/Live Camera")]
	public class AVProLiveCamera : MonoBehaviour
	{
		public enum IAFKEFNDGJL
		{
			Default = 0,
			Name = 1,
			Index = 2
		}

		public enum AMEHHMPFCBF
		{
			Default = 0,
			Resolution = 1,
			Index = 2
		}

		private sealed class AEFBOEOJDIB : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AVProLiveCamera _003C_003E4__this;

			private bool _003ChasUpdatedThisFrame_003E5__2;

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
			public AEFBOEOJDIB(int _003C_003E1__state)
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

		protected MKLEKKHHFJJ GHPECFKLKDG;

		protected OHFCCHMPCCG MMLHIMJIAPA;

		protected int OHHEFMOOAJB;

		[Header("Device Selection")]
		public IAFKEFNDGJL _deviceSelection;

		public List<string> _desiredDeviceNames;

		public int _desiredDeviceIndex;

		public AMEHHMPFCBF _modeSelection;

		public bool _desiredAnyResolution;

		public List<Vector2> _desiredResolutions;

		public int _desiredModeIndex;

		public bool _maintainAspectRatio;

		public float _desiredFrameRate;

		public bool _desiredFormatAny;

		public bool _desiredTransparencyFormat;

		public CBAGIJEIGIF.OOHECJDJGON _desiredFormat;

		public IAFKEFNDGJL _videoInputSelection;

		public List<CBAGIJEIGIF.GBFOHLCKIHJ> _desiredVideoInputs;

		public int _desiredVideoInputIndex;

		[Header("Device Start")]
		[SerializeField]
		private bool _preferPreviewPin;

		[SerializeField]
		private MKLEKKHHFJJ.LDONFPAADGG _clockMode;

		public bool _deinterlace;

		public bool _playOnStart;

		[Header("Display")]
		public bool _allowTransparency;

		public bool _flipX;

		public bool _flipY;

		[SerializeField]
		private IIELEOPCPPB _yCbCrRange;

		[Header("Update")]
		public bool _updateHotSwap;

		public bool _updateFrameRates;

		public bool _updateSettings;

		private IntPtr CCPGHGJOMMG;

		private int KDAHLPPCKDL;

		private YieldInstruction LKEEAJDOIIK;

		private Coroutine ONAMCCDIMMN;

		private int EBCDOKFDNAO;

		public MKLEKKHHFJJ Device => null;

		public MKLEKKHHFJJ.LDONFPAADGG Clock
		{
			get
			{
				return default(MKLEKKHHFJJ.LDONFPAADGG);
			}
			set
			{
			}
		}

		public IIELEOPCPPB YCbCrRange
		{
			get
			{
				return default(IIELEOPCPPB);
			}
			set
			{
			}
		}

		public bool PreferPreviewPin
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Texture OutputTexture => null;

		private void KAFJIEMDCPB()
		{
		}

		private void JDKOKJMEFDH()
		{
		}

		private void Update()
		{
		}

		private static MKLEKKHHFJJ MJOLFNLHHOD(List<string> OOFFDMIGOIK)
		{
			return null;
		}

		public void OnDestroy()
		{
		}

		private void GDNNHFCMAIF()
		{
		}

		public void DJIEHLBBJAC()
		{
		}

		private bool IBGBCDODNLM()
		{
			return false;
		}

		private void CPPMOKFADLM()
		{
		}

		[SpecialName]
		public Texture DMEDMMPHPDG()
		{
			return null;
		}

		[SpecialName]
		public bool MHHLMACOPPF()
		{
			return false;
		}

		public void POEHOFBCMKO()
		{
		}

		[SpecialName]
		public IIELEOPCPPB AAPDFMEOLDB()
		{
			return default(IIELEOPCPPB);
		}

		public void Start()
		{
		}

		[SpecialName]
		public bool NINFBANHFJI()
		{
			return false;
		}

		private void HAPLAAHNFKJ()
		{
		}

		public void KCIFAGNNMFG()
		{
		}

		[SpecialName]
		public IIELEOPCPPB BCLDOFFJEOJ()
		{
			return default(IIELEOPCPPB);
		}

		public void CJIOGBDOHCD()
		{
		}

		private static MKLEKKHHFJJ CFGBMIBFCND(List<string> OOFFDMIGOIK)
		{
			return null;
		}

		private int ALNKJBOPBKD()
		{
			return 0;
		}

		private static MKLEKKHHFJJ LEIAJGJLDMN(List<string> OOFFDMIGOIK)
		{
			return null;
		}

		private void Reset()
		{
		}

		[SpecialName]
		public bool JGEPGDBMPPK()
		{
			return false;
		}

		public void SelectDeviceAndMode()
		{
		}

		private OHFCCHMPCCG FIEMIEJFDOH()
		{
			return null;
		}

		private bool PADMGDMMGHC()
		{
			return false;
		}

		[SpecialName]
		public MKLEKKHHFJJ EHMFCBKBDKJ()
		{
			return null;
		}

		[IteratorStateMachine(typeof(AEFBOEOJDIB))]
		private IEnumerator HJEIDMDCHMD()
		{
			return null;
		}

		[SpecialName]
		public MKLEKKHHFJJ.LDONFPAADGG CIHIKMBKHGA()
		{
			return default(MKLEKKHHFJJ.LDONFPAADGG);
		}

		private void OnDisable()
		{
		}

		private static OHFCCHMPCCG AOMJOIBAOCI(MKLEKKHHFJJ BGGKNNJILFL, bool NBOAJKCMHJL, List<Vector2> KJMACHPAPMC, bool ALKLLHOADOO, float FPIGEJMEENG, bool DBHGLMMONBB, bool LGIPAODJDBE, CBAGIJEIGIF.OOHECJDJGON ADEBNBNFDME)
		{
			return null;
		}

		[SpecialName]
		public void OIMDIEEJBLB(IIELEOPCPPB JEHONDDIMPC)
		{
		}

		private void OnEnable()
		{
		}

		private void CONLDJEFMGM()
		{
		}

		[SpecialName]
		public MKLEKKHHFJJ.LDONFPAADGG JBEDIBKIBBN()
		{
			return default(MKLEKKHHFJJ.LDONFPAADGG);
		}

		private static MKLEKKHHFJJ AGGLOKELNBC(List<string> OOFFDMIGOIK)
		{
			return null;
		}

		private void NPDADIFBINP()
		{
		}

		private bool KLFANIMFAJI()
		{
			return false;
		}

		private static OHFCCHMPCCG BLHCKLILLJJ(MKLEKKHHFJJ BGGKNNJILFL, bool NBOAJKCMHJL, List<Vector2> KJMACHPAPMC, bool ALKLLHOADOO, float FPIGEJMEENG, bool DBHGLMMONBB, bool LGIPAODJDBE, CBAGIJEIGIF.OOHECJDJGON ADEBNBNFDME)
		{
			return null;
		}

		public void Begin()
		{
		}

		private MKLEKKHHFJJ GGCGIKLGAOB()
		{
			return null;
		}

		private void PKMOHAOCILA()
		{
		}

		public void LIPIMJGDPBI()
		{
		}

		public void JHDNOIFDFCI()
		{
		}

		[SpecialName]
		public Texture KNFEOKIMKKN()
		{
			return null;
		}

		[SpecialName]
		public void FMLCDPBFEDP(IIELEOPCPPB JEHONDDIMPC)
		{
		}

		private int AMDACJOPPPJ()
		{
			return 0;
		}

		private static MKLEKKHHFJJ MIJGDEHBMKK(List<string> OOFFDMIGOIK)
		{
			return null;
		}

		public void ADNCOBKDKHF()
		{
		}

		private static OHFCCHMPCCG NHMBCBHGGID(MKLEKKHHFJJ BGGKNNJILFL, bool NBOAJKCMHJL, List<Vector2> KJMACHPAPMC, bool ALKLLHOADOO, float FPIGEJMEENG, bool DBHGLMMONBB, bool LGIPAODJDBE, CBAGIJEIGIF.OOHECJDJGON ADEBNBNFDME)
		{
			return null;
		}
	}
}
