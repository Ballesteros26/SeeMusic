using System.Reflection;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class MethodSymbol : MethodOrPropertySymbol
	{
		private MethodKindEnum _methKind;

		private bool _inferenceMustFail;

		private bool _checkedInfMustFail;

		private MethodSymbol _convNext;

		private PropertySymbol _prop;

		private EventSymbol _evt;

		public bool isVirtual;

		public MemberInfo AssociatedMemberInfo;

		public TypeArray typeVars;

		public MethodKindEnum MethKind => default(MethodKindEnum);

		public bool InferenceMustFail()
		{
			return false;
		}

		public bool IsConstructor()
		{
			return false;
		}

		public bool IsNullableConstructor()
		{
			return false;
		}

		public bool isPropertyAccessor()
		{
			return false;
		}

		public bool isEventAccessor()
		{
			return false;
		}

		public bool isImplicit()
		{
			return false;
		}

		public void SetMethKind(MethodKindEnum mk)
		{
		}

		public MethodSymbol ConvNext()
		{
			return null;
		}

		public void SetConvNext(MethodSymbol conv)
		{
		}

		public PropertySymbol getProperty()
		{
			return null;
		}

		public void SetProperty(PropertySymbol prop)
		{
		}

		public EventSymbol getEvent()
		{
			return null;
		}

		public void SetEvent(EventSymbol evt)
		{
		}

		public new bool isUserCallable()
		{
			return false;
		}

		private bool isAnyAccessor()
		{
			return false;
		}

		public bool isSetAccessor()
		{
			return false;
		}
	}
}
