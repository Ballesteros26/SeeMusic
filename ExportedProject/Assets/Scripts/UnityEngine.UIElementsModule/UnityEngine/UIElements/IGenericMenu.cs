using System;

namespace UnityEngine.UIElements
{
	internal interface IGenericMenu
	{
		void AddItem(string itemName, bool isChecked, Action action);

		void DropDown(Rect position, VisualElement targetElement = null, bool anchored = false);
	}
}
