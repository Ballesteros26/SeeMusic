namespace UnityEngine.UIElements
{
	internal interface IGroupManager
	{
		void OnOptionSelectionChanged(IGroupBoxOption selectedOption);

		void RegisterOption(IGroupBoxOption option);

		void UnregisterOption(IGroupBoxOption option);
	}
}
