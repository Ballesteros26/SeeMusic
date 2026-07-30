using System;

namespace UnityEngine.TextCore.Text
{
	[Serializable]
	public class TextStyle
	{
		internal static TextStyle k_NormalStyle;

		[SerializeField]
		private string m_Name;

		[SerializeField]
		private int m_HashCode;

		[SerializeField]
		private string m_OpeningDefinition;

		[SerializeField]
		private string m_ClosingDefinition;

		[SerializeField]
		private int[] m_OpeningTagArray;

		[SerializeField]
		private int[] m_ClosingTagArray;

		[SerializeField]
		internal uint[] m_OpeningTagUnicodeArray;

		[SerializeField]
		internal uint[] m_ClosingTagUnicodeArray;

		public int hashCode => 0;

		public int[] styleOpeningTagArray => null;

		public int[] styleClosingTagArray => null;

		public void RefreshStyle()
		{
		}
	}
}
