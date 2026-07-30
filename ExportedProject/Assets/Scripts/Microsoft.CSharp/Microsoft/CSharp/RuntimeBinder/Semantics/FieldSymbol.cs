using System.Reflection;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal class FieldSymbol : VariableSymbol
	{
		public new bool isStatic;

		public bool isReadOnly;

		public bool isEvent;

		public FieldInfo AssociatedFieldInfo;

		public void SetType(CType pType)
		{
		}

		public new CType GetType()
		{
			return null;
		}

		public AggregateSymbol getClass()
		{
			return null;
		}

		public EventSymbol getEvent()
		{
			return null;
		}
	}
}
