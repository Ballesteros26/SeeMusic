using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[Serializable]
	[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
	public sealed class GUISettings
	{
		[SerializeField]
		private bool m_DoubleClickSelectsWord;

		[SerializeField]
		private bool m_TripleClickSelectsLine;

		[SerializeField]
		private Color m_CursorColor;

		[SerializeField]
		private float m_CursorFlashSpeed;

		[SerializeField]
		private Color m_SelectionColor;

		public bool doubleClickSelectsWord => false;

		public bool tripleClickSelectsLine => false;

		public Color cursorColor => default(Color);

		public float cursorFlashSpeed => 0f;

		public Color selectionColor => default(Color);

		private static float Internal_GetCursorFlashSpeed()
		{
			return 0f;
		}
	}
}
