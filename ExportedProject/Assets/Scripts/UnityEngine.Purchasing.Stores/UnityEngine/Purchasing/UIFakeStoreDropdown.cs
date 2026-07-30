using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal class UIFakeStoreDropdown
	{
		private List<string> m_Options;

		private Action<int, string> m_OnDropdown;

		private Vector2 scrollPosition;

		public void DoPopup(int windowID)
		{
		}

		private void OnOptionSelected(int optionIndex)
		{
		}

		internal void SetOptions(List<string> options)
		{
		}

		internal void SetSelectionAction(Action<int, string> onDropdown)
		{
		}
	}
}
