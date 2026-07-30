using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal class UIFakeStoreWindow : MonoBehaviour
	{
		private string m_QueryText;

		private string m_OkText;

		private string m_CancelText;

		private string m_LastSelectedOptionText;

		private Action m_OnOk;

		private Action m_OnCancel;

		private Action<int> m_OnDropdown;

		private bool m_CancelEnabled;

		private bool m_DropdownEnabled;

		private bool m_DoDropdown;

		private readonly UIFakeStoreDropdown m_Dropdown;

		private Vector2 scrollPosition;

		private const float k_MenuScreenRatio = 0.6f;

		private void OnGUI()
		{
		}

		private Rect CreateCenteredWindowRect()
		{
			return default(Rect);
		}

		private void DoMainGUI(int windowID)
		{
		}

		private void DoDropDown()
		{
		}

		private void OnOkClicked()
		{
		}

		private void OnCancelClicked()
		{
		}

		internal void ConfigureMainDialogText(string queryText, string okText, string cancelText)
		{
		}

		internal void ConfigureDropdownOptions(List<string> options)
		{
		}

		private void OnDropdown(int index, string selectionText)
		{
		}

		internal void AssignCallbacks(Action onOk, Action onCancel, Action<int> onDropdown)
		{
		}
	}
}
