using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UnityEngine.Purchasing
{
	internal class UIFakeStore : FakeStore
	{
		private DialogRequest m_CurrentDialog;

		private int m_LastSelectedDropdownIndex;

		private GameObject m_UIFakeStoreWindowObject;

		private GameObject m_EventSystem;

		protected override bool StartUI<T>(object model, DialogType dialogType, Action<bool, T> callback)
		{
			return false;
		}

		private bool StartUI(string queryText, string okayButtonText, string cancelButtonText, List<string> options, Action<bool, int> callback)
		{
			return false;
		}

		private void InstantiateDialog()
		{
		}

		private UIFakeStoreWindow GetOrCreateFakeStoreWindow()
		{
			return null;
		}

		private void AddLifeCycleNotifierAndSetDestroyCallback(GameObject gameObject)
		{
		}

		private void EnsureEventSystemCreated(Transform rootTransform)
		{
		}

		private void ConfigureDialogWindow(UIFakeStoreWindow dialogWindow)
		{
		}

		private void ConfigureDialogWindowCallbacks(UIFakeStoreWindow dialogWindow, bool assignCancelCallback, bool assignDropDownCallback)
		{
		}

		private void CreateEventSystem(Transform rootTransform)
		{
		}

		private string CreatePurchaseQuestion(ProductDefinition definition)
		{
			return null;
		}

		private string CreateRetrieveProductsQuestion(ReadOnlyCollection<ProductDefinition> definitions)
		{
			return null;
		}

		private void OkayButtonClicked()
		{
		}

		private void CancelButtonClicked()
		{
		}

		private void DropdownValueChanged(int selectedItem)
		{
		}

		private void CloseDialog()
		{
		}

		public bool IsShowingDialog()
		{
			return false;
		}
	}
}
