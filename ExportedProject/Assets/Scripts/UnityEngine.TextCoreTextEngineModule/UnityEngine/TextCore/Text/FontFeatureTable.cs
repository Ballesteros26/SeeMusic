using System;
using System.Collections.Generic;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore.Text
{
	[Serializable]
	public class FontFeatureTable
	{
		[SerializeField]
		internal List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords;

		internal Dictionary<uint, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup;

		internal List<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords => null;

		public void SortGlyphPairAdjustmentRecords()
		{
		}
	}
}
