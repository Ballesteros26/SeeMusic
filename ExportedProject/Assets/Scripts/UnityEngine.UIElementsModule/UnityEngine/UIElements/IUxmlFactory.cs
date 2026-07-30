namespace UnityEngine.UIElements
{
	public interface IUxmlFactory
	{
		string uxmlQualifiedName { get; }

		bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc);

		VisualElement Create(IUxmlAttributes bag, CreationContext cc);
	}
}
