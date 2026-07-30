using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	internal class DefaultGroupManager : IGroupManager
	{
		private List<IGroupBoxOption> m_GroupOptions;

		private IGroupBoxOption m_SelectedOption;

		public void OnOptionSelectionChanged(IGroupBoxOption selectedOption)
		{
		}

		public void RegisterOption(IGroupBoxOption option)
		{
		}

		public void UnregisterOption(IGroupBoxOption option)
		{
		}
	}
}
