namespace UnityEngine.UIElements
{
	public class UxmlFactory<TCreatedType, TTraits> : IUxmlFactory where TCreatedType : VisualElement, new() where TTraits : UxmlTraits, new()
	{
		internal TTraits m_Traits;

		public virtual string uxmlName => null;

		public virtual string uxmlNamespace => null;

		public virtual string uxmlQualifiedName => null;

		protected UxmlFactory()
		{
		}

		public virtual bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc)
		{
			return false;
		}

		public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc)
		{
			return null;
		}
	}
	public class UxmlFactory<TCreatedType> : UxmlFactory<TCreatedType, VisualElement.UxmlTraits> where TCreatedType : VisualElement, new()
	{
	}
}
