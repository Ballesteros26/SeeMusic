using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace AdvancedColorPicker
{
	public class ColorEyedropper : ColorComponent
	{
		[Serializable]
		public class ActiveChanged : UnityEvent
		{
		}

		private sealed class EGFAHKPCCLG : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ColorEyedropper _003C_003E4__this;

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
			public EGFAHKPCCLG(int _003C_003E1__state)
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

		public ActiveChanged OnActivated;

		public ActiveChanged OnDeactivated;

		[SerializeField]
		private bool changesColorInstantly;

		private bool NGCIBDMPNPJ;

		private Coroutine DNBDMMHDHJM;

		private Color BGOKDMFOBEG;

		private Texture2D BGOCMBCELFB;

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

		public bool ChangesColorInstantly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[IteratorStateMachine(typeof(EGFAHKPCCLG))]
		private IEnumerator JDPCGOCAFIK()
		{
			return null;
		}

		[SpecialName]
		public void EFDKBDBBKBC(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void MMGLLJDCDIN(bool JEHONDDIMPC)
		{
		}

		private IEnumerator KIJMJCFMFGA()
		{
			return null;
		}

		protected override void OnEnable()
		{
		}

		private void HGNOBNGECFA()
		{
		}

		public void LANBGAJFBNJ()
		{
		}

		[SpecialName]
		public void KEIAKDINEMC(bool JEHONDDIMPC)
		{
		}

		protected override void Awake()
		{
		}

		[SpecialName]
		public void LNFDNCMPBBC(bool JEHONDDIMPC)
		{
		}

		private void MPHBECIAKGM()
		{
		}

		private IEnumerator PAKDNHJEBNH()
		{
			return null;
		}

		[SpecialName]
		public void FDCMOEFCDJK(bool JEHONDDIMPC)
		{
		}

		protected override void OAOOLMGAMOK()
		{
		}

		[SpecialName]
		public void PBLLBAIGDJI(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public bool HNMEBDPNFKG()
		{
			return false;
		}

		private IEnumerator LDFKPPHCCHP()
		{
			return null;
		}

		[SpecialName]
		public bool BMHLHDMBMPC()
		{
			return false;
		}

		[SpecialName]
		public bool KAEANMDCCHH()
		{
			return false;
		}

		public void LJBMPFJAHAO()
		{
		}

		private IEnumerator DEELMAJNNHA()
		{
			return null;
		}

		[SpecialName]
		public void LGOBFECBJDC(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void JALEJKJOAHB(bool JEHONDDIMPC)
		{
		}

		private IEnumerator CIDKIMFDFEJ()
		{
			return null;
		}

		[SpecialName]
		public bool OLILDFHAKOC()
		{
			return false;
		}

		protected override void OnDestroy()
		{
		}

		private IEnumerator GCKCLNOFBMP()
		{
			return null;
		}

		private IEnumerator ANCELGLEOBG()
		{
			return null;
		}

		[SpecialName]
		public void JCGMKOCOOBF(bool JEHONDDIMPC)
		{
		}

		private IEnumerator MMOPDNHJKJN()
		{
			return null;
		}

		[SpecialName]
		public bool HLLNKDBKLNA()
		{
			return false;
		}

		private IEnumerator OLBAJLBAAKH()
		{
			return null;
		}

		[SpecialName]
		public bool PJELDICMNDL()
		{
			return false;
		}

		[SpecialName]
		public bool JFNPCHPDJPP()
		{
			return false;
		}

		[SpecialName]
		public void ONHMMHEPABJ(bool JEHONDDIMPC)
		{
		}

		public void IOBNMLIFBMA()
		{
		}

		[SpecialName]
		public bool JEDKLHGHCJA()
		{
			return false;
		}

		[SpecialName]
		public bool ANILDDCAHME()
		{
			return false;
		}

		[SpecialName]
		public void CMBAMFIANDN(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void JMPIPKNGHNG(bool JEHONDDIMPC)
		{
		}

		public void EDICPELJKFM()
		{
		}

		public void JBOJKJJLGDB()
		{
		}

		private IEnumerator LIAALACBBKB()
		{
			return null;
		}

		[SpecialName]
		public void FIDNFJMLOIK(bool JEHONDDIMPC)
		{
		}

		private void FEHHDJMLLPL()
		{
		}

		[SpecialName]
		public bool JLDHCFKFKIK()
		{
			return false;
		}

		private void NENHGCPABOJ()
		{
		}

		[SpecialName]
		public void OOLLNCMMGEB(bool JEHONDDIMPC)
		{
		}

		private IEnumerator OMCFEMIEFNC()
		{
			return null;
		}

		private IEnumerator NONEEFCJDDH()
		{
			return null;
		}

		[SpecialName]
		public bool GACBCJLJLGL()
		{
			return false;
		}

		private void BMDDKECIEJL()
		{
		}

		[SpecialName]
		public void JOONHBLMCMG(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void FAAHEMAICOA(bool JEHONDDIMPC)
		{
		}

		[SpecialName]
		public void DKPOPOBHDJG(bool JEHONDDIMPC)
		{
		}

		public void IFBABAMHIJC()
		{
		}

		[SpecialName]
		public bool GJHADFJBLCE()
		{
			return false;
		}

		[SpecialName]
		public void BAMECNOMNCL(bool JEHONDDIMPC)
		{
		}

		private void FNEKFADNGEI()
		{
		}

		private IEnumerator HIDPPCACGHF()
		{
			return null;
		}

		[SpecialName]
		public bool AHMIMOLPBEC()
		{
			return false;
		}

		[SpecialName]
		public void DBIJOEFIOKB(bool JEHONDDIMPC)
		{
		}

		private void JALDBFILPAL()
		{
		}

		public void HLLMAHCOIPI()
		{
		}

		[SpecialName]
		public bool KFAODKFODHD()
		{
			return false;
		}

		private void JGAJOGHJOPL()
		{
		}

		[SpecialName]
		public bool OIMIAHOOFDN()
		{
			return false;
		}

		public void Activate()
		{
		}

		private void DBKKNCEJIKJ()
		{
		}

		protected override void OnDisable()
		{
		}

		[SpecialName]
		public bool DMMOCPAJMAJ()
		{
			return false;
		}

		private void OOGFBDFKCHD()
		{
		}

		[SpecialName]
		public void PDNDNBDEOLJ(bool JEHONDDIMPC)
		{
		}

		private void PBJHJHMKEPJ()
		{
		}

		public void EABLIJJAJIJ()
		{
		}

		public void BPCNGDKBJIM()
		{
		}

		private IEnumerator MEHHMCKEHAH()
		{
			return null;
		}

		[SpecialName]
		public bool BFBJMIANKBH()
		{
			return false;
		}
	}
}
