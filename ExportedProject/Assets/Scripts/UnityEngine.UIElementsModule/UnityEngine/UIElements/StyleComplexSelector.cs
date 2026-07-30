using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	[Serializable]
	internal class StyleComplexSelector
	{
		private struct PseudoStateData
		{
			public readonly PseudoStates state;

			public readonly bool negate;

			public PseudoStateData(PseudoStates state, bool negate)
			{
				this.state = default(PseudoStates);
				this.negate = false;
			}
		}

		[SerializeField]
		private int m_Specificity;

		[SerializeField]
		private StyleSelector[] m_Selectors;

		[SerializeField]
		internal int ruleIndex;

		[NonSerialized]
		internal StyleComplexSelector nextInTable;

		[NonSerialized]
		internal int orderInStyleSheet;

		private static Dictionary<string, PseudoStateData> s_PseudoStates;

		public int specificity => 0;

		public StyleRule rule { get; internal set; }

		public StyleSelector[] selectors
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		internal void CachePseudoStateMasks()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
