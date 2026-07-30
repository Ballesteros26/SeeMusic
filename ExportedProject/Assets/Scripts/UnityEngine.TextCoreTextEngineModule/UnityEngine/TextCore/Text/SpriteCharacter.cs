using System;

namespace UnityEngine.TextCore.Text
{
	[Serializable]
	public class SpriteCharacter : TextElement
	{
		[SerializeField]
		private string m_Name;

		[SerializeField]
		private int m_HashCode;

		public string name => null;
	}
}
