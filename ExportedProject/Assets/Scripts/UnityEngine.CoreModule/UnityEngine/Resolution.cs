using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode]
	public struct Resolution
	{
		private int m_Width;

		private int m_Height;

		private int m_RefreshRate;

		public int width => 0;

		public int height => 0;

		public int refreshRate => 0;

		public override string ToString()
		{
			return null;
		}
	}
}
